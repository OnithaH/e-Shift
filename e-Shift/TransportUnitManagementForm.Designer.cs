namespace e_Shift
{
    partial class TransportUnitManagementForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTransportUnits = new System.Windows.Forms.TabPage();
            this.tabLorries = new System.Windows.Forms.TabPage();
            this.tabDrivers = new System.Windows.Forms.TabPage();
            this.tabAssistants = new System.Windows.Forms.TabPage();
            this.tabContainers = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();

            // Transport Units Tab Controls
            this.groupBoxTransportUnits = new System.Windows.Forms.GroupBox();
            this.dgvTransportUnits = new System.Windows.Forms.DataGridView();
            this.groupBoxTransportUnitDetails = new System.Windows.Forms.GroupBox();
            this.lblUnitNumber = new System.Windows.Forms.Label();
            this.txtUnitNumber = new System.Windows.Forms.TextBox();
            this.lblStatusTU = new System.Windows.Forms.Label();
            this.cmbStatusTU = new System.Windows.Forms.ComboBox();
            this.lblLorryTU = new System.Windows.Forms.Label();
            this.cmbLorryTU = new System.Windows.Forms.ComboBox();
            this.lblDriverTU = new System.Windows.Forms.Label();
            this.cmbDriverTU = new System.Windows.Forms.ComboBox();
            this.lblAssistantTU = new System.Windows.Forms.Label();
            this.cmbAssistantTU = new System.Windows.Forms.ComboBox();
            this.lblContainerTU = new System.Windows.Forms.Label();
            this.cmbContainerTU = new System.Windows.Forms.ComboBox();
            this.chkIsAvailableUnit = new System.Windows.Forms.CheckBox();
            this.btnCreateTransportUnit = new System.Windows.Forms.Button();
            this.btnUpdateTransportUnit = new System.Windows.Forms.Button();
            this.btnDeleteTransportUnit = new System.Windows.Forms.Button();

            // Lorries Tab Controls
            this.groupBoxLorries = new System.Windows.Forms.GroupBox();
            this.dgvLorries = new System.Windows.Forms.DataGridView();
            this.groupBoxLorryDetails = new System.Windows.Forms.GroupBox();
            this.lblRegistrationNumber = new System.Windows.Forms.Label();
            this.txtRegistrationNumber = new System.Windows.Forms.TextBox();
            this.lblMake = new System.Windows.Forms.Label();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.lblLoadCapacity = new System.Windows.Forms.Label();
            this.numLoadCapacity = new System.Windows.Forms.NumericUpDown();
            this.lblVolumeCapacity = new System.Windows.Forms.Label();
            this.numVolumeCapacity = new System.Windows.Forms.NumericUpDown();
            this.lblFuelType = new System.Windows.Forms.Label();
            this.cmbFuelType = new System.Windows.Forms.ComboBox();
            this.lblLastMaintenance = new System.Windows.Forms.Label();
            this.dtpLastMaintenance = new System.Windows.Forms.DateTimePicker();
            this.lblStatusLorry = new System.Windows.Forms.Label();
            this.cmbStatusLorry = new System.Windows.Forms.ComboBox();
            this.chkIsAvailableLorry = new System.Windows.Forms.CheckBox();
            this.btnAddLorry = new System.Windows.Forms.Button();
            this.btnUpdateLorry = new System.Windows.Forms.Button();
            this.btnDeleteLorry = new System.Windows.Forms.Button();

            // Drivers Tab Controls
            this.groupBoxDrivers = new System.Windows.Forms.GroupBox();
            this.dgvDrivers = new System.Windows.Forms.DataGridView();
            this.groupBoxDriverDetails = new System.Windows.Forms.GroupBox();
            this.lblLicenseNumber = new System.Windows.Forms.Label();
            this.txtLicenseNumber = new System.Windows.Forms.TextBox();
            this.lblFirstNameDriver = new System.Windows.Forms.Label();
            this.txtFirstNameDriver = new System.Windows.Forms.TextBox();
            this.lblLastNameDriver = new System.Windows.Forms.Label();
            this.txtLastNameDriver = new System.Windows.Forms.TextBox();
            this.lblPhoneDriver = new System.Windows.Forms.Label();
            this.txtPhoneDriver = new System.Windows.Forms.TextBox();
            this.lblEmailDriver = new System.Windows.Forms.Label();
            this.txtEmailDriver = new System.Windows.Forms.TextBox();
            this.lblAddressDriver = new System.Windows.Forms.Label();
            this.txtAddressDriver = new System.Windows.Forms.TextBox();
            this.lblLicenseExpiry = new System.Windows.Forms.Label();
            this.dtpLicenseExpiry = new System.Windows.Forms.DateTimePicker();
            this.lblLicenseClass = new System.Windows.Forms.Label();
            this.cmbLicenseClass = new System.Windows.Forms.ComboBox();
            this.lblHourlyRateDriver = new System.Windows.Forms.Label();
            this.numHourlyRateDriver = new System.Windows.Forms.NumericUpDown();
            this.chkIsAvailableDriver = new System.Windows.Forms.CheckBox();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.btnUpdateDriver = new System.Windows.Forms.Button();
            this.btnDeleteDriver = new System.Windows.Forms.Button();

            // Assistants Tab Controls
            this.groupBoxAssistants = new System.Windows.Forms.GroupBox();
            this.dgvAssistants = new System.Windows.Forms.DataGridView();
            this.groupBoxAssistantDetails = new System.Windows.Forms.GroupBox();
            this.lblFirstNameAssistant = new System.Windows.Forms.Label();
            this.txtFirstNameAssistant = new System.Windows.Forms.TextBox();
            this.lblLastNameAssistant = new System.Windows.Forms.Label();
            this.txtLastNameAssistant = new System.Windows.Forms.TextBox();
            this.lblPhoneAssistant = new System.Windows.Forms.Label();
            this.txtPhoneAssistant = new System.Windows.Forms.TextBox();
            this.lblEmailAssistant = new System.Windows.Forms.Label();
            this.txtEmailAssistant = new System.Windows.Forms.TextBox();
            this.lblAddressAssistant = new System.Windows.Forms.Label();
            this.txtAddressAssistant = new System.Windows.Forms.TextBox();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.lblHourlyRateAssistant = new System.Windows.Forms.Label();
            this.numHourlyRateAssistant = new System.Windows.Forms.NumericUpDown();
            this.chkIsAvailableAssistant = new System.Windows.Forms.CheckBox();
            this.btnAddAssistant = new System.Windows.Forms.Button();
            this.btnUpdateAssistant = new System.Windows.Forms.Button();
            this.btnDeleteAssistant = new System.Windows.Forms.Button();

            // Containers Tab Controls
            this.groupBoxContainers = new System.Windows.Forms.GroupBox();
            this.dgvContainers = new System.Windows.Forms.DataGridView();
            this.groupBoxContainerDetails = new System.Windows.Forms.GroupBox();
            this.lblContainerNumber = new System.Windows.Forms.Label();
            this.txtContainerNumber = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.numCapacity = new System.Windows.Forms.NumericUpDown();
            this.lblLength = new System.Windows.Forms.Label();
            this.numLength = new System.Windows.Forms.NumericUpDown();
            this.lblWidth = new System.Windows.Forms.Label();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.lblHeight = new System.Windows.Forms.Label();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.lblStatusContainer = new System.Windows.Forms.Label();
            this.cmbStatusContainer = new System.Windows.Forms.ComboBox();
            this.chkIsAvailableContainer = new System.Windows.Forms.CheckBox();
            this.btnAddContainer = new System.Windows.Forms.Button();
            this.btnUpdateContainer = new System.Windows.Forms.Button();
            this.btnDeleteContainer = new System.Windows.Forms.Button();


            this.tabControl1.SuspendLayout();
            this.tabTransportUnits.SuspendLayout();
            this.groupBoxTransportUnits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportUnits)).BeginInit();
            this.groupBoxTransportUnitDetails.SuspendLayout();
            this.tabLorries.SuspendLayout();
            this.groupBoxLorries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLorries)).BeginInit();
            this.groupBoxLorryDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLoadCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVolumeCapacity)).BeginInit();
            this.tabDrivers.SuspendLayout();
            this.groupBoxDrivers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).BeginInit();
            this.groupBoxDriverDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHourlyRateDriver)).BeginInit();
            this.tabAssistants.SuspendLayout();
            this.groupBoxAssistants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssistants)).BeginInit();
            this.groupBoxAssistantDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHourlyRateAssistant)).BeginInit();
            this.tabContainers.SuspendLayout();
            this.groupBoxContainers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContainers)).BeginInit();
            this.groupBoxContainerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            this.SuspendLayout();

            // Form Properties
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Name = "TransportUnitManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-Shift - Transport Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TransportUnitManagementForm_Load);

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(311, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Transport Management";

            // tabControl1
            this.tabControl1.Controls.Add(this.tabTransportUnits);
            this.tabControl1.Controls.Add(this.tabLorries);
            this.tabControl1.Controls.Add(this.tabDrivers);
            this.tabControl1.Controls.Add(this.tabAssistants);
            this.tabControl1.Controls.Add(this.tabContainers);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl1.Location = new System.Drawing.Point(30, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1320, 650);
            this.tabControl1.TabIndex = 1;

            // ================================
            // TRANSPORT UNITS TAB
            // ================================
            this.tabTransportUnits.Controls.Add(this.groupBoxTransportUnits);
            this.tabTransportUnits.Controls.Add(this.groupBoxTransportUnitDetails);
            this.tabTransportUnits.Location = new System.Drawing.Point(4, 32);
            this.tabTransportUnits.Name = "tabTransportUnits";
            this.tabTransportUnits.Padding = new System.Windows.Forms.Padding(3);
            this.tabTransportUnits.Size = new System.Drawing.Size(1312, 614);
            this.tabTransportUnits.TabIndex = 0;
            this.tabTransportUnits.Text = "🚚 Transport Units";
            this.tabTransportUnits.UseVisualStyleBackColor = true;

            // Transport Units List Group
            this.groupBoxTransportUnits.Controls.Add(this.dgvTransportUnits);
            this.groupBoxTransportUnits.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxTransportUnits.Location = new System.Drawing.Point(20, 20);
            this.groupBoxTransportUnits.Name = "groupBoxTransportUnits";
            this.groupBoxTransportUnits.Size = new System.Drawing.Size(850, 570);
            this.groupBoxTransportUnits.TabIndex = 0;
            this.groupBoxTransportUnits.TabStop = false;
            this.groupBoxTransportUnits.Text = "Transport Units";

            this.dgvTransportUnits.AllowUserToAddRows = false;
            this.dgvTransportUnits.AllowUserToDeleteRows = false;
            this.dgvTransportUnits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransportUnits.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransportUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransportUnits.Location = new System.Drawing.Point(20, 30);
            this.dgvTransportUnits.MultiSelect = false;
            this.dgvTransportUnits.Name = "dgvTransportUnits";
            this.dgvTransportUnits.ReadOnly = true;
            this.dgvTransportUnits.RowHeadersWidth = 51;
            this.dgvTransportUnits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransportUnits.Size = new System.Drawing.Size(810, 520);
            this.dgvTransportUnits.TabIndex = 0;
            this.dgvTransportUnits.SelectionChanged += new System.EventHandler(this.dgvTransportUnits_SelectionChanged);

            // Transport Unit Details Group
            this.groupBoxTransportUnitDetails.Controls.Add(this.lblUnitNumber);
            this.groupBoxTransportUnitDetails.Controls.Add(this.txtUnitNumber);
            this.groupBoxTransportUnitDetails.Controls.Add(this.lblStatusTU);
            this.groupBoxTransportUnitDetails.Controls.Add(this.cmbStatusTU);
            this.groupBoxTransportUnitDetails.Controls.Add(this.lblLorryTU);
            this.groupBoxTransportUnitDetails.Controls.Add(this.cmbLorryTU);
            this.groupBoxTransportUnitDetails.Controls.Add(this.lblDriverTU);
            this.groupBoxTransportUnitDetails.Controls.Add(this.cmbDriverTU);
            this.groupBoxTransportUnitDetails.Controls.Add(this.lblAssistantTU);
            this.groupBoxTransportUnitDetails.Controls.Add(this.cmbAssistantTU);
            this.groupBoxTransportUnitDetails.Controls.Add(this.lblContainerTU);
            this.groupBoxTransportUnitDetails.Controls.Add(this.cmbContainerTU);
            this.groupBoxTransportUnitDetails.Controls.Add(this.chkIsAvailableUnit);
            this.groupBoxTransportUnitDetails.Controls.Add(this.btnCreateTransportUnit);
            this.groupBoxTransportUnitDetails.Controls.Add(this.btnUpdateTransportUnit);
            this.groupBoxTransportUnitDetails.Controls.Add(this.btnDeleteTransportUnit);
            this.groupBoxTransportUnitDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxTransportUnitDetails.Location = new System.Drawing.Point(890, 20);
            this.groupBoxTransportUnitDetails.Name = "groupBoxTransportUnitDetails";
            this.groupBoxTransportUnitDetails.Size = new System.Drawing.Size(400, 570);
            this.groupBoxTransportUnitDetails.TabIndex = 1;
            this.groupBoxTransportUnitDetails.TabStop = false;
            this.groupBoxTransportUnitDetails.Text = "Transport Unit Details";

            // Transport Unit Controls
            this.lblUnitNumber.AutoSize = true;
            this.lblUnitNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUnitNumber.Location = new System.Drawing.Point(20, 40);
            this.lblUnitNumber.Name = "lblUnitNumber";
            this.lblUnitNumber.Size = new System.Drawing.Size(98, 20);
            this.lblUnitNumber.TabIndex = 0;
            this.lblUnitNumber.Text = "Unit Number:";

            this.txtUnitNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUnitNumber.Location = new System.Drawing.Point(130, 37);
            this.txtUnitNumber.Name = "txtUnitNumber";
            this.txtUnitNumber.Size = new System.Drawing.Size(240, 27);
            this.txtUnitNumber.TabIndex = 1;

            this.lblStatusTU.AutoSize = true;
            this.lblStatusTU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatusTU.Location = new System.Drawing.Point(20, 80);
            this.lblStatusTU.Name = "lblStatusTU";
            this.lblStatusTU.Size = new System.Drawing.Size(52, 20);
            this.lblStatusTU.TabIndex = 2;
            this.lblStatusTU.Text = "Status:";

            this.cmbStatusTU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusTU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbStatusTU.FormattingEnabled = true;
            this.cmbStatusTU.Items.AddRange(new object[] { "Available", "Assigned", "In Transit", "Maintenance" });
            this.cmbStatusTU.Location = new System.Drawing.Point(130, 77);
            this.cmbStatusTU.Name = "cmbStatusTU";
            this.cmbStatusTU.Size = new System.Drawing.Size(240, 28);
            this.cmbStatusTU.TabIndex = 3;

            this.lblLorryTU.AutoSize = true;
            this.lblLorryTU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLorryTU.Location = new System.Drawing.Point(20, 120);
            this.lblLorryTU.Name = "lblLorryTU";
            this.lblLorryTU.Size = new System.Drawing.Size(45, 20);
            this.lblLorryTU.TabIndex = 4;
            this.lblLorryTU.Text = "Lorry:";

            this.cmbLorryTU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLorryTU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbLorryTU.FormattingEnabled = true;
            this.cmbLorryTU.Location = new System.Drawing.Point(130, 117);
            this.cmbLorryTU.Name = "cmbLorryTU";
            this.cmbLorryTU.Size = new System.Drawing.Size(240, 28);
            this.cmbLorryTU.TabIndex = 5;

            this.lblDriverTU.AutoSize = true;
            this.lblDriverTU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDriverTU.Location = new System.Drawing.Point(20, 160);
            this.lblDriverTU.Name = "lblDriverTU";
            this.lblDriverTU.Size = new System.Drawing.Size(51, 20);
            this.lblDriverTU.TabIndex = 6;
            this.lblDriverTU.Text = "Driver:";

            this.cmbDriverTU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDriverTU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbDriverTU.FormattingEnabled = true;
            this.cmbDriverTU.Location = new System.Drawing.Point(130, 157);
            this.cmbDriverTU.Name = "cmbDriverTU";
            this.cmbDriverTU.Size = new System.Drawing.Size(240, 28);
            this.cmbDriverTU.TabIndex = 7;

            this.lblAssistantTU.AutoSize = true;
            this.lblAssistantTU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAssistantTU.Location = new System.Drawing.Point(20, 200);
            this.lblAssistantTU.Name = "lblAssistantTU";
            this.lblAssistantTU.Size = new System.Drawing.Size(71, 20);
            this.lblAssistantTU.TabIndex = 8;
            this.lblAssistantTU.Text = "Assistant:";

            this.cmbAssistantTU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssistantTU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbAssistantTU.FormattingEnabled = true;
            this.cmbAssistantTU.Location = new System.Drawing.Point(130, 197);
            this.cmbAssistantTU.Name = "cmbAssistantTU";
            this.cmbAssistantTU.Size = new System.Drawing.Size(240, 28);
            this.cmbAssistantTU.TabIndex = 9;

            this.lblContainerTU.AutoSize = true;
            this.lblContainerTU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblContainerTU.Location = new System.Drawing.Point(20, 240);
            this.lblContainerTU.Name = "lblContainerTU";
            this.lblContainerTU.Size = new System.Drawing.Size(78, 20);
            this.lblContainerTU.TabIndex = 10;
            this.lblContainerTU.Text = "Container:";

            this.cmbContainerTU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContainerTU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbContainerTU.FormattingEnabled = true;
            this.cmbContainerTU.Location = new System.Drawing.Point(130, 237);
            this.cmbContainerTU.Name = "cmbContainerTU";
            this.cmbContainerTU.Size = new System.Drawing.Size(240, 28);
            this.cmbContainerTU.TabIndex = 11;

            this.chkIsAvailableUnit.AutoSize = true;
            this.chkIsAvailableUnit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkIsAvailableUnit.Location = new System.Drawing.Point(130, 280);
            this.chkIsAvailableUnit.Name = "chkIsAvailableUnit";
            this.chkIsAvailableUnit.Size = new System.Drawing.Size(100, 24);
            this.chkIsAvailableUnit.TabIndex = 12;
            this.chkIsAvailableUnit.Text = "Is Available";
            this.chkIsAvailableUnit.UseVisualStyleBackColor = true;

            this.btnCreateTransportUnit.BackColor = System.Drawing.Color.LightGreen;
            this.btnCreateTransportUnit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCreateTransportUnit.Location = new System.Drawing.Point(20, 480);
            this.btnCreateTransportUnit.Name = "btnCreateTransportUnit";
            this.btnCreateTransportUnit.Size = new System.Drawing.Size(110, 40);
            this.btnCreateTransportUnit.TabIndex = 13;
            this.btnCreateTransportUnit.Text = "➕ Create";
            this.btnCreateTransportUnit.UseVisualStyleBackColor = false;
            this.btnCreateTransportUnit.Click += new System.EventHandler(this.btnCreateTransportUnit_Click);

            this.btnUpdateTransportUnit.BackColor = System.Drawing.Color.LightBlue;
            this.btnUpdateTransportUnit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateTransportUnit.Location = new System.Drawing.Point(140, 480);
            this.btnUpdateTransportUnit.Name = "btnUpdateTransportUnit";
            this.btnUpdateTransportUnit.Size = new System.Drawing.Size(110, 40);
            this.btnUpdateTransportUnit.TabIndex = 14;
            this.btnUpdateTransportUnit.Text = "✏️ Update";
            this.btnUpdateTransportUnit.UseVisualStyleBackColor = false;
            this.btnUpdateTransportUnit.Click += new System.EventHandler(this.btnUpdateTransportUnit_Click);

            this.btnDeleteTransportUnit.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeleteTransportUnit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteTransportUnit.Location = new System.Drawing.Point(260, 480);
            this.btnDeleteTransportUnit.Name = "btnDeleteTransportUnit";
            this.btnDeleteTransportUnit.Size = new System.Drawing.Size(110, 40);
            this.btnDeleteTransportUnit.TabIndex = 15;
            this.btnDeleteTransportUnit.Text = "🗑️ Delete";
            this.btnDeleteTransportUnit.UseVisualStyleBackColor = false;
            this.btnDeleteTransportUnit.Click += new System.EventHandler(this.btnDeleteTransportUnit_Click);

            // ================================
            // LORRIES TAB (Simplified setup - similar structure for all tabs)
            // ================================
            this.SetupLorriesTab();
            this.SetupDriversTab();
            this.SetupAssistantsTab();
            this.SetupContainersTab();

            // Form Controls
            this.btnRefresh.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(1100, 740);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(130, 40);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "🔄 Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.btnClose.BackColor = System.Drawing.Color.LightCoral;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(1250, 740);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 40);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "❌ Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatus.Location = new System.Drawing.Point(30, 750);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(55, 23);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Ready";

            // Add controls to form
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblStatus);

            // Cleanup
            this.tabControl1.ResumeLayout(false);
            this.tabTransportUnits.ResumeLayout(false);
            this.groupBoxTransportUnits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportUnits)).EndInit();
            this.groupBoxTransportUnitDetails.ResumeLayout(false);
            this.groupBoxTransportUnitDetails.PerformLayout();
            this.tabLorries.ResumeLayout(false);
            this.groupBoxLorries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLorries)).EndInit();
            this.groupBoxLorryDetails.ResumeLayout(false);
            this.groupBoxLorryDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLoadCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVolumeCapacity)).EndInit();
            this.tabDrivers.ResumeLayout(false);
            this.groupBoxDrivers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).EndInit();
            this.groupBoxDriverDetails.ResumeLayout(false);
            this.groupBoxDriverDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHourlyRateDriver)).EndInit();
            this.tabAssistants.ResumeLayout(false);
            this.groupBoxAssistants.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssistants)).EndInit();
            this.groupBoxAssistantDetails.ResumeLayout(false);
            this.groupBoxAssistantDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHourlyRateAssistant)).EndInit();
            this.tabContainers.ResumeLayout(false);
            this.groupBoxContainers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContainers)).EndInit();
            this.groupBoxContainerDetails.ResumeLayout(false);
            this.groupBoxContainerDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void SetupLorriesTab()
        {
            this.tabLorries.Controls.Add(this.groupBoxLorries);
            this.tabLorries.Controls.Add(this.groupBoxLorryDetails);
            this.tabLorries.Location = new System.Drawing.Point(4, 32);
            this.tabLorries.Name = "tabLorries";
            this.tabLorries.Size = new System.Drawing.Size(1312, 614);
            this.tabLorries.TabIndex = 1;
            this.tabLorries.Text = "🚛 Lorries";
            this.tabLorries.UseVisualStyleBackColor = true;

            this.groupBoxLorries.Controls.Add(this.dgvLorries);
            this.groupBoxLorries.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxLorries.Location = new System.Drawing.Point(20, 20);
            this.groupBoxLorries.Name = "groupBoxLorries";
            this.groupBoxLorries.Size = new System.Drawing.Size(850, 570);
            this.groupBoxLorries.TabIndex = 0;
            this.groupBoxLorries.TabStop = false;
            this.groupBoxLorries.Text = "Lorries";

            this.dgvLorries.AllowUserToAddRows = false;
            this.dgvLorries.AllowUserToDeleteRows = false;
            this.dgvLorries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLorries.BackgroundColor = System.Drawing.Color.White;
            this.dgvLorries.Location = new System.Drawing.Point(20, 30);
            this.dgvLorries.Name = "dgvLorries";
            this.dgvLorries.ReadOnly = true;
            this.dgvLorries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLorries.Size = new System.Drawing.Size(810, 520);
            this.dgvLorries.SelectionChanged += new System.EventHandler(this.dgvLorries_SelectionChanged);

            // Lorry Details Setup
            this.SetupLorryDetailsPanel();
        }

        private void SetupLorryDetailsPanel()
        {
            this.groupBoxLorryDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxLorryDetails.Location = new System.Drawing.Point(890, 20);
            this.groupBoxLorryDetails.Name = "groupBoxLorryDetails";
            this.groupBoxLorryDetails.Size = new System.Drawing.Size(400, 570);
            this.groupBoxLorryDetails.TabIndex = 1;
            this.groupBoxLorryDetails.TabStop = false;
            this.groupBoxLorryDetails.Text = "Lorry Details";

            // Initialize controls
            this.txtRegistrationNumber = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.numLoadCapacity = new System.Windows.Forms.NumericUpDown();
            this.numVolumeCapacity = new System.Windows.Forms.NumericUpDown();
            this.cmbFuelType = new System.Windows.Forms.ComboBox();
            this.dtpLastMaintenance = new System.Windows.Forms.DateTimePicker();
            this.cmbStatusLorry = new System.Windows.Forms.ComboBox();
            this.chkIsAvailableLorry = new System.Windows.Forms.CheckBox();
            this.btnAddLorry = new System.Windows.Forms.Button();
            this.btnUpdateLorry = new System.Windows.Forms.Button();
            this.btnDeleteLorry = new System.Windows.Forms.Button();

            // Setup ComboBox items
            this.cmbFuelType.Items.AddRange(new object[] { "Diesel", "Petrol", "Electric", "Hybrid" });
            this.cmbStatusLorry.Items.AddRange(new object[] { "Available", "In Use", "Maintenance", "Out of Service" });

            // Setup numeric controls
            this.numYear.Minimum = 1990;
            this.numYear.Maximum = 2030;
            this.numYear.Value = 2020;
            this.numLoadCapacity.Maximum = 50000;
            this.numLoadCapacity.DecimalPlaces = 2;
            this.numVolumeCapacity.Maximum = 1000;
            this.numVolumeCapacity.DecimalPlaces = 2;

            // Labels for Lorry Details
            this.lblRegistrationNumber = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblLoadCapacity = new System.Windows.Forms.Label();
            this.lblVolumeCapacity = new System.Windows.Forms.Label();
            this.lblFuelType = new System.Windows.Forms.Label();
            this.lblLastMaintenance = new System.Windows.Forms.Label();
            this.lblStatusLorry = new System.Windows.Forms.Label();

            // Setup Labels and Controls Layout for Lorry Details
            this.lblRegistrationNumber.AutoSize = true;
            this.lblRegistrationNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRegistrationNumber.Location = new System.Drawing.Point(20, 40);
            this.lblRegistrationNumber.Text = "Registration No:";

            this.txtRegistrationNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRegistrationNumber.Location = new System.Drawing.Point(150, 37);
            this.txtRegistrationNumber.Size = new System.Drawing.Size(220, 27);

            this.lblMake.AutoSize = true;
            this.lblMake.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMake.Location = new System.Drawing.Point(20, 80);
            this.lblMake.Text = "Make:";

            this.txtMake.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMake.Location = new System.Drawing.Point(150, 77);
            this.txtMake.Size = new System.Drawing.Size(220, 27);

            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblModel.Location = new System.Drawing.Point(20, 120);
            this.lblModel.Text = "Model:";

            this.txtModel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtModel.Location = new System.Drawing.Point(150, 117);
            this.txtModel.Size = new System.Drawing.Size(220, 27);

            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblYear.Location = new System.Drawing.Point(20, 160);
            this.lblYear.Text = "Year:";

            this.numYear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numYear.Location = new System.Drawing.Point(150, 157);
            this.numYear.Size = new System.Drawing.Size(100, 27);

            this.lblLoadCapacity.AutoSize = true;
            this.lblLoadCapacity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLoadCapacity.Location = new System.Drawing.Point(20, 200);
            this.lblLoadCapacity.Text = "Load Capacity:";

            this.numLoadCapacity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numLoadCapacity.Location = new System.Drawing.Point(150, 197);
            this.numLoadCapacity.Size = new System.Drawing.Size(120, 27);

            this.lblVolumeCapacity.AutoSize = true;
            this.lblVolumeCapacity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVolumeCapacity.Location = new System.Drawing.Point(20, 240);
            this.lblVolumeCapacity.Text = "Volume Capacity:";

            this.numVolumeCapacity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numVolumeCapacity.Location = new System.Drawing.Point(150, 237);
            this.numVolumeCapacity.Size = new System.Drawing.Size(120, 27);

            this.lblFuelType.AutoSize = true;
            this.lblFuelType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFuelType.Location = new System.Drawing.Point(20, 280);
            this.lblFuelType.Text = "Fuel Type:";

            this.cmbFuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuelType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbFuelType.Location = new System.Drawing.Point(150, 277);
            this.cmbFuelType.Size = new System.Drawing.Size(120, 28);

            this.lblLastMaintenance.AutoSize = true;
            this.lblLastMaintenance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLastMaintenance.Location = new System.Drawing.Point(20, 320);
            this.lblLastMaintenance.Text = "Last Maintenance:";

            this.dtpLastMaintenance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpLastMaintenance.Location = new System.Drawing.Point(150, 317);
            this.dtpLastMaintenance.Size = new System.Drawing.Size(220, 27);

            this.lblStatusLorry.AutoSize = true;
            this.lblStatusLorry.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatusLorry.Location = new System.Drawing.Point(20, 360);
            this.lblStatusLorry.Text = "Status:";

            this.cmbStatusLorry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusLorry.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbStatusLorry.Location = new System.Drawing.Point(150, 357);
            this.cmbStatusLorry.Size = new System.Drawing.Size(120, 28);

            this.chkIsAvailableLorry.AutoSize = true;
            this.chkIsAvailableLorry.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkIsAvailableLorry.Location = new System.Drawing.Point(150, 400);
            this.chkIsAvailableLorry.Text = "Is Available";

            // Lorry Buttons
            this.btnAddLorry.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddLorry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddLorry.Location = new System.Drawing.Point(20, 480);
            this.btnAddLorry.Size = new System.Drawing.Size(110, 40);
            this.btnAddLorry.Text = "➕ Add";
            this.btnAddLorry.UseVisualStyleBackColor = false;
            this.btnAddLorry.Click += new System.EventHandler(this.btnAddLorry_Click);

            this.btnUpdateLorry.BackColor = System.Drawing.Color.LightBlue;
            this.btnUpdateLorry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateLorry.Location = new System.Drawing.Point(140, 480);
            this.btnUpdateLorry.Size = new System.Drawing.Size(110, 40);
            this.btnUpdateLorry.Text = "✏️ Update";
            this.btnUpdateLorry.UseVisualStyleBackColor = false;
            this.btnUpdateLorry.Click += new System.EventHandler(this.btnUpdateLorry_Click);

            this.btnDeleteLorry.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeleteLorry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteLorry.Location = new System.Drawing.Point(260, 480);
            this.btnDeleteLorry.Size = new System.Drawing.Size(110, 40);
            this.btnDeleteLorry.Text = "🗑️ Delete";
            this.btnDeleteLorry.UseVisualStyleBackColor = false;
            this.btnDeleteLorry.Click += new System.EventHandler(this.btnDeleteLorry_Click);

            // Add all controls to Lorry Details group
            this.groupBoxLorryDetails.Controls.Add(this.lblRegistrationNumber);
            this.groupBoxLorryDetails.Controls.Add(this.txtRegistrationNumber);
            this.groupBoxLorryDetails.Controls.Add(this.lblMake);
            this.groupBoxLorryDetails.Controls.Add(this.txtMake);
            this.groupBoxLorryDetails.Controls.Add(this.lblModel);
            this.groupBoxLorryDetails.Controls.Add(this.txtModel);
            this.groupBoxLorryDetails.Controls.Add(this.lblYear);
            this.groupBoxLorryDetails.Controls.Add(this.numYear);
            this.groupBoxLorryDetails.Controls.Add(this.lblLoadCapacity);
            this.groupBoxLorryDetails.Controls.Add(this.numLoadCapacity);
            this.groupBoxLorryDetails.Controls.Add(this.lblVolumeCapacity);
            this.groupBoxLorryDetails.Controls.Add(this.numVolumeCapacity);
            this.groupBoxLorryDetails.Controls.Add(this.lblFuelType);
            this.groupBoxLorryDetails.Controls.Add(this.cmbFuelType);
            this.groupBoxLorryDetails.Controls.Add(this.lblLastMaintenance);
            this.groupBoxLorryDetails.Controls.Add(this.dtpLastMaintenance);
            this.groupBoxLorryDetails.Controls.Add(this.lblStatusLorry);
            this.groupBoxLorryDetails.Controls.Add(this.cmbStatusLorry);
            this.groupBoxLorryDetails.Controls.Add(this.chkIsAvailableLorry);
            this.groupBoxLorryDetails.Controls.Add(this.btnAddLorry);
            this.groupBoxLorryDetails.Controls.Add(this.btnUpdateLorry);
            this.groupBoxLorryDetails.Controls.Add(this.btnDeleteLorry);
        }

        private void SetupDriversTab()
        {
            this.tabDrivers.Controls.Add(this.groupBoxDrivers);
            this.tabDrivers.Controls.Add(this.groupBoxDriverDetails);
            this.tabDrivers.Location = new System.Drawing.Point(4, 32);
            this.tabDrivers.Name = "tabDrivers";
            this.tabDrivers.Size = new System.Drawing.Size(1312, 614);
            this.tabDrivers.TabIndex = 2;
            this.tabDrivers.Text = "👨‍💼 Drivers";
            this.tabDrivers.UseVisualStyleBackColor = true;

            this.groupBoxDrivers.Controls.Add(this.dgvDrivers);
            this.groupBoxDrivers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxDrivers.Location = new System.Drawing.Point(20, 20);
            this.groupBoxDrivers.Name = "groupBoxDrivers";
            this.groupBoxDrivers.Size = new System.Drawing.Size(850, 570);
            this.groupBoxDrivers.TabIndex = 0;
            this.groupBoxDrivers.TabStop = false;
            this.groupBoxDrivers.Text = "Drivers";

            this.dgvDrivers.AllowUserToAddRows = false;
            this.dgvDrivers.AllowUserToDeleteRows = false;
            this.dgvDrivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDrivers.BackgroundColor = System.Drawing.Color.White;
            this.dgvDrivers.Location = new System.Drawing.Point(20, 30);
            this.dgvDrivers.Name = "dgvDrivers";
            this.dgvDrivers.ReadOnly = true;
            this.dgvDrivers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrivers.Size = new System.Drawing.Size(810, 520);
            this.dgvDrivers.SelectionChanged += new System.EventHandler(this.dgvDrivers_SelectionChanged);

            this.SetupDriverDetailsPanel();
        }

        private void SetupDriverDetailsPanel()
        {
            this.groupBoxDriverDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxDriverDetails.Location = new System.Drawing.Point(890, 20);
            this.groupBoxDriverDetails.Name = "groupBoxDriverDetails";
            this.groupBoxDriverDetails.Size = new System.Drawing.Size(400, 570);
            this.groupBoxDriverDetails.TabIndex = 1;
            this.groupBoxDriverDetails.TabStop = false;
            this.groupBoxDriverDetails.Text = "Driver Details";

            // Initialize driver controls
            this.txtLicenseNumber = new System.Windows.Forms.TextBox();
            this.txtFirstNameDriver = new System.Windows.Forms.TextBox();
            this.txtLastNameDriver = new System.Windows.Forms.TextBox();
            this.txtPhoneDriver = new System.Windows.Forms.TextBox();
            this.txtEmailDriver = new System.Windows.Forms.TextBox();
            this.txtAddressDriver = new System.Windows.Forms.TextBox();
            this.dtpLicenseExpiry = new System.Windows.Forms.DateTimePicker();
            this.cmbLicenseClass = new System.Windows.Forms.ComboBox();
            this.numHourlyRateDriver = new System.Windows.Forms.NumericUpDown();
            this.chkIsAvailableDriver = new System.Windows.Forms.CheckBox();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.btnUpdateDriver = new System.Windows.Forms.Button();
            this.btnDeleteDriver = new System.Windows.Forms.Button();

            // Setup ComboBox items
            this.cmbLicenseClass.Items.AddRange(new object[] { "Light", "Heavy", "Commercial" });

            // Setup numeric controls
            this.numHourlyRateDriver.Maximum = 10000;
            this.numHourlyRateDriver.DecimalPlaces = 2;

            // Labels for Driver Details
            this.lblLicenseNumber = new System.Windows.Forms.Label();
            this.lblFirstNameDriver = new System.Windows.Forms.Label();
            this.lblLastNameDriver = new System.Windows.Forms.Label();
            this.lblPhoneDriver = new System.Windows.Forms.Label();
            this.lblEmailDriver = new System.Windows.Forms.Label();
            this.lblAddressDriver = new System.Windows.Forms.Label();
            this.lblLicenseExpiry = new System.Windows.Forms.Label();
            this.lblLicenseClass = new System.Windows.Forms.Label();
            this.lblHourlyRateDriver = new System.Windows.Forms.Label();

            // Setup Layout - Driver Details
            this.SetupDriverControlsLayout();
        }

        private void SetupDriverControlsLayout()
        {
            // License Number
            this.lblLicenseNumber.AutoSize = true;
            this.lblLicenseNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLicenseNumber.Location = new System.Drawing.Point(20, 40);
            this.lblLicenseNumber.Text = "License Number:";
            this.txtLicenseNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLicenseNumber.Location = new System.Drawing.Point(130, 37);
            this.txtLicenseNumber.Size = new System.Drawing.Size(240, 27);

            // First Name
            this.lblFirstNameDriver.AutoSize = true;
            this.lblFirstNameDriver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFirstNameDriver.Location = new System.Drawing.Point(20, 80);
            this.lblFirstNameDriver.Text = "First Name:";
            this.txtFirstNameDriver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFirstNameDriver.Location = new System.Drawing.Point(130, 77);
            this.txtFirstNameDriver.Size = new System.Drawing.Size(240, 27);

            // Last Name
            this.lblLastNameDriver.AutoSize = true;
            this.lblLastNameDriver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLastNameDriver.Location = new System.Drawing.Point(20, 120);
            this.lblLastNameDriver.Text = "Last Name:";
            this.txtLastNameDriver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLastNameDriver.Location = new System.Drawing.Point(130, 117);
            this.txtLastNameDriver.Size = new System.Drawing.Size(240, 27);

            // Phone
            this.lblPhoneDriver.AutoSize = true;
            this.lblPhoneDriver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhoneDriver.Location = new System.Drawing.Point(20, 160);
            this.lblPhoneDriver.Text = "Phone:";
            this.txtPhoneDriver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhoneDriver.Location = new System.Drawing.Point(130, 157);
            this.txtPhoneDriver.Size = new System.Drawing.Size(240, 27);

            // Email
            this.lblEmailDriver.AutoSize = true;
            this.lblEmailDriver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmailDriver.Location = new System.Drawing.Point(20, 200);
            this.lblEmailDriver.Text = "Email:";
            this.txtEmailDriver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmailDriver.Location = new System.Drawing.Point(130, 197);
            this.txtEmailDriver.Size = new System.Drawing.Size(240, 27);

            // Address
            this.lblAddressDriver.AutoSize = true;
            this.lblAddressDriver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAddressDriver.Location = new System.Drawing.Point(20, 240);
            this.lblAddressDriver.Text = "Address:";
            this.txtAddressDriver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddressDriver.Location = new System.Drawing.Point(130, 237);
            this.txtAddressDriver.Size = new System.Drawing.Size(240, 27);

            // License Expiry
            this.lblLicenseExpiry.AutoSize = true;
            this.lblLicenseExpiry.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLicenseExpiry.Location = new System.Drawing.Point(20, 280);
            this.lblLicenseExpiry.Text = "License Expiry:";
            this.dtpLicenseExpiry.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpLicenseExpiry.Location = new System.Drawing.Point(130, 277);
            this.dtpLicenseExpiry.Size = new System.Drawing.Size(200, 27);

            // License Class
            this.lblLicenseClass.AutoSize = true;
            this.lblLicenseClass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLicenseClass.Location = new System.Drawing.Point(20, 320);
            this.lblLicenseClass.Text = "License Class:";
            this.cmbLicenseClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLicenseClass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbLicenseClass.Location = new System.Drawing.Point(130, 317);
            this.cmbLicenseClass.Size = new System.Drawing.Size(120, 28);

            // Hourly Rate
            this.lblHourlyRateDriver.AutoSize = true;
            this.lblHourlyRateDriver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHourlyRateDriver.Location = new System.Drawing.Point(20, 360);
            this.lblHourlyRateDriver.Text = "Hourly Rate:";
            this.numHourlyRateDriver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numHourlyRateDriver.Location = new System.Drawing.Point(130, 357);
            this.numHourlyRateDriver.Size = new System.Drawing.Size(120, 27);

            // Is Available
            this.chkIsAvailableDriver.AutoSize = true;
            this.chkIsAvailableDriver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkIsAvailableDriver.Location = new System.Drawing.Point(130, 400);
            this.chkIsAvailableDriver.Text = "Is Available";

            // Driver Buttons
            this.btnAddDriver.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddDriver.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddDriver.Location = new System.Drawing.Point(20, 480);
            this.btnAddDriver.Size = new System.Drawing.Size(110, 40);
            this.btnAddDriver.Text = "➕ Add";
            this.btnAddDriver.UseVisualStyleBackColor = false;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);

            this.btnUpdateDriver.BackColor = System.Drawing.Color.LightBlue;
            this.btnUpdateDriver.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateDriver.Location = new System.Drawing.Point(140, 480);
            this.btnUpdateDriver.Size = new System.Drawing.Size(110, 40);
            this.btnUpdateDriver.Text = "✏️ Update";
            this.btnUpdateDriver.UseVisualStyleBackColor = false;
            this.btnUpdateDriver.Click += new System.EventHandler(this.btnUpdateDriver_Click);

            this.btnDeleteDriver.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeleteDriver.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteDriver.Location = new System.Drawing.Point(260, 480);
            this.btnDeleteDriver.Size = new System.Drawing.Size(110, 40);
            this.btnDeleteDriver.Text = "🗑️ Delete";
            this.btnDeleteDriver.UseVisualStyleBackColor = false;
            this.btnDeleteDriver.Click += new System.EventHandler(this.btnDeleteDriver_Click);

            // Add all controls to Driver Details group
            this.groupBoxDriverDetails.Controls.Add(this.lblLicenseNumber);
            this.groupBoxDriverDetails.Controls.Add(this.txtLicenseNumber);
            this.groupBoxDriverDetails.Controls.Add(this.lblFirstNameDriver);
            this.groupBoxDriverDetails.Controls.Add(this.txtFirstNameDriver);
            this.groupBoxDriverDetails.Controls.Add(this.lblLastNameDriver);
            this.groupBoxDriverDetails.Controls.Add(this.txtLastNameDriver);
            this.groupBoxDriverDetails.Controls.Add(this.lblPhoneDriver);
            this.groupBoxDriverDetails.Controls.Add(this.txtPhoneDriver);
            this.groupBoxDriverDetails.Controls.Add(this.lblEmailDriver);
            this.groupBoxDriverDetails.Controls.Add(this.txtEmailDriver);
            this.groupBoxDriverDetails.Controls.Add(this.lblAddressDriver);
            this.groupBoxDriverDetails.Controls.Add(this.txtAddressDriver);
            this.groupBoxDriverDetails.Controls.Add(this.lblLicenseExpiry);
            this.groupBoxDriverDetails.Controls.Add(this.dtpLicenseExpiry);
            this.groupBoxDriverDetails.Controls.Add(this.lblLicenseClass);
            this.groupBoxDriverDetails.Controls.Add(this.cmbLicenseClass);
            this.groupBoxDriverDetails.Controls.Add(this.lblHourlyRateDriver);
            this.groupBoxDriverDetails.Controls.Add(this.numHourlyRateDriver);
            this.groupBoxDriverDetails.Controls.Add(this.chkIsAvailableDriver);
            this.groupBoxDriverDetails.Controls.Add(this.btnAddDriver);
            this.groupBoxDriverDetails.Controls.Add(this.btnUpdateDriver);
            this.groupBoxDriverDetails.Controls.Add(this.btnDeleteDriver);
        }

        private void SetupAssistantsTab()
        {
            this.tabAssistants.Controls.Add(this.groupBoxAssistants);
            this.tabAssistants.Controls.Add(this.groupBoxAssistantDetails);
            this.tabAssistants.Location = new System.Drawing.Point(4, 32);
            this.tabAssistants.Name = "tabAssistants";
            this.tabAssistants.Size = new System.Drawing.Size(1312, 614);
            this.tabAssistants.TabIndex = 3;
            this.tabAssistants.Text = "👷‍♂️ Assistants";
            this.tabAssistants.UseVisualStyleBackColor = true;

            this.groupBoxAssistants.Controls.Add(this.dgvAssistants);
            this.groupBoxAssistants.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxAssistants.Location = new System.Drawing.Point(20, 20);
            this.groupBoxAssistants.Name = "groupBoxAssistants";
            this.groupBoxAssistants.Size = new System.Drawing.Size(850, 570);
            this.groupBoxAssistants.TabIndex = 0;
            this.groupBoxAssistants.TabStop = false;
            this.groupBoxAssistants.Text = "Assistants";

            this.dgvAssistants.AllowUserToAddRows = false;
            this.dgvAssistants.AllowUserToDeleteRows = false;
            this.dgvAssistants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssistants.BackgroundColor = System.Drawing.Color.White;
            this.dgvAssistants.Location = new System.Drawing.Point(20, 30);
            this.dgvAssistants.Name = "dgvAssistants";
            this.dgvAssistants.ReadOnly = true;
            this.dgvAssistants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssistants.Size = new System.Drawing.Size(810, 520);
            this.dgvAssistants.SelectionChanged += new System.EventHandler(this.dgvAssistants_SelectionChanged);

            this.SetupAssistantDetailsPanel();
        }

        private void SetupAssistantDetailsPanel()
        {
            this.groupBoxAssistantDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxAssistantDetails.Location = new System.Drawing.Point(890, 20);
            this.groupBoxAssistantDetails.Name = "groupBoxAssistantDetails";
            this.groupBoxAssistantDetails.Size = new System.Drawing.Size(400, 570);
            this.groupBoxAssistantDetails.TabIndex = 1;
            this.groupBoxAssistantDetails.TabStop = false;
            this.groupBoxAssistantDetails.Text = "Assistant Details";

            // Initialize assistant controls
            this.txtFirstNameAssistant = new System.Windows.Forms.TextBox();
            this.txtLastNameAssistant = new System.Windows.Forms.TextBox();
            this.txtPhoneAssistant = new System.Windows.Forms.TextBox();
            this.txtEmailAssistant = new System.Windows.Forms.TextBox();
            this.txtAddressAssistant = new System.Windows.Forms.TextBox();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.numHourlyRateAssistant = new System.Windows.Forms.NumericUpDown();
            this.chkIsAvailableAssistant = new System.Windows.Forms.CheckBox();
            this.btnAddAssistant = new System.Windows.Forms.Button();
            this.btnUpdateAssistant = new System.Windows.Forms.Button();
            this.btnDeleteAssistant = new System.Windows.Forms.Button();

            // Setup numeric controls
            this.numHourlyRateAssistant.Maximum = 10000;
            this.numHourlyRateAssistant.DecimalPlaces = 2;

            // Labels for Assistant Details
            this.lblFirstNameAssistant = new System.Windows.Forms.Label();
            this.lblLastNameAssistant = new System.Windows.Forms.Label();
            this.lblPhoneAssistant = new System.Windows.Forms.Label();
            this.lblEmailAssistant = new System.Windows.Forms.Label();
            this.lblAddressAssistant = new System.Windows.Forms.Label();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.lblHourlyRateAssistant = new System.Windows.Forms.Label();

            this.SetupAssistantControlsLayout();
        }

        private void SetupAssistantControlsLayout()
        {
            // First Name
            this.lblFirstNameAssistant.AutoSize = true;
            this.lblFirstNameAssistant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFirstNameAssistant.Location = new System.Drawing.Point(20, 40);
            this.lblFirstNameAssistant.Text = "First Name:";
            this.txtFirstNameAssistant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFirstNameAssistant.Location = new System.Drawing.Point(130, 37);
            this.txtFirstNameAssistant.Size = new System.Drawing.Size(240, 27);

            // Last Name
            this.lblLastNameAssistant.AutoSize = true;
            this.lblLastNameAssistant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLastNameAssistant.Location = new System.Drawing.Point(20, 80);
            this.lblLastNameAssistant.Text = "Last Name:";
            this.txtLastNameAssistant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLastNameAssistant.Location = new System.Drawing.Point(130, 77);
            this.txtLastNameAssistant.Size = new System.Drawing.Size(240, 27);

            // Phone
            this.lblPhoneAssistant.AutoSize = true;
            this.lblPhoneAssistant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhoneAssistant.Location = new System.Drawing.Point(20, 120);
            this.lblPhoneAssistant.Text = "Phone:";
            this.txtPhoneAssistant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhoneAssistant.Location = new System.Drawing.Point(130, 117);
            this.txtPhoneAssistant.Size = new System.Drawing.Size(240, 27);

            // Email
            this.lblEmailAssistant.AutoSize = true;
            this.lblEmailAssistant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmailAssistant.Location = new System.Drawing.Point(20, 160);
            this.lblEmailAssistant.Text = "Email:";
            this.txtEmailAssistant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmailAssistant.Location = new System.Drawing.Point(130, 157);
            this.txtEmailAssistant.Size = new System.Drawing.Size(240, 27);

            // Address
            this.lblAddressAssistant.AutoSize = true;
            this.lblAddressAssistant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAddressAssistant.Location = new System.Drawing.Point(20, 200);
            this.lblAddressAssistant.Text = "Address:";
            this.txtAddressAssistant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddressAssistant.Location = new System.Drawing.Point(130, 197);
            this.txtAddressAssistant.Size = new System.Drawing.Size(240, 27);

            // Hire Date
            this.lblHireDate.AutoSize = true;
            this.lblHireDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHireDate.Location = new System.Drawing.Point(20, 240);
            this.lblHireDate.Text = "Hire Date:";
            this.dtpHireDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpHireDate.Location = new System.Drawing.Point(130, 237);
            this.dtpHireDate.Size = new System.Drawing.Size(200, 27);

            // Hourly Rate
            this.lblHourlyRateAssistant.AutoSize = true;
            this.lblHourlyRateAssistant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHourlyRateAssistant.Location = new System.Drawing.Point(20, 280);
            this.lblHourlyRateAssistant.Text = "Hourly Rate:";
            this.numHourlyRateAssistant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numHourlyRateAssistant.Location = new System.Drawing.Point(130, 277);
            this.numHourlyRateAssistant.Size = new System.Drawing.Size(120, 27);

            // Is Available
            this.chkIsAvailableAssistant.AutoSize = true;
            this.chkIsAvailableAssistant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkIsAvailableAssistant.Location = new System.Drawing.Point(130, 320);
            this.chkIsAvailableAssistant.Text = "Is Available";

            // Assistant Buttons
            this.btnAddAssistant.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddAssistant.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddAssistant.Location = new System.Drawing.Point(20, 480);
            this.btnAddAssistant.Size = new System.Drawing.Size(110, 40);
            this.btnAddAssistant.Text = "➕ Add";
            this.btnAddAssistant.UseVisualStyleBackColor = false;
            this.btnAddAssistant.Click += new System.EventHandler(this.btnAddAssistant_Click);

            this.btnUpdateAssistant.BackColor = System.Drawing.Color.LightBlue;
            this.btnUpdateAssistant.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateAssistant.Location = new System.Drawing.Point(140, 480);
            this.btnUpdateAssistant.Size = new System.Drawing.Size(110, 40);
            this.btnUpdateAssistant.Text = "✏️ Update";
            this.btnUpdateAssistant.UseVisualStyleBackColor = false;
            this.btnUpdateAssistant.Click += new System.EventHandler(this.btnUpdateAssistant_Click);

            this.btnDeleteAssistant.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeleteAssistant.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteAssistant.Location = new System.Drawing.Point(260, 480);
            this.btnDeleteAssistant.Size = new System.Drawing.Size(110, 40);
            this.btnDeleteAssistant.Text = "🗑️ Delete";
            this.btnDeleteAssistant.UseVisualStyleBackColor = false;
            this.btnDeleteAssistant.Click += new System.EventHandler(this.btnDeleteAssistant_Click);

            // Add all controls to Assistant Details group
            this.groupBoxAssistantDetails.Controls.Add(this.lblFirstNameAssistant);
            this.groupBoxAssistantDetails.Controls.Add(this.txtFirstNameAssistant);
            this.groupBoxAssistantDetails.Controls.Add(this.lblLastNameAssistant);
            this.groupBoxAssistantDetails.Controls.Add(this.txtLastNameAssistant);
            this.groupBoxAssistantDetails.Controls.Add(this.lblPhoneAssistant);
            this.groupBoxAssistantDetails.Controls.Add(this.txtPhoneAssistant);
            this.groupBoxAssistantDetails.Controls.Add(this.lblEmailAssistant);
            this.groupBoxAssistantDetails.Controls.Add(this.txtEmailAssistant);
            this.groupBoxAssistantDetails.Controls.Add(this.lblAddressAssistant);
            this.groupBoxAssistantDetails.Controls.Add(this.txtAddressAssistant);
            this.groupBoxAssistantDetails.Controls.Add(this.lblHireDate);
            this.groupBoxAssistantDetails.Controls.Add(this.dtpHireDate);
            this.groupBoxAssistantDetails.Controls.Add(this.lblHourlyRateAssistant);
            this.groupBoxAssistantDetails.Controls.Add(this.numHourlyRateAssistant);
            this.groupBoxAssistantDetails.Controls.Add(this.chkIsAvailableAssistant);
            this.groupBoxAssistantDetails.Controls.Add(this.btnAddAssistant);
            this.groupBoxAssistantDetails.Controls.Add(this.btnUpdateAssistant);
            this.groupBoxAssistantDetails.Controls.Add(this.btnDeleteAssistant);
        }

        private void SetupContainersTab()
        {
            this.tabContainers.Controls.Add(this.groupBoxContainers);
            this.tabContainers.Controls.Add(this.groupBoxContainerDetails);
            this.tabContainers.Location = new System.Drawing.Point(4, 32);
            this.tabContainers.Name = "tabContainers";
            this.tabContainers.Size = new System.Drawing.Size(1312, 614);
            this.tabContainers.TabIndex = 4;
            this.tabContainers.Text = "📦 Containers";
            this.tabContainers.UseVisualStyleBackColor = true;

            this.groupBoxContainers.Controls.Add(this.dgvContainers);
            this.groupBoxContainers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxContainers.Location = new System.Drawing.Point(20, 20);
            this.groupBoxContainers.Name = "groupBoxContainers";
            this.groupBoxContainers.Size = new System.Drawing.Size(850, 570);
            this.groupBoxContainers.TabIndex = 0;
            this.groupBoxContainers.TabStop = false;
            this.groupBoxContainers.Text = "Containers";

            this.dgvContainers.AllowUserToAddRows = false;
            this.dgvContainers.AllowUserToDeleteRows = false;
            this.dgvContainers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContainers.BackgroundColor = System.Drawing.Color.White;
            this.dgvContainers.Location = new System.Drawing.Point(20, 30);
            this.dgvContainers.Name = "dgvContainers";
            this.dgvContainers.ReadOnly = true;
            this.dgvContainers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContainers.Size = new System.Drawing.Size(810, 520);
            this.dgvContainers.SelectionChanged += new System.EventHandler(this.dgvContainers_SelectionChanged);

            this.SetupContainerDetailsPanel();
        }

        private void SetupContainerDetailsPanel()
        {
            this.groupBoxContainerDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxContainerDetails.Location = new System.Drawing.Point(890, 20);
            this.groupBoxContainerDetails.Name = "groupBoxContainerDetails";
            this.groupBoxContainerDetails.Size = new System.Drawing.Size(400, 570);
            this.groupBoxContainerDetails.TabIndex = 1;
            this.groupBoxContainerDetails.TabStop = false;
            this.groupBoxContainerDetails.Text = "Container Details";

            // Initialize container controls
            this.txtContainerNumber = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.numCapacity = new System.Windows.Forms.NumericUpDown();
            this.numLength = new System.Windows.Forms.NumericUpDown();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.cmbStatusContainer = new System.Windows.Forms.ComboBox();
            this.chkIsAvailableContainer = new System.Windows.Forms.CheckBox();
            this.btnAddContainer = new System.Windows.Forms.Button();
            this.btnUpdateContainer = new System.Windows.Forms.Button();
            this.btnDeleteContainer = new System.Windows.Forms.Button();

            // Setup ComboBox items
            this.cmbType.Items.AddRange(new object[] { "Standard", "Refrigerated", "Fragile", "Liquid", "Special" });
            this.cmbMaterial.Items.AddRange(new object[] { "Steel", "Aluminum", "Fiberglass", "Wood" });
            this.cmbStatusContainer.Items.AddRange(new object[] { "Available", "In Use", "Maintenance", "Damaged" });

            // Setup numeric controls
            this.numCapacity.Maximum = 1000;
            this.numCapacity.DecimalPlaces = 2;
            this.numLength.Maximum = 20;
            this.numLength.DecimalPlaces = 2;
            this.numWidth.Maximum = 10;
            this.numWidth.DecimalPlaces = 2;
            this.numHeight.Maximum = 10;
            this.numHeight.DecimalPlaces = 2;

            // Labels for Container Details
            this.lblContainerNumber = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.lblStatusContainer = new System.Windows.Forms.Label();

            this.SetupContainerControlsLayout();
        }

        private void SetupContainerControlsLayout()
        {
            // Container Number
            this.lblContainerNumber.AutoSize = true;
            this.lblContainerNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblContainerNumber.Location = new System.Drawing.Point(20, 40);
            this.lblContainerNumber.Text = "Container No:";
            this.txtContainerNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtContainerNumber.Location = new System.Drawing.Point(130, 37);
            this.txtContainerNumber.Size = new System.Drawing.Size(240, 27);

            // Type
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblType.Location = new System.Drawing.Point(20, 80);
            this.lblType.Text = "Type:";
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbType.Location = new System.Drawing.Point(130, 77);
            this.cmbType.Size = new System.Drawing.Size(150, 28);

            // Capacity
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCapacity.Location = new System.Drawing.Point(20, 120);
            this.lblCapacity.Text = "Capacity (m³):";
            this.numCapacity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numCapacity.Location = new System.Drawing.Point(130, 117);
            this.numCapacity.Size = new System.Drawing.Size(120, 27);

            // Length
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLength.Location = new System.Drawing.Point(20, 160);
            this.lblLength.Text = "Length (m):";
            this.numLength.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numLength.Location = new System.Drawing.Point(130, 157);
            this.numLength.Size = new System.Drawing.Size(120, 27);

            // Width
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblWidth.Location = new System.Drawing.Point(20, 200);
            this.lblWidth.Text = "Width (m):";
            this.numWidth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numWidth.Location = new System.Drawing.Point(130, 197);
            this.numWidth.Size = new System.Drawing.Size(120, 27);

            // Height
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHeight.Location = new System.Drawing.Point(20, 240);
            this.lblHeight.Text = "Height (m):";
            this.numHeight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numHeight.Location = new System.Drawing.Point(130, 237);
            this.numHeight.Size = new System.Drawing.Size(120, 27);

            // Material
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaterial.Location = new System.Drawing.Point(20, 280);
            this.lblMaterial.Text = "Material:";
            this.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbMaterial.Location = new System.Drawing.Point(130, 277);
            this.cmbMaterial.Size = new System.Drawing.Size(150, 28);

            // Status
            this.lblStatusContainer.AutoSize = true;
            this.lblStatusContainer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatusContainer.Location = new System.Drawing.Point(20, 320);
            this.lblStatusContainer.Text = "Status:";
            this.cmbStatusContainer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusContainer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbStatusContainer.Location = new System.Drawing.Point(130, 317);
            this.cmbStatusContainer.Size = new System.Drawing.Size(150, 28);

            // Is Available
            this.chkIsAvailableContainer.AutoSize = true;
            this.chkIsAvailableContainer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkIsAvailableContainer.Location = new System.Drawing.Point(130, 360);
            this.chkIsAvailableContainer.Text = "Is Available";

            // Container Buttons
            this.btnAddContainer.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddContainer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddContainer.Location = new System.Drawing.Point(20, 480);
            this.btnAddContainer.Size = new System.Drawing.Size(110, 40);
            this.btnAddContainer.Text = "➕ Add";
            this.btnAddContainer.UseVisualStyleBackColor = false;
            this.btnAddContainer.Click += new System.EventHandler(this.btnAddContainer_Click);

            this.btnUpdateContainer.BackColor = System.Drawing.Color.LightBlue;
            this.btnUpdateContainer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateContainer.Location = new System.Drawing.Point(140, 480);
            this.btnUpdateContainer.Size = new System.Drawing.Size(110, 40);
            this.btnUpdateContainer.Text = "✏️ Update";
            this.btnUpdateContainer.UseVisualStyleBackColor = false;
            this.btnUpdateContainer.Click += new System.EventHandler(this.btnUpdateContainer_Click);

            this.btnDeleteContainer.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeleteContainer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteContainer.Location = new System.Drawing.Point(260, 480);
            this.btnDeleteContainer.Size = new System.Drawing.Size(110, 40);
            this.btnDeleteContainer.Text = "🗑️ Delete";
            this.btnDeleteContainer.UseVisualStyleBackColor = false;
            this.btnDeleteContainer.Click += new System.EventHandler(this.btnDeleteContainer_Click);

            // Add all controls to Container Details group
            this.groupBoxContainerDetails.Controls.Add(this.lblContainerNumber);
            this.groupBoxContainerDetails.Controls.Add(this.txtContainerNumber);
            this.groupBoxContainerDetails.Controls.Add(this.lblType);
            this.groupBoxContainerDetails.Controls.Add(this.cmbType);
            this.groupBoxContainerDetails.Controls.Add(this.lblCapacity);
            this.groupBoxContainerDetails.Controls.Add(this.numCapacity);
            this.groupBoxContainerDetails.Controls.Add(this.lblLength);
            this.groupBoxContainerDetails.Controls.Add(this.numLength);
            this.groupBoxContainerDetails.Controls.Add(this.lblWidth);
            this.groupBoxContainerDetails.Controls.Add(this.numWidth);
            this.groupBoxContainerDetails.Controls.Add(this.lblHeight);
            this.groupBoxContainerDetails.Controls.Add(this.numHeight);
            this.groupBoxContainerDetails.Controls.Add(this.lblMaterial);
            this.groupBoxContainerDetails.Controls.Add(this.cmbMaterial);
            this.groupBoxContainerDetails.Controls.Add(this.lblStatusContainer);
            this.groupBoxContainerDetails.Controls.Add(this.cmbStatusContainer);
            this.groupBoxContainerDetails.Controls.Add(this.chkIsAvailableContainer);
            this.groupBoxContainerDetails.Controls.Add(this.btnAddContainer);
            this.groupBoxContainerDetails.Controls.Add(this.btnUpdateContainer);
            this.groupBoxContainerDetails.Controls.Add(this.btnDeleteContainer);
        }

        #endregion

        // Field declarations for all controls
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTransportUnits;
        private System.Windows.Forms.TabPage tabLorries;
        private System.Windows.Forms.TabPage tabDrivers;
        private System.Windows.Forms.TabPage tabAssistants;
        private System.Windows.Forms.TabPage tabContainers;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblStatus;

        // Transport Units Tab Controls
        private System.Windows.Forms.GroupBox groupBoxTransportUnits;
        private System.Windows.Forms.DataGridView dgvTransportUnits;
        private System.Windows.Forms.GroupBox groupBoxTransportUnitDetails;
        private System.Windows.Forms.Label lblUnitNumber;
        private System.Windows.Forms.TextBox txtUnitNumber;
        private System.Windows.Forms.Label lblStatusTU;
        private System.Windows.Forms.ComboBox cmbStatusTU;
        private System.Windows.Forms.Label lblLorryTU;
        private System.Windows.Forms.ComboBox cmbLorryTU;
        private System.Windows.Forms.Label lblDriverTU;
        private System.Windows.Forms.ComboBox cmbDriverTU;
        private System.Windows.Forms.Label lblAssistantTU;
        private System.Windows.Forms.ComboBox cmbAssistantTU;
        private System.Windows.Forms.Label lblContainerTU;
        private System.Windows.Forms.ComboBox cmbContainerTU;
        private System.Windows.Forms.CheckBox chkIsAvailableUnit;
        private System.Windows.Forms.Button btnCreateTransportUnit;
        private System.Windows.Forms.Button btnUpdateTransportUnit;
        private System.Windows.Forms.Button btnDeleteTransportUnit;

        // Lorries Tab Controls
        private System.Windows.Forms.GroupBox groupBoxLorries;
        private System.Windows.Forms.DataGridView dgvLorries;
        private System.Windows.Forms.GroupBox groupBoxLorryDetails;
        private System.Windows.Forms.Label lblRegistrationNumber;
        private System.Windows.Forms.TextBox txtRegistrationNumber;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.Label lblLoadCapacity;
        private System.Windows.Forms.NumericUpDown numLoadCapacity;
        private System.Windows.Forms.Label lblVolumeCapacity;
        private System.Windows.Forms.NumericUpDown numVolumeCapacity;
        private System.Windows.Forms.Label lblFuelType;
        private System.Windows.Forms.ComboBox cmbFuelType;
        private System.Windows.Forms.Label lblLastMaintenance;
        private System.Windows.Forms.DateTimePicker dtpLastMaintenance;
        private System.Windows.Forms.Label lblStatusLorry;
        private System.Windows.Forms.ComboBox cmbStatusLorry;
        private System.Windows.Forms.CheckBox chkIsAvailableLorry;
        private System.Windows.Forms.Button btnAddLorry;
        private System.Windows.Forms.Button btnUpdateLorry;
        private System.Windows.Forms.Button btnDeleteLorry;

        // Drivers Tab Controls
        private System.Windows.Forms.GroupBox groupBoxDrivers;
        private System.Windows.Forms.DataGridView dgvDrivers;
        private System.Windows.Forms.GroupBox groupBoxDriverDetails;
        private System.Windows.Forms.Label lblLicenseNumber;
        private System.Windows.Forms.TextBox txtLicenseNumber;
        private System.Windows.Forms.Label lblFirstNameDriver;
        private System.Windows.Forms.TextBox txtFirstNameDriver;
        private System.Windows.Forms.Label lblLastNameDriver;
        private System.Windows.Forms.TextBox txtLastNameDriver;
        private System.Windows.Forms.Label lblPhoneDriver;
        private System.Windows.Forms.TextBox txtPhoneDriver;
        private System.Windows.Forms.Label lblEmailDriver;
        private System.Windows.Forms.TextBox txtEmailDriver;
        private System.Windows.Forms.Label lblAddressDriver;
        private System.Windows.Forms.TextBox txtAddressDriver;
        private System.Windows.Forms.Label lblLicenseExpiry;
        private System.Windows.Forms.DateTimePicker dtpLicenseExpiry;
        private System.Windows.Forms.Label lblLicenseClass;
        private System.Windows.Forms.ComboBox cmbLicenseClass;
        private System.Windows.Forms.Label lblHourlyRateDriver;
        private System.Windows.Forms.NumericUpDown numHourlyRateDriver;
        private System.Windows.Forms.CheckBox chkIsAvailableDriver;
        private System.Windows.Forms.Button btnAddDriver;
        private System.Windows.Forms.Button btnUpdateDriver;
        private System.Windows.Forms.Button btnDeleteDriver;

        // Assistants Tab Controls
        private System.Windows.Forms.GroupBox groupBoxAssistants;
        private System.Windows.Forms.DataGridView dgvAssistants;
        private System.Windows.Forms.GroupBox groupBoxAssistantDetails;
        private System.Windows.Forms.Label lblFirstNameAssistant;
        private System.Windows.Forms.TextBox txtFirstNameAssistant;
        private System.Windows.Forms.Label lblLastNameAssistant;
        private System.Windows.Forms.TextBox txtLastNameAssistant;
        private System.Windows.Forms.Label lblPhoneAssistant;
        private System.Windows.Forms.TextBox txtPhoneAssistant;
        private System.Windows.Forms.Label lblEmailAssistant;
        private System.Windows.Forms.TextBox txtEmailAssistant;
        private System.Windows.Forms.Label lblAddressAssistant;
        private System.Windows.Forms.TextBox txtAddressAssistant;
        private System.Windows.Forms.Label lblHireDate;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.Label lblHourlyRateAssistant;
        private System.Windows.Forms.NumericUpDown numHourlyRateAssistant;
        private System.Windows.Forms.CheckBox chkIsAvailableAssistant;
        private System.Windows.Forms.Button btnAddAssistant;
        private System.Windows.Forms.Button btnUpdateAssistant;
        private System.Windows.Forms.Button btnDeleteAssistant;

        // Containers Tab Controls
        private System.Windows.Forms.GroupBox groupBoxContainers;
        private System.Windows.Forms.DataGridView dgvContainers;
        private System.Windows.Forms.GroupBox groupBoxContainerDetails;
        private System.Windows.Forms.Label lblContainerNumber;
        private System.Windows.Forms.TextBox txtContainerNumber;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.NumericUpDown numCapacity;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.NumericUpDown numLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Label lblStatusContainer;
        private System.Windows.Forms.ComboBox cmbStatusContainer;
        private System.Windows.Forms.CheckBox chk