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
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (selectedJobId == -1)
            {
                ShowMessage("Please select a job to approve", true);
                return;
            }

            decimal estimatedCost;
            if (!decimal.TryParse(txtEstimatedCost.Text, out estimatedCost) || estimatedCost <= 0)
            {
                ShowMessage("Please enter a valid estimated cost", true);
                txtEstimatedCost.Focus();
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to approve this job?\n\nEstimated Cost: ${estimatedCost:F2}",
                "Confirm Approval",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (ApproveJob(selectedJobId, estimatedCost))
                {
                    ShowMessage("Job approved successfully!", false);
                    RefreshJobs();
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
            string selectedStatus = comboBoxFilterStatus.Text;
            LoadJobs(selectedStatus);
            ClearJobDetails();
            ShowMessage("Jobs refreshed", false);
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
    }
}