using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using e_Shift.Database;
using e_Shift.Utils;
using Microsoft.Data.SqlClient;

namespace e_Shift
{
    public partial class AdminDashboard : Form
    {
        // Dashboard statistics
        private int pendingJobs;
        private int approvedJobs;
        private int completedJobs;
        private int availableTransportUnits;
        private int totalCustomers;
        private int activeProducts;
        private decimal totalRevenue;

        public AdminDashboard()
        {
            InitializeComponent();
            CheckAdminAccess();
            LoadDashboardData();
            SetupFormLayout();
        }

        private void CheckAdminAccess()
        {
            // Ensure only admin can access this form
            if (!UserSession.IsLoggedIn || !UserSession.IsAdmin())
            {
                MessageBox.Show("Access denied! Admin privileges required.",
                              "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }

        private void SetupFormLayout()
        {
            // Update welcome message
            lblWelcome.Text = $"Welcome, {UserSession.GetFullName()}";
            lblRole.Text = $"Role: {UserSession.Role}";
            lblLoginTime.Text = $"Login Time: {UserSession.LoginTime:HH:mm:ss}";
        }

        private void LoadDashboardData()
        {
            try
            {
                // Call stored procedure to get dashboard data
                string query = "EXEC sp_GetAdminDashboard";
                using (SqlDataReader reader = DatabaseConnection.ExecuteReader(query))
                {
                    if (reader != null && reader.Read())
                    {
                        pendingJobs = Convert.ToInt32(reader["PendingJobs"] ?? 0);
                        approvedJobs = Convert.ToInt32(reader["ApprovedJobs"] ?? 0);
                        completedJobs = Convert.ToInt32(reader["CompletedJobs"] ?? 0);
                        availableTransportUnits = Convert.ToInt32(reader["AvailableTransportUnits"] ?? 0);
                        totalCustomers = Convert.ToInt32(reader["TotalCustomers"] ?? 0);
                        activeProducts = Convert.ToInt32(reader["ActiveProducts"] ?? 0);

                        // Handle nullable revenue
                        if (reader["TotalRevenue"] != DBNull.Value)
                            totalRevenue = Convert.ToDecimal(reader["TotalRevenue"]);
                        else
                            totalRevenue = 0;
                    }
                }

                UpdateStatisticsDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard data: {ex.Message}",
                              "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateStatisticsDisplay()
        {
            // Update job statistics
            lblPendingJobs.Text = pendingJobs.ToString();
            lblApprovedJobs.Text = approvedJobs.ToString();
            lblCompletedJobs.Text = completedJobs.ToString();

            // Update resource statistics
            lblAvailableUnits.Text = availableTransportUnits.ToString();
            lblTotalCustomers.Text = totalCustomers.ToString();
            lblActiveProducts.Text = activeProducts.ToString();

            // Update revenue
            lblTotalRevenue.Text = totalRevenue.ToString("C");

            // Update progress bars and colors based on data
            UpdateStatisticsColors();
        }

        private void UpdateStatisticsColors()
        {
            // Color code statistics based on values
            lblPendingJobs.ForeColor = pendingJobs > 5 ? Color.Red : Color.Orange;
            lblApprovedJobs.ForeColor = Color.Blue;
            lblCompletedJobs.ForeColor = Color.Green;
            lblTotalRevenue.ForeColor = totalRevenue > 0 ? Color.DarkGreen : Color.Gray;
        }

        // Navigation button click events - Show placeholder messages for now
        private void btnCustomerManagement_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Customer Management form will be created next!\n\n" +
                          "This will allow you to:\n" +
                          "• View all customers\n" +
                          "• Add new customers\n" +
                          "• Edit customer details\n" +
                          "• Activate/Deactivate customers",
                          "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            try
            {
                // Open Product Management form
                ProductManagementForm productManagementForm = new ProductManagementForm();
                productManagementForm.ShowDialog();
            }
            catch (Exception ex)
            {
                ShowMessage($"Error opening product management: {ex.Message}", true);
            }
        }

        private void btnJobManagement_Click(object sender, EventArgs e)
        {
            try
            {
                // Open Admin Job Management form
                AdminJobManagementForm jobManagementForm = new AdminJobManagementForm();
                jobManagementForm.ShowDialog();

                // Refresh dashboard statistics after job management
                LoadDashboardData();
            }
            catch (Exception ex)
            {
                ShowMessage($"Error opening job management: {ex.Message}", true);
            }
        }

        private void btnTransportManagement_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transport Management form will be created later!\n\n" +
                          "This will allow you to:\n" +
                          "• Manage lorries\n" +
                          "• Manage drivers\n" +
                          "• Manage assistants\n" +
                          "• Manage containers",
                          "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reports form will be created later!\n\n" +
                          "This will allow you to:\n" +
                          "• Generate customer reports\n" +
                          "• Generate revenue reports\n" +
                          "• Generate job statistics\n" +
                          "• Export data to PDF/Excel",
                          "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUserProfile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Profile form will be created later!\n\n" +
                          "This will allow you to:\n" +
                          "• Edit your profile information\n" +
                          "• Change password\n" +
                          "• Update contact details\n" +
                          "• View login history",
                          "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDashboardData();
            ShowMessage("Dashboard data refreshed successfully!", false);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Clear user session
                UserSession.Logout();

                // Return to login form
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            // Additional setup when form loads
            this.WindowState = FormWindowState.Maximized;

            // Set focus to refresh button
            btnRefresh.Focus();

            // Show welcome message
            ShowMessage($"Welcome to e-Shift Admin Dashboard, {UserSession.GetFullName()}!", false);
        }

        private void AdminDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Prevent accidental closing, ask for confirmation
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to exit the application?",
                    "Confirm Exit",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }

                // Logout user session when closing
                UserSession.Logout();
            }
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
                timer.Tick += (s, e) => {
                    lblStatus.Text = "Ready";
                    lblStatus.ForeColor = Color.Black;
                    timer.Stop();
                    timer.Dispose();
                };
                timer.Start();
            }
        }

        private void btnQuickAddCustomer_Click(object sender, EventArgs e)
        {
            string customerName = PromptForInput("Enter customer name (FirstName LastName):", "Quick Add Customer");

            if (!string.IsNullOrEmpty(customerName))
            {
                try
                {
                    string[] nameParts = customerName.Split(' ');
                    if (nameParts.Length >= 2)
                    {
                        string firstName = nameParts[0];
                        string lastName = string.Join(" ", nameParts, 1, nameParts.Length - 1);
                        string email = $"{firstName.ToLower()}.{lastName.ToLower()}@example.com";

                        // Simplified query - NO SALT COLUMN
                        string query = @"
                    INSERT INTO Customers (FirstName, LastName, Email, Password)
                    VALUES (@FirstName, @LastName, @Email, @Password)";

                        SqlParameter[] parameters = {
                    new SqlParameter("@FirstName", firstName),
                    new SqlParameter("@LastName", lastName),
                    new SqlParameter("@Email", email),
                    new SqlParameter("@Password", PasswordUtils.HashPassword("customer123"))
                    // NO SALT PARAMETER!
                };

                        int result = DatabaseConnection.ExecuteNonQuery(query, parameters);
                        if (result > 0)
                        {
                            ShowMessage($"Customer {customerName} added successfully!", false);
                            LoadDashboardData(); // Refresh statistics
                        }
                    }
                    else
                    {
                        ShowMessage("Please enter both first and last name", true);
                    }
                }
                catch (Exception ex)
                {
                    ShowMessage($"Error adding customer: {ex.Message}", true);
                }
            }
        }

        private void btnViewRecentActivity_Click(object sender, EventArgs e)
        {
            try
            {
                // Show recent activity in a simple message box
                string query = @"
                    SELECT TOP 5 
                        LogType, Action, Details, LogDate 
                    FROM SystemLogs 
                    ORDER BY LogDate DESC";

                DataTable activityData = DatabaseConnection.FillDataTable(query);

                if (activityData != null && activityData.Rows.Count > 0)
                {
                    string activity = "Recent Activity:\n\n";
                    foreach (DataRow row in activityData.Rows)
                    {
                        activity += $"{row["LogDate"]:MM/dd HH:mm} - {row["LogType"]}: {row["Action"]}\n";
                    }

                    MessageBox.Show(activity, "Recent Activity",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No recent activity found.", "Recent Activity",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error loading recent activity: {ex.Message}", true);
            }
        }

        // Helper method to replace Microsoft.VisualBasic.Interaction.InputBox
        private string PromptForInput(string prompt, string title)
        {
            Form promptForm = new Form()
            {
                Width = 400,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = title,
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Label textLabel = new Label() { Left = 20, Top = 20, Width = 350, Text = prompt };
            TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 300 };
            Button confirmation = new Button() { Text = "OK", Left = 230, Width = 90, Top = 80, DialogResult = DialogResult.OK };
            Button cancel = new Button() { Text = "Cancel", Left = 330, Width = 90, Top = 80, DialogResult = DialogResult.Cancel };

            confirmation.Click += (sender, e) => { promptForm.Close(); };
            cancel.Click += (sender, e) => { promptForm.Close(); };

            promptForm.Controls.Add(textLabel);
            promptForm.Controls.Add(textBox);
            promptForm.Controls.Add(confirmation);
            promptForm.Controls.Add(cancel);
            promptForm.AcceptButton = confirmation;
            promptForm.CancelButton = cancel;

            return promptForm.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}