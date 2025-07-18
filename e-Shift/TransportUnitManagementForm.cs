using e_Shift.Database;
using e_Shift.Utils;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace e_Shift
{
    public partial class TransportUnitManagementForm : Form
    {
        private int selectedTransportUnitID = 0;
        private int selectedLorryID = 0;
        private int selectedDriverID = 0;
        private int selectedAssistantID = 0;
        private int selectedContainerID = 0;

        public TransportUnitManagementForm()
        {
            InitializeComponent();
            CheckAdminAccess();
        }

        private void CheckAdminAccess()
        {
            if (!UserSession.IsLoggedIn || !UserSession.IsAdmin())
            {
                MessageBox.Show("Access denied! Admin privileges required.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }

        private void TransportUnitManagementForm_Load(object sender, EventArgs e)
        {
            LoadAllData();
            SetupForm();
        }

        private void SetupForm()
        {
            this.WindowState = FormWindowState.Maximized;
            ClearAllForms();
        }

        private void LoadAllData()
        {
            LoadTransportUnits();
            LoadLorries();
            LoadDrivers();
            LoadAssistants();
            LoadContainers();
            LoadComboBoxData();
        }

        #region Transport Units Management
        private void LoadTransportUnits()
        {
            try
            {
                string query = @"
                    SELECT 
                        tu.TransportUnitID,
                        tu.UnitNumber,
                        tu.Status,
                        tu.IsAvailable,
                        l.RegistrationNumber as LorryReg,
                        CONCAT(d.FirstName, ' ', d.LastName) as DriverName,
                        CONCAT(a.FirstName, ' ', a.LastName) as AssistantName,
                        c.ContainerNumber
                    FROM TransportUnits tu
                    INNER JOIN Lorries l ON tu.LorryID = l.LorryID
                    INNER JOIN Drivers d ON tu.DriverID = d.DriverID
                    INNER JOIN Assistants a ON tu.AssistantID = a.AssistantID
                    INNER JOIN Containers c ON tu.ContainerID = c.ContainerID
                    WHERE tu.IsDeleted = 0
                    ORDER BY tu.UnitNumber";

                DataTable dataTable = DatabaseConnection.FillDataTable(query);
                if (dataTable != null)
                {
                    dgvTransportUnits.DataSource = dataTable;
                    FormatTransportUnitsGrid();
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error loading transport units: {ex.Message}", true);
            }
        }

        private void FormatTransportUnitsGrid()
        {
            if (dgvTransportUnits.Columns.Count > 0)
            {
                dgvTransportUnits.Columns["TransportUnitID"].Visible = false;
                dgvTransportUnits.Columns["UnitNumber"].HeaderText = "Unit Number";
                dgvTransportUnits.Columns["Status"].HeaderText = "Status";
                dgvTransportUnits.Columns["IsAvailable"].HeaderText = "Available";
                dgvTransportUnits.Columns["LorryReg"].HeaderText = "Lorry";
                dgvTransportUnits.Columns["DriverName"].HeaderText = "Driver";
                dgvTransportUnits.Columns["AssistantName"].HeaderText = "Assistant";
                dgvTransportUnits.Columns["ContainerNumber"].HeaderText = "Container";
            }
        }

        private void dgvTransportUnits_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTransportUnits.SelectedRows.Count > 0)
            {
                var row = dgvTransportUnits.SelectedRows[0];
                selectedTransportUnitID = Convert.ToInt32(row.Cells["TransportUnitID"].Value);
                LoadTransportUnitDetails(selectedTransportUnitID);
            }
        }

        private void LoadTransportUnitDetails(int transportUnitID)
        {
            try
            {
                string query = @"SELECT UnitNumber, Status, LorryID, DriverID, AssistantID, ContainerID, IsAvailable FROM TransportUnits WHERE TransportUnitID = @TransportUnitID";
                SqlParameter[] parameters = { new SqlParameter("@TransportUnitID", transportUnitID) };

                using (SqlDataReader reader = DatabaseConnection.ExecuteReader(query, parameters))
                {
                    if (reader != null && reader.Read())
                    {
                        txtUnitNumber.Text = reader["UnitNumber"].ToString();
                        cmbStatusTU.Text = reader["Status"].ToString();
                        if (reader["LorryID"] != DBNull.Value) cmbLorryTU.SelectedValue = Convert.ToInt32(reader["LorryID"]);
                        if (reader["DriverID"] != DBNull.Value) cmbDriverTU.SelectedValue = Convert.ToInt32(reader["DriverID"]);
                        if (reader["AssistantID"] != DBNull.Value) cmbAssistantTU.SelectedValue = Convert.ToInt32(reader["AssistantID"]);
                        if (reader["ContainerID"] != DBNull.Value) cmbContainerTU.SelectedValue = Convert.ToInt32(reader["ContainerID"]);
                        chkIsAvailableUnit.Checked = Convert.ToBoolean(reader["IsAvailable"]);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error loading transport unit details: {ex.Message}", true);
            }
        }

        private void btnCreateTransportUnit_Click(object sender, EventArgs e)
        {
            if (ValidateTransportUnitData())
            {
                try
                {
                    string query = @"INSERT INTO TransportUnits (UnitNumber, Status, LorryID, DriverID, AssistantID, ContainerID, IsAvailable) VALUES (@UnitNumber, @Status, @LorryID, @DriverID, @AssistantID, @ContainerID, @IsAvailable)";
                    SqlParameter[] parameters = {
                        new SqlParameter("@UnitNumber", txtUnitNumber.Text.Trim()),
                        new SqlParameter("@Status", cmbStatusTU.Text),
                        new SqlParameter("@LorryID", cmbLorryTU.SelectedValue),
                        new SqlParameter("@DriverID", cmbDriverTU.SelectedValue),
                        new SqlParameter("@AssistantID", cmbAssistantTU.SelectedValue),
                        new SqlParameter("@ContainerID", cmbContainerTU.SelectedValue),
                        new SqlParameter("@IsAvailable", chkIsAvailableUnit.Checked)
                    };

                    int result = DatabaseConnection.ExecuteNonQuery(query, parameters);
                    if (result > 0)
                    {
                        ShowMessage("Transport unit created successfully!", false);
                        LoadTransportUnits();
                        ClearTransportUnitForm();
                    }
                }
                catch (Exception ex)
                {
                    ShowMessage($"Error creating transport unit: {ex.Message}", true);
                }
            }
        }

        private void btnUpdateTransportUnit_Click(object sender, EventArgs e)
        {
            if (selectedTransportUnitID > 0 && ValidateTransportUnitData())
            {
                try
                {
                    string query = @"UPDATE TransportUnits SET UnitNumber = @UnitNumber, Status = @Status, LorryID = @LorryID, DriverID = @DriverID, AssistantID = @AssistantID, ContainerID = @ContainerID, IsAvailable = @IsAvailable, ModifiedDate = @ModifiedDate WHERE TransportUnitID = @TransportUnitID";
                    SqlParameter[] parameters = {
                        new SqlParameter("@UnitNumber", txtUnitNumber.Text.Trim()),
                        new SqlParameter("@Status", cmbStatusTU.Text),
                        new SqlParameter("@LorryID", cmbLorryTU.SelectedValue),
                        new SqlParameter("@DriverID", cmbDriverTU.SelectedValue),
                        new SqlParameter("@AssistantID", cmbAssistantTU.SelectedValue),
                        new SqlParameter("@ContainerID", cmbContainerTU.SelectedValue),
                        new SqlParameter("@IsAvailable", chkIsAvailableUnit.Checked),
                        new SqlParameter("@ModifiedDate", DateTime.Now),
                        new SqlParameter("@TransportUnitID", selectedTransportUnitID)
                    };

                    int result = DatabaseConnection.ExecuteNonQuery(query, parameters);
                    if (result > 0)
                    {
                        ShowMessage("Transport unit updated successfully!", false);
                        LoadTransportUnits();
                        LoadComboBoxData();
                    }
                }
                catch (Exception ex)
                {
                    ShowMessage($"Error updating transport unit: {ex.Message}", true);
                }
            }
        }

        private void btnDeleteTransportUnit_Click(object sender, EventArgs e)
        {
            if (selectedTransportUnitID > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this transport unit?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string query = @"UPDATE TransportUnits SET IsDeleted = 1, ModifiedDate = @ModifiedDate WHERE TransportUnitID = @TransportUnitID";
                        SqlParameter[] parameters = {
                            new SqlParameter("@ModifiedDate", DateTime.Now),
                            new SqlParameter("@TransportUnitID", selectedTransportUnitID)
                        };

                        int deleteResult = DatabaseConnection.ExecuteNonQuery(query, parameters);
                        if (deleteResult > 0)
                        {
                            ShowMessage("Transport unit deleted successfully!", false);
                            LoadTransportUnits();
                            LoadComboBoxData();
                            ClearTransportUnitForm();
                        }
                    }
                    catch (Exception ex)
                    {
                        ShowMessage($"Error deleting transport unit: {ex.Message}", true);
                    }
                }
            }
        }

        private bool ValidateTransportUnitData()
        {
            if (string.IsNullOrWhiteSpace(txtUnitNumber.Text)) { ShowMessage("Unit Number is required", true); txtUnitNumber.Focus(); return false; }
            if (cmbStatusTU.SelectedIndex == -1) { ShowMessage("Status is required", true); cmbStatusTU.Focus(); return false; }
            if (cmbLorryTU.SelectedValue == null) { ShowMessage("Lorry selection is required", true); cmbLorryTU.Focus(); return false; }
            if (cmbDriverTU.SelectedValue == null) { ShowMessage("Driver selection is required", true); cmbDriverTU.Focus(); return false; }
            if (cmbAssistantTU.SelectedValue == null) { ShowMessage("Assistant selection is required", true); cmbAssistantTU.Focus(); return false; }
            if (cmbContainerTU.SelectedValue == null) { ShowMessage("Container selection is required", true); cmbContainerTU.Focus(); return false; }
            return true;
        }

        private void ClearTransportUnitForm()
        {
            selectedTransportUnitID = 0;
            txtUnitNumber.Clear();
            cmbStatusTU.SelectedIndex = 0;
            cmbLorryTU.SelectedIndex = -1;
            cmbDriverTU.SelectedIndex = -1;
            cmbAssistantTU.SelectedIndex = -1;
            cmbContainerTU.SelectedIndex = -1;
            chkIsAvailableUnit.Checked = true;
        }
        #endregion

        #region Lorries Management
        private void LoadLorries()
        {
            try
            {
                string query = @"SELECT LorryID, RegistrationNumber, Make, Model, Year, LoadCapacity, VolumeCapacity, FuelType, Status, IsAvailable FROM Lorries WHERE IsDeleted = 0 ORDER BY RegistrationNumber";
                DataTable dataTable = DatabaseConnection.FillDataTable(query);
                if (dataTable != null)
                {
                    dgvLorries.DataSource = dataTable;
                    FormatLorriesGrid();
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error loading lorries: {ex.Message}", true);
            }
        }

        private void FormatLorriesGrid()
        {
            if (dgvLorries.Columns.Count > 0)
            {
                dgvLorries.Columns["LorryID"].Visible = false;
                dgvLorries.Columns["RegistrationNumber"].HeaderText = "Registration";
                dgvLorries.Columns["LoadCapacity"].HeaderText = "Load Cap.";
                dgvLorries.Columns["VolumeCapacity"].HeaderText = "Volume Cap.";
                dgvLorries.Columns["IsAvailable"].HeaderText = "Available";
            }
        }

        private void dgvLorries_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLorries.SelectedRows.Count > 0)
            {
                var row = dgvLorries.SelectedRows[0];
                selectedLorryID = Convert.ToInt32(row.Cells["LorryID"].Value);
                LoadLorryDetails(selectedLorryID);
            }
        }

        private void LoadLorryDetails(int lorryID)
        {
            try
            {
                string query = @"SELECT RegistrationNumber, Make, Model, Year, LoadCapacity, VolumeCapacity, FuelType, LastMaintenance, Status, IsAvailable FROM Lorries WHERE LorryID = @LorryID";
                SqlParameter[] parameters = { new SqlParameter("@LorryID", lorryID) };

                using (SqlDataReader reader = DatabaseConnection.ExecuteReader(query, parameters))
                {
                    if (reader != null && reader.Read())
                    {
                        txtRegistrationNumber.Text = reader["RegistrationNumber"].ToString();
                        txtMake.Text = reader["Make"].ToString();
                        txtModel.Text = reader["Model"].ToString();
                        numYear.Value = Convert.ToDecimal(reader["Year"]);
                        numLoadCapacity.Value = Convert.ToDecimal(reader["LoadCapacity"]);
                        numVolumeCapacity.Value = Convert.ToDecimal(reader["VolumeCapacity"]);
                        cmbFuelType.Text = reader["FuelType"].ToString();
                        if (reader["LastMaintenance"] != DBNull.Value) dtpLastMaintenance.Value = Convert.ToDateTime(reader["LastMaintenance"]);
                        else dtpLastMaintenance.Value = DateTime.Now;
                        cmbStatusLorry.Text = reader["Status"].ToString();
                        chkIsAvailableLorry.Checked = Convert.ToBoolean(reader["IsAvailable"]);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error loading lorry details: {ex.Message}", true);
            }
        }

        private void btnAddLorry_Click(object sender, EventArgs e)
        {
            if (ValidateLorryData())
            {
                try
                {
                    string query = @"INSERT INTO Lorries (RegistrationNumber, Make, Model, Year, LoadCapacity, VolumeCapacity, FuelType, LastMaintenance, Status, IsAvailable) VALUES (@RegistrationNumber, @Make, @Model, @Year, @LoadCapacity, @VolumeCapacity, @FuelType, @LastMaintenance, @Status, @IsAvailable)";
                    SqlParameter[] parameters = {
                        new SqlParameter("@RegistrationNumber", txtRegistrationNumber.Text.Trim()),
                        new SqlParameter("@Make", txtMake.Text.Trim()),
                        new SqlParameter("@Model", txtModel.Text.Trim()),
                        new SqlParameter("@Year", (int)numYear.Value),
                        new SqlParameter("@LoadCapacity", numLoadCapacity.Value),
                        new SqlParameter("@VolumeCapacity", numVolumeCapacity.Value),
                        new SqlParameter("@FuelType", cmbFuelType.Text),
                        new SqlParameter("@LastMaintenance", dtpLastMaintenance.Value),
                        new SqlParameter("@Status", cmbStatusLorry.Text),
                        new SqlParameter("@IsAvailable", chkIsAvailableLorry.Checked)
                    };

                    int result = DatabaseConnection.ExecuteNonQuery(query, parameters);
                    if (result > 0)
                    {
                        ShowMessage("Lorry added successfully!", false);
                        LoadLorries();
                        LoadComboBoxData();
                        ClearLorryForm();
                    }
                }
                catch (Exception ex)
                {
                    ShowMessage($"Error adding lorry: {ex.Message}", true);
                }
            }
        }

        private void btnUpdateLorry_Click(object sender, EventArgs e)
        {
            if (selectedLorryID > 0 && ValidateLorryData())
            {
                try
                {
                    string query = @"UPDATE Lorries SET RegistrationNumber = @RegistrationNumber, Make = @Make, Model = @Model, Year = @Year, LoadCapacity = @LoadCapacity, VolumeCapacity = @VolumeCapacity, FuelType = @FuelType, LastMaintenance = @LastMaintenance, Status = @Status, IsAvailable = @IsAvailable, ModifiedDate = @ModifiedDate WHERE LorryID = @LorryID";
                    SqlParameter[] parameters = {
                        new SqlParameter("@RegistrationNumber", txtRegistrationNumber.Text.Trim()),
                        new SqlParameter("@Make", txtMake.Text.Trim()),
                        new SqlParameter("@Model", txtModel.Text.Trim()),
                        new SqlParameter("@Year", (int)numYear.Value),
                        new SqlParameter("@LoadCapacity", numLoadCapacity.Value),
                        new SqlParameter("@VolumeCapacity", numVolumeCapacity.Value),
                        new SqlParameter("@FuelType", cmbFuelType.Text),
                        new SqlParameter("@LastMaintenance", dtpLastMaintenance.Value),
                        new SqlParameter("@Status", cmbStatusLorry.Text),
                        new SqlParameter("@IsAvailable", chkIsAvailableLorry.Checked),
                        new SqlParameter("@ModifiedDate", DateTime.Now),
                        new SqlParameter("@LorryID", selectedLorryID)
                    };

                    int result = DatabaseConnection.ExecuteNonQuery(query, parameters);
                    if (result > 0)
                    {
                        ShowMessage("Lorry updated successfully!", false);
                        LoadLorries();
                        LoadComboBoxData();
                    }
                }
                catch (Exception ex)
                {
                    ShowMessage($"Error updating lorry: {ex.Message}", true);
                }
            }
        }

        private void btnDeleteLorry_Click(object sender, EventArgs e)
        {
            if (selectedLorryID > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this lorry?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string query = @"UPDATE Lorries SET IsDeleted = 1, ModifiedDate = @ModifiedDate WHERE LorryID = @LorryID";
                        SqlParameter[] parameters = {
                            new SqlParameter("@ModifiedDate", DateTime.Now),
                            new SqlParameter("@LorryID", selectedLorryID)
                        };

                        int deleteResult = DatabaseConnection.ExecuteNonQuery(query, parameters);
                        if (deleteResult > 0)
                        {
                            ShowMessage("Lorry deleted successfully!", false);
                            LoadLorries();
                            LoadComboBoxData();
                            ClearLorryForm();
                        }
                    }
                    catch (Exception ex)
                    {
                        ShowMessage($"Error deleting lorry: {ex.Message}", true);
                    }
                }
            }
        }

        private bool ValidateLorryData()
        {
            if (string.IsNullOrWhiteSpace(txtRegistrationNumber.Text)) { ShowMessage("Registration Number is required", true); txtRegistrationNumber.Focus(); return false; }
            if (string.IsNullOrWhiteSpace(txtMake.Text)) { ShowMessage("Make is required", true); txtMake.Focus(); return false; }
            if (string.IsNullOrWhiteSpace(txtModel.Text)) { ShowMessage("Model is required", true); txtModel.Focus(); return false; }
            if (cmbFuelType.SelectedIndex == -1) { ShowMessage("Fuel Type is required", true); cmbFuelType.Focus(); return false; }
            if (cmbStatusLorry.SelectedIndex == -1) { ShowMessage("Status is required", true); cmbStatusLorry.Focus(); return false; }
            return true;
        }

        private void ClearLorryForm()
        {
            selectedLorryID = 0;
            txtRegistrationNumber.Clear();
            txtMake.Clear();
            txtModel.Clear();
            numYear.Value = 2020;
            numLoadCapacity.Value = 0;
            numVolumeCapacity.Value = 0;
            cmbFuelType.SelectedIndex = 0;
            dtpLastMaintenance.Value = DateTime.Now;
            cmbStatusLorry.SelectedIndex = 0;
            chkIsAvailableLorry.Checked = true;
        }
        #endregion

        #region Drivers Management
        private void LoadDrivers()
        {
            try
            {
                string query = @"SELECT DriverID, LicenseNumber, FirstName, LastName, Phone, Email, LicenseExpiry, LicenseClass, HourlyRate, IsAvailable FROM Drivers WHERE IsDeleted = 0 ORDER BY FirstName, LastName";
                DataTable dataTable = DatabaseConnection.FillDataTable(query);
                if (dataTable != null)
                {
                    dgvDrivers.DataSource = dataTable;
                    FormatDriversGrid();
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error loading drivers: {ex.Message}", true);
            }
        }

        private void FormatDriversGrid()
        {
            if (dgvDrivers.Columns.Count > 0)
            {
                dgvDrivers.Columns["DriverID"].Visible = false;
                dgvDrivers.Columns["LicenseNumber"].HeaderText = "License No.";
                dgvDrivers.Columns["FirstName"].HeaderText = "First Name";
                dgvDrivers.Columns["LastName"].HeaderText = "Last Name";
                dgvDrivers.Columns["LicenseExpiry"].HeaderText = "License Expiry";
                dgvDrivers.Columns["LicenseClass"].HeaderText = "Class";
                dgvDrivers.Columns["HourlyRate"].HeaderText = "Rate/Hour";
                dgvDrivers.Columns["IsAvailable"].HeaderText = "Available";
            }
        }

        private void dgvDrivers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDrivers.SelectedRows.Count > 0)
            {
                var row = dgvDrivers.SelectedRows[0];
                selectedDriverID = Convert.ToInt32(row.Cells["DriverID"].Value);
                LoadDriverDetails(selectedDriverID);
            }
        }

        private void LoadDriverDetails(int driverID)
        {
            try
            {
                string query = @"SELECT LicenseNumber, FirstName, LastName, Phone, Email, Address, LicenseExpiry, LicenseClass, HourlyRate, IsAvailable FROM Drivers WHERE DriverID = @DriverID";
                SqlParameter[] parameters = { new SqlParameter("@DriverID", driverID) };

                using (SqlDataReader reader = DatabaseConnection.ExecuteReader(query, parameters))
                {
                    if (reader != null && reader.Read())
                    {
                        txtLicenseNumber.Text = reader["LicenseNumber"].ToString();
                        txtFirstNameDriver.Text = reader["FirstName"].ToString();
                        txtLastNameDriver.Text = reader["LastName"].ToString();
                        txtPhoneDriver.Text = reader["Phone"].ToString();
                        txtEmailDriver.Text = reader["Email"].ToString();
                        txtAddressDriver.Text = reader["Address"].ToString();
                        dtpLicenseExpiry.Value = Convert.ToDateTime(reader["LicenseExpiry"]);
                        cmbLicenseClass.Text = reader["LicenseClass"].ToString();
                        numHourlyRateDriver.Value = Convert.ToDecimal(reader["HourlyRate"]);
                        chkIsAvailableDriver.Checked = Convert.ToBoolean(reader["IsAvailable"]);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error loading driver details: {ex.Message}", true);
            }
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            if (ValidateDriverData())
            {
                try
                {
                    string query = @"INSERT INTO Drivers (LicenseNumber, FirstName, LastName, Phone, Email, Address, LicenseExpiry, LicenseClass, HourlyRate, IsAvailable) VALUES (@LicenseNumber, @FirstName, @LastName, @Phone, @Email, @Address, @LicenseExpiry, @LicenseClass, @HourlyRate, @IsAvailable)";
                    SqlParameter[] parameters = {
                        new SqlParameter("@LicenseNumber", txtLicenseNumber.Text.Trim()),
                        new SqlParameter("@FirstName", txtFirstNameDriver.Text.Trim()),
                        new SqlParameter("@LastName", txtLastNameDriver.Text.Trim()),
                        new SqlParameter("@Phone", txtPhoneDriver.Text.Trim()),
                        new SqlParameter("@Email", txtEmailDriver.Text.Trim()),
                        new SqlParameter("@Address", txtAddressDriver.Text.Trim()),
                        new SqlParameter("@LicenseExpiry", dtpLicenseExpiry.Value),
                        new SqlParameter("@LicenseClass", cmbLicenseClass.Text),
                        new SqlParameter("@HourlyRate", numHourlyRateDriver.Value),
                        new SqlParameter("@IsAvailable", chkIsAvailableDriver.Checked)
                    };

                    int result = DatabaseConnection.ExecuteNonQuery(query, parameters);
                    if (result > 0)
                    {
                        ShowMessage("Driver added successfully!", false);
                        LoadDrivers();
                        LoadComboBoxData();
                        ClearDriverForm();
                    }
                }
                catch (Exception ex)
                {
                    ShowMessage($"Error adding driver: {ex.Message}", true);
                }
            }
        }

        private void btnUpdateDriver_Click(object sender, EventArgs e)
        {
            if (selectedDriverID > 0 && ValidateDriverData())
            {
                try
                {
                    string query = @"UPDATE Drivers SET LicenseNumber = @LicenseNumber, FirstName = @FirstName, LastName = @LastName, Phone = @Phone, Email = @Email, Address = @Address, LicenseExpiry = @LicenseExpiry, LicenseClass = @LicenseClass, HourlyRate = @HourlyRate, IsAvailable = @IsAvailable, ModifiedDate = @ModifiedDate WHERE DriverID = @DriverID";
                    SqlParameter[] parameters = {
                        new SqlParameter("@LicenseNumber", txtLicenseNumber.Text.Trim()),
                        new SqlParameter("@FirstName", txtFirstNameDriver.Text.Trim()),
                        new SqlParameter("@LastName", txtLastNameDriver.Text.Trim()),
                        new SqlParameter("@Phone", txtPhoneDriver.Text.Trim()),
                        new SqlParameter("@Email", txtEmailDriver.Text.Trim()),
                        new SqlParameter("@Address", txtAddressDriver.Text.Trim()),
                        new SqlParameter("@LicenseExpiry", dtpLicenseExpiry.Value),
                        new SqlParameter("@LicenseClass", cmbLicenseClass.Text),
                        new SqlParameter("@HourlyRate", numHourlyRateDriver.Value),
                        new SqlParameter("@IsAvailable", chkIsAvailableDriver.Checked),
                        new SqlParameter("@ModifiedDate", DateTime.Now),
                        new SqlParameter("@DriverID", selectedDriverID)
                    };

                    int result = DatabaseConnection.ExecuteNonQuery(query, parameters);
                    if (result > 0)
                    {
                        ShowMessage("Driver updated successfully!", false);
                        LoadDrivers();
                        LoadComboBoxData();
                    }
                }
                catch (Exception ex)
                {
                    ShowMessage($"Error updating driver: {ex.Message}", true);
                }
            }
        }

        private void btnDeleteDriver_Click(object sender, EventArgs e)
        {
            if (selectedDriverID > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this driver?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string query = @"UPDATE Drivers SET IsDeleted = 1, ModifiedDate = @ModifiedDate WHERE DriverID = @DriverID";
                        SqlParameter[] parameters = {
                            new SqlParameter("@ModifiedDate", DateTime.Now),
                            new SqlParameter("@DriverID", selectedDriverID)
                        };

                        int deleteResult = DatabaseConnection.ExecuteNonQuery(query, parameters);
                        if (deleteResult > 0)
                        {
                            ShowMessage("Driver deleted successfully!", false);
                            LoadDrivers();
                            LoadComboBoxData();
                            ClearDriverForm();
                        }
                    }
                    catch (Exception ex)
                    {
                        ShowMessage($"Error deleting driver: {ex.Message}", true);
                    }
                }
            }
        }

        private bool ValidateDriverData()
        {
            if (string.IsNullOrWhiteSpace(txtLicenseNumber.Text)) { ShowMessage("License Number is required", true); txtLicenseNumber.Focus(); return false; }
            if (string.IsNullOrWhiteSpace(txtFirstNameDriver.Text)) { ShowMessage("First Name is required", true); txtFirstNameDriver.Focus(); return false; }
            if (string.IsNullOrWhiteSpace(txtLastNameDriver.Text)) { ShowMessage("Last Name is required", true); txtLastNameDriver.Focus(); return false; }
            if (string.IsNullOrWhiteSpace(txtPhoneDriver.Text)) { ShowMessage("Phone is required", true); txtPhoneDriver.Focus(); return false; }
            if (cmbLicenseClass.SelectedIndex == -1) { ShowMessage("License Class is required", true); cmbLicenseClass.Focus(); return false; }
            return true;
        }

        private void ClearDriverForm()
        {
            selectedDriverID = 0;
            txtLicenseNumber.Clear();
            txtFirstNameDriver.Clear();
            txtLastNameDriver.Clear();
            txtPhoneDriver.Clear();
            txtEmailDriver.Clear();
            txtAddressDriver.Clear();
            dtpLicenseExpiry.Value = DateTime.Now.AddYears(1);
            cmbLicenseClass.SelectedIndex = -1;
            numHourlyRateDriver.Value = 0;
            chkIsAvailableDriver.Checked = true;
        }
        #endregion

        #region Assistants Management
        private void LoadAssistants()
        {
            try
            {
                string query = @"SELECT AssistantID, FirstName, LastName, Phone, Email, HireDate, HourlyRate, IsAvailable FROM Assistants WHERE IsDeleted = 0 ORDER BY FirstName, LastName";
                DataTable dataTable = DatabaseConnection.FillDataTable(query);
                if (dataTable != null)
                {
                    dgvAssistants.DataSource = dataTable;
                    FormatAssistantsGrid();
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error loading assistants: {ex.Message}", true);
            }
        }

        private void FormatAssistantsGrid()
        {
            if (dgvAssistants.Columns.Count > 0)
            {
                dgvAssistants.Columns["AssistantID"].Visible = false;
                dgvAssistants.Columns["FirstName"].HeaderText = "First Name";
                dgvAssistants.Columns["LastName"].HeaderText = "Last Name";
                dgvAssistants.Columns["HireDate"].HeaderText = "Hire Date";
                dgvAssistants.Columns["HourlyRate"].HeaderText = "Rate/Hour";
                dgvAssistants.Columns["IsAvailable"].HeaderText = "Available";
            }
        }

        private void dgvAssistants_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAssistants.SelectedRows.Count > 0)
            {
                var row = dgvAssistants.SelectedRows[0];
                selectedAssistantID = Convert.ToInt32(row.Cells["AssistantID"].Value);
                LoadAssistantDetails(selectedAssistantID);
            }
        }

        private void LoadAssistantDetails(int assistantID)
        {
            try
            {
                string query = @"SELECT FirstName, LastName, Phone, Email, Address, HireDate, HourlyRate, IsAvailable FROM Assistants WHERE AssistantID = @AssistantID";
                SqlParameter[] parameters = { new SqlParameter("@AssistantID", assistantID) };

                using (SqlDataReader reader = DatabaseConnection.ExecuteReader(query, parameters))
                {
                    if (reader != null && reader.Read())
                    {
                        txtFirstNameAssistant.Text = reader["FirstName"].ToString();
                        txtLastNameAssistant.Text = reader["LastName"].ToString();
                        txtPhoneAssistant.Text = reader["Phone"].ToString();
                        txtEmailAssistant.Text = reader["Email"].ToString();
                        txtAddressAssistant.Text = reader["Address"].ToString();
                        dtpHireDate.Value = Convert.ToDateTime(reader["HireDate"]);
                        numHourlyRateAssistant.Value = Convert.ToDecimal(reader["HourlyRate"]);
                        chkIsAvailableAssistant.Checked = Convert.ToBoolean(reader["IsAvailable"]);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error loading assistant details: {ex.Message}", true);
            }
        }

        private void btnAddAssistant_Click(object sender, EventArgs e)
        {
            if (ValidateAssistantData())
            {
                try
                {
                    string query = @"INSERT INTO Assistants (FirstName, LastName, Phone, Email, Address, HireDate, HourlyRate, IsAvailable) VALUES (@FirstName, @LastName, @Phone, @Email, @Address, @HireDate, @HourlyRate, @IsAvailable)";
                    SqlParameter[] parameters = {
                        new SqlParameter("@FirstName", txtFirstNameAssistant.Text.Trim()),
                        new SqlParameter("@LastName", txtLastNameAssistant.Text.Trim()),
                        new SqlParameter("@Phone", txtPhoneAssistant.Text.Trim()),
                        new SqlParameter("@Email", txtEmailAssistant.Text.Trim()),
                        new SqlParameter("@Address", txtAddressAssistant.Text.Trim()),
                        new SqlParameter("@HireDate", dtpHireDate.Value),
                        new SqlParameter("@HourlyRate", numHourlyRateAssistant.Value),
                        new SqlParameter("@IsAvailable", chkIsAvailableAssistant.Checked)
                    };

                    int result = DatabaseConnection.ExecuteNonQuery(query, parameters);
                    if (result > 0)
                    {
                        ShowMessage("Assistant added successfully!", false);
                        LoadAssistants();
                        LoadComboBoxData();
                        ClearAssistantForm();
                    }
                }
                catch (Exception ex)
                {
                    ShowMessage($"Error adding assistant: {ex.Message}", true);
                }
            }
        }

        private void btnUpdateAssistant_Click(object sender, EventArgs e)
        {
            if (selectedAssistantID > 0 && ValidateAssistantData())
            {
                try
                {
                    string query = @"UPDATE Assistants SET FirstName = @FirstName, LastName = @LastName, Phone = @Phone, Email = @Email, Address = @Address, HireDate = @HireDate, HourlyRate = @HourlyRate, IsAvailable = @IsAvailable, ModifiedDate = @ModifiedDate WHERE AssistantID = @AssistantID";
                    SqlParameter[] parameters = {
                        new SqlParameter("@FirstName", txtFirstNameAssistant.Text.Trim()),
                        new SqlParameter("@LastName", txtLastNameAssistant.Text.Trim()),
                        new SqlParameter("@Phone", txtPhoneAssistant.Text.Trim()),
                        new SqlParameter("@Email", txtEmailAssistant.Text.Trim()),
                        new SqlParameter("@Address", txtAddressAssistant.Text.Trim()),
                        new SqlParameter("@HireDate", dtpHireDate.Value),
                        new SqlParameter("@HourlyRate", numHourlyRateAssistant.Value),
                        new SqlParameter("@IsAvailable", chkIsAvailableAssistant.Checked),
                        new SqlParameter("@ModifiedDate", DateTime.Now),
                        new SqlParameter("@AssistantID", selectedAssistantID)
                    };

                    int result = DatabaseConnection.ExecuteNonQuery(query, parameters);
                    if (result > 0)
                    {
                        ShowMessage("Assistant updated successfully!", false);
                        LoadAssistants();
                        LoadComboBoxData();
                    }
                }
                catch (Exception ex)
                {
                    ShowMessage($"Error updating assistant: {ex.Message}", true);
                }
            }
        }

        private void btnDeleteAssistant_Click(object sender, EventArgs e)
        {
            if (selectedAssistantID > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this assistant?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string query = @"UPDATE Assistants SET IsDeleted = 1, ModifiedDate = @ModifiedDate WHERE AssistantID = @AssistantID";
                        SqlParameter[] parameters = {
                            new SqlParameter("@ModifiedDate", DateTime.Now),
                            new SqlParameter("@AssistantID", selectedAssistantID)
                        };

                        int deleteResult = DatabaseConnection.ExecuteNonQuery(query, parameters);
                        if (deleteResult > 0)
                        {
                            ShowMessage("Assistant deleted successfully!", false);
                            LoadAssistants();
                            LoadComboBoxData();
                            ClearAssistantForm();
                        }
                    }
                    catch (Exception ex)
                    {
                        ShowMessage($"Error deleting assistant: {ex.Message}", true);
                    }
                }
            }
        }

        private bool ValidateAssistantData()
        {
            if (string.IsNullOrWhiteSpace(txtFirstNameAssistant.Text)) { ShowMessage("First Name is required", true); txtFirstNameAssistant.Focus(); return false; }
            if (string.IsNullOrWhiteSpace(txtLastNameAssistant.Text)) { ShowMessage("Last Name is required", true); txtLastNameAssistant.Focus(); return false; }
            if (string.IsNullOrWhiteSpace(txtPhoneAssistant.Text)) { ShowMessage("Phone is required", true); txtPhoneAssistant.Focus(); return false; }
            return true;
        }

        private void ClearAssistantForm()
        {
            selectedAssistantID = 0;
            txtFirstNameAssistant.Clear();
            txtLastNameAssistant.Clear();
            txtPhoneAssistant.Clear();
            txtEmailAssistant.Clear();
            txtAddressAssistant.Clear();
            dtpHireDate.Value = DateTime.Now;
            numHourlyRateAssistant.Value = 0;
            chkIsAvailableAssistant.Checked = true;
        }
        #endregion

        #region Containers Management
        private void LoadContainers()
        {
            try
            {
                string query = @"SELECT ContainerID, ContainerNumber, Type, Capacity, Length, Width, Height, Material, Status, IsAvailable FROM Containers WHERE IsDeleted = 0 ORDER BY ContainerNumber";
                DataTable dataTable = DatabaseConnection.FillDataTable(query);
                if (dataTable != null)
                {
                    dgvContainers.DataSource = dataTable;
                    FormatContainersGrid();
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error loading containers: {ex.Message}", true);
            }
        }

        private void FormatContainersGrid()
        {
            if (dgvContainers.Columns.Count > 0)
            {
                dgvContainers.Columns["ContainerID"].Visible = false;
                dgvContainers.Columns["ContainerNumber"].HeaderText = "Container No.";
                dgvContainers.Columns["IsAvailable"].HeaderText = "Available";
            }
        }

        private void dgvContainers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvContainers.SelectedRows.Count > 0)
            {
                var row = dgvContainers.SelectedRows[0];
                selectedContainerID = Convert.ToInt32(row.Cells["ContainerID"].Value);
                LoadContainerDetails(selectedContainerID);
            }
        }

        private void LoadContainerDetails(int containerID)
        {
            try
            {
                string query = @"SELECT ContainerNumber, Type, Capacity, Length, Width, Height, Material, Status, IsAvailable FROM Containers WHERE ContainerID = @ContainerID";
                SqlParameter[] parameters = { new SqlParameter("@ContainerID", containerID) };

                using (SqlDataReader reader = DatabaseConnection.ExecuteReader(query, parameters))
                {
                    if (reader != null && reader.Read())
                    {
                        txtContainerNumber.Text = reader["ContainerNumber"].ToString();
                        cmbType.Text = reader["Type"].ToString();
                        numCapacity.Value = Convert.ToDecimal(reader["Capacity"]);
                        numLength.Value = Convert.ToDecimal(reader["Length"]);
                        numWidth.Value = Convert.ToDecimal(reader["Width"]);
                        numHeight.Value = Convert.ToDecimal(reader["Height"]);
                        cmbMaterial.Text = reader["Material"].ToString();
                        cmbStatusContainer.Text = reader["Status"].ToString();
                        chkIsAvailableContainer.Checked = Convert.ToBoolean(reader["IsAvailable"]);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error loading container details: {ex.Message}", true);
            }
        }

        private void btnAddContainer_Click(object sender, EventArgs e)
        {
            if (ValidateContainerData())
            {
                try
                {
                    string query = @"INSERT INTO Containers (ContainerNumber, Type, Capacity, Length, Width, Height, Material, Status, IsAvailable) VALUES (@ContainerNumber, @Type, @Capacity, @Length, @Width, @Height, @Material, @Status, @IsAvailable)";
                    SqlParameter[] parameters = {
                        new SqlParameter("@ContainerNumber", txtContainerNumber.Text.Trim()),
                        new SqlParameter("@Type", cmbType.Text),
                        new SqlParameter("@Capacity", numCapacity.Value),
                        new SqlParameter("@Length", numLength.Value),
                        new SqlParameter("@Width", numWidth.Value),
                        new SqlParameter("@Height", numHeight.Value),
                        new SqlParameter("@Material", cmbMaterial.Text),
                        new SqlParameter("@Status", cmbStatusContainer.Text),
                        new SqlParameter("@IsAvailable", chkIsAvailableContainer.Checked)
                    };

                    int result = DatabaseConnection.ExecuteNonQuery(query, parameters);
                    if (result > 0)
                    {
                        ShowMessage("Container added successfully!", false);
                        LoadContainers();
                        LoadComboBoxData();
                        ClearContainerForm();
                    }
                }
                catch (Exception ex)
                {
                    ShowMessage($"Error adding container: {ex.Message}", true);
                }
            }
        }

        private void btnUpdateContainer_Click(object sender, EventArgs e)
        {
            if (selectedContainerID > 0 && ValidateContainerData())
            {
                try
                {
                    string query = @"UPDATE Containers SET ContainerNumber = @ContainerNumber, Type = @Type, Capacity = @Capacity, Length = @Length, Width = @Width, Height = @Height, Material = @Material, Status = @Status, IsAvailable = @IsAvailable, ModifiedDate = @ModifiedDate WHERE ContainerID = @ContainerID";
                    SqlParameter[] parameters = {
                        new SqlParameter("@ContainerNumber", txtContainerNumber.Text.Trim()),
                        new SqlParameter("@Type", cmbType.Text),
                        new SqlParameter("@Capacity", numCapacity.Value),
                        new SqlParameter("@Length", numLength.Value),
                        new SqlParameter("@Width", numWidth.Value),
                        new SqlParameter("@Height", numHeight.Value),
                        new SqlParameter("@Material", cmbMaterial.Text),
                        new SqlParameter("@Status", cmbStatusContainer.Text),
                        new SqlParameter("@IsAvailable", chkIsAvailableContainer.Checked),
                        new SqlParameter("@ModifiedDate", DateTime.Now),
                        new SqlParameter("@ContainerID", selectedContainerID)
                    };

                    int result = DatabaseConnection.ExecuteNonQuery(query, parameters);
                    if (result > 0)
                    {
                        ShowMessage("Container updated successfully!", false);
                        LoadContainers();
                        LoadComboBoxData();
                    }
                }
                catch (Exception ex)
                {
                    ShowMessage($"Error updating container: {ex.Message}", true);
                }
            }
        }

        private void btnDeleteContainer_Click(object sender, EventArgs e)
        {
            if (selectedContainerID > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this container?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string query = @"UPDATE Containers SET IsDeleted = 1, ModifiedDate = @ModifiedDate WHERE ContainerID = @ContainerID";
                        SqlParameter[] parameters = {
                            new SqlParameter("@ModifiedDate", DateTime.Now),
                            new SqlParameter("@ContainerID", selectedContainerID)
                        };

                        int deleteResult = DatabaseConnection.ExecuteNonQuery(query, parameters);
                        if (deleteResult > 0)
                        {
                            ShowMessage("Container deleted successfully!", false);
                            LoadContainers();
                            LoadComboBoxData();
                            ClearContainerForm();
                        }
                    }
                    catch (Exception ex)
                    {
                        ShowMessage($"Error deleting container: {ex.Message}", true);
                    }
                }
            }
        }

        private bool ValidateContainerData()
        {
            if (string.IsNullOrWhiteSpace(txtContainerNumber.Text)) { ShowMessage("Container Number is required", true); txtContainerNumber.Focus(); return false; }
            if (cmbType.SelectedIndex == -1) { ShowMessage("Type is required", true); cmbType.Focus(); return false; }
            if (cmbMaterial.SelectedIndex == -1) { ShowMessage("Material is required", true); cmbMaterial.Focus(); return false; }
            if (cmbStatusContainer.SelectedIndex == -1) { ShowMessage("Status is required", true); cmbStatusContainer.Focus(); return false; }
            return true;
        }

        private void ClearContainerForm()
        {
            selectedContainerID = 0;
            txtContainerNumber.Clear();
            cmbType.SelectedIndex = -1;
            numCapacity.Value = 0;
            numLength.Value = 0;
            numWidth.Value = 0;
            numHeight.Value = 0;
            cmbMaterial.SelectedIndex = 0;
            cmbStatusContainer.SelectedIndex = 0;
            chkIsAvailableContainer.Checked = true;
        }
        #endregion

        #region Combo Box Data Loading
        private void LoadComboBoxData()
        {
            LoadLorriesComboBox();
            LoadDriversComboBox();
            LoadAssistantsComboBox();
            LoadContainersComboBox();
        }

        private void LoadLorriesComboBox()
        {
            try
            {
                string query = @"SELECT LorryID, CONCAT(RegistrationNumber, ' - ', Make, ' ', Model) as DisplayText FROM Lorries WHERE IsDeleted = 0 AND IsAvailable = 1 ORDER BY RegistrationNumber";
                DataTable dataTable = DatabaseConnection.FillDataTable(query);
                if (dataTable != null)
                {
                    cmbLorryTU.DataSource = dataTable;
                    cmbLorryTU.DisplayMember = "DisplayText";
                    cmbLorryTU.ValueMember = "LorryID";
                    cmbLorryTU.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error loading lorries combo box: {ex.Message}", true);
            }
        }

        private void LoadDriversComboBox()
        {
            try
            {
                string query = @"SELECT DriverID, CONCAT(FirstName, ' ', LastName, ' (', LicenseNumber, ')') as DisplayText FROM Drivers WHERE IsDeleted = 0 AND IsAvailable = 1 ORDER BY FirstName, LastName";
                DataTable dataTable = DatabaseConnection.FillDataTable(query);
                if (dataTable != null)
                {
                    cmbDriverTU.DataSource = dataTable;
                    cmbDriverTU.DisplayMember = "DisplayText";
                    cmbDriverTU.ValueMember = "DriverID";
                    cmbDriverTU.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error loading drivers combo box: {ex.Message}", true);
            }
        }

        private void LoadAssistantsComboBox()
        {
            try
            {
                string query = @"SELECT AssistantID, CONCAT(FirstName, ' ', LastName) as DisplayText FROM Assistants WHERE IsDeleted = 0 AND IsAvailable = 1 ORDER BY FirstName, LastName";
                DataTable dataTable = DatabaseConnection.FillDataTable(query);
                if (dataTable != null)
                {
                    cmbAssistantTU.DataSource = dataTable;
                    cmbAssistantTU.DisplayMember = "DisplayText";
                    cmbAssistantTU.ValueMember = "AssistantID";
                    cmbAssistantTU.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error loading assistants combo box: {ex.Message}", true);
            }
        }

        private void LoadContainersComboBox()
        {
            try
            {
                string query = @"SELECT ContainerID, CONCAT(ContainerNumber, ' - ', Type, ' (', Capacity, ' m³)') as DisplayText FROM Containers WHERE IsDeleted = 0 AND IsAvailable = 1 ORDER BY ContainerNumber";
                DataTable dataTable = DatabaseConnection.FillDataTable(query);
                if (dataTable != null)
                {
                    cmbContainerTU.DataSource = dataTable;
                    cmbContainerTU.DisplayMember = "DisplayText";
                    cmbContainerTU.ValueMember = "ContainerID";
                    cmbContainerTU.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error loading containers combo box: {ex.Message}", true);
            }
        }
        #endregion

        #region Form Events
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAllData();
            ShowMessage("Data refreshed successfully!", false);
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

        private void ClearAllForms()
        {
            ClearTransportUnitForm();
            ClearLorryForm();
            ClearDriverForm();
            ClearAssistantForm();
            ClearContainerForm();
        }
        #endregion

        // Add these missing event handler methods to your TransportUnitManagementForm.cs file

        #region DataGridView Cell Click Events

        private void dgvTransportUnits_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvTransportUnits.Rows[e.RowIndex];
                    selectedTransportUnitID = Convert.ToInt32(row.Cells["TransportUnitID"].Value);
                    LoadTransportUnitDetails(selectedTransportUnitID);
                }
                catch (Exception ex)
                {
                    ShowMessage($"Error selecting transport unit: {ex.Message}", true);
                }
            }
        }

        private void dgvLorries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvLorries.Rows[e.RowIndex];
                    selectedLorryID = Convert.ToInt32(row.Cells["LorryID"].Value);
                    LoadLorryDetails(selectedLorryID);
                }
                catch (Exception ex)
                {
                    ShowMessage($"Error selecting lorry: {ex.Message}", true);
                }
            }
        }

        private void dgvDrivers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvDrivers.Rows[e.RowIndex];
                    selectedDriverID = Convert.ToInt32(row.Cells["DriverID"].Value);
                    LoadDriverDetails(selectedDriverID);
                }
                catch (Exception ex)
                {
                    ShowMessage($"Error selecting driver: {ex.Message}", true);
                }
            }
        }

        private void dgvAssistants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvAssistants.Rows[e.RowIndex];
                    selectedAssistantID = Convert.ToInt32(row.Cells["AssistantID"].Value);
                    LoadAssistantDetails(selectedAssistantID);
                }
                catch (Exception ex)
                {
                    ShowMessage($"Error selecting assistant: {ex.Message}", true);
                }
            }
        }

        private void dgvContainers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvContainers.Rows[e.RowIndex];
                    selectedContainerID = Convert.ToInt32(row.Cells["ContainerID"].Value);
                    LoadContainerDetails(selectedContainerID);
                }
                catch (Exception ex)
                {
                    ShowMessage($"Error selecting container: {ex.Message}", true);
                }
            }
        }

        #endregion

        #region Form Events

        private void TransportUnitManagementForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadTransportUnits();
                LoadLorries();
                LoadDrivers();
                LoadAssistants();
                LoadContainers();
                LoadComboBoxData();
                ShowMessage("Transport Unit Management loaded successfully!", false);
            }
            catch (Exception ex)
            {
                ShowMessage($"Error loading assistant details: {ex.Message}", true);
            }
        }

        private void LoadContainerDetails(int containerID)
        {
            try
            {
                string query = "SELECT * FROM Containers WHERE ContainerID = @ContainerID AND IsDeleted = 0";
                SqlParameter[] parameters = { new SqlParameter("@ContainerID", containerID) };

                using (SqlDataReader reader = DatabaseConnection.ExecuteReader(query, parameters))
                {
                    if (reader.Read())
                    {
                        txtContainerNumber.Text = reader["ContainerNumber"].ToString();
                        cmbType.Text = reader["Type"].ToString();
                        numCapacity.Value = Convert.ToDecimal(reader["Capacity"]);
                        numLength.Value = Convert.ToDecimal(reader["Length"]);
                        numWidth.Value = Convert.ToDecimal(reader["Width"]);
                        numHeight.Value = Convert.ToDecimal(reader["Height"]);
                        cmbMaterial.Text = reader["Material"].ToString();
                        cmbStatusContainer.Text = reader["Status"].ToString();
                        chkIsAvailableContainer.Checked = Convert.ToBoolean(reader["IsAvailable"]);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error loading container details: {ex.Message}", true);
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                LoadTransportUnits();
                LoadLorries();
                LoadDrivers();
                LoadAssistants();
                LoadContainers();
                LoadComboBoxData();
                ShowMessage("Data refreshed successfully!", false);
            }
            catch (Exception ex)
            {
                ShowMessage($"Error refreshing data: {ex.Message}", true);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Lorry Events

        private void btnAddLorry_Click(object sender, EventArgs e)
        {
            if (ValidateLorryData())
            {
                try
                {
                    string query = @"INSERT INTO Lorries (RegistrationNumber, Make, Model, Year, LoadCapacity, VolumeCapacity, FuelType, LastMaintenanceDate, Status, IsAvailable) 
                           VALUES (@RegistrationNumber, @Make, @Model, @Year, @LoadCapacity, @VolumeCapacity, @FuelType, @LastMaintenanceDate, @Status, @IsAvailable)";

                    SqlParameter[] parameters = {
                new SqlParameter("@RegistrationNumber", txtRegistrationNumber.Text.Trim()),
                new SqlParameter("@Make", txtMake.Text.Trim()),
                new SqlParameter("@Model", txtModel.Text.Trim()),
                new SqlParameter("@Year", numYear.Value),
                new SqlParameter("@LoadCapacity", numLoadCapacity.Value),
                new SqlParameter("@VolumeCapacity", numVolumeCapacity.Value),
                new SqlParameter("@FuelType", cmbFuelType.Text),
                new SqlParameter("@LastMaintenanceDate", dtpLastMaintenance.Value),
                new SqlParameter("@Status", cmbStatusLorry.Text),
                new SqlParameter("@IsAvailable", chkIsAvailableLorry.Checked)
            };

                    int result = DatabaseConnection.ExecuteNonQuery(query, parameters);
                    if (result > 0)
                    {
                        ShowMessage("Lorry added successfully!", false);
                        LoadLorries();
                        LoadComboBoxData();
                        ClearLorryForm();
                    }
                }
                catch (Exception ex)
                {
                    ShowMessage($"Error adding lorry: {ex.Message}", true);
                }
            }
        }

        private void btnUpdateLorry_Click(object sender, EventArgs e)
        {
            if (selectedLorryID > 0 && ValidateLorryData())
            {
                try
                {
                    string query = @"UPDATE Lorries SET RegistrationNumber = @RegistrationNumber, Make = @Make, Model = @Model, 
                           Year = @Year, LoadCapacity = @LoadCapacity, VolumeCapacity = @VolumeCapacity, 
                           FuelType = @FuelType, LastMaintenanceDate = @LastMaintenanceDate, Status = @Status, 
                           IsAvailable = @IsAvailable, ModifiedDate = @ModifiedDate WHERE LorryID = @LorryID";

                    SqlParameter[] parameters = {
                new SqlParameter("@RegistrationNumber", txtRegistrationNumber.Text.Trim()),
                new SqlParameter("@Make", txtMake.Text.Trim()),
                new SqlParameter("@Model", txtModel.Text.Trim()),
                new SqlParameter("@Year", numYear.Value),
                new SqlParameter("@LoadCapacity", numLoadCapacity.Value),
                new SqlParameter("@VolumeCapacity", numVolumeCapacity.Value),
                new SqlParameter("@FuelType", cmbFuelType.Text),
                new SqlParameter("@LastMaintenanceDate", dtpLastMaintenance.Value),
                new SqlParameter("@Status", cmbStatusLorry.Text),
                new SqlParameter("@IsAvailable", chkIsAvailableLorry.Checked),
                new SqlParameter("@ModifiedDate", DateTime.Now),
                new SqlParameter("@LorryID", selectedLorryID)
            };

                    int result = DatabaseConnection.ExecuteNonQuery(query, parameters);
                    if (result > 0)
                    {
                        ShowMessage("Lorry updated successfully!", false);
                        LoadLorries();
                        LoadComboBoxData();
                    }
                }
                catch (Exception ex)
                {
                    ShowMessage($"Error updating lorry: {ex.Message}", true);
                }
            }
        }

        private void btnDeleteLorry_Click(object sender, EventArgs e)
        {
            if (selectedLorryID > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this lorry?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string query = "UPDATE Lorries SET IsDeleted = 1, ModifiedDate = @ModifiedDate WHERE LorryID = @LorryID";
                        SqlParameter[] parameters = {
                    new SqlParameter("@ModifiedDate", DateTime.Now),
                    new SqlParameter("@LorryID", selectedLorryID)
                };

                        int queryResult = DatabaseConnection.ExecuteNonQuery(query, parameters);
                        if (queryResult > 0)
                        {
                            ShowMessage("Lorry deleted successfully!", false);
                            LoadLorries();
                            LoadComboBoxData();
                            ClearLorryForm();
                        }
                    }
                    catch (Exception ex)
                    {
                        ShowMessage($"Error deleting lorry: {ex.Message}", true);
                    }
                }
            }
        }

        #endregion

        #region Driver Events

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            if (ValidateDriverData())
            {
                try
                {
                    string query = @"INSERT INTO Drivers (LicenseNumber, FirstName, LastName, Phone, Email, Address, 
                           LicenseExpiryDate, LicenseClass, HourlyRate, IsAvailable) 
                           VALUES (@LicenseNumber, @FirstName, @LastName, @Phone, @Email, @Address, 
                           @LicenseExpiryDate, @LicenseClass, @HourlyRate, @IsAvailable)";

                    SqlParameter[] parameters = {
                new SqlParameter("@LicenseNumber", txtLicenseNumber.Text.Trim()),
                new SqlParameter("@FirstName", txtFirstNameDriver.Text.Trim()),
                new SqlParameter("@LastName", txtLastNameDriver.Text.Trim()),
                new SqlParameter("@Phone", txtPhoneDriver.Text.Trim()),
                new SqlParameter("@Email", txtEmailDriver.Text.Trim()),
                new SqlParameter("@Address", txtAddressDriver.Text.Trim()),
                new SqlParameter("@LicenseExpiryDate", dtpLicenseExpiry.Value),
                new SqlParameter("@LicenseClass", cmbLicenseClass.Text),
                new SqlParameter("@HourlyRate", numHourlyRateDriver.Value),
                new SqlParameter("@IsAvailable", chkIsAvailableDriver.Checked)
            };

                    int result = DatabaseConnection.ExecuteNonQuery(query, parameters);
                    if (result > 0)
                    {
                        ShowMessage("Driver added successfully!", false);
                        LoadDrivers();
                        LoadComboBoxData();
                        ClearDriverForm();
                    }
                }
                catch (Exception ex)
                {
                    ShowMessage($"Error adding driver: {ex.Message}", true);
                }
            }
        }

        private void btnUpdateDriver_Click(object sender, EventArgs e)
        {
            if (selectedDriverID > 0 && ValidateDriverData())
            {
                try
                {
                    string query = @"UPDATE Drivers SET LicenseNumber = @LicenseNumber, FirstName = @FirstName, 
                           LastName = @LastName, Phone = @Phone, Email = @Email, Address = @Address, 
                           LicenseExpiryDate = @LicenseExpiryDate, LicenseClass = @LicenseClass, 
                           HourlyRate = @HourlyRate, IsAvailable = @IsAvailable, ModifiedDate = @ModifiedDate 
                           WHERE DriverID = @DriverID";

                    SqlParameter[] parameters = {
                new SqlParameter("@LicenseNumber", txtLicenseNumber.Text.Trim()),
                new SqlParameter("@FirstName", txtFirstNameDriver.Text.Trim()),
                new SqlParameter("@LastName", txtLastNameDriver.Text.Trim()),
                new SqlParameter("@Phone", txtPhoneDriver.Text.Trim()),
                new SqlParameter("@Email", txtEmailDriver.Text.Trim()),
                new SqlParameter("@Address", txtAddressDriver.Text.Trim()),
                new SqlParameter("@LicenseExpiryDate", dtpLicenseExpiry.Value),
                new SqlParameter("@LicenseClass", cmbLicenseClass.Text),
                new SqlParameter("@HourlyRate", numHourlyRateDriver.Value),
                new SqlParameter("@IsAvailable", chkIsAvailableDriver.Checked),
                new SqlParameter("@ModifiedDate", DateTime.Now),
                new SqlParameter("@DriverID", selectedDriverID)
            };

                    int result = DatabaseConnection.ExecuteNonQuery(query, parameters);
                    if (result > 0)
                    {
                        ShowMessage("Driver updated successfully!", false);
                        LoadDrivers();
                        LoadComboBoxData();
                    }
                }
                catch (Exception ex)
                {
                    ShowMessage($"Error updating driver: {ex.Message}", true);
                }
            }
        }

        private void btnDeleteDriver_Click(object sender, EventArgs e)
        {
            if (selectedDriverID > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this driver?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string query = "UPDATE Drivers SET IsDeleted = 1, ModifiedDate = @ModifiedDate WHERE DriverID = @DriverID";
                        SqlParameter[] parameters = {
                    new SqlParameter("@ModifiedDate", DateTime.Now),
                    new SqlParameter("@DriverID", selectedDriverID)
                };

                        int queryResult = DatabaseConnection.ExecuteNonQuery(query, parameters);
                        if (queryResult > 0)
                        {
                            ShowMessage("Driver deleted successfully!", false);
                            LoadDrivers();
                            LoadComboBoxData();
                            ClearDriverForm();
                        }
                    }
                    catch (Exception ex)
                    {
                        ShowMessage($"Error deleting driver: {ex.Message}", true);
                    }
                }
            }
        }

        #endregion

        #region Assistant Events

        private void btnAddAssistant_Click(object sender, EventArgs e)
        {
            if (ValidateAssistantData())
            {
                try
                {
                    string query = @"INSERT INTO Assistants (FirstName, LastName, Phone, Email, Address, HireDate, HourlyRate, IsAvailable) 
                           VALUES (@FirstName, @LastName, @Phone, @Email, @Address, @HireDate, @HourlyRate, @IsAvailable)";

                    SqlParameter[] parameters = {
                new SqlParameter("@FirstName", txtFirstNameAssistant.Text.Trim()),
                new SqlParameter("@LastName", txtLastNameAssistant.Text.Trim()),
                new SqlParameter("@Phone", txtPhoneAssistant.Text.Trim()),
                new SqlParameter("@Email", txtEmailAssistant.Text.Trim()),
                new SqlParameter("@Address", txtAddressAssistant.Text.Trim()),
                new SqlParameter("@HireDate", dtpHireDate.Value),
                new SqlParameter("@HourlyRate", numHourlyRateAssistant.Value),
                new SqlParameter("@IsAvailable", chkIsAvailableAssistant.Checked)
            };

                    int result = DatabaseConnection.ExecuteNonQuery(query, parameters);
                    if (result > 0)
                    {
                        ShowMessage("Assistant added successfully!", false);
                        LoadAssistants();
                        LoadComboBoxData();
                        ClearAssistantForm();
                    }
                }
                catch (Exception ex)
                {
                    ShowMessage($"Error adding assistant: {ex.Message}", true);
                }
            }
        }

        private void btnUpdateAssistant_Click(object sender, EventArgs e)
        {
            if (selectedAssistantID > 0 && ValidateAssistantData())
            {
                try
                {
                    string query = @"UPDATE Assistants SET FirstName = @FirstName, LastName = @LastName, Phone = @Phone, 
                           Email = @Email, Address = @Address, HireDate = @HireDate, HourlyRate = @HourlyRate, 
                           IsAvailable = @IsAvailable, ModifiedDate = @ModifiedDate WHERE AssistantID = @AssistantID";

                    SqlParameter[] parameters = {
                new SqlParameter("@FirstName", txtFirstNameAssistant.Text.Trim()),
                new SqlParameter("@LastName", txtLastNameAssistant.Text.Trim()),
                new SqlParameter("@Phone", txtPhoneAssistant.Text.Trim()),
                new SqlParameter("@Email", txtEmailAssistant.Text.Trim()),
                new SqlParameter("@Address", txtAddressAssistant.Text.Trim()),
                new SqlParameter("@HireDate", dtpHireDate.Value),
                new SqlParameter("@HourlyRate", numHourlyRateAssistant.Value),
                new SqlParameter("@IsAvailable", chkIsAvailableAssistant.Checked),
                new SqlParameter("@ModifiedDate", DateTime.Now),
                new SqlParameter("@AssistantID", selectedAssistantID)
            };

                    int result = DatabaseConnection.ExecuteNonQuery(query, parameters);
                    if (result > 0)
                    {
                        ShowMessage("Assistant updated successfully!", false);
                        LoadAssistants();
                        LoadComboBoxData();
                    }
                }
                catch (Exception ex)
                {
                    ShowMessage($"Error updating assistant: {ex.Message}", true);
                }
            }
        }

        private void btnDeleteAssistant_Click(object sender, EventArgs e)
        {
            if (selectedAssistantID > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this assistant?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string query = "UPDATE Assistants SET IsDeleted = 1, ModifiedDate = @ModifiedDate WHERE AssistantID = @AssistantID";
                        SqlParameter[] parameters = {
                    new SqlParameter("@ModifiedDate", DateTime.Now),
                    new SqlParameter("@AssistantID", selectedAssistantID)
                };

                        int queryResult = DatabaseConnection.ExecuteNonQuery(query, parameters);
                        if (queryResult > 0)
                        {
                            ShowMessage("Assistant deleted successfully!", false);
                            LoadAssistants();
                            LoadComboBoxData();
                            ClearAssistantForm();
                        }
                    }
                    catch (Exception ex)
                    {
                        ShowMessage($"Error deleting assistant: {ex.Message}", true);
                    }
                }
            }
        }

        #endregion

        #region Container Events

        private void btnAddContainer_Click(object sender, EventArgs e)
        {
            if (ValidateContainerData())
            {
                try
                {
                    string query = @"INSERT INTO Containers (ContainerNumber, Type, Capacity, Length, Width, Height, Material, Status, IsAvailable) 
                           VALUES (@ContainerNumber, @Type, @Capacity, @Length, @Width, @Height, @Material, @Status, @IsAvailable)";

                    SqlParameter[] parameters = {
                new SqlParameter("@ContainerNumber", txtContainerNumber.Text.Trim()),
                new SqlParameter("@Type", cmbType.Text),
                new SqlParameter("@Capacity", numCapacity.Value),
                new SqlParameter("@Length", numLength.Value),
                new SqlParameter("@Width", numWidth.Value),
                new SqlParameter("@Height", numHeight.Value),
                new SqlParameter("@Material", cmbMaterial.Text),
                new SqlParameter("@Status", cmbStatusContainer.Text),
                new SqlParameter("@IsAvailable", chkIsAvailableContainer.Checked)
            };

                    int result = DatabaseConnection.ExecuteNonQuery(query, parameters);
                    if (result > 0)
                    {
                        ShowMessage("Container added successfully!", false);
                        LoadContainers();
                        LoadComboBoxData();
                        ClearContainerForm();
                    }
                }
                catch (Exception ex)
                {
                    ShowMessage($"Error adding container: {ex.Message}", true);
                }
            }
        }

        private void btnUpdateContainer_Click(object sender, EventArgs e)
        {
            if (selectedContainerID > 0 && ValidateContainerData())
            {
                try
                {
                    string query = @"UPDATE Containers SET ContainerNumber = @ContainerNumber, Type = @Type, Capacity = @Capacity, 
                           Length = @Length, Width = @Width, Height = @Height, Material = @Material, Status = @Status, 
                           IsAvailable = @IsAvailable, ModifiedDate = @ModifiedDate WHERE ContainerID = @ContainerID";

                    SqlParameter[] parameters = {
                new SqlParameter("@ContainerNumber", txtContainerNumber.Text.Trim()),
                new SqlParameter("@Type", cmbType.Text),
                new SqlParameter("@Capacity", numCapacity.Value),
                new SqlParameter("@Length", numLength.Value),
                new SqlParameter("@Width", numWidth.Value),
                new SqlParameter("@Height", numHeight.Value),
                new SqlParameter("@Material", cmbMaterial.Text),
                new SqlParameter("@Status", cmbStatusContainer.Text),
                new SqlParameter("@IsAvailable", chkIsAvailableContainer.Checked),
                new SqlParameter("@ModifiedDate", DateTime.Now),
                new SqlParameter("@ContainerID", selectedContainerID)
            };

                    int result = DatabaseConnection.ExecuteNonQuery(query, parameters);
                    if (result > 0)
                    {
                        ShowMessage("Container updated successfully!", false);
                        LoadContainers();
                        LoadComboBoxData();
                    }
                }
                catch (Exception ex)
                {
                    ShowMessage($"Error updating container: {ex.Message}", true);
                }
            }
        }

        private void btnDeleteContainer_Click(object sender, EventArgs e)
        {
            if (selectedContainerID > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this container?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string query = "UPDATE Containers SET IsDeleted = 1, ModifiedDate = @ModifiedDate WHERE ContainerID = @ContainerID";
                        SqlParameter[] parameters = {
                    new SqlParameter("@ModifiedDate", DateTime.Now),
                    new SqlParameter("@ContainerID", selectedContainerID)
                };

                        int queryResult = DatabaseConnection.ExecuteNonQuery(query, parameters);
                        if (queryResult > 0)
                        {
                            ShowMessage("Container deleted successfully!", false);
                            LoadContainers();
                            LoadComboBoxData();
                            ClearContainerForm();
                        }
                    }
                    catch (Exception ex)
                    {
                        ShowMessage($"Error deleting container: {ex.Message}", true);
                    }
                }
            }
        }

        #endregion

        #region Helper Methods - Add if missing

        // Add these variables at the class level if they don't exist
        private int selectedLorryID = 0;
        private int selectedDriverID = 0;
        private int selectedAssistantID = 0;
        private int selectedContainerID = 0;

        // Add these validation methods if they don't exist
        private bool ValidateLorryData()
        {
            if (string.IsNullOrWhiteSpace(txtRegistrationNumber.Text)) { ShowMessage("Registration Number is required", true); txtRegistrationNumber.Focus(); return false; }
            if (string.IsNullOrWhiteSpace(txtMake.Text)) { ShowMessage("Make is required", true); txtMake.Focus(); return false; }
            if (string.IsNullOrWhiteSpace(txtModel.Text)) { ShowMessage("Model is required", true); txtModel.Focus(); return false; }
            if (cmbFuelType.SelectedIndex == -1) { ShowMessage("Fuel Type is required", true); cmbFuelType.Focus(); return false; }
            if (cmbStatusLorry.SelectedIndex == -1) { ShowMessage("Status is required", true); cmbStatusLorry.Focus(); return false; }
            return true;
        }

        private bool ValidateDriverData()
        {
            if (string.IsNullOrWhiteSpace(txtLicenseNumber.Text)) { ShowMessage("License Number is required", true); txtLicenseNumber.Focus(); return false; }
            if (string.IsNullOrWhiteSpace(txtFirstNameDriver.Text)) { ShowMessage("First Name is required", true); txtFirstNameDriver.Focus(); return false; }
            if (string.IsNullOrWhiteSpace(txtLastNameDriver.Text)) { ShowMessage("Last Name is required", true); txtLastNameDriver.Focus(); return false; }
            if (cmbLicenseClass.SelectedIndex == -1) { ShowMessage("License Class is required", true); cmbLicenseClass.Focus(); return false; }
            return true;
        }

        private bool ValidateAssistantData()
        {
            if (string.IsNullOrWhiteSpace(txtFirstNameAssistant.Text)) { ShowMessage("First Name is required", true); txtFirstNameAssistant.Focus(); return false; }
            if (string.IsNullOrWhiteSpace(txtLastNameAssistant.Text)) { ShowMessage("Last Name is required", true); txtLastNameAssistant.Focus(); return false; }
            return true;
        }

        // Add these clear form methods if they don't exist
        private void ClearLorryForm()
        {
            selectedLorryID = 0;
            txtRegistrationNumber.Clear();
            txtMake.Clear();
            txtModel.Clear();
            numYear.Value = 2020;
            numLoadCapacity.Value = 0;
            numVolumeCapacity.Value = 0;
            cmbFuelType.SelectedIndex = -1;
            dtpLastMaintenance.Value = DateTime.Now;
            cmbStatusLorry.SelectedIndex = 0;
            chkIsAvailableLorry.Checked = true;
        }

        private void ClearDriverForm()
        {
            selectedDriverID = 0;
            txtLicenseNumber.Clear();
            txtFirstNameDriver.Clear();
            txtLastNameDriver.Clear();
            txtPhoneDriver.Clear();
            txtEmailDriver.Clear();
            txtAddressDriver.Clear();
            dtpLicenseExpiry.Value = DateTime.Now.AddYears(1);
            cmbLicenseClass.SelectedIndex = -1;
            numHourlyRateDriver.Value = 0;
            chkIsAvailableDriver.Checked = true;
        }

        private void ClearAssistantForm()
        {
            selectedAssistantID = 0;
            txtFirstNameAssistant.Clear();
            txtLastNameAssistant.Clear();
            txtPhoneAssistant.Clear();
            txtEmailAssistant.Clear();
            txtAddressAssistant.Clear();
            dtpHireDate.Value = DateTime.Now;
            numHourlyRateAssistant.Value = 0;
            chkIsAvailableAssistant.Checked = true;
        }

        // Add these load detail methods if they don't exist
        private void LoadLorryDetails(int lorryID)
        {
            try
            {
                string query = "SELECT * FROM Lorries WHERE LorryID = @LorryID AND IsDeleted = 0";
                SqlParameter[] parameters = { new SqlParameter("@LorryID", lorryID) };

                using (SqlDataReader reader = DatabaseConnection.ExecuteReader(query, parameters))
                {
                    if (reader.Read())
                    {
                        txtRegistrationNumber.Text = reader["RegistrationNumber"].ToString();
                        txtMake.Text = reader["Make"].ToString();
                        txtModel.Text = reader["Model"].ToString();
                        numYear.Value = Convert.ToDecimal(reader["Year"]);
                        numLoadCapacity.Value = Convert.ToDecimal(reader["LoadCapacity"]);
                        numVolumeCapacity.Value = Convert.ToDecimal(reader["VolumeCapacity"]);
                        cmbFuelType.Text = reader["FuelType"].ToString();
                        dtpLastMaintenance.Value = Convert.ToDateTime(reader["LastMaintenanceDate"]);
                        cmbStatusLorry.Text = reader["Status"].ToString();
                        chkIsAvailableLorry.Checked = Convert.ToBoolean(reader["IsAvailable"]);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error loading lorry details: {ex.Message}", true);
            }
        }

        private void LoadDriverDetails(int driverID)
        {
            try
            {
                string query = "SELECT * FROM Drivers WHERE DriverID = @DriverID AND IsDeleted = 0";
                SqlParameter[] parameters = { new SqlParameter("@DriverID", driverID) };

                using (SqlDataReader reader = DatabaseConnection.ExecuteReader(query, parameters))
                {
                    if (reader.Read())
                    {
                        txtLicenseNumber.Text = reader["LicenseNumber"].ToString();
                        txtFirstNameDriver.Text = reader["FirstName"].ToString();
                        txtLastNameDriver.Text = reader["LastName"].ToString();
                        txtPhoneDriver.Text = reader["Phone"].ToString();
                        txtEmailDriver.Text = reader["Email"].ToString();
                        txtAddressDriver.Text = reader["Address"].ToString();
                        dtpLicenseExpiry.Value = Convert.ToDateTime(reader["LicenseExpiryDate"]);
                        cmbLicenseClass.Text = reader["LicenseClass"].ToString();
                        numHourlyRateDriver.Value = Convert.ToDecimal(reader["HourlyRate"]);
                        chkIsAvailableDriver.Checked = Convert.ToBoolean(reader["IsAvailable"]);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error loading driver details: {ex.Message}", true);
            }
        }

        private void LoadAssistantDetails(int assistantID)
        {
            try
            {
                string query = "SELECT * FROM Assistants WHERE AssistantID = @AssistantID AND IsDeleted = 0";
                SqlParameter[] parameters = { new SqlParameter("@AssistantID", assistantID) };

                using (SqlDataReader reader = DatabaseConnection.ExecuteReader(query, parameters))
                {
                    if (reader.Read())
                    {
                        txtFirstNameAssistant.Text = reader["FirstName"].ToString();
                        txtLastNameAssistant.Text = reader["LastName"].ToString();
                        txtPhoneAssistant.Text = reader["Phone"].ToString();
                        txtEmailAssistant.Text = reader["Email"].ToString();
                        txtAddressAssistant.Text = reader["Address"].ToString();
                        dtpHireDate.Value = Convert.ToDateTime(reader["HireDate"]);
                        numHourlyRateAssistant.Value = Convert.ToDecimal(reader["HourlyRate"]);
                        chkIsAvailableAssistant.Checked = Convert.ToBoolean(reader["IsAvailable"]);
                    }
                }
            }
            catch (Exception)
            {

            }
        }





    }
}