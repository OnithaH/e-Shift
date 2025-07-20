using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using e_Shift.Database;
using e_Shift.Utils;

namespace e_Shift
{
    public partial class AdminJobManagementForm : Form
    {
        private int selectedJobId = -1;

        public AdminJobManagementForm()
        {
            InitializeComponent();
        }

        private void AdminJobManagementForm_Load(object sender, EventArgs e)
        {
            // Check if admin is logged in
            if (!UserSession.IsLoggedIn || !UserSession.IsAdmin())
            {
                MessageBox.Show("Access denied! Admin privileges required.",
                              "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // Set default filter
            comboBoxFilterStatus.SelectedIndex = 1; // "Pending"

            // Load jobs
            LoadJobs();
            LoadAvailableTransportUnits();

            // Clear job details
            ClearJobDetails();

            ShowMessage("Job management loaded successfully", false);
        }

        private void LoadJobs(string statusFilter = "Pending")
        {
            try
            {
                string query = @"
                    SELECT 
                        j.JobID, j.JobNumber, j.Status, j.Priority, j.RequestDate, j.ScheduledDate,
                        j.StartLocation, j.StartCity, j.Destination, j.DestinationCity,
                        j.EstimatedCost, j.ActualCost, j.SpecialInstructions,
                        c.CustomerNumber, c.FirstName, c.LastName, c.Email,
                        j.ApprovedByAdminID, j.ApprovalDate, j.DeclineReason
                    FROM Jobs j
                    INNER JOIN Customers c ON j.CustomerID = c.CustomerID
                    WHERE j.IsDeleted = 0";

                if (statusFilter != "All")
                {
                    query += " AND j.Status = @Status";
                }

                query += " ORDER BY j.RequestDate DESC";

                SqlParameter[] parameters = null;
                if (statusFilter != "All")
                {
                    parameters = new SqlParameter[] { new SqlParameter("@Status", statusFilter) };
                }

                DataTable jobsData = DatabaseConnection.FillDataTable(query, parameters);

                if (jobsData != null)
                {
                    dataGridViewJobs.DataSource = jobsData;
                    FormatJobsGrid();
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error loading jobs: {ex.Message}", true);
            }
        }

        private void FormatJobsGrid()
        {
            try
            {
                if (dataGridViewJobs.Columns.Count > 0)
                {
                    // Hide unnecessary columns
                    dataGridViewJobs.Columns["JobID"].Visible = false;
                    dataGridViewJobs.Columns["ApprovedByAdminID"].Visible = false;
                    dataGridViewJobs.Columns["Email"].Visible = false;

                    // Set column headers
                    dataGridViewJobs.Columns["JobNumber"].HeaderText = "Job #";
                    dataGridViewJobs.Columns["CustomerNumber"].HeaderText = "Customer";
                    dataGridViewJobs.Columns["FirstName"].HeaderText = "First Name";
                    dataGridViewJobs.Columns["LastName"].HeaderText = "Last Name";
                    dataGridViewJobs.Columns["StartLocation"].HeaderText = "From";
                    dataGridViewJobs.Columns["Destination"].HeaderText = "To";
                    dataGridViewJobs.Columns["Status"].HeaderText = "Status";
                    dataGridViewJobs.Columns["Priority"].HeaderText = "Priority";
                    dataGridViewJobs.Columns["RequestDate"].HeaderText = "Requested";
                    dataGridViewJobs.Columns["ScheduledDate"].HeaderText = "Scheduled";
                    dataGridViewJobs.Columns["EstimatedCost"].HeaderText = "Est. Cost";

                    // Set column widths
                    dataGridViewJobs.Columns["JobNumber"].Width = 80;
                    dataGridViewJobs.Columns["CustomerNumber"].Width = 80;
                    dataGridViewJobs.Columns["FirstName"].Width = 80;
                    dataGridViewJobs.Columns["LastName"].Width = 80;
                    dataGridViewJobs.Columns["StartLocation"].Width = 100;
                    dataGridViewJobs.Columns["Destination"].Width = 100;
                    dataGridViewJobs.Columns["Status"].Width = 80;
                    dataGridViewJobs.Columns["Priority"].Width = 70;
                    dataGridViewJobs.Columns["RequestDate"].Width = 90;
                    dataGridViewJobs.Columns["ScheduledDate"].Width = 90;
                    dataGridViewJobs.Columns["EstimatedCost"].Width = 80;

                    // Format date and currency columns
                    dataGridViewJobs.Columns["RequestDate"].DefaultCellStyle.Format = "MM/dd/yyyy";
                    dataGridViewJobs.Columns["ScheduledDate"].DefaultCellStyle.Format = "MM/dd/yyyy";
                    dataGridViewJobs.Columns["EstimatedCost"].DefaultCellStyle.Format = "C";
                    dataGridViewJobs.Columns["EstimatedCost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    // Color code by status
                    foreach (DataGridViewRow row in dataGridViewJobs.Rows)
                    {
                        string status = row.Cells["Status"].Value?.ToString();
                        switch (status)
                        {
                            case "Pending":
                                row.DefaultCellStyle.BackColor = Color.LightYellow;
                                break;
                            case "Approved":
                                row.DefaultCellStyle.BackColor = Color.LightGreen;
                                break;
                            case "InProgress":
                                row.DefaultCellStyle.BackColor = Color.LightBlue;
                                break;
                            case "Completed":
                                row.DefaultCellStyle.BackColor = Color.LightGray;
                                break;
                            case "Declined":
                                row.DefaultCellStyle.BackColor = Color.LightPink;
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error formatting grid: {ex.Message}");
            }
        }

        private void dataGridViewJobs_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewJobs.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewJobs.SelectedRows[0];
                selectedJobId = Convert.ToInt32(selectedRow.Cells["JobID"].Value);
                LoadJobDetails(selectedRow);
            }
        }


        // 1. Fix the LoadJobDetails method to handle status dropdown properly:
        private void LoadJobDetails(DataGridViewRow row)
        {
            try
            {
                lblJobNumber.Text = $"Job Number: {row.Cells["JobNumber"].Value}";
                lblCustomerName.Text = $"Customer: {row.Cells["FirstName"].Value} {row.Cells["LastName"].Value} ({row.Cells["CustomerNumber"].Value})";
                lblFromTo.Text = $"From/To: {row.Cells["StartLocation"].Value}, {row.Cells["StartCity"].Value} → {row.Cells["Destination"].Value}, {row.Cells["DestinationCity"].Value}";
                lblRequestDate.Text = $"Request Date: {Convert.ToDateTime(row.Cells["RequestDate"].Value):MM/dd/yyyy}";
                lblCurrentStatus.Text = $"Status: {row.Cells["Status"].Value} (Priority: {row.Cells["Priority"].Value})";
                string specialInstr = row.Cells["SpecialInstructions"].Value?.ToString();
                txtJobDetails.Text = string.IsNullOrEmpty(specialInstr) ? "No special instructions" : specialInstr;
                decimal estimatedCost = Convert.ToDecimal(row.Cells["EstimatedCost"].Value ?? 0);
                txtEstimatedCost.Text = estimatedCost.ToString("F2");

                // NEW: Load associated load details
                LoadJobLoadDetails(selectedJobId);

                // Enable/disable buttons based on status
                string status = row.Cells["Status"].Value?.ToString();
                btnApprove.Enabled = status == "Pending";
                btnDecline.Enabled = status == "Pending";
                btnUpdateStatus.Enabled = status == "Approved" || status == "InProgress";

                // Clear and populate status dropdown based on current status
                comboBoxNewStatus.Items.Clear();
                if (status == "Pending")
                {
                    // For pending jobs, no status update needed (use approve/decline instead)
                    comboBoxNewStatus.Items.Add("Select Action");
                }
                else if (status == "Approved")
                {
                    comboBoxNewStatus.Items.Add("InProgress");
                    comboBoxNewStatus.Items.Add("Completed");
                }
                else if (status == "InProgress")
                {
                    comboBoxNewStatus.Items.Add("Completed");
                }
                else
                {
                    // For completed or declined jobs
                    comboBoxNewStatus.Items.Add("No Updates Available");
                }
                if (comboBoxNewStatus.Items.Count > 0)
                    comboBoxNewStatus.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                ShowMessage($"Error loading job details: {ex.Message}", true);
            }
        }


        private void LoadJobLoadDetails(int jobId)
        {
            try
            {
                // Query to get detailed load information with products
                string query = @"
            SELECT 
                l.Weight as TotalWeight,
                l.Volume as TotalVolume,
                l.LoadCost as TotalCost,
                l.Description as LoadDescription,
                lp.Quantity,
                lp.UnitWeight,
                lp.UnitVolume,
                lp.UnitPrice,
                lp.TotalPrice,
                p.ProductName,
                p.Category,
                p.IsFragile
            FROM Loads l
            LEFT JOIN LoadProducts lp ON l.LoadID = lp.LoadID
            LEFT JOIN Products p ON lp.ProductID = p.ProductID
            WHERE l.JobID = @JobID AND l.IsDeleted = 0
            ORDER BY p.Category, p.ProductName";

                SqlParameter[] parameters = {
            new SqlParameter("@JobID", jobId)
        };

                DataTable loadData = DatabaseConnection.FillDataTable(query, parameters);

                if (loadData != null && loadData.Rows.Count > 0)
                {
                    // Get totals from first row (same for all rows)
                    DataRow firstRow = loadData.Rows[0];
                    decimal totalWeight = Convert.ToDecimal(firstRow["TotalWeight"]);
                    decimal totalVolume = Convert.ToDecimal(firstRow["TotalVolume"]);
                    decimal totalCost = Convert.ToDecimal(firstRow["TotalCost"]);

                    // Build detailed product list
                    System.Text.StringBuilder productDetails = new System.Text.StringBuilder();
                    int productCount = 0;

                    foreach (DataRow row in loadData.Rows)
                    {
                        if (row["ProductName"] != DBNull.Value)
                        {
                            string productName = row["ProductName"].ToString();
                            int quantity = Convert.ToInt32(row["Quantity"]);
                            decimal unitWeight = Convert.ToDecimal(row["UnitWeight"]);
                            decimal unitVolume = Convert.ToDecimal(row["UnitVolume"]);
                            decimal totalPrice = Convert.ToDecimal(row["TotalPrice"]);
                            bool isFragile = Convert.ToBoolean(row["IsFragile"]);

                            string fragileIcon = isFragile ? "⚠️" : "";
                            productDetails.AppendLine($"• {productName} (Qty: {quantity}) - {unitWeight}kg, {unitVolume}m³, ${totalPrice:F2} {fragileIcon}");
                            productCount++;
                        }
                    }

                    // Update display
                    if (productCount > 0)
                    {
                        txtLoadDetails.Text = productDetails.ToString().Trim();
                    }
                    else
                    {
                        txtLoadDetails.Text = firstRow["LoadDescription"].ToString();
                    }

                    lblWeightValue.Text = $"{totalWeight} kg";
                    lblVolumeValue.Text = $"{totalVolume} m³";
                    lblCostValue.Text = $"${totalCost:F2}";
                }
                else
                {
                    // No load details found
                    txtLoadDetails.Text = "No load details specified";
                    lblWeightValue.Text = "Not specified";
                    lblVolumeValue.Text = "Not specified";
                    lblCostValue.Text = "$0.00";
                }
            }
            catch (Exception ex)
            {
                txtLoadDetails.Text = "Error loading load details";
                lblWeightValue.Text = "Error";
                lblVolumeValue.Text = "Error";
                lblCostValue.Text = "Error";
                ShowMessage($"Error loading load details: {ex.Message}", true);
            }
        }

        private void cmbTransportUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTransportUnit.SelectedIndex >= 0 && cmbTransportUnit.SelectedValue != null)
            {
                try
                {
                    DataTable dt = (DataTable)cmbTransportUnit.DataSource;
                    DataRow selectedRow = dt.Select($"TransportUnitID = {cmbTransportUnit.SelectedValue}")[0];

                    decimal loadCapacity = Convert.ToDecimal(selectedRow["LoadCapacity"]);
                    decimal volumeCapacity = Convert.ToDecimal(selectedRow["VolumeCapacity"]);

                    lblCapacityInfo.Text = $"Capacity: {loadCapacity} kg, {volumeCapacity} m³";
                    lblCapacityInfo.ForeColor = Color.Blue;
                }
                catch (Exception)
                {
                    lblCapacityInfo.Text = "Capacity info unavailable";
                    lblCapacityInfo.ForeColor = Color.Red;
                }
            }
            else
            {
                lblCapacityInfo.Text = "";
            }
        }

        // 2. Add a new method to handle cell clicks (more reliable than selection changed):
        private void dataGridViewJobs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewJobs.Rows[e.RowIndex];
                selectedJobId = Convert.ToInt32(selectedRow.Cells["JobID"].Value);
                LoadJobDetails(selectedRow);
            }
        }

        private bool ApproveJobWithTransportUnit(int jobId, decimal estimatedCost, int transportUnitId)
        {
            try
            {
                // Step 1: Update job with approval and transport unit assignment
                string updateJobQuery = @"
            UPDATE Jobs 
            SET Status = 'Approved', 
                EstimatedCost = @EstimatedCost,
                TransportUnitID = @TransportUnitID,
                ApprovedByAdminID = @AdminID,
                ApprovalDate = @ApprovalDate,
                ModifiedDate = @ModifiedDate
            WHERE JobID = @JobID";

                SqlParameter[] jobParameters = {
            new SqlParameter("@EstimatedCost", estimatedCost),
            new SqlParameter("@TransportUnitID", transportUnitId),
            new SqlParameter("@AdminID", UserSession.UserId),
            new SqlParameter("@ApprovalDate", DateTime.Now),
            new SqlParameter("@ModifiedDate", DateTime.Now),
            new SqlParameter("@JobID", jobId)
        };

                int jobUpdateResult = DatabaseConnection.ExecuteNonQuery(updateJobQuery, jobParameters);

                if (jobUpdateResult > 0)
                {
                    // Step 2: Mark transport unit as unavailable
                    string updateTransportQuery = @"
                UPDATE TransportUnits 
                SET IsAvailable = 0, 
                    AssignedDate = @AssignedDate,
                    Status = 'Assigned',
                    ModifiedDate = @ModifiedDate
                WHERE TransportUnitID = @TransportUnitID";

                    SqlParameter[] transportParameters = {
                new SqlParameter("@AssignedDate", DateTime.Now),
                new SqlParameter("@ModifiedDate", DateTime.Now),
                new SqlParameter("@TransportUnitID", transportUnitId)
            };

                    DatabaseConnection.ExecuteNonQuery(updateTransportQuery, transportParameters);

                    // Step 3: Create Load record for this job
                    CreateLoadForApprovedJob(jobId, transportUnitId, estimatedCost);

                    return true;
                }
                else
                {
                    ShowMessage("Failed to approve job. Please try again.", true);
                    return false;
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error approving job: {ex.Message}", true);
                return false;
            }
        }
        private void CreateLoadForApprovedJob(int jobId, int transportUnitId, decimal estimatedCost)
        {
            try
            {
                // Create a load record for the approved job
                string createLoadQuery = @"
            INSERT INTO Loads (LoadNumber, JobID, Description, Weight, Volume, 
                              Status, TransportUnitID, LoadCost, CreatedDate, ModifiedDate, IsDeleted)
            VALUES (@LoadNumber, @JobID, @Description, 0, 0, 
                   'Assigned', @TransportUnitID, @LoadCost, @CreatedDate, @ModifiedDate, 0)";

                string loadNumber = $"LOAD{jobId:000}"; // Generate load number like LOAD001

                SqlParameter[] loadParameters = {
            new SqlParameter("@LoadNumber", loadNumber),
            new SqlParameter("@JobID", jobId),
            new SqlParameter("@Description", $"Transport load for Job {jobId}"),
            new SqlParameter("@TransportUnitID", transportUnitId),
            new SqlParameter("@LoadCost", estimatedCost),
            new SqlParameter("@CreatedDate", DateTime.Now),
            new SqlParameter("@ModifiedDate", DateTime.Now)
        };

                DatabaseConnection.ExecuteNonQuery(createLoadQuery, loadParameters);
            }
            catch (Exception ex)
            {
                // Log the error but don't stop the approval process
                ShowMessage($"Load creation warning: {ex.Message}", true);
            }
        }


        private void ClearJobDetails()
        {
            lblJobNumber.Text = "Job Number: Select a job";
            lblCustomerName.Text = "Customer: ";
            lblFromTo.Text = "From/To: ";
            lblRequestDate.Text = "Request Date: ";
            lblCurrentStatus.Text = "Status: ";
            txtJobDetails.Text = "";
            txtEstimatedCost.Text = "0.00";
            txtDeclineReason.Text = "";

            btnApprove.Enabled = false;
            btnDecline.Enabled = false;
            btnUpdateStatus.Enabled = false;

            txtLoadDetails.Text = "";
            lblWeightValue.Text = "0 kg";
            lblVolumeValue.Text = "0 m³";
            lblCostValue.Text = "$0.00";

            btnApprove.Enabled = false;
            btnDecline.Enabled = false;
            btnUpdateStatus.Enabled = false;
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (selectedJobId == -1)
            {
                ShowMessage("Please select a job to approve", true);
                return;
            }

            // NEW: Validate transport unit is selected
            if (cmbTransportUnit.SelectedIndex < 0 || cmbTransportUnit.SelectedValue == null)
            {
                ShowMessage("Please select a transport unit before approving the job", true);
                cmbTransportUnit.Focus();
                return;
            }

            decimal estimatedCost;
            if (!decimal.TryParse(txtEstimatedCost.Text, out estimatedCost) || estimatedCost <= 0)
            {
                ShowMessage("Please enter a valid estimated cost", true);
                txtEstimatedCost.Focus();
                return;
            }

            // Get selected transport unit ID
            int transportUnitId = Convert.ToInt32(cmbTransportUnit.SelectedValue);

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to approve this job?\n\n" +
                $"Estimated Cost: ${estimatedCost:F2}\n" +
                $"Assigned Transport Unit: {cmbTransportUnit.Text}",
                "Confirm Approval",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (ApproveJobWithTransportUnit(selectedJobId, estimatedCost, transportUnitId))
                {
                    ShowMessage("Job approved successfully and transport unit assigned!", false);
                    RefreshJobs();
                    LoadAvailableTransportUnits(); // Refresh dropdown
                }
            }
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            if (selectedJobId == -1)
            {
                ShowMessage("Please select a job to decline", true);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDeclineReason.Text))
            {
                ShowMessage("Please enter a decline reason", true);
                txtDeclineReason.Focus();
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to decline this job?\n\nReason: {txtDeclineReason.Text}",
                "Confirm Decline",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (DeclineJob(selectedJobId, txtDeclineReason.Text))
                {
                    ShowMessage("Job declined", false);
                    RefreshJobs();
                }
            }
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (selectedJobId == -1)
            {
                ShowMessage("Please select a job to update", true);
                return;
            }

            if (comboBoxNewStatus.SelectedIndex == -1 ||
                comboBoxNewStatus.Text == "Select Action" ||
                comboBoxNewStatus.Text == "No Updates Available")
            {
                ShowMessage("Please select a valid status", true);
                return;
            }

            string newStatus = comboBoxNewStatus.Text;

            DialogResult result = MessageBox.Show(
                $"Update job status to '{newStatus}'?",
                "Confirm Status Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (UpdateJobStatus(selectedJobId, newStatus))
                {
                    ShowMessage($"Job status updated to {newStatus}", false);
                    RefreshJobs();
                }
            }
        }

        private bool ApproveJob(int jobId, decimal estimatedCost)
        {
            try
            {
                string query = @"
                    UPDATE Jobs 
                    SET Status = 'Approved', 
                        EstimatedCost = @EstimatedCost,
                        ApprovedByAdminID = @AdminID,
                        ApprovalDate = @ApprovalDate,
                        LastUpdatedByAdminID = @AdminID,
                        LastUpdatedDate = @UpdateDate,
                        ModifiedDate = @UpdateDate
                    WHERE JobID = @JobID";

                SqlParameter[] parameters = {
                    new SqlParameter("@EstimatedCost", estimatedCost),
                    new SqlParameter("@AdminID", UserSession.UserId),
                    new SqlParameter("@ApprovalDate", DateTime.Now),
                    new SqlParameter("@UpdateDate", DateTime.Now),
                    new SqlParameter("@JobID", jobId)
                };

                int result = DatabaseConnection.ExecuteNonQuery(query, parameters);

                if (result > 0)
                {
                    LogJobAction(jobId, "Job_Approved", $"Job approved with estimated cost ${estimatedCost:F2}");
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                ShowMessage($"Error approving job: {ex.Message}", true);
                return false;
            }
        }

        private bool DeclineJob(int jobId, string reason)
        {
            try
            {
                string query = @"
                    UPDATE Jobs 
                    SET Status = 'Declined', 
                        DeclineReason = @DeclineReason,
                        LastUpdatedByAdminID = @AdminID,
                        LastUpdatedDate = @UpdateDate,
                        ModifiedDate = @UpdateDate
                    WHERE JobID = @JobID";

                SqlParameter[] parameters = {
                    new SqlParameter("@DeclineReason", reason),
                    new SqlParameter("@AdminID", UserSession.UserId),
                    new SqlParameter("@UpdateDate", DateTime.Now),
                    new SqlParameter("@JobID", jobId)
                };

                int result = DatabaseConnection.ExecuteNonQuery(query, parameters);

                if (result > 0)
                {
                    LogJobAction(jobId, "Job_Declined", $"Job declined: {reason}");
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                ShowMessage($"Error declining job: {ex.Message}", true);
                return false;
            }
        }

        private bool UpdateJobStatus(int jobId, string newStatus)
        {
            try
            {
                string query = @"
                    UPDATE Jobs 
                    SET Status = @Status,
                        LastUpdatedByAdminID = @AdminID,
                        LastUpdatedDate = @UpdateDate,
                        ModifiedDate = @UpdateDate";

                // Set completion date if completing the job
                if (newStatus == "Completed")
                {
                    query += ", CompletionDate = @CompletionDate";
                }

                query += " WHERE JobID = @JobID";

                var parameterList = new List<SqlParameter>
                {
                    new SqlParameter("@Status", newStatus),
                    new SqlParameter("@AdminID", UserSession.UserId),
                    new SqlParameter("@UpdateDate", DateTime.Now),
                    new SqlParameter("@JobID", jobId)
                };

                if (newStatus == "Completed")
                {
                    parameterList.Add(new SqlParameter("@CompletionDate", DateTime.Now));
                }

                int result = DatabaseConnection.ExecuteNonQuery(query, parameterList.ToArray());

                if (result > 0)
                {
                    LogJobAction(jobId, "Job_StatusUpdate", $"Status updated to {newStatus}");
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                ShowMessage($"Error updating job status: {ex.Message}", true);
                return false;
            }
        }

        private void LogJobAction(int jobId, string actionType, string details)
        {
            try
            {
                string query = @"
                    INSERT INTO SystemLogs (LogType, UserType, UserID, Action, Details, LogDate, IPAddress)
                    VALUES (@LogType, @UserType, @UserID, @Action, @Details, @LogDate, @IPAddress)";

                SqlParameter[] parameters = {
                    new SqlParameter("@LogType", actionType),
                    new SqlParameter("@UserType", "Admin"),
                    new SqlParameter("@UserID", UserSession.UserId),
                    new SqlParameter("@Action", $"Job {jobId} - {actionType}"),
                    new SqlParameter("@Details", details),
                    new SqlParameter("@LogDate", DateTime.Now),
                    new SqlParameter("@IPAddress", "127.0.0.1")
                };

                DatabaseConnection.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to log job action: {ex.Message}");
            }
        }

        private void LoadAvailableTransportUnits()
        {
            try
            {
                string query = @"
            SELECT 
                tu.TransportUnitID,
                tu.UnitNumber,
                l.RegistrationNumber,
                l.LoadCapacity,
                l.VolumeCapacity,
                CONCAT(d.FirstName, ' ', d.LastName) as DriverName
            FROM TransportUnits tu
            INNER JOIN Lorries l ON tu.LorryID = l.LorryID
            INNER JOIN Drivers d ON tu.DriverID = d.DriverID
            WHERE tu.IsAvailable = 1 AND tu.IsDeleted = 0
            ORDER BY tu.UnitNumber";

                DataTable transportUnits = DatabaseConnection.FillDataTable(query);

                if (transportUnits != null && transportUnits.Rows.Count > 0)
                {
                    // Create display table with formatted text
                    DataTable displayTable = new DataTable();
                    displayTable.Columns.Add("TransportUnitID", typeof(int));
                    displayTable.Columns.Add("DisplayText", typeof(string));
                    displayTable.Columns.Add("LoadCapacity", typeof(decimal));
                    displayTable.Columns.Add("VolumeCapacity", typeof(decimal));

                    foreach (DataRow row in transportUnits.Rows)
                    {
                        DataRow newRow = displayTable.NewRow();
                        newRow["TransportUnitID"] = row["TransportUnitID"];
                        newRow["DisplayText"] = $"{row["UnitNumber"]} - {row["RegistrationNumber"]} (Driver: {row["DriverName"]})";
                        newRow["LoadCapacity"] = row["LoadCapacity"];
                        newRow["VolumeCapacity"] = row["VolumeCapacity"];
                        displayTable.Rows.Add(newRow);
                    }

                    cmbTransportUnit.DataSource = displayTable;
                    cmbTransportUnit.DisplayMember = "DisplayText";
                    cmbTransportUnit.ValueMember = "TransportUnitID";
                    cmbTransportUnit.SelectedIndex = -1; // No selection initially
                }
                else
                {
                    // No available units
                    DataTable emptyTable = new DataTable();
                    emptyTable.Columns.Add("TransportUnitID", typeof(int));
                    emptyTable.Columns.Add("DisplayText", typeof(string));
                    DataRow emptyRow = emptyTable.NewRow();
                    emptyRow["TransportUnitID"] = -1;
                    emptyRow["DisplayText"] = "No available transport units";
                    emptyTable.Rows.Add(emptyRow);

                    cmbTransportUnit.DataSource = emptyTable;
                    cmbTransportUnit.DisplayMember = "DisplayText";
                    cmbTransportUnit.ValueMember = "TransportUnitID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading transport units: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = comboBoxFilterStatus.Text;
            LoadJobs(selectedStatus);
            ClearJobDetails();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshJobs();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            comboBoxFilterStatus.SelectedIndex = 0; // "All"
            LoadJobs("All");
        }

        private void RefreshJobs()
        {
            // Get current filter status
            string currentFilter = comboBoxFilterStatus.SelectedItem?.ToString() ?? "Pending";

            // Reload jobs with current filter
            LoadJobs(currentFilter);

            // Clear job details since selection might change
            ClearJobDetails();

            // Reset selected job
            selectedJobId = -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowMessage(string message, bool isError)
        {
            if (lblStatus != null)
            {
                lblStatus.Text = message;
                lblStatus.ForeColor = isError ? Color.Red : Color.Green;

                // Auto-clear message after 5 seconds
                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 5000;
                timer.Tick += (s, e) =>
                {
                    lblStatus.Text = "Ready";
                    lblStatus.ForeColor = Color.Black;
                    timer.Stop();
                    timer.Dispose();
                };
                timer.Start();
            }
        }

        private void dataGridViewJobs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxNewStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTransportUnit_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxActions_Enter(object sender, EventArgs e)
        {

        }
    }
}