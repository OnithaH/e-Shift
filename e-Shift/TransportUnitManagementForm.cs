using e_Shift.Database;
using e_Shift.Utils;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace e_Shift
{
    public partial class TransportUnitManagementForm : Form
    {
        #region Private Fields
        private int selectedTransportUnitID = 0;
        private int selectedLorryID = 0;
        private int selectedDriverID = 0;
        private int selectedAssistantID = 0;
        private int selectedContainerID = 0;
        #endregion

        #region Constructor and Initialization
        public TransportUnitManagementForm()
        {
            InitializeComponent();
            CheckAdminAccess();
            SetupTabs();

        }
        private void SetupTabs()
        {
            // Make sure all tabs are visible
            if (tabControl1.TabPages.Count < 5)
            {
                // If tabs are missing, show a message
                ShowMessage("Some management tabs are not configured yet", false);
            }

            // Set the first tab as selected
            tabControl1.SelectedIndex = 0;
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

        private void ClearAllForms()
        {
            ClearTransportUnitForm();
            ClearLorryForm();
            ClearDriverForm();
            ClearAssistantForm();
            ClearContainerForm();
        }
        #endregion

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
                dgvTransportUnits.Columns["LorryReg"].HeaderText = "Lorry";
                dgvTransportUnits.Columns["DriverName"].HeaderText = "Driver";
                dgvTransportUnits.Columns["AssistantName"].HeaderText = "Assistant";
                dgvTransportUnits.Columns["ContainerNumber"].HeaderText = "Container";
            }
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

        private bool ValidateTransportUnitData()
        {
            if (string.IsNullOrWhiteSpace(txtUnitNumber.Text))
            {
                ShowMessage("Unit Number is required", true);
                txtUnitNumber.Focus();
                return false;
            }

            if (cmbStatusTU.SelectedIndex == -1)
            {
                ShowMessage("Status is required", true);
                cmbStatusTU.Focus();
                return false;
            }

            if (cmbLorryTU.SelectedValue == null || Convert.ToInt32(cmbLorryTU.SelectedValue) <= 0)
            {
                ShowMessage("Lorry selection is required", true);
                cmbLorryTU.Focus();
                return false;
            }

            if (cmbDriverTU.SelectedValue == null || Convert.ToInt32(cmbDriverTU.SelectedValue) <= 0)
            {
                ShowMessage("Driver selection is required", true);
                cmbDriverTU.Focus();
                return false;
            }

            if (cmbAssistantTU.SelectedValue == null || Convert.ToInt32(cmbAssistantTU.SelectedValue) <= 0)
            {
                ShowMessage("Assistant selection is required", true);
                cmbAssistantTU.Focus();
                return false;
            }

            if (cmbContainerTU.SelectedValue == null || Convert.ToInt32(cmbContainerTU.SelectedValue) <= 0)
            {
                ShowMessage("Container selection is required", true);
                cmbContainerTU.Focus();
                return false;
            }

            return true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = ((TextBox)sender).Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                LoadTransportUnits(); // Show all
                return;
            }

            if (searchText.Length < 2) return; // Wait for at least 2 characters

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
            AND (tu.UnitNumber LIKE @Search 
                OR l.RegistrationNumber LIKE @Search
                OR d.FirstName LIKE @Search
                OR d.LastName LIKE @Search)
            ORDER BY tu.UnitNumber";

                SqlParameter[] parameters = {
            new SqlParameter("@Search", $"%{searchText}%")
        };

                DataTable dataTable = DatabaseConnection.FillDataTable(query, parameters);
                if (dataTable != null)
                {
                    dgvTransportUnits.DataSource = dataTable;
                    FormatTransportUnitsGrid();
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Search error: {ex.Message}", true);
            }
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
            }
        }

        private void LoadLorryDetails(int lorryID)
        {
            try
            {
                string query = @"SELECT * FROM Lorries WHERE LorryID = @LorryID";
                SqlParameter[] parameters = { new SqlParameter("@LorryID", lorryID) };

                using (SqlDataReader reader = DatabaseConnection.ExecuteReader(query, parameters))
                {
                    if (reader != null && reader.Read())
                    {
                        // Handle potential null values with proper checking
                        txtRegistrationNumber.Text = reader["RegistrationNumber"]?.ToString() ?? "";
                        txtMake.Text = reader["Make"]?.ToString() ?? "";
                        txtModel.Text = reader["Model"]?.ToString() ?? "";

                        // Safe conversion for Year
                        if (reader["Year"] != DBNull.Value)
                            numYear.Value = Convert.ToDecimal(reader["Year"]);
                        else
                            numYear.Value = DateTime.Now.Year;

                        // Safe conversion for LoadCapacity
                        if (reader["LoadCapacity"] != DBNull.Value)
                            numLoadCapacity.Value = Convert.ToDecimal(reader["LoadCapacity"]);
                        else
                            numLoadCapacity.Value = 0;

                        // Safe conversion for VolumeCapacity
                        if (reader["VolumeCapacity"] != DBNull.Value)
                            numVolumeCapacity.Value = Convert.ToDecimal(reader["VolumeCapacity"]);
                        else
                            numVolumeCapacity.Value = 0;

                        cmbFuelType.Text = reader["FuelType"]?.ToString() ?? "Diesel";

                        // Safe conversion for LastMaintenance
                        if (reader["LastMaintenance"] != DBNull.Value)
                            dtpLastMaintenance.Value = Convert.ToDateTime(reader["LastMaintenance"]);
                        else
                            dtpLastMaintenance.Value = DateTime.Now.AddMonths(-6); // Default to 6 months ago

                        cmbStatusLorry.Text = reader["Status"]?.ToString() ?? "Available";

                        // Safe conversion for IsAvailable
                        if (reader["IsAvailable"] != DBNull.Value)
                            chkIsAvailableLorry.Checked = Convert.ToBoolean(reader["IsAvailable"]);
                        else
                            chkIsAvailableLorry.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error loading lorry details: {ex.Message}", true);
            }
        }

        private void ClearLorryForm()
        {
            selectedLorryID = 0;
            txtRegistrationNumber.Clear();
            txtMake.Clear();
            txtModel.Clear();
            numYear.Minimum = 1980;
            numYear.Maximum = 2030;
            numYear.Value = DateTime.Now.Year;
            numLoadCapacity.Value = 0;
            numVolumeCapacity.Value = 0;
            cmbFuelType.SelectedIndex = -1;
            dtpLastMaintenance.Value = DateTime.Now;
            cmbStatusLorry.SelectedIndex = 0;
            chkIsAvailableLorry.Checked = true;
        }

        private bool ValidateLorryData()
        {
            if (string.IsNullOrWhiteSpace(txtRegistrationNumber.Text))
            {
                ShowMessage("Registration Number is required", true);
                txtRegistrationNumber.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMake.Text))
            {
                ShowMessage("Make is required", true);
                txtMake.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtModel.Text))
            {
                ShowMessage("Model is required", true);
                txtModel.Focus();
                return false;
            }
            if (cmbFuelType.SelectedIndex == -1)
            {
                ShowMessage("Fuel Type is required", true);
                cmbFuelType.Focus();
                return false;
            }
            if (cmbStatusLorry.SelectedIndex == -1)
            {
                ShowMessage("Status is required", true);
                cmbStatusLorry.Focus();
                return false;
            }
            return true;
        }
        #endregion

        #region Drivers Management 

        private void LoadDrivers()
        {
            try
            {
                string query = @"SELECT DriverID, LicenseNumber, FirstName, LastName, Phone, Email, Address, 
                        LicenseExpiry, LicenseClass, HourlyRate, IsAvailable 
                        FROM Drivers WHERE IsDeleted = 0 ORDER BY FirstName, LastName";
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
                dgvDrivers.Columns["LicenseExpiry"].HeaderText = "License Exp.";
                dgvDrivers.Columns["LicenseClass"].HeaderText = "Class";
                dgvDrivers.Columns["HourlyRate"].HeaderText = "Rate";

                // Format columns
                if (dgvDrivers.Columns["HourlyRate"] != null)
                    dgvDrivers.Columns["HourlyRate"].DefaultCellStyle.Format = "C2"; // Currency format
                if (dgvDrivers.Columns["LicenseExpiry"] != null)
                    dgvDrivers.Columns["LicenseExpiry"].DefaultCellStyle.Format = "yyyy-MM-dd";
            }
        }

        private void LoadDriverDetails(int driverID)
        {
            try
            {
                string query = @"SELECT * FROM Drivers WHERE DriverID = @DriverID AND IsDeleted = 0";
                SqlParameter[] parameters = { new SqlParameter("@DriverID", driverID) };

                using (SqlDataReader reader = DatabaseConnection.ExecuteReader(query, parameters))
                {
                    if (reader != null && reader.Read())
                    {
                        // Handle potential null values with proper checking
                        txtLicenseNumber.Text = reader["LicenseNumber"]?.ToString() ?? "";
                        txtFirstNameDriver.Text = reader["FirstName"]?.ToString() ?? "";
                        txtLastNameDriver.Text = reader["LastName"]?.ToString() ?? "";
                        txtPhoneDriver.Text = reader["Phone"]?.ToString() ?? "";
                        txtEmailDriver.Text = reader["Email"]?.ToString() ?? "";
                        txtAddressDriver.Text = reader["Address"]?.ToString() ?? "";

                        // Safe conversion for LicenseExpiry
                        if (reader["LicenseExpiry"] != DBNull.Value)
                            dtpLicenseExpiry.Value = Convert.ToDateTime(reader["LicenseExpiry"]);
                        else
                            dtpLicenseExpiry.Value = DateTime.Now.AddYears(1); // Default to 1 year from now

                        cmbLicenseClass.Text = reader["LicenseClass"]?.ToString() ?? "Light";

                        // Safe conversion for HourlyRate
                        if (reader["HourlyRate"] != DBNull.Value)
                            numHourlyRateDriver.Value = Convert.ToDecimal(reader["HourlyRate"]);
                        else
                            numHourlyRateDriver.Value = 1000; // Default rate

                        // Safe conversion for IsAvailable
                        if (reader["IsAvailable"] != DBNull.Value)
                            chkIsAvailableDriver.Checked = Convert.ToBoolean(reader["IsAvailable"]);
                        else
                            chkIsAvailableDriver.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error loading driver details: {ex.Message}", true);
            }
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
            numHourlyRateDriver.Value = 1000;
            chkIsAvailableDriver.Checked = true;
        }

        private bool ValidateDriverData()
        {
            if (string.IsNullOrWhiteSpace(txtLicenseNumber.Text))
            {
                ShowMessage("License Number is required", true);
                txtLicenseNumber.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtFirstNameDriver.Text))
            {
                ShowMessage("First Name is required", true);
                txtFirstNameDriver.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastNameDriver.Text))
            {
                ShowMessage("Last Name is required", true);
                txtLastNameDriver.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhoneDriver.Text))
            {
                ShowMessage("Phone is required", true);
                txtPhoneDriver.Focus();
                return false;
            }

            if (cmbLicenseClass.SelectedIndex == -1)
            {
                ShowMessage("Please select a license class", true);
                cmbLicenseClass.Focus();
                return false;
            }

            if (dtpLicenseExpiry.Value <= DateTime.Now)
            {
                ShowMessage("License expiry date must be in the future", true);
                dtpLicenseExpiry.Focus();
                return false;
            }

            if (numHourlyRateDriver.Value <= 0)
            {
                ShowMessage("Hourly rate must be greater than 0", true);
                numHourlyRateDriver.Focus();
                return false;
            }

            return true;
        }
        #endregion

        #region Assistants Management
        private void LoadAssistants()
        {
            try
            {
                string query = @"SELECT AssistantID, FirstName, LastName, Phone, Email, Address, 
                        HireDate, HourlyRate, IsAvailable 
                        FROM Assistants WHERE IsDeleted = 0 ORDER BY FirstName, LastName";
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
                dgvAssistants.Columns["Phone"].HeaderText = "Phone";
                dgvAssistants.Columns["Email"].HeaderText = "Email";
                dgvAssistants.Columns["Address"].HeaderText = "Address";
                dgvAssistants.Columns["HireDate"].HeaderText = "Hire Date";
                dgvAssistants.Columns["HourlyRate"].HeaderText = "Rate";
                dgvAssistants.Columns["IsAvailable"].HeaderText = "Available";

                // Format columns
                if (dgvAssistants.Columns["HourlyRate"] != null)
                    dgvAssistants.Columns["HourlyRate"].DefaultCellStyle.Format = "C2"; // Currency format
                if (dgvAssistants.Columns["HireDate"] != null)
                    dgvAssistants.Columns["HireDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
            }
        }

        private void LoadAssistantDetails(int assistantID)
        {
            try
            {
                string query = @"SELECT * FROM Assistants WHERE AssistantID = @AssistantID AND IsDeleted = 0";
                SqlParameter[] parameters = { new SqlParameter("@AssistantID", assistantID) };

                using (SqlDataReader reader = DatabaseConnection.ExecuteReader(query, parameters))
                {
                    if (reader != null && reader.Read())
                    {
                        // Handle potential null values with proper checking
                        txtFirstNameAssistant.Text = reader["FirstName"]?.ToString() ?? "";
                        txtLastNameAssistant.Text = reader["LastName"]?.ToString() ?? "";
                        txtPhoneAssistant.Text = reader["Phone"]?.ToString() ?? "";
                        txtEmailAssistant.Text = reader["Email"]?.ToString() ?? "";
                        txtAddressAssistant.Text = reader["Address"]?.ToString() ?? "";

                        // Safe conversion for HireDate
                        if (reader["HireDate"] != DBNull.Value)
                            dtpHireDate.Value = Convert.ToDateTime(reader["HireDate"]);
                        else
                            dtpHireDate.Value = DateTime.Now;

                        // Safe conversion for HourlyRate
                        if (reader["HourlyRate"] != DBNull.Value)
                            numHourlyRateAssistant.Value = Convert.ToDecimal(reader["HourlyRate"]);
                        else
                            numHourlyRateAssistant.Value = 800; // Default rate for assistants

                        // Safe conversion for IsAvailable
                        if (reader["IsAvailable"] != DBNull.Value)
                            chkIsAvailableAssistant.Checked = Convert.ToBoolean(reader["IsAvailable"]);
                        else
                            chkIsAvailableAssistant.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error loading assistant details: {ex.Message}", true);
            }
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
            numHourlyRateAssistant.Value = 800; // Default assistant rate
            chkIsAvailableAssistant.Checked = true;
        }

        private bool ValidateAssistantData()
        {
            if (string.IsNullOrWhiteSpace(txtFirstNameAssistant.Text))
            {
                ShowMessage("First Name is required", true);
                txtFirstNameAssistant.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastNameAssistant.Text))
            {
                ShowMessage("Last Name is required", true);
                txtLastNameAssistant.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhoneAssistant.Text))
            {
                ShowMessage("Phone is required", true);
                txtPhoneAssistant.Focus();
                return false;
            }

            if (numHourlyRateAssistant.Value <= 0)
            {
                ShowMessage("Hourly rate must be greater than 0", true);
                numHourlyRateAssistant.Focus();
                return false;
            }

            if (dtpHireDate.Value > DateTime.Now)
            {
                ShowMessage("Hire date cannot be in the future", true);
                dtpHireDate.Focus();
                return false;
            }

            return true;
        }

        #endregion

        #region Containers Management
        private void LoadContainers()
        {
            try
            {
                string query = @"SELECT ContainerID, ContainerNumber, Type, Capacity, Length, Width, Height, 
                        Material, Status, IsAvailable 
                        FROM Containers WHERE IsDeleted = 0 ORDER BY ContainerNumber";
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
                dgvContainers.Columns["Type"].HeaderText = "Type";
                dgvContainers.Columns["Capacity"].HeaderText = "Capacity (m³)";
                dgvContainers.Columns["Length"].HeaderText = "Length (m)";
                dgvContainers.Columns["Width"].HeaderText = "Width (m)";
                dgvContainers.Columns["Height"].HeaderText = "Height (m)";
                dgvContainers.Columns["Material"].HeaderText = "Material";
                dgvContainers.Columns["Status"].HeaderText = "Status";
                dgvContainers.Columns["IsAvailable"].HeaderText = "Available";

                // Format decimal columns
                if (dgvContainers.Columns["Capacity"] != null)
                    dgvContainers.Columns["Capacity"].DefaultCellStyle.Format = "N2";
                if (dgvContainers.Columns["Length"] != null)
                    dgvContainers.Columns["Length"].DefaultCellStyle.Format = "N2";
                if (dgvContainers.Columns["Width"] != null)
                    dgvContainers.Columns["Width"].DefaultCellStyle.Format = "N2";
                if (dgvContainers.Columns["Height"] != null)
                    dgvContainers.Columns["Height"].DefaultCellStyle.Format = "N2";
            }
        }

        private void LoadContainerDetails(int containerID)
        {
            try
            {
                string query = @"SELECT * FROM Containers WHERE ContainerID = @ContainerID AND IsDeleted = 0";
                SqlParameter[] parameters = { new SqlParameter("@ContainerID", containerID) };

                using (SqlDataReader reader = DatabaseConnection.ExecuteReader(query, parameters))
                {
                    if (reader != null && reader.Read())
                    {
                        // Handle potential null values with proper checking
                        txtContainerNumber.Text = reader["ContainerNumber"]?.ToString() ?? "";
                        cmbType.Text = reader["Type"]?.ToString() ?? "Standard";

                        // Safe conversion for Capacity
                        if (reader["Capacity"] != DBNull.Value)
                            numCapacity.Value = Convert.ToDecimal(reader["Capacity"]);
                        else
                            numCapacity.Value = 1;

                        cmbStatusContainer.Text = reader["Status"]?.ToString() ?? "Available";

                        // Safe conversion for IsAvailable
                        if (reader["IsAvailable"] != DBNull.Value)
                            chkIsAvailableContainer.Checked = Convert.ToBoolean(reader["IsAvailable"]);
                        else
                            chkIsAvailableContainer.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error loading container details: {ex.Message}", true);
            }
        }

        private void ClearContainerForm()
        {
            selectedContainerID = 0;
            txtContainerNumber.Clear();
            cmbType.SelectedIndex = -1;
            numCapacity.Value = 1;
            cmbStatusContainer.SelectedIndex = 0;
            chkIsAvailableContainer.Checked = true;
        }

        private bool ValidateContainerData()
        {
            if (string.IsNullOrWhiteSpace(txtContainerNumber.Text))
            {
                ShowMessage("Container Number is required", true);
                txtContainerNumber.Focus();
                return false;
            }

            if (cmbType.SelectedIndex == -1)
            {
                ShowMessage("Container Type is required", true);
                cmbType.Focus();
                return false;
            }

            if (numCapacity.Value <= 0)
            {
                ShowMessage("Capacity must be greater than 0", true);
                numCapacity.Focus();
                return false;
            }

            if (cmbStatusContainer.SelectedIndex == -1)
            {
                ShowMessage("Please select a status", true);
                cmbStatusContainer.Focus();
                return false;
            }

            return true;
        }
        #endregion

        #region Button Event Handlers
        // Transport Unit Events
        private void btnCreateTransportUnit_Click(object sender, EventArgs e)
        {
            if (ValidateTransportUnitData())
            {
                try
                {
                    string query = @"INSERT INTO TransportUnits (UnitNumber, LorryID, DriverID, AssistantID, ContainerID, Status, IsAvailable, CreatedDate, ModifiedDate, IsDeleted) 
                           VALUES (@UnitNumber, @LorryID, @DriverID, @AssistantID, @ContainerID, @Status, @IsAvailable, @CreatedDate, @ModifiedDate, 0)";

                    SqlParameter[] parameters = {
                new SqlParameter("@UnitNumber", txtUnitNumber.Text.Trim()),
                new SqlParameter("@LorryID", Convert.ToInt32(cmbLorryTU.SelectedValue)),
                new SqlParameter("@DriverID", Convert.ToInt32(cmbDriverTU.SelectedValue)),
                new SqlParameter("@AssistantID", Convert.ToInt32(cmbAssistantTU.SelectedValue)),
                new SqlParameter("@ContainerID", Convert.ToInt32(cmbContainerTU.SelectedValue)),
                new SqlParameter("@Status", cmbStatusTU.Text),
                new SqlParameter("@IsAvailable", chkIsAvailableUnit.Checked),
                new SqlParameter("@CreatedDate", DateTime.Now),
                new SqlParameter("@ModifiedDate", DateTime.Now)
            };

                    int result = DatabaseConnection.ExecuteNonQuery(query, parameters);
                    if (result > 0)
                    {
                        ShowMessage("Transport unit created successfully!", false);
                        LoadTransportUnits();
                        LoadComboBoxData(); // Refresh combo boxes to show updated availability
                        ClearTransportUnitForm();
                    }
                    else
                    {
                        ShowMessage("Failed to create transport unit", true);
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
                    string query = @"UPDATE TransportUnits SET 
                           UnitNumber = @UnitNumber, 
                           LorryID = @LorryID, 
                           DriverID = @DriverID, 
                           AssistantID = @AssistantID, 
                           ContainerID = @ContainerID, 
                           Status = @Status, 
                           IsAvailable = @IsAvailable, 
                           ModifiedDate = @ModifiedDate 
                           WHERE TransportUnitID = @TransportUnitID";

                    SqlParameter[] parameters = {
                new SqlParameter("@UnitNumber", txtUnitNumber.Text.Trim()),
                new SqlParameter("@LorryID", Convert.ToInt32(cmbLorryTU.SelectedValue)),
                new SqlParameter("@DriverID", Convert.ToInt32(cmbDriverTU.SelectedValue)),
                new SqlParameter("@AssistantID", Convert.ToInt32(cmbAssistantTU.SelectedValue)),
                new SqlParameter("@ContainerID", Convert.ToInt32(cmbContainerTU.SelectedValue)),
                new SqlParameter("@Status", cmbStatusTU.Text),
                new SqlParameter("@IsAvailable", chkIsAvailableUnit.Checked),
                new SqlParameter("@ModifiedDate", DateTime.Now),
                new SqlParameter("@TransportUnitID", selectedTransportUnitID)
                };

                    int result = DatabaseConnection.ExecuteNonQuery(query, parameters);
                    if (result > 0)
                    {
                        ShowMessage("Transport unit updated successfully!", false);
                        LoadTransportUnits();
                        LoadComboBoxData(); // Refresh combo boxes
                    }
                    else
                    {
                        ShowMessage("Failed to update transport unit", true);
                    }
                }
                catch (Exception ex)
                {
                    ShowMessage($"Error updating transport unit: {ex.Message}", true);
                }
            }
            else if (selectedTransportUnitID <= 0)
            {
                ShowMessage("Please select a transport unit to update", true);
            }
        }

        private void btnDeleteTransportUnit_Click(object sender, EventArgs e)
        {
            if (selectedTransportUnitID > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this transport unit?\n\nThis will mark it as deleted but preserve the record.",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

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
                            LoadComboBoxData(); // Refresh combo boxes
                            ClearTransportUnitForm();
                        }
                        else
                        {
                            ShowMessage("Failed to delete transport unit", true);
                        }
                    }
                    catch (Exception ex)
                    {
                        ShowMessage($"Error deleting transport unit: {ex.Message}", true);
                    }
                }
            }
            else
            {
                ShowMessage("Please select a transport unit to delete", true);
            }
        }



        // Lorry Events
        private void btnAddLorry_Click(object sender, EventArgs e)
        {
            if (ValidateLorryData())
            {
                try
                {
                    string query = @"INSERT INTO Lorries (RegistrationNumber, Make, Model, Year, LoadCapacity, VolumeCapacity, FuelType, LastMaintenance, Status, IsAvailable, CreatedDate, ModifiedDate) 
                           VALUES (@RegistrationNumber, @Make, @Model, @Year, @LoadCapacity, @VolumeCapacity, @FuelType, @LastMaintenance, @Status, @IsAvailable, @CreatedDate, @ModifiedDate)";

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
                new SqlParameter("@CreatedDate", DateTime.Now),
                new SqlParameter("@ModifiedDate", DateTime.Now)
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
            if (selectedLorryID <= 0)
            {
                ShowMessage("Please select a lorry to update", true);
                return;
            }

            if (ValidateLorryData())
            {
                try
                {
                    string query = @"UPDATE Lorries SET 
                           RegistrationNumber = @RegistrationNumber,
                           Make = @Make,
                           Model = @Model,
                           Year = @Year,
                           LoadCapacity = @LoadCapacity,
                           VolumeCapacity = @VolumeCapacity,
                           FuelType = @FuelType,
                           LastMaintenance = @LastMaintenance,
                           Status = @Status,
                           IsAvailable = @IsAvailable,
                           ModifiedDate = @ModifiedDate
                           WHERE LorryID = @LorryID";

                    SqlParameter[] parameters = {
                new SqlParameter("@LorryID", selectedLorryID),
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
                new SqlParameter("@ModifiedDate", DateTime.Now)
            };

                    int result = DatabaseConnection.ExecuteNonQuery(query, parameters);
                    if (result > 0)
                    {
                        ShowMessage("Lorry updated successfully!", false);
                        LoadLorries();
                        LoadComboBoxData();
                        ClearLorryForm();
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
            if (selectedLorryID <= 0)
            {
                ShowMessage("Please select a lorry to delete", true);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this lorry?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Check if lorry is used in any transport units
                    string checkQuery = "SELECT COUNT(*) FROM TransportUnits WHERE LorryID = @LorryID AND IsDeleted = 0";
                    SqlParameter[] checkParams = { new SqlParameter("@LorryID", selectedLorryID) };

                    object count = DatabaseConnection.ExecuteScalar(checkQuery, checkParams);
                    if (Convert.ToInt32(count) > 0)
                    {
                        ShowMessage("Cannot delete lorry: It is assigned to transport units", true);
                        return;
                    }

                    // Soft delete the lorry
                    string deleteQuery = @"UPDATE Lorries SET IsDeleted = 1, ModifiedDate = @ModifiedDate WHERE LorryID = @LorryID";
                    SqlParameter[] deleteParams = {
                new SqlParameter("@LorryID", selectedLorryID),
                new SqlParameter("@ModifiedDate", DateTime.Now)
            };

                    int deleteResult = DatabaseConnection.ExecuteNonQuery(deleteQuery, deleteParams);
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



        // Driver Events
        // FIXED EVENT HANDLERS FOR DRIVER BUTTONS

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            if (ValidateDriverData())
            {
                try
                {
                    string query = @"INSERT INTO Drivers (LicenseNumber, FirstName, LastName, Phone, Email, Address, LicenseExpiry, LicenseClass, HourlyRate, IsAvailable, CreatedDate, ModifiedDate) 
                           VALUES (@LicenseNumber, @FirstName, @LastName, @Phone, @Email, @Address, @LicenseExpiry, @LicenseClass, @HourlyRate, @IsAvailable, @CreatedDate, @ModifiedDate)";

                    SqlParameter[] parameters = {
                new SqlParameter("@LicenseNumber", txtLicenseNumber.Text.Trim()),
                new SqlParameter("@FirstName", txtFirstNameDriver.Text.Trim()),
                new SqlParameter("@LastName", txtLastNameDriver.Text.Trim()),
                new SqlParameter("@Phone", txtPhoneDriver.Text.Trim()),
                new SqlParameter("@Email", string.IsNullOrWhiteSpace(txtEmailDriver.Text) ? (object)DBNull.Value : txtEmailDriver.Text.Trim()),
                new SqlParameter("@Address", string.IsNullOrWhiteSpace(txtAddressDriver.Text) ? (object)DBNull.Value : txtAddressDriver.Text.Trim()),
                new SqlParameter("@LicenseExpiry", dtpLicenseExpiry.Value),
                new SqlParameter("@LicenseClass", cmbLicenseClass.Text),
                new SqlParameter("@HourlyRate", numHourlyRateDriver.Value),
                new SqlParameter("@IsAvailable", chkIsAvailableDriver.Checked),
                new SqlParameter("@CreatedDate", DateTime.Now),
                new SqlParameter("@ModifiedDate", DateTime.Now)
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
            if (selectedDriverID <= 0)
            {
                ShowMessage("Please select a driver to update", true);
                return;
            }

            if (ValidateDriverData())
            {
                try
                {
                    string query = @"UPDATE Drivers SET 
                           LicenseNumber = @LicenseNumber,
                           FirstName = @FirstName,
                           LastName = @LastName,
                           Phone = @Phone,
                           Email = @Email,
                           Address = @Address,
                           LicenseExpiry = @LicenseExpiry,
                           LicenseClass = @LicenseClass,
                           HourlyRate = @HourlyRate,
                           IsAvailable = @IsAvailable,
                           ModifiedDate = @ModifiedDate
                           WHERE DriverID = @DriverID";

                    SqlParameter[] parameters = {
                new SqlParameter("@DriverID", selectedDriverID),
                new SqlParameter("@LicenseNumber", txtLicenseNumber.Text.Trim()),
                new SqlParameter("@FirstName", txtFirstNameDriver.Text.Trim()),
                new SqlParameter("@LastName", txtLastNameDriver.Text.Trim()),
                new SqlParameter("@Phone", txtPhoneDriver.Text.Trim()),
                new SqlParameter("@Email", string.IsNullOrWhiteSpace(txtEmailDriver.Text) ? (object)DBNull.Value : txtEmailDriver.Text.Trim()),
                new SqlParameter("@Address", string.IsNullOrWhiteSpace(txtAddressDriver.Text) ? (object)DBNull.Value : txtAddressDriver.Text.Trim()),
                new SqlParameter("@LicenseExpiry", dtpLicenseExpiry.Value),
                new SqlParameter("@LicenseClass", cmbLicenseClass.Text),
                new SqlParameter("@HourlyRate", numHourlyRateDriver.Value),
                new SqlParameter("@IsAvailable", chkIsAvailableDriver.Checked),
                new SqlParameter("@ModifiedDate", DateTime.Now)
            };

                    int result = DatabaseConnection.ExecuteNonQuery(query, parameters);
                    if (result > 0)
                    {
                        ShowMessage("Driver updated successfully!", false);
                        LoadDrivers();
                        LoadComboBoxData();
                        ClearDriverForm();
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
            if (selectedDriverID <= 0)
            {
                ShowMessage("Please select a driver to delete", true);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this driver?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Check if driver is used in any transport units
                    string checkQuery = "SELECT COUNT(*) FROM TransportUnits WHERE DriverID = @DriverID AND IsDeleted = 0";
                    SqlParameter[] checkParams = { new SqlParameter("@DriverID", selectedDriverID) };

                    object count = DatabaseConnection.ExecuteScalar(checkQuery, checkParams);
                    if (Convert.ToInt32(count) > 0)
                    {
                        ShowMessage("Cannot delete driver: Driver is assigned to transport units", true);
                        return;
                    }

                    // Soft delete the driver
                    string deleteQuery = @"UPDATE Drivers SET IsDeleted = 1, ModifiedDate = @ModifiedDate WHERE DriverID = @DriverID";
                    SqlParameter[] deleteParams = {
                new SqlParameter("@DriverID", selectedDriverID),
                new SqlParameter("@ModifiedDate", DateTime.Now)
            };

                    int deleteResult = DatabaseConnection.ExecuteNonQuery(deleteQuery, deleteParams);
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




        // Assistant Events
        // FIXED EVENT HANDLERS FOR ASSISTANT BUTTONS

        private void btnAddAssistant_Click(object sender, EventArgs e)
        {
            if (ValidateAssistantData())
            {
                try
                {
                    string query = @"INSERT INTO Assistants (FirstName, LastName, Phone, Email, Address, HireDate, HourlyRate, IsAvailable, CreatedDate, ModifiedDate) 
                           VALUES (@FirstName, @LastName, @Phone, @Email, @Address, @HireDate, @HourlyRate, @IsAvailable, @CreatedDate, @ModifiedDate)";

                    SqlParameter[] parameters = {
                new SqlParameter("@FirstName", txtFirstNameAssistant.Text.Trim()),
                new SqlParameter("@LastName", txtLastNameAssistant.Text.Trim()),
                new SqlParameter("@Phone", txtPhoneAssistant.Text.Trim()),
                new SqlParameter("@Email", string.IsNullOrWhiteSpace(txtEmailAssistant.Text) ? (object)DBNull.Value : txtEmailAssistant.Text.Trim()),
                new SqlParameter("@Address", string.IsNullOrWhiteSpace(txtAddressAssistant.Text) ? (object)DBNull.Value : txtAddressAssistant.Text.Trim()),
                new SqlParameter("@HireDate", dtpHireDate.Value),
                new SqlParameter("@HourlyRate", numHourlyRateAssistant.Value),
                new SqlParameter("@IsAvailable", chkIsAvailableAssistant.Checked),
                new SqlParameter("@CreatedDate", DateTime.Now),
                new SqlParameter("@ModifiedDate", DateTime.Now)
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
            if (selectedAssistantID <= 0)
            {
                ShowMessage("Please select an assistant to update", true);
                return;
            }

            if (ValidateAssistantData())
            {
                try
                {
                    string query = @"UPDATE Assistants SET 
                           FirstName = @FirstName,
                           LastName = @LastName,
                           Phone = @Phone,
                           Email = @Email,
                           Address = @Address,
                           HireDate = @HireDate,
                           HourlyRate = @HourlyRate,
                           IsAvailable = @IsAvailable,
                           ModifiedDate = @ModifiedDate
                           WHERE AssistantID = @AssistantID";

                    SqlParameter[] parameters = {
                new SqlParameter("@AssistantID", selectedAssistantID),
                new SqlParameter("@FirstName", txtFirstNameAssistant.Text.Trim()),
                new SqlParameter("@LastName", txtLastNameAssistant.Text.Trim()),
                new SqlParameter("@Phone", txtPhoneAssistant.Text.Trim()),
                new SqlParameter("@Email", string.IsNullOrWhiteSpace(txtEmailAssistant.Text) ? (object)DBNull.Value : txtEmailAssistant.Text.Trim()),
                new SqlParameter("@Address", string.IsNullOrWhiteSpace(txtAddressAssistant.Text) ? (object)DBNull.Value : txtAddressAssistant.Text.Trim()),
                new SqlParameter("@HireDate", dtpHireDate.Value),
                new SqlParameter("@HourlyRate", numHourlyRateAssistant.Value),
                new SqlParameter("@IsAvailable", chkIsAvailableAssistant.Checked),
                new SqlParameter("@ModifiedDate", DateTime.Now)
            };

                    int result = DatabaseConnection.ExecuteNonQuery(query, parameters);
                    if (result > 0)
                    {
                        ShowMessage("Assistant updated successfully!", false);
                        LoadAssistants();
                        LoadComboBoxData();
                        ClearAssistantForm();
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
            if (selectedAssistantID <= 0)
            {
                ShowMessage("Please select an assistant to delete", true);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this assistant?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Check if assistant is used in any transport units
                    string checkQuery = "SELECT COUNT(*) FROM TransportUnits WHERE AssistantID = @AssistantID AND IsDeleted = 0";
                    SqlParameter[] checkParams = { new SqlParameter("@AssistantID", selectedAssistantID) };

                    object count = DatabaseConnection.ExecuteScalar(checkQuery, checkParams);
                    if (Convert.ToInt32(count) > 0)
                    {
                        ShowMessage("Cannot delete assistant: Assistant is assigned to transport units", true);
                        return;
                    }

                    // Soft delete the assistant
                    string deleteQuery = @"UPDATE Assistants SET IsDeleted = 1, ModifiedDate = @ModifiedDate WHERE AssistantID = @AssistantID";
                    SqlParameter[] deleteParams = {
                new SqlParameter("@AssistantID", selectedAssistantID),
                new SqlParameter("@ModifiedDate", DateTime.Now)
            };

                    int deleteResult = DatabaseConnection.ExecuteNonQuery(deleteQuery, deleteParams);
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





        // Container Events
        private void btnAddContainer_Click(object sender, EventArgs e)
        {
            if (ValidateContainerData())
            {
                try
                {
                    string query = @"INSERT INTO Containers (ContainerNumber, Type, Capacity, Length, Width, Height, Material, Status, IsAvailable, CreatedDate, ModifiedDate) 
                           VALUES (@ContainerNumber, @Type, @Capacity, @Length, @Width, @Height, @Material, @Status, @IsAvailable, @CreatedDate, @ModifiedDate)";

                    SqlParameter[] parameters = {
                new SqlParameter("@ContainerNumber", txtContainerNumber.Text.Trim()),
                new SqlParameter("@Type", cmbType.Text),
                new SqlParameter("@Capacity", numCapacity.Value),
                new SqlParameter("@Length", GetContainerLength(cmbType.Text)), // Calculate based on type
                new SqlParameter("@Width", GetContainerWidth(cmbType.Text)),   // Calculate based on type
                new SqlParameter("@Height", GetContainerHeight(cmbType.Text)), // Calculate based on type
                new SqlParameter("@Material", "Steel"), // Default material
                new SqlParameter("@Status", cmbStatusContainer.Text),
                new SqlParameter("@IsAvailable", chkIsAvailableContainer.Checked),
                new SqlParameter("@CreatedDate", DateTime.Now),
                new SqlParameter("@ModifiedDate", DateTime.Now)
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
            if (selectedContainerID <= 0)
            {
                ShowMessage("Please select a container to update", true);
                return;
            }

            if (ValidateContainerData())
            {
                try
                {
                    string query = @"UPDATE Containers SET 
                           ContainerNumber = @ContainerNumber,
                           Type = @Type,
                           Capacity = @Capacity,
                           Length = @Length,
                           Width = @Width,
                           Height = @Height,
                           Status = @Status,
                           IsAvailable = @IsAvailable,
                           ModifiedDate = @ModifiedDate
                           WHERE ContainerID = @ContainerID";

                    SqlParameter[] parameters = {
                new SqlParameter("@ContainerID", selectedContainerID),
                new SqlParameter("@ContainerNumber", txtContainerNumber.Text.Trim()),
                new SqlParameter("@Type", cmbType.Text),
                new SqlParameter("@Capacity", numCapacity.Value),
                new SqlParameter("@Length", GetContainerLength(cmbType.Text)),
                new SqlParameter("@Width", GetContainerWidth(cmbType.Text)),
                new SqlParameter("@Height", GetContainerHeight(cmbType.Text)),
                new SqlParameter("@Status", cmbStatusContainer.Text),
                new SqlParameter("@IsAvailable", chkIsAvailableContainer.Checked),
                new SqlParameter("@ModifiedDate", DateTime.Now)
            };

                    int result = DatabaseConnection.ExecuteNonQuery(query, parameters);
                    if (result > 0)
                    {
                        ShowMessage("Container updated successfully!", false);
                        LoadContainers();
                        LoadComboBoxData();
                        ClearContainerForm();
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
            if (selectedContainerID <= 0)
            {
                ShowMessage("Please select a container to delete", true);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this container?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Check if container is used in any transport units
                    string checkQuery = "SELECT COUNT(*) FROM TransportUnits WHERE ContainerID = @ContainerID AND IsDeleted = 0";
                    SqlParameter[] checkParams = { new SqlParameter("@ContainerID", selectedContainerID) };

                    object count = DatabaseConnection.ExecuteScalar(checkQuery, checkParams);
                    if (Convert.ToInt32(count) > 0)
                    {
                        ShowMessage("Cannot delete container: It is assigned to transport units", true);
                        return;
                    }

                    // Soft delete the container
                    string deleteQuery = @"UPDATE Containers SET IsDeleted = 1, ModifiedDate = @ModifiedDate WHERE ContainerID = @ContainerID";
                    SqlParameter[] deleteParams = {
                new SqlParameter("@ContainerID", selectedContainerID),
                new SqlParameter("@ModifiedDate", DateTime.Now)
            };

                    int deleteResult = DatabaseConnection.ExecuteNonQuery(deleteQuery, deleteParams);
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

        // HELPER METHODS FOR CONTAINER DIMENSIONS
        private decimal GetContainerLength(string type)
        {
            switch (type?.ToLower())
            {
                case "small": return 4.00m;
                case "standard": return 6.00m;
                case "large": return 8.00m;
                case "fragile": return 5.00m;
                case "refrigerated": return 6.50m;
                default: return 6.00m;
            }
        }

        private decimal GetContainerWidth(string type)
        {
            switch (type?.ToLower())
            {
                case "small": return 2.00m;
                case "standard": return 2.50m;
                case "large": return 3.00m;
                case "fragile": return 2.40m;
                case "refrigerated": return 2.50m;
                default: return 2.50m;
            }
        }

        private decimal GetContainerHeight(string type)
        {
            switch (type?.ToLower())
            {
                case "small": return 2.00m;
                case "standard": return 2.50m;
                case "large": return 3.00m;
                case "fragile": return 2.40m;
                case "refrigerated": return 2.60m;
                default: return 2.50m;
            }
        }




        // General Events
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                LoadAllData();
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

        #region DataGridView Event Handlers
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

        #region Helper Methods
        private void LoadComboBoxData()
        {
            try
            {
                // Load Lorries into combo box
                string lorryQuery = "SELECT LorryID, RegistrationNumber FROM Lorries WHERE IsDeleted = 0 AND IsAvailable = 1";
                DataTable lorryData = DatabaseConnection.FillDataTable(lorryQuery);
                if (lorryData != null)
                {
                    cmbLorryTU.DataSource = lorryData;
                    cmbLorryTU.DisplayMember = "RegistrationNumber";
                    cmbLorryTU.ValueMember = "LorryID";
                    cmbLorryTU.SelectedIndex = -1;
                }

                // Load Drivers into combo box
                string driverQuery = "SELECT DriverID, CONCAT(FirstName, ' ', LastName) as DriverName FROM Drivers WHERE IsDeleted = 0 AND IsAvailable = 1";
                DataTable driverData = DatabaseConnection.FillDataTable(driverQuery);
                if (driverData != null)
                {
                    cmbDriverTU.DataSource = driverData;
                    cmbDriverTU.DisplayMember = "DriverName";
                    cmbDriverTU.ValueMember = "DriverID";
                    cmbDriverTU.SelectedIndex = -1;
                }

                // Load Assistants into combo box
                string assistantQuery = "SELECT AssistantID, CONCAT(FirstName, ' ', LastName) as AssistantName FROM Assistants WHERE IsDeleted = 0 AND IsAvailable = 1";
                DataTable assistantData = DatabaseConnection.FillDataTable(assistantQuery);
                if (assistantData != null)
                {
                    cmbAssistantTU.DataSource = assistantData;
                    cmbAssistantTU.DisplayMember = "AssistantName";
                    cmbAssistantTU.ValueMember = "AssistantID";
                    cmbAssistantTU.SelectedIndex = -1;
                }

                // Load Containers into combo box
                string containerQuery = "SELECT ContainerID, ContainerNumber FROM Containers WHERE IsDeleted = 0 AND IsAvailable = 1";
                DataTable containerData = DatabaseConnection.FillDataTable(containerQuery);
                if (containerData != null)
                {
                    cmbContainerTU.DataSource = containerData;
                    cmbContainerTU.DisplayMember = "ContainerNumber";
                    cmbContainerTU.ValueMember = "ContainerID";
                    cmbContainerTU.SelectedIndex = -1;
                }

                // Setup static combo boxes
                SetupStaticComboBoxes();
            }
            catch (Exception ex)
            {
                ShowMessage($"Error loading combo box data: {ex.Message}", true);
            }
        }

        private void SetupStaticComboBoxes()
        {
            // Fuel Type combo box
            cmbFuelType.Items.Clear();
            cmbFuelType.Items.AddRange(new string[] { "Petrol", "Diesel", "Electric", "Hybrid" });

            // Status combo boxes
            cmbStatusTU.Items.Clear();
            cmbStatusTU.Items.AddRange(new string[] { "Active", "Inactive", "Maintenance" });

            cmbStatusLorry.Items.Clear();
            cmbStatusLorry.Items.AddRange(new string[] { "Active", "Inactive", "Maintenance", "Out of Service" });

            cmbStatusContainer.Items.Clear();
            cmbStatusContainer.Items.AddRange(new string[] { "Available", "In Use", "Maintenance", "Out of Service" });

            // License Class combo box
            cmbLicenseClass.Items.Clear();
            cmbLicenseClass.Items.AddRange(new string[] { "Class A", "Class B", "Class C", "CDL" });

            // Container Type combo box
            cmbType.Items.Clear();
            cmbType.Items.AddRange(new string[] { "Dry", "Refrigerated", "Tank", "Flatbed" });
        }

        private void LoadTransportUnitDetails(int transportUnitID)
        {
            try
            {
                string query = @"SELECT * FROM TransportUnits WHERE TransportUnitID = @TransportUnitID";
                SqlParameter[] parameters = { new SqlParameter("@TransportUnitID", transportUnitID) };

                using (SqlDataReader reader = DatabaseConnection.ExecuteReader(query, parameters))
                {
                    if (reader != null && reader.Read())
                    {
                        txtUnitNumber.Text = reader["UnitNumber"].ToString();
                        cmbStatusTU.Text = reader["Status"].ToString();
                        cmbLorryTU.SelectedValue = reader["LorryID"];
                        cmbDriverTU.SelectedValue = reader["DriverID"];
                        cmbAssistantTU.SelectedValue = reader["AssistantID"];
                        cmbContainerTU.SelectedValue = reader["ContainerID"];
                        chkIsAvailableUnit.Checked = Convert.ToBoolean(reader["IsAvailable"]);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error loading transport unit details: {ex.Message}", true);
            }
        }

        private void ShowMessage(string message, bool isError)
        {
            if (isError)
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = $"Error: {message}";
                lblStatus.ForeColor = Color.Red;
            }
            else
            {
                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblStatus.Text = message;
                lblStatus.ForeColor = Color.Green;
            }
        }
        #endregion
    }
}