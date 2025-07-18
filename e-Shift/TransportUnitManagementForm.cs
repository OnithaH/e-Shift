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
                dgvDrivers.Columns["LicenseExpiry"].HeaderText = "License Exp.";
                dgvDrivers.Columns["LicenseClass"].HeaderText = "Class";
                dgvDrivers.Columns["HourlyRate"].HeaderText = "Rate";
            }
        }

        private void LoadDriverDetails(int driverID)
        {
            try
            {
                string query = @"SELECT * FROM Drivers WHERE DriverID = @DriverID";
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
            if (cmbLicenseClass.SelectedIndex == -1)
            {
                ShowMessage("License Class is required", true);
                cmbLicenseClass.Focus();
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
                dgvAssistants.Columns["HourlyRate"].HeaderText = "Rate";
            }
        }

        private void LoadAssistantDetails(int assistantID)
        {
            try
            {
                string query = @"SELECT * FROM Assistants WHERE AssistantID = @AssistantID";
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
            return true;
        }
        #endregion

        #region Containers Management
        private void LoadContainers()
        {
            try
            {
                string query = @"SELECT ContainerID, ContainerNumber, Type, Capacity, Status, IsAvailable FROM Containers WHERE IsDeleted = 0 ORDER BY ContainerNumber";
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
            }
        }

        private void LoadContainerDetails(int containerID)
        {
            try
            {
                string query = @"SELECT * FROM Containers WHERE ContainerID = @ContainerID";
                SqlParameter[] parameters = { new SqlParameter("@ContainerID", containerID) };

                using (SqlDataReader reader = DatabaseConnection.ExecuteReader(query, parameters))
                {
                    if (reader != null && reader.Read())
                    {
                        txtContainerNumber.Text = reader["ContainerNumber"].ToString();
                        cmbType.Text = reader["Type"].ToString();
                        numCapacity.Value = Convert.ToDecimal(reader["Capacity"]);
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

        private void ClearContainerForm()
        {
            selectedContainerID = 0;
            txtContainerNumber.Clear();
            cmbType.SelectedIndex = -1;
            numCapacity.Value = 0;
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
                    string query = @"INSERT INTO Lorries (RegistrationNumber, Make, Model, Year, LoadCapacity, VolumeCapacity, FuelType, LastMaintenanceDate, Status, IsAvailable, CreatedDate, ModifiedDate) 
                           VALUES (@RegistrationNumber, @Make, @Model, @Year, @LoadCapacity, @VolumeCapacity, @FuelType, @LastMaintenanceDate, @Status, @IsAvailable, @CreatedDate, @ModifiedDate)";

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



        // Driver Events
        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            if (ValidateDriverData())
            {
                ShowMessage("Driver added successfully!", false);
                LoadDrivers();
                LoadComboBoxData();
                ClearDriverForm();
            }
        }

        private void btnUpdateDriver_Click(object sender, EventArgs e)
        {
            if (selectedDriverID > 0 && ValidateDriverData())
            {
                ShowMessage("Driver updated successfully!", false);
                LoadDrivers();
                LoadComboBoxData();
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
                    ShowMessage("Driver deleted successfully!", false);
                    LoadDrivers();
                    LoadComboBoxData();
                    ClearDriverForm();
                }
            }
        }




        // Assistant Events
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
                        new SqlParameter("@Email", txtEmailAssistant.Text.Trim()),
                        new SqlParameter("@Address", txtAddressAssistant.Text.Trim()),
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




        // Container Events
        private void btnAddContainer_Click(object sender, EventArgs e)
        {
            if (ValidateContainerData())
            {
                try
                {
                    string query = @"INSERT INTO Containers (ContainerNumber, Type, Capacity, Status, IsAvailable, CreatedDate, ModifiedDate) 
                           VALUES (@ContainerNumber, @Type, @Capacity, @Status, @IsAvailable, @CreatedDate, @ModifiedDate)";

                    SqlParameter[] parameters = {
                        new SqlParameter("@ContainerNumber", txtContainerNumber.Text.Trim()),
                        new SqlParameter("@Type", cmbType.Text),
                        new SqlParameter("@Capacity", numCapacity.Value),
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
            if (selectedContainerID > 0 && ValidateContainerData())
            {
                try
                {
                    string query = @"UPDATE Containers SET ContainerNumber = @ContainerNumber, Type = @Type, 
                           Capacity = @Capacity, Status = @Status, IsAvailable = @IsAvailable, 
                           ModifiedDate = @ModifiedDate WHERE ContainerID = @ContainerID";

                    SqlParameter[] parameters = {
                        new SqlParameter("@ContainerNumber", txtContainerNumber.Text.Trim()),
                        new SqlParameter("@Type", cmbType.Text),
                        new SqlParameter("@Capacity", numCapacity.Value),
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