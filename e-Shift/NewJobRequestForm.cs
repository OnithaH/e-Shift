using e_Shift.Database;
using e_Shift.Utils;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace e_Shift
{
    public partial class NewJobRequestForm : Form
    {
        public NewJobRequestForm()
        {
            InitializeComponent();
        }

        private void NewJobRequestForm_Load(object sender, EventArgs e)
        {
            // Check if customer is logged in
            if (!UserSession.IsLoggedIn || !UserSession.IsCustomer())
            {
                MessageBox.Show("Please login as customer to create job requests.",
                              "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // Set default values
            dateTimePickerScheduled.Value = DateTime.Now.AddDays(1); // Tomorrow as default
            comboBoxPriority.SelectedIndex = 1; // Medium priority as default

            // Focus on first field
            txtPickupLocation.Focus();

            LoadAvailableProducts();

            ShowMessage("Fill in the details for your transport request", false);
        }



        private void LoadAvailableProducts()
        {
            try
            {
                string query = @"
            SELECT ProductID, ProductName, Category, Weight, Volume, PricePerUnit,
                   HandlingRequirements, IsFragile
            FROM Products 
            WHERE IsActive = 1 AND IsDeleted = 0
            ORDER BY Category, ProductName";

                DataTable productsTable = DatabaseConnection.FillDataTable(query);

                if (productsTable != null)
                {
                    // Add checkbox and quantity columns
                    DataTable displayTable = new DataTable();
                    displayTable.Columns.Add("Select", typeof(bool));
                    displayTable.Columns.Add("ProductID", typeof(int));
                    displayTable.Columns.Add("Product Name", typeof(string));
                    displayTable.Columns.Add("Category", typeof(string));
                    displayTable.Columns.Add("Weight (kg)", typeof(decimal));
                    displayTable.Columns.Add("Volume (m³)", typeof(decimal));
                    displayTable.Columns.Add("Price/Unit", typeof(decimal));
                    displayTable.Columns.Add("Quantity", typeof(int));
                    displayTable.Columns.Add("Fragile", typeof(string));

                    foreach (DataRow row in productsTable.Rows)
                    {
                        DataRow newRow = displayTable.NewRow();
                        newRow["Select"] = false;
                        newRow["ProductID"] = row["ProductID"];
                        newRow["Product Name"] = row["ProductName"];
                        newRow["Category"] = row["Category"];
                        newRow["Weight (kg)"] = row["Weight"];
                        newRow["Volume (m³)"] = row["Volume"];
                        newRow["Price/Unit"] = row["PricePerUnit"];
                        newRow["Quantity"] = 0;
                        newRow["Fragile"] = Convert.ToBoolean(row["IsFragile"]) ? "Yes" : "No";
                        displayTable.Rows.Add(newRow);
                    }

                    dgvProductSelection.DataSource = displayTable;

                    // Configure columns
                    dgvProductSelection.Columns["ProductID"].Visible = false;
                    dgvProductSelection.Columns["Select"].Width = 60;
                    dgvProductSelection.Columns["Product Name"].Width = 150;
                    dgvProductSelection.Columns["Category"].Width = 80;
                    dgvProductSelection.Columns["Weight (kg)"].Width = 80;
                    dgvProductSelection.Columns["Volume (m³)"].Width = 80;
                    dgvProductSelection.Columns["Price/Unit"].Width = 80;
                    dgvProductSelection.Columns["Quantity"].Width = 70;
                    dgvProductSelection.Columns["Fragile"].Width = 60;

                    // Make columns editable
                    dgvProductSelection.Columns["Select"].ReadOnly = false;
                    dgvProductSelection.Columns["Quantity"].ReadOnly = false;
                    foreach (DataGridViewColumn col in dgvProductSelection.Columns)
                    {
                        if (col.Name != "Select" && col.Name != "Quantity")
                            col.ReadOnly = true;
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error loading products: {ex.Message}", true);
            }
        }



        private void dgvProductSelection_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProductSelection.Rows[e.RowIndex];

                // If Select checkbox changed
                if (e.ColumnIndex == dgvProductSelection.Columns["Select"].Index)
                {
                    bool isSelected = Convert.ToBoolean(row.Cells["Select"].Value);
                    if (isSelected && Convert.ToInt32(row.Cells["Quantity"].Value) == 0)
                    {
                        row.Cells["Quantity"].Value = 1; // Default quantity
                    }
                    else if (!isSelected)
                    {
                        row.Cells["Quantity"].Value = 0;
                    }
                }

                // If Quantity changed
                if (e.ColumnIndex == dgvProductSelection.Columns["Quantity"].Index)
                {
                    int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                    row.Cells["Select"].Value = quantity > 0;
                }

                // Recalculate totals
                CalculateTotals();
            }
        }

        private void CalculateTotals()
        {
            try
            {
                decimal totalWeight = 0;
                decimal totalVolume = 0;
                decimal totalProductCost = 0;
                decimal totalDistance = 0;
                int selectedProductCount = 0;

                // Calculate product costs
                foreach (DataGridViewRow row in dgvProductSelection.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["Select"].Value))
                    {
                        int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                        if (quantity > 0)
                        {
                            decimal weight = Convert.ToDecimal(row.Cells["Weight (kg)"].Value);
                            decimal volume = Convert.ToDecimal(row.Cells["Volume (m³)"].Value);
                            decimal price = Convert.ToDecimal(row.Cells["Price/Unit"].Value);

                            totalWeight += weight * quantity;
                            totalVolume += volume * quantity;
                            totalProductCost += price * quantity;
                            selectedProductCount++;
                        }
                    }
                }

                // Calculate distance and distance cost
                decimal distanceCost = 0.00m;
                if (!string.IsNullOrWhiteSpace(txtPickupCity.Text) && !string.IsNullOrWhiteSpace(txtDeliveryCity.Text))
                {
                    string pickup = txtPickupCity.Text.Trim().ToLower();
                    string delivery = txtDeliveryCity.Text.Trim().ToLower();

                    // Distance lookup table (kilometers)
                    var distances = new Dictionary<string, decimal>
            {
                {"colombo-kandy", 115.8m},
                {"colombo-gampaha", 35.2m},
                {"colombo-negombo", 37.4m},
                {"colombo-galle", 119.0m},
                {"colombo-matara", 160.5m},
                {"colombo-jaffna", 396.8m},
                {"kandy-colombo", 115.8m},
                {"gampaha-colombo", 35.2m},
                {"negombo-colombo", 37.4m},
                {"galle-colombo", 119.0m},
                {"matara-colombo", 160.5m},
                {"jaffna-colombo", 396.8m},
                {"gampaha-kandy", 85.6m},
                {"kandy-gampaha", 85.6m},
                {"negombo-kandy", 142.3m},
                {"kandy-negombo", 142.3m},
                {"galle-kandy", 145.2m},
                {"kandy-galle", 145.2m},
                {"gampaha-negombo", 28.5m},
                {"negombo-gampaha", 28.5m},
                {"galle-matara", 41.3m},
                {"matara-galle", 41.3m}
            };

                    string route = $"{pickup}-{delivery}";
                    if (distances.ContainsKey(route))
                    {
                        totalDistance = distances[route];
                        distanceCost = totalDistance * 2.5m; // $2.50 per km rate
                    }
                    else if (pickup != delivery) // Different cities but not in our database
                    {
                        totalDistance = 75.0m; // Default distance for unknown routes
                        distanceCost = 187.50m; // Default cost (75km * $2.50)
                    }
                }

                // Total cost = Product cost + Distance cost
                decimal totalCost = totalProductCost + distanceCost;

                // Apply priority multiplier to final total
                decimal priorityMultiplier = 1.0m;
                if (comboBoxPriority.Text == "High" || comboBoxPriority.Text == "Urgent")
                    priorityMultiplier = 1.5m;
                totalCost *= priorityMultiplier;

                // Update display controls
                lblWeightValue.Text = $"{totalWeight} kg";
                lblVolumeValue.Text = $"{totalVolume} m³";
                lblDistanceValue.Text = $"{totalDistance} km"; // Update distance display
                lblCostValue.Text = $"${totalCost:F2}";
            }
            catch (Exception ex)
            {
                ShowMessage($"Error calculating totals: {ex.Message}", true);
            }
        }



        private void btnSubmitRequest_Click(object sender, EventArgs e)
        {
            // Clear previous status
            lblStatus.Text = "";

            // Validate required fields
            if (!ValidateForm())
                return;

            // Confirm submission
            DialogResult result = MessageBox.Show(
                "Are you sure you want to submit this transport request?\n\n" +
                $"From: {txtPickupLocation.Text}, {txtPickupCity.Text}\n" +
                $"To: {txtDeliveryLocation.Text}, {txtDeliveryCity.Text}\n" +
                $"Preferred Date: {dateTimePickerScheduled.Value:MM/dd/yyyy}\n" +
                $"Priority: {comboBoxPriority.Text}",
                "Confirm Job Request",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (SubmitJobRequest())
                {
                    MessageBox.Show("✅ Transport request submitted successfully!\n\n" +
                                  "Your request has been sent to the admin for review.\n" +
                                  "You will be notified once it's approved.\n\n" +
                                  "You can check the status in your dashboard.",
                                  "Request Submitted",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private bool ValidateForm()
        {
            // Pickup location validation
            if (string.IsNullOrWhiteSpace(txtPickupLocation.Text))
            {
                ShowMessage("Pickup location is required", true);
                txtPickupLocation.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPickupAddress.Text))
            {
                ShowMessage("Pickup address is required", true);
                txtPickupAddress.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPickupCity.Text))
            {
                ShowMessage("Pickup city is required", true);
                txtPickupCity.Focus();
                return false;
            }

            // Delivery location validation
            if (string.IsNullOrWhiteSpace(txtDeliveryLocation.Text))
            {
                ShowMessage("Delivery location is required", true);
                txtDeliveryLocation.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDeliveryAddress.Text))
            {
                ShowMessage("Delivery address is required", true);
                txtDeliveryAddress.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDeliveryCity.Text))
            {
                ShowMessage("Delivery city is required", true);
                txtDeliveryCity.Focus();
                return false;
            }

            // Date validation
            if (dateTimePickerScheduled.Value.Date < DateTime.Now.Date)
            {
                ShowMessage("Scheduled date cannot be in the past", true);
                dateTimePickerScheduled.Focus();
                return false;
            }

            // Priority validation
            if (comboBoxPriority.SelectedIndex == -1)
            {
                ShowMessage("Please select a priority level", true);
                comboBoxPriority.Focus();
                return false;
            }
            bool hasSelectedProducts = false;
            foreach (DataGridViewRow row in dgvProductSelection.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Select"].Value))
                {
                    hasSelectedProducts = true;
                    break;
                }
            }

            if (!hasSelectedProducts)
            {
                ShowMessage("Please select at least one item to move", true);
                return false;
            }

            return true;
        }

        // Replace the SubmitJobRequest method in NewJobRequestForm.cs with this fixed version:

        private bool SubmitJobRequest()
        {
            try
            {
                // Step 1: Calculate totals from selected products
                decimal totalWeight = 0, totalVolume = 0, totalCost = 0;
                int selectedProductCount = 0;

                foreach (DataGridViewRow row in dgvProductSelection.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["Select"].Value))
                    {
                        int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                        if (quantity > 0)
                        {
                            decimal weight = Convert.ToDecimal(row.Cells["Weight (kg)"].Value);
                            decimal volume = Convert.ToDecimal(row.Cells["Volume (m³)"].Value);
                            decimal price = Convert.ToDecimal(row.Cells["Price/Unit"].Value);

                            totalWeight += weight * quantity;
                            totalVolume += volume * quantity;
                            totalCost += price * quantity;
                            selectedProductCount++;
                        }
                    }
                }

                // Apply priority multiplier
                decimal priorityMultiplier = 1.0m;
                if (comboBoxPriority.Text == "High" || comboBoxPriority.Text == "Urgent")
                    priorityMultiplier = 1.5m;
                totalCost *= priorityMultiplier;

                // Step 2: Create Job record
                string jobQuery = @"
            INSERT INTO Jobs (
                CustomerID, StartLocation, StartAddress, StartCity, StartPostalCode,
                Destination, DestinationAddress, DestinationCity, DestinationPostalCode,
                ScheduledDate, Priority, SpecialInstructions, Status, EstimatedCost
            ) VALUES (
                @CustomerID, @StartLocation, @StartAddress, @StartCity, @StartPostalCode,
                @Destination, @DestinationAddress, @DestinationCity, @DestinationPostalCode,
                @ScheduledDate, @Priority, @SpecialInstructions, @Status, @EstimatedCost
            ); SELECT SCOPE_IDENTITY();";

                SqlParameter[] jobParameters = {
            new SqlParameter("@CustomerID", UserSession.UserId),
            new SqlParameter("@StartLocation", txtPickupLocation.Text.Trim()),
            new SqlParameter("@StartAddress", txtPickupAddress.Text.Trim()),
            new SqlParameter("@StartCity", txtPickupCity.Text.Trim()),
            new SqlParameter("@StartPostalCode", string.IsNullOrEmpty(txtPickupPostal.Text) ? (object)DBNull.Value : txtPickupPostal.Text.Trim()),
            new SqlParameter("@Destination", txtDeliveryLocation.Text.Trim()),
            new SqlParameter("@DestinationAddress", txtDeliveryAddress.Text.Trim()),
            new SqlParameter("@DestinationCity", txtDeliveryCity.Text.Trim()),
            new SqlParameter("@DestinationPostalCode", string.IsNullOrEmpty(txtDeliveryPostal.Text) ? (object)DBNull.Value : txtDeliveryPostal.Text.Trim()),
            new SqlParameter("@ScheduledDate", dateTimePickerScheduled.Value.Date),
            new SqlParameter("@Priority", comboBoxPriority.Text),
            new SqlParameter("@SpecialInstructions", string.IsNullOrEmpty(txtSpecialInstructions.Text) ? (object)DBNull.Value : txtSpecialInstructions.Text.Trim()),
            new SqlParameter("@Status", "Pending"),
            new SqlParameter("@EstimatedCost", totalCost)
        };

                // Execute job creation and get JobID
                object jobResult = DatabaseConnection.ExecuteScalar(jobQuery, jobParameters);
                if (jobResult == null) return false;

                int newJobID = Convert.ToInt32(jobResult);

                // Step 3: Create Load record
                string loadQuery = @"
            INSERT INTO Loads (JobID, Description, Weight, Volume, LoadCost, Status)
            VALUES (@JobID, @Description, @Weight, @Volume, @LoadCost, @Status);
            SELECT SCOPE_IDENTITY();";

                SqlParameter[] loadParameters = {
            new SqlParameter("@JobID", newJobID),
            new SqlParameter("@Description", $"Household items - {selectedProductCount} product types"),
            new SqlParameter("@Weight", totalWeight),
            new SqlParameter("@Volume", totalVolume),
            new SqlParameter("@LoadCost", totalCost),
            new SqlParameter("@Status", "Pending")
        };

                object loadResult = DatabaseConnection.ExecuteScalar(loadQuery, loadParameters);
                if (loadResult == null) return false;

                int newLoadID = Convert.ToInt32(loadResult);

                // Step 4: Create LoadProducts records
                foreach (DataGridViewRow row in dgvProductSelection.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["Select"].Value))
                    {
                        int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                        if (quantity > 0)
                        {
                            string loadProductQuery = @"
                        INSERT INTO LoadProducts (LoadID, ProductID, Quantity, UnitWeight, UnitVolume, UnitPrice, TotalPrice)
                        VALUES (@LoadID, @ProductID, @Quantity, @UnitWeight, @UnitVolume, @UnitPrice, @TotalPrice)";

                            SqlParameter[] loadProductParameters = {
                        new SqlParameter("@LoadID", newLoadID),
                        new SqlParameter("@ProductID", Convert.ToInt32(row.Cells["ProductID"].Value)),
                        new SqlParameter("@Quantity", quantity),
                        new SqlParameter("@UnitWeight", Convert.ToDecimal(row.Cells["Weight (kg)"].Value)),
                        new SqlParameter("@UnitVolume", Convert.ToDecimal(row.Cells["Volume (m³)"].Value)),
                        new SqlParameter("@UnitPrice", Convert.ToDecimal(row.Cells["Price/Unit"].Value)),
                        new SqlParameter("@TotalPrice", Convert.ToDecimal(row.Cells["Price/Unit"].Value) * quantity)
                    };

                            DatabaseConnection.ExecuteNonQuery(loadProductQuery, loadProductParameters);
                        }
                    }
                }

                // Log the action
                LogJobRequest();
                return true;
            }
            catch (Exception ex)
            {
                ShowMessage($"Error submitting request: {ex.Message}", true);
                return false;
            }
        }




        private int GetLastInsertedJobID()
        {
            try
            {
                string query = "SELECT SCOPE_IDENTITY()";
                object result = DatabaseConnection.ExecuteScalar(query);
                return result != null ? Convert.ToInt32(result) : -1;
            }
            catch (Exception ex)
            {
                ShowMessage($"Error getting job ID: {ex.Message}", true);
                return -1;
            }
        }

        private void LogJobRequest()
        {
            try
            {
                string query = @"
                    INSERT INTO SystemLogs (LogType, UserType, UserID, Action, Details, LogDate, IPAddress)
                    VALUES (@LogType, @UserType, @UserID, @Action, @Details, @LogDate, @IPAddress)";

                SqlParameter[] parameters = {
                    new SqlParameter("@LogType", "Job_Request"),
                    new SqlParameter("@UserType", "Customer"),
                    new SqlParameter("@UserID", UserSession.UserId),
                    new SqlParameter("@Action", "New job request submitted"),
                    new SqlParameter("@Details", $"From: {txtPickupCity.Text} To: {txtDeliveryCity.Text}"),
                    new SqlParameter("@LogDate", DateTime.Now),
                    new SqlParameter("@IPAddress", "127.0.0.1")
                };

                DatabaseConnection.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to log job request: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to cancel?\nAll entered data will be lost.",
                "Confirm Cancel",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void ShowMessage(string message, bool isError)
        {
            if (lblStatus != null)
            {
                lblStatus.Text = message;
                lblStatus.ForeColor = isError ? Color.Red : Color.Green;

                // Auto-clear message after 5 seconds
                if (!isError)
                {
                    System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                    timer.Interval = 5000;
                    timer.Tick += (s, e) =>
                    {
                        lblStatus.Text = "";
                        timer.Stop();
                        timer.Dispose();
                    };
                    timer.Start();
                }
            }
        }

        // Helper method to auto-fill city based on postal code (optional feature)
        private void txtPickupPostal_TextChanged(object sender, EventArgs e)
        {
            // Could add postal code lookup functionality here
        }

        private void txtDeliveryPostal_TextChanged(object sender, EventArgs e)
        {
            // Could add postal code lookup functionality here
        }

        private void lblCostValue_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}