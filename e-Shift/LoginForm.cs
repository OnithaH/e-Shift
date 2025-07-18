using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using e_Shift.Database;
using e_Shift.Utils;
using System.Security.Cryptography;
using System.Text;

namespace e_Shift
{
    public partial class LoginForm : Form
    {
        // Secret key for password hashing (same as used in database)
        private const string SECRET_KEY = "ESHIFT_SECRET_2024";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Set initial focus
            txtUsername.Focus();

            // Test database connection
            if (!DatabaseConnection.TestConnection())
            {
                ShowMessage("Database connection failed! Please check your connection.", true);
                btnLogin.Enabled = false;
            }
            else
            {
                ShowMessage("Ready to login", false);
            }

            // Set default login type
            rbCustomer.Checked = true;

            // Clear any existing session
            UserSession.Logout();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            bool isAdmin = rbAdmin.Checked;

            // Clear previous messages
            ShowMessage("", false);

            // Validate input
            if (string.IsNullOrWhiteSpace(username))
            {
                ShowMessage("Please enter username", true);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                ShowMessage("Please enter password", true);
                txtPassword.Focus();
                return;
            }

            // Disable login button during authentication
            btnLogin.Enabled = false;
            btnLogin.Text = "Authenticating...";
            this.Cursor = Cursors.WaitCursor;

            try
            {
                if (isAdmin)
                {
                    AuthenticateAdmin(username, password);
                }
                else
                {
                    AuthenticateCustomer(username, password);
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Login error: {ex.Message}", true);
            }
            finally
            {
                // Re-enable login button
                btnLogin.Enabled = true;
                btnLogin.Text = "Login";
                this.Cursor = Cursors.Default;
            }
        }

        private void AuthenticateAdmin(string username, string password)
        {
            try
            {
                string query = @"
                    SELECT AdminID, Username, Password, FirstName, LastName, Email, Role, IsActive 
                    FROM Admins 
                    WHERE LOWER(LTRIM(RTRIM(Username))) = LOWER(LTRIM(RTRIM(@Username))) 
                    AND IsDeleted = 0";

                SqlParameter[] parameters = {
                    new SqlParameter("@Username", username)
                };

                using (SqlDataReader reader = DatabaseConnection.ExecuteReader(query, parameters))
                {
                    if (reader != null && reader.Read())
                    {
                        bool isActive = Convert.ToBoolean(reader["IsActive"]);
                        if (!isActive)
                        {
                            ShowMessage("Admin account is deactivated", true);
                            return;
                        }

                        byte[] storedPasswordHash = (byte[])reader["Password"];

                        if (VerifyPasswordSimple(password, storedPasswordHash))
                        {
                            // Create user session
                            UserSession.LoginAdmin(
                                Convert.ToInt32(reader["AdminID"]),
                                reader["Username"].ToString(),
                                reader["FirstName"].ToString(),
                                reader["LastName"].ToString(),
                                reader["Email"].ToString(),
                                reader["Role"].ToString()
                            );

                            // Update last login
                            UpdateLastLogin("Admins", "AdminID", UserSession.UserId);

                            // Log successful login
                            LogLoginAttempt(username, "Admin", true, "Login successful");

                            // Show success message
                            string fullName = UserSession.GetFullName();
                            ShowMessage($"Login successful! Welcome {fullName}", false);

                            // Small delay to show success message
                            Application.DoEvents();
                            System.Threading.Thread.Sleep(500);

                            // Open AdminDashboard
                            AdminDashboard adminDashboard = new AdminDashboard();
                            adminDashboard.Show();
                            this.Hide();
                        }
                        else
                        {
                            ShowMessage("Invalid password", true);
                            LogLoginAttempt(username, "Admin", false, "Invalid password");
                            ClearPasswordField();
                        }
                    }
                    else
                    {
                        ShowMessage($"Admin '{username}' not found", true);
                        LogLoginAttempt(username, "Admin", false, "User not found");
                        ClearPasswordField();
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Admin login error: {ex.Message}", true);
                LogLoginAttempt(username, "Admin", false, $"System error: {ex.Message}");
            }
        }

        private void AuthenticateCustomer(string username, string password)
        {
            try
            {
                string query = @"
                    SELECT CustomerID, CustomerNumber, Password, FirstName, LastName, Email, IsActive 
                    FROM Customers 
                    WHERE (CustomerNumber = @Username OR Email = @Username) AND IsDeleted = 0";

                SqlParameter[] parameters = {
                    new SqlParameter("@Username", username)
                };

                using (SqlDataReader reader = DatabaseConnection.ExecuteReader(query, parameters))
                {
                    if (reader != null && reader.Read())
                    {
                        bool isActive = Convert.ToBoolean(reader["IsActive"]);
                        if (!isActive)
                        {
                            ShowMessage("Customer account is deactivated", true);
                            return;
                        }

                        byte[] storedPasswordHash = (byte[])reader["Password"];

                        // Replace the customer authentication success section in LoginForm.cs with this:

                        if (VerifyPasswordSimple(password, storedPasswordHash))
                        {
                            // Create user session
                            UserSession.LoginCustomer(
                                Convert.ToInt32(reader["CustomerID"]),
                                reader["CustomerNumber"].ToString(),
                                reader["FirstName"].ToString(),
                                reader["LastName"].ToString(),
                                reader["Email"].ToString()
                            );

                            // Update last login
                            UpdateLastLogin("Customers", "CustomerID", UserSession.UserId);

                            // Log successful login
                            LogLoginAttempt(username, "Customer", true, "Login successful");

                            string fullName = UserSession.GetFullName();
                            ShowMessage($"Login successful! Welcome {fullName}", false);

                            // Small delay to show success message
                            Application.DoEvents();
                            System.Threading.Thread.Sleep(500);

                            // Open CustomerDashboard
                            CustomerDashboard customerDashboard = new CustomerDashboard();
                            customerDashboard.Show();
                            this.Hide();
                        }
                        else
                        {
                            ShowMessage("Invalid password", true);
                            LogLoginAttempt(username, "Customer", false, "Invalid password");
                            ClearPasswordField();
                        }
                    }
                    else
                    {
                        ShowMessage($"Customer '{username}' not found", true);
                        LogLoginAttempt(username, "Customer", false, "User not found");
                        ClearPasswordField();
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Customer login error: {ex.Message}", true);
                LogLoginAttempt(username, "Customer", false, $"System error: {ex.Message}");
            }
        }

        /// <summary>
        /// Verify password using SHA-256 with secret key approach
        /// </summary>
        private bool VerifyPasswordSimple(string inputPassword, byte[] storedHash)
        {
            try
            {
                // Create hash same way as database: SHA-256(password + secret)
                string passwordWithSecret = inputPassword + SECRET_KEY;

                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] computedHash = sha256.ComputeHash(Encoding.UTF8.GetBytes(passwordWithSecret));

                    // Compare hashes byte by byte
                    if (computedHash.Length != storedHash.Length)
                        return false;

                    for (int i = 0; i < computedHash.Length; i++)
                    {
                        if (computedHash[i] != storedHash[i])
                            return false;
                    }

                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void UpdateLastLogin(string tableName, string idColumn, int userId)
        {
            try
            {
                string query = $"UPDATE {tableName} SET LastLogin = @LastLogin, ModifiedDate = @ModifiedDate WHERE {idColumn} = @UserId";
                SqlParameter[] parameters = {
                    new SqlParameter("@LastLogin", DateTime.Now),
                    new SqlParameter("@ModifiedDate", DateTime.Now),
                    new SqlParameter("@UserId", userId)
                };

                DatabaseConnection.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                // Log error but don't show to user (non-critical)
                Console.WriteLine($"Failed to update last login: {ex.Message}");
            }
        }

        private void LogLoginAttempt(string username, string userType, bool success, string details)
        {
            try
            {
                string query = @"
                    INSERT INTO SystemLogs (LogType, UserType, UserID, Action, Details, LogDate, IPAddress)
                    VALUES (@LogType, @UserType, @UserID, @Action, @Details, @LogDate, @IPAddress)";

                SqlParameter[] parameters = {
                    new SqlParameter("@LogType", success ? "Login_Success" : "Login_Failed"),
                    new SqlParameter("@UserType", userType),
                    new SqlParameter("@UserID", success ? UserSession.UserId : 0),
                    new SqlParameter("@Action", $"Login attempt for {username}"),
                    new SqlParameter("@Details", details),
                    new SqlParameter("@LogDate", DateTime.Now),
                    new SqlParameter("@IPAddress", "127.0.0.1")
                };

                DatabaseConnection.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                // Log error but don't show to user (non-critical)
                Console.WriteLine($"Failed to log login attempt: {ex.Message}");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit the application?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void rbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAdmin.Checked)
            {
                // Provide helpful hint for admin login
                ShowMessage("Admin Login Selected - Use admin/admin123", false);
            }
        }

        private void rbCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCustomer.Checked)
            {
                // Provide helpful hint for customer login
                ShowMessage("Customer Login Selected - Use CUST001/customer123", false);
            }
        }

        private void ShowMessage(string message, bool isError)
        {
            try
            {
                if (lblStatus != null)
                {
                    lblStatus.Text = message;
                    lblStatus.ForeColor = isError ? System.Drawing.Color.Red : System.Drawing.Color.Green;

                    // Auto-clear error messages after 5 seconds
                    if (isError && !string.IsNullOrEmpty(message))
                    {
                        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                        timer.Interval = 5000;
                        timer.Tick += (s, e) => {
                            if (lblStatus.ForeColor == System.Drawing.Color.Red)
                            {
                                lblStatus.Text = "Ready to login";
                                lblStatus.ForeColor = System.Drawing.Color.Black;
                            }
                            timer.Stop();
                            timer.Dispose();
                        };
                        timer.Start();
                    }
                }
            }
            catch
            {
                // Fallback to MessageBox if label doesn't exist
                if (!string.IsNullOrEmpty(message))
                {
                    MessageBox.Show(message, isError ? "Error" : "Status",
                                   MessageBoxButtons.OK,
                                   isError ? MessageBoxIcon.Error : MessageBoxIcon.Information);
                }
            }
        }

        private void ClearForm()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            rbCustomer.Checked = true;
            ShowMessage("Ready to login", false);
            txtUsername.Focus();
        }

        private void ClearPasswordField()
        {
            txtPassword.Clear();
            txtPassword.Focus();
        }

        // Handle form closing to ensure proper cleanup
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Clear any user session when form is closing
            UserSession.Logout();
        }

        // Handle when login form is shown again (e.g., after logout)
        private void LoginForm_Activated(object sender, EventArgs e)
        {
            // Clear session and reset form when activated
            UserSession.Logout();
            ClearForm();
        }
    }
}