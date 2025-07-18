using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using e_Shift.Database;
using e_Shift.Utils;
using Microsoft.Data.SqlClient;

namespace e_Shift
{
    public partial class CustomerDashboard : Form
    {
        // Dashboard statistics
        private int totalJobs;
        private int pendingJobs;
        private int approvedJobs;
        private int completedJobs;

        public CustomerDashboard()
        {
            InitializeComponent();
            CheckCustomerAccess();
            LoadDashboardData();
            SetupFormLayout();
        }

        private void CheckCustomerAccess()
        {
            // Ensure only customer can access this form
            if (!UserSession.IsLoggedIn || !UserSession.IsCustomer())
            {
                MessageBox.Show("Access denied! Customer login required.",
                              "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }

        private void SetupFormLayout()
        {
            // Update welcome message
            lblWelcome.Text = $"Welcome, {UserSession.GetFullName()}";
            lblCustomerNumber.Text = $"Customer Number: {UserSession.Username}";
            lblLoginTime.Text = $"Login Time: {UserSession.LoginTime:HH:mm:ss}";
        }

        private void LoadDashboardData()
        {
            try
            {
                // Get customer statistics
                LoadCustomerStatistics();

                // Load recent jobs
                LoadRecentJobs();

                // Update display
                UpdateStatisticsDisplay();
            }
            catch (Exception ex)
            {
                ShowMessage($"Error loading dashboard data: {ex.Message}", true);
            }
        }

        private void LoadCustomerStatistics()
        {
            try
            {
                // Call stored procedure to get customer dashboard data
                string query = "EXEC sp_GetCustomerDashboard @CustomerID";
                SqlParameter[] parameters = {
                    new SqlParameter("@CustomerID", UserSession.UserId)
                };

                using (SqlDataReader reader = DatabaseConnection.ExecuteReader(query, parameters))
                {
                    if (reader != null && reader.Read())
                    {
                        totalJobs = Convert.ToInt32(reader["TotalJobs"] ?? 0);
                        pendingJobs = Convert.ToInt32(reader["PendingJobs"] ?? 0);
                        approvedJobs = Convert.ToInt32(reader["ApprovedJobs"] ?? 0);
                        completedJobs = Convert.ToInt32(reader["CompletedJobs"] ?? 0);
                    }
                }
            }
            catch (Exception)
            {
                // If stored procedure fails, get basic count
                GetBasicJobCounts();
            }
        }

        private void GetBasicJobCounts()
        {
            try
            {
                string query = @"
                    SELECT 
                        COUNT(*) as TotalJobs,
                        SUM(CASE WHEN Status = 'Pending' THEN 1 ELSE 0 END) as PendingJobs,
                        SUM(CASE WHEN Status = 'Approved' THEN 1 ELSE 0 END) as ApprovedJobs,
                        SUM(CASE WHEN Status = 'Completed' THEN 1 ELSE 0 END) as CompletedJobs
                    FROM Jobs 
                    WHERE CustomerID = @CustomerID AND IsDeleted = 0";

                SqlParameter[] parameters = {
                    new SqlParameter("@CustomerID", UserSession.UserId)
                };

                using (SqlDataReader reader = DatabaseConnection.ExecuteReader(query, parameters))
                {
                    if (reader != null && reader.Read())
                    {
                        totalJobs = Convert.ToInt32(reader["TotalJobs"] ?? 0);
                        pendingJobs = Convert.ToInt32(reader["PendingJobs"] ?? 0);
                        approvedJobs = Convert.ToInt32(reader["ApprovedJobs"] ?? 0);
                        completedJobs = Convert.ToInt32(reader["CompletedJobs"] ?? 0);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error loading job statistics: {ex.Message}", true);
            }
        }

        private void LoadRecentJobs()
        {
            try
            {
                string query = @"
                    SELECT TOP 10
                        JobNumber,
                        StartLocation,
                        Destination,
                        Status,
                        RequestDate,
                        ScheduledDate,
                        EstimatedCost
                    FROM Jobs 
                    WHERE CustomerID = @CustomerID AND IsDeleted = 0
                    ORDER BY RequestDate DESC";

                SqlParameter[] parameters = {
                    new SqlParameter("@CustomerID", UserSession.UserId)
                };

                DataTable jobsData = DatabaseConnection.FillDataTable(query, parameters);

                if (jobsData != null)
                {
                    dataGridViewJobs.DataSource = jobsData;
                    FormatJobsGrid();
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error loading recent jobs: {ex.Message}", true);
            }
        }

        private void FormatJobsGrid()
        {
            try
            {
                if (dataGridViewJobs.Columns.Count > 0)
                {
                    // Set column headers
                    dataGridViewJobs.Columns["JobNumber"].HeaderText = "Job #";
                    dataGridViewJobs.Columns["StartLocation"].HeaderText = "From";
                    dataGridViewJobs.Columns["Destination"].HeaderText = "To";
                    dataGridViewJobs.Columns["Status"].HeaderText = "Status";
                    dataGridViewJobs.Columns["RequestDate"].HeaderText = "Requested";
                    dataGridViewJobs.Columns["ScheduledDate"].HeaderText = "Scheduled";
                    dataGridViewJobs.Columns["EstimatedCost"].HeaderText = "Cost";

                    // Set column widths
                    dataGridViewJobs.Columns["JobNumber"].Width = 80;
                    dataGridViewJobs.Columns["StartLocation"].Width = 100;
                    dataGridViewJobs.Columns["Destination"].Width = 100;
                    dataGridViewJobs.Columns["Status"].Width = 80;
                    dataGridViewJobs.Columns["RequestDate"].Width = 90;
                    dataGridViewJobs.Columns["ScheduledDate"].Width = 90;
                    dataGridViewJobs.Columns["EstimatedCost"].Width = 80;

                    // Format date columns
                    dataGridViewJobs.Columns["RequestDate"].DefaultCellStyle.Format = "MM/dd/yyyy";
                    dataGridViewJobs.Columns["ScheduledDate"].DefaultCellStyle.Format = "MM/dd/yyyy";

                    // Format currency
                    dataGridViewJobs.Columns["EstimatedCost"].DefaultCellStyle.Format = "C";
                    dataGridViewJobs.Columns["EstimatedCost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error formatting grid: {ex.Message}");
            }
        }

        private void UpdateStatisticsDisplay()
        {
            // Update job statistics
            lblTotalJobs.Text = totalJobs.ToString();
            lblPendingJobs.Text = pendingJobs.ToString();
            lblApprovedJobs.Text = approvedJobs.ToString();
            lblCompletedJobs.Text = completedJobs.ToString();

            // Update colors based on status
            lblPendingJobs.ForeColor = pendingJobs > 0 ? Color.Orange : Color.Gray;
            lblApprovedJobs.ForeColor = approvedJobs > 0 ? Color.Blue : Color.Gray;
            lblCompletedJobs.ForeColor = completedJobs > 0 ? Color.Green : Color.Gray;
        }

        // Button click events
        private void btnNewJobRequest_Click(object sender, EventArgs e)
        {
            try
            {
                // Open New Job Request form
                using (NewJobRequestForm jobRequestForm = new NewJobRequestForm())
                {
                    if (jobRequestForm.ShowDialog() == DialogResult.OK)
                    {
                        // Job request was submitted successfully
                        ShowMessage("Job request submitted successfully!", false);

                        // Refresh dashboard to show new job
                        RefreshDashboard();
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error opening job request form: {ex.Message}", true);
            }
        }

        private void btnViewMyJobs_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO: Open MyJobsForm  
                MessageBox.Show("My Jobs form will be created later!\n\n" +
                              "This will allow you to:\n" +
                              "• View all your job requests\n" +
                              "• Check job status and progress\n" +
                              "• View assigned transport details\n" +
                              "• Track job completion",
                              "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ShowMessage($"Error opening jobs view: {ex.Message}", true);
            }
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO: Open EditProfileForm
                MessageBox.Show("Edit Profile form will be created later!\n\n" +
                              "This will allow you to:\n" +
                              "• Update contact information\n" +
                              "• Change address details\n" +
                              "• Update phone number\n" +
                              "• Change password",
                              "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ShowMessage($"Error opening profile form: {ex.Message}", true);
            }
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

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            // Additional setup when form loads
            this.WindowState = FormWindowState.Normal;

            // Set focus to new job request button
            btnNewJobRequest.Focus();

            // Show welcome message
            ShowMessage($"Welcome to your dashboard, {UserSession.GetFullName()}!", false);
        }

        private void CustomerDashboard_FormClosing(object sender, FormClosingEventArgs e)
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

        // Refresh dashboard data
        private void RefreshDashboard()
        {
            LoadDashboardData();
            ShowMessage("Dashboard refreshed successfully!", false);
        }

        // Handle double-click on jobs grid to view job details
        private void dataGridViewJobs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    string jobNumber = dataGridViewJobs.Rows[e.RowIndex].Cells["JobNumber"].Value?.ToString();
                    string status = dataGridViewJobs.Rows[e.RowIndex].Cells["Status"].Value?.ToString();
                    string from = dataGridViewJobs.Rows[e.RowIndex].Cells["StartLocation"].Value?.ToString();
                    string to = dataGridViewJobs.Rows[e.RowIndex].Cells["Destination"].Value?.ToString();

                    MessageBox.Show($"Job Details:\n\n" +
                                  $"Job Number: {jobNumber}\n" +
                                  $"Status: {status}\n" +
                                  $"From: {from}\n" +
                                  $"To: {to}\n\n" +
                                  $"Double-click to view full details (Feature coming soon!)",
                                  "Job Information",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    ShowMessage($"Error viewing job details: {ex.Message}", true);
                }
            }
        }
    }
}