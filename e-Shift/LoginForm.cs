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
            txtUsername.Focus();

            if (!DatabaseConnection.TestConnection())
            {
                ShowMessage("Database connection failed!", true);
                btnLogin.Enabled = false;
            }
            else
            {
                ShowMessage("Ready to login", false);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            bool isAdmin = rbAdmin.Checked;

            ShowMessage("", false);

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

            btnLogin.Enabled = false;
            btnLogin.Text = "Authenticating...";

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
            finally
            {
                btnLogin.Enabled = true;
                btnLogin.Text = "Login";
            }
        }

        private void AuthenticateAdmin(string username, string password)
        {
            try
            {
                // Note: We don't need Salt column anymore, just Password
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

                        // SIMPLE SECURE PASSWORD VERIFICATION
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

                            string fullName = UserSession.GetFullName();
                            ShowMessage($"Login successful! Welcome {fullName}", false);

                            MessageBox.Show($"✅ Admin Login Successful!\n\n" +
                                          $"Welcome: {fullName}\n" +
                                          $"Role: {UserSession.Role}\n" +
                                          $"Username: {UserSession.Username}\n" +
                                          $"Login Time: {UserSession.LoginTime:HH:mm:ss}",
                                          "Admin Dashboard",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Information);

                            // TODO: Open AdminDashboard form
                            // AdminDashboard adminDashboard = new AdminDashboard();
                            // adminDashboard.Show();
                            // this.Hide();

                            ClearForm();
                        }
                        else
                        {
                            ShowMessage("Invalid password", true);
                            LogLoginAttempt(username, "Admin", false, "Invalid password");
                        }
                    }
                    else
                    {
                        ShowMessage($"Admin '{username}' not found", true);
                        LogLoginAttempt(username, "Admin", false, "User not found");
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Login error: {ex.Message}", true);
                LogLoginAttempt(username, "Admin", false, $"System error: {ex.Message}");
            }
        }

        private void AuthenticateCustomer(string username, string password)
        {
            try
            {
                // Note: We don't need Salt column anymore, just Password
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

                        // SIMPLE SECURE PASSWORD VERIFICATION
                        byte[] storedPasswordHash = (byte[])reader["Password"];

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

                            string fullName = UserSession.GetFullName();
                            ShowMessage($"Login successful! Welcome {fullName}", false);

                            MessageBox.Show($"✅ Customer Login Successful!\n\n" +
                                          $"Welcome: {fullName}\n" +
                                          $"Customer Number: {UserSession.Username}\n" +
                                          $"Login Time: {UserSession.LoginTime:HH:mm:ss}",
                                          "Customer Dashboard",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Information);

                            // TODO: Open CustomerDashboard form
                            // CustomerDashboard customerDashboard = new CustomerDashboard();
                            // customerDashboard.Show();
                            // this.Hide();

                            ClearForm();
                        }
                        else
                        {
                            ShowMessage("Invalid password", true);
                            LogLoginAttempt(username, "Customer", false, "Invalid password");
                        }
                    }
                    else
                    {
                        ShowMessage($"Customer '{username}' not found", true);
                        LogLoginAttempt(username, "Customer", false, "User not found");
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Login error: {ex.Message}", true);
                LogLoginAttempt(username, "Customer", false, $"System error: {ex.Message}");
            }
        }

        /// <summary>
        /// Simple but secure password verification using SHA-256 with secret key
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
                Console.WriteLine($"Failed to log login attempt: {ex.Message}");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {
            // Optional: Show detailed status
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

        private void ShowMessage(string message, bool isError)
        {
            try
            {
                if (lblStatus != null)
                {
                    lblStatus.Text = message;
                    lblStatus.ForeColor = isError ? System.Drawing.Color.Red : System.Drawing.Color.Green;
                }
            }
            catch
            {
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
            ShowMessage("", false);
            txtUsername.Focus();
        }
    }
}