using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using e_Shift.Database;
using e_Shift.Utils;

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

            ShowMessage("Fill in the details for your transport request", false);
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

            return true;
        }

        // Replace the SubmitJobRequest method in NewJobRequestForm.cs with this fixed version:

        private bool SubmitJobRequest()
        {
            try
            {
                string query = @"
            INSERT INTO Jobs (
                CustomerID, StartLocation, StartAddress, StartCity, StartPostalCode,
                Destination, DestinationAddress, DestinationCity, DestinationPostalCode,
                ScheduledDate, Priority, SpecialInstructions, Status
            ) VALUES (
                @CustomerID, @StartLocation, @StartAddress, @StartCity, @StartPostalCode,
                @Destination, @DestinationAddress, @DestinationCity, @DestinationPostalCode,
                @ScheduledDate, @Priority, @SpecialInstructions, @Status
            )";

                SqlParameter[] parameters = {
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
            new SqlParameter("@Status", "Pending")
        };

                int result = DatabaseConnection.ExecuteNonQuery(query, parameters);

                if (result > 0)
                {
                    // Log the action
                    LogJobRequest();
                    return true;
                }
                else
                {
                    ShowMessage("Failed to submit job request", true);
                    return false;
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error submitting request: {ex.Message}", true);
                return false;
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
                    timer.Tick += (s, e) => {
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
    }
}