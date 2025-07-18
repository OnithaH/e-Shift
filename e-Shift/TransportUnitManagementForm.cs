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
                MessageBox.Show("Access denied! Admin privileges required.",
                              "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            ClearTransportUnitForm();
            ClearLorryForm();
            ClearDriverForm();
            ClearAssistantForm();
            ClearContainerForm();
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
                string query = @"
                    SELECT UnitNumber, Status, LorryID, DriverID, AssistantID, ContainerID, IsAvailable
                    FROM TransportUnits 
                    WHERE TransportUnitID = @TransportUnitID";

                SqlParameter[] parameters = {
                    new SqlParameter("@TransportUnitID", transportUnitID)
                };

                using (SqlDataReader reader = DatabaseConnection.ExecuteReader(query, parameters))
                {
                    if (reader != null && reader.Read())
                    {
                        txtUnitNumber.Text = reader["UnitNumber"].ToString();
                        cmbStatusTU.Text = reader["Status"].ToString();

                        // Set combo box values
                        if (reader["LorryID"] != DBNull.Value)
                            cmbLorryTU.SelectedValue = Convert.ToInt32(reader["LorryID"]);
                        if (reader["DriverID"] != DBNull.Value)
                            cmbDriverTU.SelectedValue = Convert.ToInt32(reader["DriverID"]);
                        if (reader["AssistantID"] != DBNull.Value)
                            cmbAssistantTU.SelectedValue = Convert.ToInt32(reader["AssistantID"]);
                        if (reader["ContainerID"] != DBNull.Value)
                            cmbContainerTU.SelectedValue = Convert.ToInt32(reader["ContainerID"]);

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
                    string query = @"
                        INSERT INTO TransportUnits (UnitNumber, Status, LorryID, DriverID, AssistantID, ContainerID, IsAvailable)
                        VALUES (@UnitNumber, @Status, @LorryID, @DriverID, @AssistantID, @ContainerID, @IsAvailable)";

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
                    }
                }
                catch (Exception ex)
                {
                    ShowMessage($"Error updating transport unit: {ex.Message}", true);
                }
            }
            else
            {
                ShowMessage("Please select a transport unit to update", true);
            }
        }

        private void btnDeleteTransportUnit_Click(object sender, EventArgs e)
        {
            if (selectedTransportUnitID > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this transport unit?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string query = @"
                            UPDATE TransportUnits 
                            SET IsDeleted = 1, ModifiedDate = @ModifiedDate 
                            WHERE TransportUnitID = @TransportUnitID";

                        SqlParameter[] parameters = {
                            new SqlParameter("@ModifiedDate", DateTime.Now),
                            new SqlParameter("@TransportUnitID", selectedTransportUnitID)
                        };

                        int deleteResult = DatabaseConnection.ExecuteNonQuery(query, parameters);
                        if (deleteResult > 0)
                        {
                            ShowMessage("Transport unit deleted successfully!", false);
                            LoadTransportUnits();
                            ClearTransportUnitForm();
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

            if (cmbLorryTU.SelectedValue == null)
            {
                ShowMessage("Lorry selection is required", true);
                cmbLorryTU.Focus();
                return false;
            }

            if (cmbDriverTU.SelectedValue == null)
            {
                ShowMessage("Driver selection is required", true);
                cmbDriverTU.Focus();
                return false;
            }

            if (cmbAssistantTU.SelectedValue == null)
            {
                ShowMessage("Assistant selection is required", true);
                cmbAssistantTU.Focus();
                return false;
            }

            if (cmbContainerTU.SelectedValue == null)
            {
                ShowMessage("Container selection is required", true);
                cmbContainerTU.Focus();
                return false;
            }

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
                string query = @"
                    SELECT LorryID, RegistrationNumber, Make, Model, Year, 
                           LoadCapacity, VolumeCapacity, FuelType, Status, IsAvailable
                    FROM Lorries 
                    WHERE IsDeleted = 0 
                    ORDER BY RegistrationNumber";

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
                dgvLorries.Columns["Make"].HeaderText = "Make";
                dgvLorries.Columns["Model"].HeaderText = "Model";
                dgvLorries.Columns["Year"].HeaderText = "Year";
                dgvLorries.Columns["LoadCapacity"].HeaderText = "Load Cap.";
                dgvLorries.Columns["VolumeCapacity"].HeaderText = "Volume Cap.";
                dgvLorries.Columns["FuelType"].HeaderText = "Fuel";
                dgvLorries.Columns["Status"].HeaderText = "Status";
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
                string query = @"
                    SELECT RegistrationNumber, Make, Model, Year, LoadCapacity, VolumeCapacity, 
                           FuelType, LastMaintenance, Status, IsAvailable
                    FROM Lorries 
                    WHERE LorryID = @LorryID";

                SqlParameter[] parameters = {
                    new SqlParameter("@LorryID", lorryID)
                };

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

                        if (reader["LastMaintenance"] != DBNull.Value)
                            dtpLastMaintenance.Value = Convert.ToDateTime(reader["LastMaintenance"]);
                        else
                            dtpLastMaintenance.Value = DateTime.Now;

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
                    string query = @"
                        INSERT INTO Lorries (RegistrationNumber, Make, Model, Year, LoadCapacity, 
                                           VolumeCapacity, FuelType, LastMaintenance, Status, IsAvailable)
                        VALUES (@RegistrationNumber, @Make, @Model, @Year, @LoadCapacity, 
                               @VolumeCapacity, @FuelType, @LastMaintenance, @Status, @IsAvailable)";

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
                        LoadComboBoxData(); // Refresh combo boxes
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
                    string query = @"
                        UPDATE Lorries 
                        SET RegistrationNumber = @RegistrationNumber, Make = @Make, Model = @Model,
                            Year = @Year, LoadCapacity = @LoadCapacity, VolumeCapacity = @VolumeCapacity,
                            FuelType = @FuelType, LastMaintenance = @LastMaintenance, Status = @Status,
                            IsAvailable = @IsAvailable, ModifiedDate = @ModifiedDate
                        WHERE LorryID = @LorryID";

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
                        LoadComboBoxData(); // Refresh combo boxes
                    }
                }
                catch (Exception ex)
                {
                    ShowMessage($"Error updating lorry: {ex.Message}", true);
                }
            }
            else
            {
                ShowMessage("Please select a lorry to update", true);
            }
        }

        private void btnDeleteLorry_Click(object sender, EventArgs e)
        {
            if (selectedLorryID > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this lorry?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string query = @"
                            UPDATE Lorries 
                            SET IsDeleted = 1, ModifiedDate = @ModifiedDate 
                            WHERE LorryID = @LorryID";

                        SqlParameter[] parameters = {
                            new SqlParameter("@ModifiedDate", DateTime.Now),
                            new SqlParameter("@LorryID", selectedLorryID)
                        };

                        int deleteResult = DatabaseConnection.ExecuteNonQuery(query, parameters);
                        if (deleteResult > 0)
                        {
                            ShowMessage("Lorry deleted successfully!", false);
                            LoadLorries();
                            LoadComboBoxData(); // Refresh combo boxes
                            ClearLorryForm();
                        }
                    }
                    catch (Exception ex)
                    {
                        ShowMessage($"Error deleting lorry: {ex.Message}", true);
                    }
                }
            }
            else
            {
                ShowMessage("Please select a lorry to delete", true);
            }
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
                string query = @"
                    SELECT DriverID, LicenseNumber, FirstName, LastName, Phone, Email,
                           LicenseExpiry, LicenseClass, HourlyRate, IsAvailable
                    FROM Drivers 
                    WHERE IsDeleted = 0 
                    ORDER BY FirstName, LastName";

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
                dgvDrivers.Columns["Phone"].HeaderText = "Phone";
                dgvDrivers.Columns["Email"].HeaderText = "Email";
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
                string query = @"
                    SELECT LicenseNumber, FirstName, LastName, Phone, Email, Address,
                           LicenseExpiry, LicenseClass, HourlyRate, IsAvailable
                    FROM Drivers 
                    WHERE DriverID = @DriverID";

                SqlParameter[] parameters = {
                    new SqlParameter("@DriverID", driverID)
                };

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

        #endregion

        #region Assistants Management

        private void LoadAssistants()
        {
            try
            {
                string query = @"
                    SELECT AssistantID, FirstName, LastName, Phone, Email, 
                           HireDate, HourlyRate, IsAvailable
                    FROM Assistants 
                    WHERE IsDeleted = 0 
                    ORDER BY FirstName, LastName";

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
                dgvAssistants.Columns["HireDate"].HeaderText = "Hire Date";
                dgvAssistants.Columns["HourlyRate"].HeaderText = "Rate/Hour";
                dgvAssistants.Columns["IsAvailable"].HeaderText = "Available";
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

        #endregion

        #region Containers Management

        private void LoadContainers()
        {
            try
            {
                string query = @"
                    SELECT ContainerID, ContainerNumber, Type, Capacity, Length, Width, Height,
                           Material, Status, IsAvailable
                    FROM Containers 
                    WHERE IsDeleted = 0 
                    ORDER BY ContainerNumber";

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
                dgvContainers.Columns["Capacity"].HeaderText = "Capacity";
                dgvContainers.Columns["Length"].HeaderText = "Length";
                dgvContainers.Columns["Width"].HeaderText = "Width";
                dgvContainers.Columns["Height"].HeaderText = "Height";
                dgvContainers.Columns["Material"].HeaderText = "Material";
                dgvContainers.Columns["Status"].HeaderText = "Status";
                dgvContainers.Columns["IsAvailable"].HeaderText = "Available";
            }
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
                string query = @"
                    SELECT LorryID, CONCAT(RegistrationNumber, ' - ', Make, ' ', Model) as DisplayText
                    FROM Lorries 
                    WHERE IsDeleted = 0 AND IsAvailable = 1
                    ORDER BY RegistrationNumber";

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
                string query = @"
                    SELECT DriverID, CONCAT(FirstName, ' ', LastName, ' (', LicenseNumber, ')') as DisplayText
                    FROM Drivers 
                    WHERE IsDeleted = 0 AND IsAvailable = 1
                    ORDER BY FirstName, LastName";

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
                string query = @"
                    SELECT AssistantID, CONCAT(FirstName, ' ', LastName) as DisplayText
                    FROM Assistants 
                    WHERE IsDeleted = 0 AND IsAvailable = 1
                    ORDER BY FirstName, LastName";

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
                string query = @"
                    SELECT ContainerID, CONCAT(ContainerNumber, ' - ', Type, ' (', Capacity, ' m³)') as DisplayText
                    FROM Containers 
                    WHERE IsDeleted = 0 AND IsAvailable = 1
                    ORDER BY ContainerNumber";

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

        // Placeholder event handlers for other tabs - you can implement these based on the same patterns
        private void dgvAssistants_SelectionChanged(object sender, EventArgs e) { }
        private void dgvContainers_SelectionChanged(object sender, EventArgs e) { }
        private void btnAddDriver_Click(object sender, EventArgs e) { }
        private void btnUpdateDriver_Click(object sender, EventArgs e) { }
        private void btnDeleteDriver_Click(object sender, EventArgs e) { }
        private void btnAddAssistant_Click(object sender, EventArgs e) { }
        private void btnUpdateAssistant_Click(object sender, EventArgs e) { }
        private void btnDeleteAssistant_Click(object sender, EventArgs e) { }
        private void btnAddContainer_Click(object sender, EventArgs e) { }
        private void btnUpdateContainer_Click(object sender, EventArgs e) { }
        private void btnDeleteContainer_Click(object sender, EventArgs e) { }
    }
}
@UnitNumber", txtUnitNumber.Text.Trim()),
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
            string query = @"
                        UPDATE TransportUnits 
                        SET UnitNumber = @UnitNumber, Status = @Status, LorryID = @LorryID, 
                            DriverID = @DriverID, AssistantID = @AssistantID, ContainerID = @ContainerID,
                            IsAvailable = @IsAvailable, ModifiedDate = @ModifiedDate
                        WHERE TransportUnitID = @TransportUnitID";

            SqlParameter[] parameters = {
                        new SqlParameter("