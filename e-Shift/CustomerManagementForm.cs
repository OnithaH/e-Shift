using e_Shift.Database;
using e_Shift.Utils;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace e_Shift
{
    public partial class CustomerManagementForm : Form
    {
        #region Private Fields
        private int selectedCustomerId = -1;
        private bool isEditing = false;
        private bool isAddingNew = false;
        #endregion

        #region Form States
        private enum FormState
        {
            Viewing,
            Adding,
            Editing
        }
        #endregion

        #region Constructor and Initialization
        public CustomerManagementForm()
        {
            InitializeComponent();
            CheckAdminAccess();
            SetFormState(FormState.Viewing);
        }

        private void CheckAdminAccess()
        {
            if (!UserSession.IsLoggedIn || !UserSession.IsAdmin())
            {
                MessageBox.Show("Access denied! Admin privileges required.",
                              "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }
        #endregion

        #region Data Loading Methods
        private void LoadCustomers(string searchTerm = "", string statusFilter = "All")
        {
            try
            {
                string query = @"
                    SELECT 
                        CustomerID, CustomerNumber, FirstName, LastName, Email, Phone, 
                        City, RegistrationDate, IsActive, LastLogin
                    FROM Customers 
                    WHERE IsDeleted = 0";

                // Add search filter
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    query += @" AND (FirstName LIKE @SearchTerm OR LastName LIKE @SearchTerm 
                               OR CustomerNumber LIKE @SearchTerm OR Email LIKE @SearchTerm)";
                }

                // Add status filter
                if (statusFilter == "Active")
                    query += " AND IsActive = 1";
                else if (statusFilter == "Inactive")
                    query += " AND IsActive = 0";

                query += " ORDER BY CustomerNumber";

                SqlParameter[] parameters = string.IsNullOrEmpty(searchTerm) ? null : new SqlParameter[]
                {
                    new SqlParameter("@SearchTerm", $"%{searchTerm}%")
                };

                DataTable customerData = DatabaseConnection.FillDataTable(query, parameters);

                if (customerData != null)
                {
                    dataGridViewCustomers.DataSource = customerData;
                    FormatCustomerGrid();
                }

                UpdateCustomerCount();
            }
            catch (Exception ex)
            {
                ShowMessage($"Error loading customers: {ex.Message}", true);
            }
        }

        private void FormatCustomerGrid()
        {
            if (dataGridViewCustomers == null) return;

            if (dataGridViewCustomers.Columns.Count > 0)
            {
                dataGridViewCustomers.Columns["CustomerID"].Visible = false;
                dataGridViewCustomers.Columns["CustomerNumber"].HeaderText = "Customer #";
                dataGridViewCustomers.Columns["CustomerNumber"].Width = 100;
                dataGridViewCustomers.Columns["FirstName"].HeaderText = "First Name";
                dataGridViewCustomers.Columns["FirstName"].Width = 120;
                dataGridViewCustomers.Columns["LastName"].HeaderText = "Last Name";
                dataGridViewCustomers.Columns["LastName"].Width = 120;
                dataGridViewCustomers.Columns["Email"].Width = 200;
                dataGridViewCustomers.Columns["Phone"].Width = 120;
                dataGridViewCustomers.Columns["City"].Width = 100;
                dataGridViewCustomers.Columns["RegistrationDate"].HeaderText = "Registered";
                dataGridViewCustomers.Columns["RegistrationDate"].Width = 100;
                dataGridViewCustomers.Columns["IsActive"].HeaderText = "Active";
                dataGridViewCustomers.Columns["IsActive"].Width = 60;
                dataGridViewCustomers.Columns["LastLogin"].HeaderText = "Last Login";
                dataGridViewCustomers.Columns["LastLogin"].Width = 130;

                // Format date columns
                dataGridViewCustomers.Columns["RegistrationDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridViewCustomers.Columns["LastLogin"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }
        }

        private void UpdateCustomerCount()
        {
            int totalCount = dataGridViewCustomers.Rows.Count;
            lblStatus.Text = $"Total Customers: {totalCount}";
        }
        #endregion

        #region Form State Management
        private void SetFormState(FormState state)
        {
            switch (state)
            {
                case FormState.Viewing:
                    isEditing = false;
                    isAddingNew = false;
                    EnableFormControls(false);
                    btnAddNew.Enabled = true;
                    btnEdit.Enabled = selectedCustomerId != -1;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnDelete.Enabled = selectedCustomerId != -1;
                    btnActivateDeactivate.Enabled = selectedCustomerId != -1;
                    dataGridViewCustomers.Enabled = true;
                    break;

                case FormState.Adding:
                    isAddingNew = true;
                    isEditing = false;
                    EnableFormControls(true);
                    ClearCustomerDetails();
                    btnAddNew.Enabled = false;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnDelete.Enabled = false;
                    btnActivateDeactivate.Enabled = false;
                    dataGridViewCustomers.Enabled = false;
                    txtFirstName.Focus();
                    break;

                case FormState.Editing:
                    isEditing = true;
                    isAddingNew = false;
                    EnableFormControls(true);
                    btnAddNew.Enabled = false;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnDelete.Enabled = false;
                    btnActivateDeactivate.Enabled = false;
                    dataGridViewCustomers.Enabled = false;
                    txtFirstName.Focus();
                    break;
            }
        }

        private void EnableFormControls(bool enabled)
        {
            txtFirstName.Enabled = enabled;
            txtLastName.Enabled = enabled;
            txtEmail.Enabled = enabled;
            txtPhone.Enabled = enabled;
            txtAddress.Enabled = enabled;
            txtCity.Enabled = enabled;
            txtPostalCode.Enabled = enabled;
            chkIsActive.Enabled = enabled;
        }
        #endregion

        #region Customer Details Management
        private void LoadCustomerDetails(DataGridViewRow row)
        {
            try
            {
                selectedCustomerId = Convert.ToInt32(row.Cells["CustomerID"].Value);

                txtCustomerNumber.Text = row.Cells["CustomerNumber"].Value?.ToString() ?? "";
                txtFirstName.Text = row.Cells["FirstName"].Value?.ToString() ?? "";
                txtLastName.Text = row.Cells["LastName"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
                txtPhone.Text = row.Cells["Phone"].Value?.ToString() ?? "";

                // Load additional details
                LoadAdditionalCustomerDetails(selectedCustomerId);

                chkIsActive.Checked = Convert.ToBoolean(row.Cells["IsActive"].Value);

                UpdateActivateDeactivateButton();
                SetFormState(FormState.Viewing);
            }
            catch (Exception ex)
            {
                ShowMessage($"Error loading customer details: {ex.Message}", true);
            }
        }

        private void LoadAdditionalCustomerDetails(int customerId)
        {
            try
            {
                string query = @"SELECT Address, City, PostalCode FROM Customers WHERE CustomerID = @CustomerID";
                SqlParameter[] parameters = { new SqlParameter("@CustomerID", customerId) };

                using (SqlDataReader reader = DatabaseConnection.ExecuteReader(query, parameters))
                {
                    if (reader != null && reader.Read())
                    {
                        txtAddress.Text = reader["Address"]?.ToString() ?? "";
                        txtCity.Text = reader["City"]?.ToString() ?? "";
                        txtPostalCode.Text = reader["PostalCode"]?.ToString() ?? "";
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error loading additional details: {ex.Message}", true);
            }
        }

        private void ClearCustomerDetails()
        {
            selectedCustomerId = -1;
            txtCustomerNumber.Text = "Auto-generated";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtPostalCode.Text = "";
            chkIsActive.Checked = true;
        }

        private void UpdateActivateDeactivateButton()
        {
            if (selectedCustomerId != -1)
            {
                bool isActive = chkIsActive.Checked;
                btnActivateDeactivate.Text = isActive ? "🔒 Deactivate" : "✅ Activate";
                btnActivateDeactivate.BackColor = isActive ? Color.LightCoral : Color.LightGreen;
            }
        }
        #endregion

        #region Validation
        private bool ValidateCustomerData()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                ShowMessage("First name is required", true);
                txtFirstName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                ShowMessage("Last name is required", true);
                txtLastName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                ShowMessage("Email is required", true);
                txtEmail.Focus();
                return false;
            }

            if (!IsValidEmail(txtEmail.Text))
            {
                ShowMessage("Please enter a valid email address", true);
                txtEmail.Focus();
                return false;
            }

            // Check for duplicate email (excluding current customer in edit mode)
            if (IsEmailDuplicate(txtEmail.Text, isEditing ? selectedCustomerId : -1))
            {
                ShowMessage("Email already exists for another customer", true);
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsEmailDuplicate(string email, int excludeCustomerId)
        {
            try
            {
                string query = @"SELECT COUNT(*) FROM Customers 
                               WHERE Email = @Email AND IsDeleted = 0";

                if (excludeCustomerId != -1)
                    query += " AND CustomerID != @CustomerID";

                SqlParameter[] parameters = excludeCustomerId != -1 ?
                    new SqlParameter[] {
                        new SqlParameter("@Email", email),
                        new SqlParameter("@CustomerID", excludeCustomerId)
                    } :
                    new SqlParameter[] { new SqlParameter("@Email", email) };

                object result = DatabaseConnection.ExecuteScalar(query, parameters);
                return Convert.ToInt32(result) > 0;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region CRUD Operations
        private bool AddCustomer()
        {
            try
            {
                string query = @"
                    INSERT INTO Customers (FirstName, LastName, Email, Phone, Address, City, PostalCode, 
                                         IsActive, Password, CreatedDate, ModifiedDate)
                    VALUES (@FirstName, @LastName, @Email, @Phone, @Address, @City, @PostalCode, 
                           @IsActive, @Password, @CreatedDate, @ModifiedDate)";

                // Generate default password for new customers
                string defaultPassword = "customer123";
                byte[] passwordHash = PasswordUtils.HashPassword(defaultPassword);

                SqlParameter[] parameters = {
                    new SqlParameter("@FirstName", txtFirstName.Text.Trim()),
                    new SqlParameter("@LastName", txtLastName.Text.Trim()),
                    new SqlParameter("@Email", txtEmail.Text.Trim()),
                    new SqlParameter("@Phone", string.IsNullOrEmpty(txtPhone.Text) ? (object)DBNull.Value : txtPhone.Text.Trim()),
                    new SqlParameter("@Address", string.IsNullOrEmpty(txtAddress.Text) ? (object)DBNull.Value : txtAddress.Text.Trim()),
                    new SqlParameter("@City", string.IsNullOrEmpty(txtCity.Text) ? (object)DBNull.Value : txtCity.Text.Trim()),
                    new SqlParameter("@PostalCode", string.IsNullOrEmpty(txtPostalCode.Text) ? (object)DBNull.Value : txtPostalCode.Text.Trim()),
                    new SqlParameter("@IsActive", chkIsActive.Checked),
                    new SqlParameter("@Password", passwordHash),
                    new SqlParameter("@CreatedDate", DateTime.Now),
                    new SqlParameter("@ModifiedDate", DateTime.Now)
                };

                int result = DatabaseConnection.ExecuteNonQuery(query, parameters);

                if (result > 0)
                {
                    LogCustomerAction("Customer_Added", $"Added customer: {txtFirstName.Text} {txtLastName.Text}");
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                ShowMessage($"Error adding customer: {ex.Message}", true);
                return false;
            }
        }

        private bool UpdateCustomer()
        {
            try
            {
                string query = @"
                    UPDATE Customers SET
                        FirstName = @FirstName,
                        LastName = @LastName,
                        Email = @Email,
                        Phone = @Phone,
                        Address = @Address,
                        City = @City,
                        PostalCode = @PostalCode,
                        IsActive = @IsActive,
                        ModifiedDate = @ModifiedDate
                    WHERE CustomerID = @CustomerID";

                SqlParameter[] parameters = {
                    new SqlParameter("@CustomerID", selectedCustomerId),
                    new SqlParameter("@FirstName", txtFirstName.Text.Trim()),
                    new SqlParameter("@LastName", txtLastName.Text.Trim()),
                    new SqlParameter("@Email", txtEmail.Text.Trim()),
                    new SqlParameter("@Phone", string.IsNullOrEmpty(txtPhone.Text) ? (object)DBNull.Value : txtPhone.Text.Trim()),
                    new SqlParameter("@Address", string.IsNullOrEmpty(txtAddress.Text) ? (object)DBNull.Value : txtAddress.Text.Trim()),
                    new SqlParameter("@City", string.IsNullOrEmpty(txtCity.Text) ? (object)DBNull.Value : txtCity.Text.Trim()),
                    new SqlParameter("@PostalCode", string.IsNullOrEmpty(txtPostalCode.Text) ? (object)DBNull.Value : txtPostalCode.Text.Trim()),
                    new SqlParameter("@IsActive", chkIsActive.Checked),
                    new SqlParameter("@ModifiedDate", DateTime.Now)
                };

                int result = DatabaseConnection.ExecuteNonQuery(query, parameters);

                if (result > 0)
                {
                    LogCustomerAction("Customer_Updated", $"Updated customer: {txtFirstName.Text} {txtLastName.Text}");
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                ShowMessage($"Error updating customer: {ex.Message}", true);
                return false;
            }
        }

        private bool DeleteCustomer()
        {
            try
            {
                // Soft delete
                string query = @"
                    UPDATE Customers SET
                        IsDeleted = 1,
                        ModifiedDate = @ModifiedDate
                    WHERE CustomerID = @CustomerID";

                SqlParameter[] parameters = {
                    new SqlParameter("@CustomerID", selectedCustomerId),
                    new SqlParameter("@ModifiedDate", DateTime.Now)
                };

                int result = DatabaseConnection.ExecuteNonQuery(query, parameters);

                if (result > 0)
                {
                    LogCustomerAction("Customer_Deleted", $"Deleted customer: {txtFirstName.Text} {txtLastName.Text}");
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                ShowMessage($"Error deleting customer: {ex.Message}", true);
                return false;
            }
        }

        private bool ToggleCustomerStatus()
        {
            try
            {
                bool newStatus = !chkIsActive.Checked;
                string query = @"
                    UPDATE Customers SET
                        IsActive = @IsActive,
                        ModifiedDate = @ModifiedDate
                    WHERE CustomerID = @CustomerID";

                SqlParameter[] parameters = {
                    new SqlParameter("@CustomerID", selectedCustomerId),
                    new SqlParameter("@IsActive", newStatus),
                    new SqlParameter("@ModifiedDate", DateTime.Now)
                };

                int result = DatabaseConnection.ExecuteNonQuery(query, parameters);

                if (result > 0)
                {
                    string action = newStatus ? "activated" : "deactivated";
                    LogCustomerAction("Customer_StatusChanged", $"Customer {action}: {txtFirstName.Text} {txtLastName.Text}");
                    chkIsActive.Checked = newStatus;
                    UpdateActivateDeactivateButton();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                ShowMessage($"Error changing customer status: {ex.Message}", true);
                return false;
            }
        }
        #endregion

        #region Event Handlers
        private void CustomerManagementForm_Load(object sender, EventArgs e)
        {
            comboBoxStatusFilter.SelectedIndex = 0; // Select "All"
            LoadCustomers();
        }

        private void dataGridViewCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCustomers.SelectedRows.Count > 0 && !isAddingNew && !isEditing)
            {
                LoadCustomerDetails(dataGridViewCustomers.SelectedRows[0]);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            SetFormState(FormState.Adding);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedCustomerId == -1)
            {
                ShowMessage("Please select a customer to edit", true);
                return;
            }
            SetFormState(FormState.Editing);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateCustomerData())
                return;

            bool success = false;
            if (isAddingNew)
            {
                success = AddCustomer();
                if (success)
                    ShowMessage("Customer added successfully!", false);
            }
            else if (isEditing)
            {
                success = UpdateCustomer();
                if (success)
                    ShowMessage("Customer updated successfully!", false);
            }

            if (success)
            {
                LoadCustomers(txtSearch.Text, comboBoxStatusFilter.Text);
                SetFormState(FormState.Viewing);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (isAddingNew || isEditing)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to cancel? All unsaved changes will be lost.",
                    "Confirm Cancel",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    SetFormState(FormState.Viewing);
                    if (dataGridViewCustomers.SelectedRows.Count > 0)
                        LoadCustomerDetails(dataGridViewCustomers.SelectedRows[0]);
                    else
                        ClearCustomerDetails();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCustomerId == -1)
            {
                ShowMessage("Please select a customer to delete", true);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete customer '{txtFirstName.Text} {txtLastName.Text}'?\n\nThis action cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (DeleteCustomer())
                {
                    ShowMessage("Customer deleted successfully!", false);
                    LoadCustomers(txtSearch.Text, comboBoxStatusFilter.Text);
                    ClearCustomerDetails();
                    SetFormState(FormState.Viewing);
                }
            }
        }

        private void btnActivateDeactivate_Click(object sender, EventArgs e)
        {
            if (selectedCustomerId == -1)
            {
                ShowMessage("Please select a customer", true);
                return;
            }

            string action = chkIsActive.Checked ? "deactivate" : "activate";
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to {action} this customer?",
                $"Confirm {action.Substring(0, 1).ToUpper() + action.Substring(1)}",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (ToggleCustomerStatus())
                {
                    ShowMessage($"Customer {action}d successfully!", false);
                    LoadCustomers(txtSearch.Text, comboBoxStatusFilter.Text);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadCustomers(txtSearch.Text, comboBoxStatusFilter.Text);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            comboBoxStatusFilter.SelectedIndex = 0;
            LoadCustomers();
        }

        private void comboBoxStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCustomers(txtSearch.Text, comboBoxStatusFilter.Text);
        }

        private void chkIsActive_CheckedChanged(object sender, EventArgs e)
        {
            if (!isAddingNew && !isEditing)
                UpdateActivateDeactivateButton();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (isEditing || isAddingNew)
            {
                DialogResult result = MessageBox.Show(
                    "You have unsaved changes. Are you sure you want to close?",
                    "Unsaved Changes",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    return;
            }

            this.Close();
        }
        #endregion

        #region Helper Methods
        private void LogCustomerAction(string actionType, string details)
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
                    new SqlParameter("@Action", actionType),
                    new SqlParameter("@Details", details),
                    new SqlParameter("@LogDate", DateTime.Now),
                    new SqlParameter("@IPAddress", "127.0.0.1")
                };

                DatabaseConnection.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to log customer action: {ex.Message}");
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
        #endregion
    }
}