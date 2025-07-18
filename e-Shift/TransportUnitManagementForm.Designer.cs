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
        /*
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
            this.lblStatusContainer = new System.Windows.Forms.Label();
            this.cmbStatusContainer = new System.Windows.Forms.ComboBox();
            this.chkIsAvailableContainer = new System.Windows.Forms.CheckBox();
            this.btnAddContainer = new System.Windows.Forms.Button();
            this.btnUpdateContainer = new System.Windows.Forms.Button();
            this.btnDeleteContainer = new System.Windows.Forms.Button();

            this.tabControl1.SuspendLayout();
            this.SuspendLayout();

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblStatus);
            this.Name = "TransportUnitManagementForm";
            this.Text = "Transport Unit Management";
            this.Load += new System.EventHandler(this.TransportUnitManagementForm_Load);

            // Title Label
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Transport Unit Management";

            // TabControl
            this.tabControl1.Controls.Add(this.tabTransportUnits);
            this.tabControl1.Controls.Add(this.tabLorries);
            this.tabControl1.Controls.Add(this.tabDrivers);
            this.tabControl1.Controls.Add(this.tabAssistants);
            this.tabControl1.Controls.Add(this.tabContainers);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl1.Location = new System.Drawing.Point(20, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1350, 650);
            this.tabControl1.TabIndex = 1;

            // Transport Units Tab
            this.tabTransportUnits.Controls.Add(this.groupBoxTransportUnits);
            this.tabTransportUnits.Controls.Add(this.groupBoxTransportUnitDetails);
            this.tabTransportUnits.Location = new System.Drawing.Point(4, 32);
            this.tabTransportUnits.Name = "tabTransportUnits";
            this.tabTransportUnits.Size = new System.Drawing.Size(1342, 614);
            this.tabTransportUnits.TabIndex = 0;
            this.tabTransportUnits.Text = "🚛 Transport Units";
            this.tabTransportUnits.UseVisualStyleBackColor = true;

            // Transport Units GroupBox
            this.groupBoxTransportUnits.Controls.Add(this.dgvTransportUnits);
            this.groupBoxTransportUnits.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxTransportUnits.Location = new System.Drawing.Point(20, 20);
            this.groupBoxTransportUnits.Name = "groupBoxTransportUnits";
            this.groupBoxTransportUnits.Size = new System.Drawing.Size(900, 580);
            this.groupBoxTransportUnits.TabIndex = 0;
            this.groupBoxTransportUnits.TabStop = false;
            this.groupBoxTransportUnits.Text = "Transport Units List";

            // Transport Units DataGridView
            this.dgvTransportUnits.AllowUserToAddRows = false;
            this.dgvTransportUnits.AllowUserToDeleteRows = false;
            this.dgvTransportUnits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransportUnits.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTransportUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransportUnits.Location = new System.Drawing.Point(20, 30);
            this.dgvTransportUnits.MultiSelect = false;
            this.dgvTransportUnits.Name = "dgvTransportUnits";
            this.dgvTransportUnits.ReadOnly = true;
            this.dgvTransportUnits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransportUnits.Size = new System.Drawing.Size(860, 530);
            this.dgvTransportUnits.TabIndex = 0;
            this.dgvTransportUnits.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransportUnits_CellClick);

            // Transport Unit Details GroupBox
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
            this.groupBoxTransportUnitDetails.Location = new System.Drawing.Point(940, 20);
            this.groupBoxTransportUnitDetails.Name = "groupBoxTransportUnitDetails";
            this.groupBoxTransportUnitDetails.Size = new System.Drawing.Size(380, 580);
            this.groupBoxTransportUnitDetails.TabIndex = 1;
            this.groupBoxTransportUnitDetails.TabStop = false;
            this.groupBoxTransportUnitDetails.Text = "Transport Unit Details";

            // Unit Number
            this.lblUnitNumber.AutoSize = true;
            this.lblUnitNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUnitNumber.Location = new System.Drawing.Point(20, 40);
            this.lblUnitNumber.Name = "lblUnitNumber";
            this.lblUnitNumber.Size = new System.Drawing.Size(95, 20);
            this.lblUnitNumber.TabIndex = 0;
            this.lblUnitNumber.Text = "Unit Number:";

            this.txtUnitNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUnitNumber.Location = new System.Drawing.Point(130, 37);
            this.txtUnitNumber.Name = "txtUnitNumber";
            this.txtUnitNumber.Size = new System.Drawing.Size(220, 27);
            this.txtUnitNumber.TabIndex = 1;

            // Status
            this.lblStatusTU.AutoSize = true;
            this.lblStatusTU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatusTU.Location = new System.Drawing.Point(20, 80);
            this.lblStatusTU.Name = "lblStatusTU";
            this.lblStatusTU.Size = new System.Drawing.Size(52, 20);
            this.lblStatusTU.TabIndex = 2;
            this.lblStatusTU.Text = "Status:";

            this.cmbStatusTU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusTU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbStatusTU.Location = new System.Drawing.Point(130, 77);
            this.cmbStatusTU.Name = "cmbStatusTU";
            this.cmbStatusTU.Size = new System.Drawing.Size(220, 28);
            this.cmbStatusTU.TabIndex = 3;

            // Lorry
            this.lblLorryTU.AutoSize = true;
            this.lblLorryTU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLorryTU.Location = new System.Drawing.Point(20, 120);
            this.lblLorryTU.Name = "lblLorryTU";
            this.lblLorryTU.Size = new System.Drawing.Size(45, 20);
            this.lblLorryTU.TabIndex = 4;
            this.lblLorryTU.Text = "Lorry:";

            this.cmbLorryTU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLorryTU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbLorryTU.Location = new System.Drawing.Point(130, 117);
            this.cmbLorryTU.Name = "cmbLorryTU";
            this.cmbLorryTU.Size = new System.Drawing.Size(220, 28);
            this.cmbLorryTU.TabIndex = 5;

            // Driver
            this.lblDriverTU.AutoSize = true;
            this.lblDriverTU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDriverTU.Location = new System.Drawing.Point(20, 160);
            this.lblDriverTU.Name = "lblDriverTU";
            this.lblDriverTU.Size = new System.Drawing.Size(51, 20);
            this.lblDriverTU.TabIndex = 6;
            this.lblDriverTU.Text = "Driver:";

            this.cmbDriverTU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDriverTU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbDriverTU.Location = new System.Drawing.Point(130, 157);
            this.cmbDriverTU.Name = "cmbDriverTU";
            this.cmbDriverTU.Size = new System.Drawing.Size(220, 28);
            this.cmbDriverTU.TabIndex = 7;

            // Assistant
            this.lblAssistantTU.AutoSize = true;
            this.lblAssistantTU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAssistantTU.Location = new System.Drawing.Point(20, 200);
            this.lblAssistantTU.Name = "lblAssistantTU";
            this.lblAssistantTU.Size = new System.Drawing.Size(71, 20);
            this.lblAssistantTU.TabIndex = 8;
            this.lblAssistantTU.Text = "Assistant:";

            this.cmbAssistantTU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssistantTU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbAssistantTU.Location = new System.Drawing.Point(130, 197);
            this.cmbAssistantTU.Name = "cmbAssistantTU";
            this.cmbAssistantTU.Size = new System.Drawing.Size(220, 28);
            this.cmbAssistantTU.TabIndex = 9;

            // Container
            this.lblContainerTU.AutoSize = true;
            this.lblContainerTU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblContainerTU.Location = new System.Drawing.Point(20, 240);
            this.lblContainerTU.Name = "lblContainerTU";
            this.lblContainerTU.Size = new System.Drawing.Size(76, 20);
            this.lblContainerTU.TabIndex = 10;
            this.lblContainerTU.Text = "Container:";

            this.cmbContainerTU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContainerTU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbContainerTU.Location = new System.Drawing.Point(130, 237);
            this.cmbContainerTU.Name = "cmbContainerTU";
            this.cmbContainerTU.Size = new System.Drawing.Size(220, 28);
            this.cmbContainerTU.TabIndex = 11;

            // Is Available
            this.chkIsAvailableUnit.AutoSize = true;
            this.chkIsAvailableUnit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkIsAvailableUnit.Location = new System.Drawing.Point(130, 280);
            this.chkIsAvailableUnit.Name = "chkIsAvailableUnit";
            this.chkIsAvailableUnit.Size = new System.Drawing.Size(106, 24);
            this.chkIsAvailableUnit.TabIndex = 12;
            this.chkIsAvailableUnit.Text = "Is Available";
            this.chkIsAvailableUnit.UseVisualStyleBackColor = true;

            // Buttons
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

            // TODO: Setup other tabs similarly (Lorries, Drivers, Assistants, Containers)
            // ADD THESE LINES in InitializeComponent() method:

            // Setup Lorries Tab
            this.tabLorries.Controls.Add(this.groupBoxLorries);
            this.tabLorries.Controls.Add(this.groupBoxLorryDetails);

            // Setup Drivers Tab
            this.tabDrivers.Controls.Add(this.groupBoxDrivers);
            this.tabDrivers.Controls.Add(this.groupBoxDriverDetails);

            // Setup Assistants Tab
            this.tabAssistants.Controls.Add(this.groupBoxAssistants);
            this.tabAssistants.Controls.Add(this.groupBoxAssistantDetails);

            // Setup Containers Tab
            this.tabContainers.Controls.Add(this.groupBoxContainers);
            this.tabContainers.Controls.Add(this.groupBoxContainerDetails);


            // Lorries Tab
            this.tabLorries.Location = new System.Drawing.Point(4, 32);
            this.tabLorries.Name = "tabLorries";
            this.tabLorries.Size = new System.Drawing.Size(1342, 614);
            this.tabLorries.TabIndex = 1;
            this.tabLorries.Text = "🚛 Lorries";
            this.tabLorries.UseVisualStyleBackColor = true;

            // Drivers Tab
            this.tabDrivers.Location = new System.Drawing.Point(4, 32);
            this.tabDrivers.Name = "tabDrivers";
            this.tabDrivers.Size = new System.Drawing.Size(1342, 614);
            this.tabDrivers.TabIndex = 2;
            this.tabDrivers.Text = "👨‍💼 Drivers";
            this.tabDrivers.UseVisualStyleBackColor = true;

            // Assistants Tab
            this.tabAssistants.Location = new System.Drawing.Point(4, 32);
            this.tabAssistants.Name = "tabAssistants";
            this.tabAssistants.Size = new System.Drawing.Size(1342, 614);
            this.tabAssistants.TabIndex = 3;
            this.tabAssistants.Text = "👷‍♂️ Assistants";
            this.tabAssistants.UseVisualStyleBackColor = true;

            // Containers Tab
            this.tabContainers.Location = new System.Drawing.Point(4, 32);
            this.tabContainers.Name = "tabContainers";
            this.tabContainers.Size = new System.Drawing.Size(1342, 614);
            this.tabContainers.TabIndex = 4;
            this.tabContainers.Text = "📦 Containers";
            this.tabContainers.UseVisualStyleBackColor = true;

            // Add these controls and their setup in InitializeComponent():

            // Lorries DataGridView
            this.dgvLorries = new System.Windows.Forms.DataGridView();
            this.dgvLorries.Location = new System.Drawing.Point(20, 30);
            this.dgvLorries.Size = new System.Drawing.Size(860, 530);
            this.dgvLorries.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLorries_CellClick);

            // Drivers DataGridView  
            this.dgvDrivers = new System.Windows.Forms.DataGridView();
            this.dgvDrivers.Location = new System.Drawing.Point(20, 30);
            this.dgvDrivers.Size = new System.Drawing.Size(860, 530);
            this.dgvDrivers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrivers_CellClick);

            // Assistants DataGridView
            this.dgvAssistants = new System.Windows.Forms.DataGridView();
            this.dgvAssistants.Location = new System.Drawing.Point(20, 30);
            this.dgvAssistants.Size = new System.Drawing.Size(860, 530);
            this.dgvAssistants.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssistants_CellClick);

            // Containers DataGridView
            this.dgvContainers = new System.Windows.Forms.DataGridView();
            this.dgvContainers.Location = new System.Drawing.Point(20, 30);
            this.dgvContainers.Size = new System.Drawing.Size(860, 530);
            this.dgvContainers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContainers_CellClick);

            // Status Label
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatus.Location = new System.Drawing.Point(20, 740);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 20);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Ready";

            // Refresh Button
            this.btnRefresh.BackColor = System.Drawing.Color.LightBlue;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(1200, 735);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 35);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "🔄 Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // Close Button
            this.btnClose.BackColor = System.Drawing.Color.LightCoral;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(1290, 735);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 35);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "❌ Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // Search components
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();

            // Search Label
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(60, 140);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(53, 20);
            this.lblSearch.TabIndex = 100;
            this.lblSearch.Text = "Search:";

            // Search TextBox
            this.txtSearch.Location = new System.Drawing.Point(120, 137);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search units...";
            this.txtSearch.Size = new System.Drawing.Size(200, 27);
            this.txtSearch.TabIndex = 101;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            // Add to form
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);


            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        */
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
            this.lblStatusContainer = new System.Windows.Forms.Label();
            this.cmbStatusContainer = new System.Windows.Forms.ComboBox();
            this.chkIsAvailableContainer = new System.Windows.Forms.CheckBox();
            this.btnAddContainer = new System.Windows.Forms.Button();
            this.btnUpdateContainer = new System.Windows.Forms.Button();
            this.btnDeleteContainer = new System.Windows.Forms.Button();

            this.tabControl1.SuspendLayout();
            this.tabTransportUnits.SuspendLayout();
            this.tabLorries.SuspendLayout();
            this.tabDrivers.SuspendLayout();
            this.tabAssistants.SuspendLayout();
            this.tabContainers.SuspendLayout();
            this.groupBoxTransportUnits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportUnits)).BeginInit();
            this.groupBoxTransportUnitDetails.SuspendLayout();
            this.groupBoxLorries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLorries)).BeginInit();
            this.groupBoxLorryDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLoadCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVolumeCapacity)).BeginInit();
            this.groupBoxDrivers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).BeginInit();
            this.groupBoxDriverDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHourlyRateDriver)).BeginInit();
            this.groupBoxAssistants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssistants)).BeginInit();
            this.groupBoxAssistantDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHourlyRateAssistant)).BeginInit();
            this.groupBoxContainers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContainers)).BeginInit();
            this.groupBoxContainerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).BeginInit();
            this.SuspendLayout();

            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblStatus);
            this.Name = "TransportUnitManagementForm";
            this.Text = "Transport Unit Management";
            this.Load += new System.EventHandler(this.TransportUnitManagementForm_Load);

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Transport Unit Management";

            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTransportUnits);
            this.tabControl1.Controls.Add(this.tabLorries);
            this.tabControl1.Controls.Add(this.tabDrivers);
            this.tabControl1.Controls.Add(this.tabAssistants);
            this.tabControl1.Controls.Add(this.tabContainers);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl1.Location = new System.Drawing.Point(20, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1350, 650);
            this.tabControl1.TabIndex = 1;

            // ==========================================
            // TRANSPORT UNITS TAB
            // ==========================================
            this.tabTransportUnits.Controls.Add(this.groupBoxTransportUnits);
            this.tabTransportUnits.Controls.Add(this.groupBoxTransportUnitDetails);
            this.tabTransportUnits.Location = new System.Drawing.Point(4, 32);
            this.tabTransportUnits.Name = "tabTransportUnits";
            this.tabTransportUnits.Size = new System.Drawing.Size(1342, 614);
            this.tabTransportUnits.TabIndex = 0;
            this.tabTransportUnits.Text = "🚛 Transport Units";
            this.tabTransportUnits.UseVisualStyleBackColor = true;

            // Transport Units GroupBox
            this.groupBoxTransportUnits.Controls.Add(this.dgvTransportUnits);
            this.groupBoxTransportUnits.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxTransportUnits.Location = new System.Drawing.Point(20, 20);
            this.groupBoxTransportUnits.Name = "groupBoxTransportUnits";
            this.groupBoxTransportUnits.Size = new System.Drawing.Size(900, 580);
            this.groupBoxTransportUnits.TabIndex = 0;
            this.groupBoxTransportUnits.TabStop = false;
            this.groupBoxTransportUnits.Text = "Transport Units List";

            // Transport Units DataGridView
            this.dgvTransportUnits.AllowUserToAddRows = false;
            this.dgvTransportUnits.AllowUserToDeleteRows = false;
            this.dgvTransportUnits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransportUnits.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTransportUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransportUnits.Location = new System.Drawing.Point(20, 30);
            this.dgvTransportUnits.MultiSelect = false;
            this.dgvTransportUnits.Name = "dgvTransportUnits";
            this.dgvTransportUnits.ReadOnly = true;
            this.dgvTransportUnits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransportUnits.Size = new System.Drawing.Size(860, 530);
            this.dgvTransportUnits.TabIndex = 0;
            this.dgvTransportUnits.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransportUnits_CellClick);

            // Transport Unit Details GroupBox
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
            this.groupBoxTransportUnitDetails.Location = new System.Drawing.Point(940, 20);
            this.groupBoxTransportUnitDetails.Name = "groupBoxTransportUnitDetails";
            this.groupBoxTransportUnitDetails.Size = new System.Drawing.Size(380, 580);
            this.groupBoxTransportUnitDetails.TabIndex = 1;
            this.groupBoxTransportUnitDetails.TabStop = false;
            this.groupBoxTransportUnitDetails.Text = "Transport Unit Details";

            // Unit Number
            this.lblUnitNumber.AutoSize = true;
            this.lblUnitNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUnitNumber.Location = new System.Drawing.Point(20, 40);
            this.lblUnitNumber.Name = "lblUnitNumber";
            this.lblUnitNumber.Size = new System.Drawing.Size(95, 20);
            this.lblUnitNumber.TabIndex = 0;
            this.lblUnitNumber.Text = "Unit Number:";

            this.txtUnitNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUnitNumber.Location = new System.Drawing.Point(130, 37);
            this.txtUnitNumber.Name = "txtUnitNumber";
            this.txtUnitNumber.Size = new System.Drawing.Size(220, 27);
            this.txtUnitNumber.TabIndex = 1;

            // Status
            this.lblStatusTU.AutoSize = true;
            this.lblStatusTU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatusTU.Location = new System.Drawing.Point(20, 80);
            this.lblStatusTU.Name = "lblStatusTU";
            this.lblStatusTU.Size = new System.Drawing.Size(52, 20);
            this.lblStatusTU.TabIndex = 2;
            this.lblStatusTU.Text = "Status:";

            this.cmbStatusTU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusTU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbStatusTU.Location = new System.Drawing.Point(130, 77);
            this.cmbStatusTU.Name = "cmbStatusTU";
            this.cmbStatusTU.Size = new System.Drawing.Size(220, 28);
            this.cmbStatusTU.TabIndex = 3;


            // ==========================================
            // ASSISTANTS TAB SETUP  
            // ==========================================
            this.tabAssistants.Controls.Add(this.groupBoxAssistants);
            this.tabAssistants.Controls.Add(this.groupBoxAssistantDetails);
            this.tabAssistants.Location = new System.Drawing.Point(4, 32);
            this.tabAssistants.Name = "tabAssistants";
            this.tabAssistants.Size = new System.Drawing.Size(1342, 614);
            this.tabAssistants.TabIndex = 3;
            this.tabAssistants.Text = "👷‍♂️ Assistants";
            this.tabAssistants.UseVisualStyleBackColor = true;

            // Assistants GroupBox
            this.groupBoxAssistants.Controls.Add(this.dgvAssistants);
            this.groupBoxAssistants.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxAssistants.Location = new System.Drawing.Point(20, 20);
            this.groupBoxAssistants.Name = "groupBoxAssistants";
            this.groupBoxAssistants.Size = new System.Drawing.Size(900, 580);
            this.groupBoxAssistants.TabIndex = 0;
            this.groupBoxAssistants.TabStop = false;
            this.groupBoxAssistants.Text = "Assistants List";

            // Assistants DataGridView
            this.dgvAssistants.AllowUserToAddRows = false;
            this.dgvAssistants.AllowUserToDeleteRows = false;
            this.dgvAssistants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssistants.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvAssistants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssistants.Location = new System.Drawing.Point(20, 30);
            this.dgvAssistants.MultiSelect = false;
            this.dgvAssistants.Name = "dgvAssistants";
            this.dgvAssistants.ReadOnly = true;
            this.dgvAssistants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssistants.Size = new System.Drawing.Size(860, 530);
            this.dgvAssistants.TabIndex = 0;
            this.dgvAssistants.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssistants_CellClick);

            // ==========================================
            // CONTAINERS TAB SETUP
            // ==========================================
            this.tabContainers.Controls.Add(this.groupBoxContainers);
            this.tabContainers.Controls.Add(this.groupBoxContainerDetails);
            this.tabContainers.Location = new System.Drawing.Point(4, 32);
            this.tabContainers.Name = "tabContainers";
            this.tabContainers.Size = new System.Drawing.Size(1342, 614);
            this.tabContainers.TabIndex = 4;
            this.tabContainers.Text = "📦 Containers";
            this.tabContainers.UseVisualStyleBackColor = true;

            // Containers GroupBox
            this.groupBoxContainers.Controls.Add(this.dgvContainers);
            this.groupBoxContainers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxContainers.Location = new System.Drawing.Point(20, 20);
            this.groupBoxContainers.Name = "groupBoxContainers";
            this.groupBoxContainers.Size = new System.Drawing.Size(900, 580);
            this.groupBoxContainers.TabIndex = 0;
            this.groupBoxContainers.TabStop = false;
            this.groupBoxContainers.Text = "Containers List";

            // Containers DataGridView
            this.dgvContainers.AllowUserToAddRows = false;
            this.dgvContainers.AllowUserToDeleteRows = false;
            this.dgvContainers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContainers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvContainers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContainers.Location = new System.Drawing.Point(20, 30);
            this.dgvContainers.MultiSelect = false;
            this.dgvContainers.Name = "dgvContainers";
            this.dgvContainers.ReadOnly = true;
            this.dgvContainers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContainers.Size = new System.Drawing.Size(860, 530);
            this.dgvContainers.TabIndex = 0;
            this.dgvContainers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContainers_CellClick);

            // Lorry
            this.lblLorryTU.AutoSize = true;
            this.lblLorryTU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLorryTU.Location = new System.Drawing.Point(20, 120);
            this.lblLorryTU.Name = "lblLorryTU";
            this.lblLorryTU.Size = new System.Drawing.Size(45, 20);
            this.lblLorryTU.TabIndex = 4;
            this.lblLorryTU.Text = "Lorry:";

            this.cmbLorryTU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLorryTU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbLorryTU.Location = new System.Drawing.Point(130, 117);
            this.cmbLorryTU.Name = "cmbLorryTU";
            this.cmbLorryTU.Size = new System.Drawing.Size(220, 28);
            this.cmbLorryTU.TabIndex = 5;

            // Driver
            this.lblDriverTU.AutoSize = true;
            this.lblDriverTU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDriverTU.Location = new System.Drawing.Point(20, 160);
            this.lblDriverTU.Name = "lblDriverTU";
            this.lblDriverTU.Size = new System.Drawing.Size(51, 20);
            this.lblDriverTU.TabIndex = 6;
            this.lblDriverTU.Text = "Driver:";

            this.cmbDriverTU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDriverTU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbDriverTU.Location = new System.Drawing.Point(130, 157);
            this.cmbDriverTU.Name = "cmbDriverTU";
            this.cmbDriverTU.Size = new System.Drawing.Size(220, 28);
            this.cmbDriverTU.TabIndex = 7;

            // Assistant
            this.lblAssistantTU.AutoSize = true;
            this.lblAssistantTU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAssistantTU.Location = new System.Drawing.Point(20, 200);
            this.lblAssistantTU.Name = "lblAssistantTU";
            this.lblAssistantTU.Size = new System.Drawing.Size(71, 20);
            this.lblAssistantTU.TabIndex = 8;
            this.lblAssistantTU.Text = "Assistant:";

            this.cmbAssistantTU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssistantTU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbAssistantTU.Location = new System.Drawing.Point(130, 197);
            this.cmbAssistantTU.Name = "cmbAssistantTU";
            this.cmbAssistantTU.Size = new System.Drawing.Size(220, 28);
            this.cmbAssistantTU.TabIndex = 9;

            // Container
            this.lblContainerTU.AutoSize = true;
            this.lblContainerTU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblContainerTU.Location = new System.Drawing.Point(20, 240);
            this.lblContainerTU.Name = "lblContainerTU";
            this.lblContainerTU.Size = new System.Drawing.Size(76, 20);
            this.lblContainerTU.TabIndex = 10;
            this.lblContainerTU.Text = "Container:";

            this.cmbContainerTU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContainerTU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbContainerTU.Location = new System.Drawing.Point(130, 237);
            this.cmbContainerTU.Name = "cmbContainerTU";
            this.cmbContainerTU.Size = new System.Drawing.Size(220, 28);
            this.cmbContainerTU.TabIndex = 11;

            // Is Available
            this.chkIsAvailableUnit.AutoSize = true;
            this.chkIsAvailableUnit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkIsAvailableUnit.Location = new System.Drawing.Point(130, 280);
            this.chkIsAvailableUnit.Name = "chkIsAvailableUnit";
            this.chkIsAvailableUnit.Size = new System.Drawing.Size(106, 24);
            this.chkIsAvailableUnit.TabIndex = 12;
            this.chkIsAvailableUnit.Text = "Is Available";
            this.chkIsAvailableUnit.UseVisualStyleBackColor = true;

            // Buttons
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

            // ==========================================
            // LORRIES TAB
            // ==========================================
            this.tabLorries.Controls.Add(this.groupBoxLorries);
            this.tabLorries.Controls.Add(this.groupBoxLorryDetails);
            this.tabLorries.Location = new System.Drawing.Point(4, 32);
            this.tabLorries.Name = "tabLorries";
            this.tabLorries.Size = new System.Drawing.Size(1342, 614);
            this.tabLorries.TabIndex = 1;
            this.tabLorries.Text = "🚛 Lorries";
            this.tabLorries.UseVisualStyleBackColor = true;

            // Lorries GroupBox
            this.groupBoxLorries.Controls.Add(this.dgvLorries);
            this.groupBoxLorries.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxLorries.Location = new System.Drawing.Point(20, 20);
            this.groupBoxLorries.Name = "groupBoxLorries";
            this.groupBoxLorries.Size = new System.Drawing.Size(900, 580);
            this.groupBoxLorries.TabIndex = 0;
            this.groupBoxLorries.TabStop = false;
            this.groupBoxLorries.Text = "Lorries List";

            // Lorries DataGridView
            this.dgvLorries.AllowUserToAddRows = false;
            this.dgvLorries.AllowUserToDeleteRows = false;
            this.dgvLorries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLorries.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLorries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLorries.Location = new System.Drawing.Point(20, 30);
            this.dgvLorries.MultiSelect = false;
            this.dgvLorries.Name = "dgvLorries";
            this.dgvLorries.ReadOnly = true;
            this.dgvLorries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLorries.Size = new System.Drawing.Size(860, 530);
            this.dgvLorries.TabIndex = 0;
            this.dgvLorries.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLorries_CellClick);

            // Lorry Details GroupBox
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
            this.groupBoxLorryDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxLorryDetails.Location = new System.Drawing.Point(940, 20);
            this.groupBoxLorryDetails.Name = "groupBoxLorryDetails";
            this.groupBoxLorryDetails.Size = new System.Drawing.Size(380, 580);
            this.groupBoxLorryDetails.TabIndex = 1;
            this.groupBoxLorryDetails.TabStop = false;
            this.groupBoxLorryDetails.Text = "Lorry Details";

            // Registration Number
            this.lblRegistrationNumber.AutoSize = true;
            this.lblRegistrationNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRegistrationNumber.Location = new System.Drawing.Point(20, 40);
            this.lblRegistrationNumber.Name = "lblRegistrationNumber";
            this.lblRegistrationNumber.Size = new System.Drawing.Size(100, 20);
            this.lblRegistrationNumber.TabIndex = 0;
            this.lblRegistrationNumber.Text = "Registration:";

            this.txtRegistrationNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRegistrationNumber.Location = new System.Drawing.Point(130, 37);
            this.txtRegistrationNumber.Name = "txtRegistrationNumber";
            this.txtRegistrationNumber.Size = new System.Drawing.Size(220, 27);
            this.txtRegistrationNumber.TabIndex = 1;

            // Make
            this.lblMake.AutoSize = true;
            this.lblMake.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMake.Location = new System.Drawing.Point(20, 80);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(45, 20);
            this.lblMake.TabIndex = 2;
            this.lblMake.Text = "Make:";

            this.txtMake.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMake.Location = new System.Drawing.Point(130, 77);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(220, 27);
            this.txtMake.TabIndex = 3;

            // Model
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblModel.Location = new System.Drawing.Point(20, 120);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(52, 20);
            this.lblModel.TabIndex = 4;
            this.lblModel.Text = "Model:";

            this.txtModel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtModel.Location = new System.Drawing.Point(130, 117);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(220, 27);
            this.txtModel.TabIndex = 5;

            // Year
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblYear.Location = new System.Drawing.Point(20, 160);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(38, 20);
            this.lblYear.TabIndex = 6;
            this.lblYear.Text = "Year:";

            this.numYear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numYear.Location = new System.Drawing.Point(130, 157);
            this.numYear.Maximum = new decimal(new int[] { 2030, 0, 0, 0 });
            this.numYear.Minimum = new decimal(new int[] { 1980, 0, 0, 0 });
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(100, 27);
            this.numYear.TabIndex = 7;
            this.numYear.Value = new decimal(new int[] { 2024, 0, 0, 0 });

            // Load Capacity
            this.lblLoadCapacity.AutoSize = true;
            this.lblLoadCapacity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLoadCapacity.Location = new System.Drawing.Point(20, 200);
            this.lblLoadCapacity.Name = "lblLoadCapacity";
            this.lblLoadCapacity.Size = new System.Drawing.Size(109, 20);
            this.lblLoadCapacity.TabIndex = 8;
            this.lblLoadCapacity.Text = "Load Capacity:";

            this.numLoadCapacity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numLoadCapacity.Location = new System.Drawing.Point(130, 197);
            this.numLoadCapacity.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            this.numLoadCapacity.Name = "numLoadCapacity";
            this.numLoadCapacity.Size = new System.Drawing.Size(120, 27);
            this.numLoadCapacity.TabIndex = 9;

            // Volume Capacity
            this.lblVolumeCapacity.AutoSize = true;
            this.lblVolumeCapacity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVolumeCapacity.Location = new System.Drawing.Point(20, 240);
            this.lblVolumeCapacity.Name = "lblVolumeCapacity";
            this.lblVolumeCapacity.Size = new System.Drawing.Size(126, 20);
            this.lblVolumeCapacity.TabIndex = 10;
            this.lblVolumeCapacity.Text = "Volume Capacity:";

            this.numVolumeCapacity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numVolumeCapacity.Location = new System.Drawing.Point(150, 237);
            this.numVolumeCapacity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numVolumeCapacity.Name = "numVolumeCapacity";
            this.numVolumeCapacity.Size = new System.Drawing.Size(100, 27);
            this.numVolumeCapacity.TabIndex = 11;

            // Fuel Type
            this.lblFuelType.AutoSize = true;
            this.lblFuelType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFuelType.Location = new System.Drawing.Point(20, 280);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Size = new System.Drawing.Size(77, 20);
            this.lblFuelType.TabIndex = 12;
            this.lblFuelType.Text = "Fuel Type:";

            this.cmbFuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuelType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbFuelType.Location = new System.Drawing.Point(130, 277);
            this.cmbFuelType.Name = "cmbFuelType";
            this.cmbFuelType.Size = new System.Drawing.Size(120, 28);
            this.cmbFuelType.TabIndex = 13;

            // Last Maintenance
            this.lblLastMaintenance.AutoSize = true;
            this.lblLastMaintenance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLastMaintenance.Location = new System.Drawing.Point(20, 320);
            this.lblLastMaintenance.Name = "lblLastMaintenance";
            this.lblLastMaintenance.Size = new System.Drawing.Size(127, 20);
            this.lblLastMaintenance.TabIndex = 14;
            this.lblLastMaintenance.Text = "Last Maintenance:";

            this.dtpLastMaintenance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpLastMaintenance.Location = new System.Drawing.Point(150, 317);
            this.dtpLastMaintenance.Name = "dtpLastMaintenance";
            this.dtpLastMaintenance.Size = new System.Drawing.Size(200, 27);
            this.dtpLastMaintenance.TabIndex = 15;

            // Status
            this.lblStatusLorry.AutoSize = true;
            this.lblStatusLorry.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatusLorry.Location = new System.Drawing.Point(20, 360);
            this.lblStatusLorry.Name = "lblStatusLorry";
            this.lblStatusLorry.Size = new System.Drawing.Size(52, 20);
            this.lblStatusLorry.TabIndex = 16;
            this.lblStatusLorry.Text = "Status:";

            this.cmbStatusLorry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusLorry.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbStatusLorry.Location = new System.Drawing.Point(130, 357);
            this.cmbStatusLorry.Name = "cmbStatusLorry";
            this.cmbStatusLorry.Size = new System.Drawing.Size(120, 28);
            this.cmbStatusLorry.TabIndex = 17;

            // Is Available
            this.chkIsAvailableLorry.AutoSize = true;
            this.chkIsAvailableLorry.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkIsAvailableLorry.Location = new System.Drawing.Point(130, 400);
            this.chkIsAvailableLorry.Name = "chkIsAvailableLorry";
            this.chkIsAvailableLorry.Size = new System.Drawing.Size(106, 24);
            this.chkIsAvailableLorry.TabIndex = 18;
            this.chkIsAvailableLorry.Text = "Is Available";
            this.chkIsAvailableLorry.UseVisualStyleBackColor = true;

            // Buttons
            this.btnAddLorry.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddLorry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddLorry.Location = new System.Drawing.Point(20, 480);
            this.btnAddLorry.Name = "btnAddLorry";
            this.btnAddLorry.Size = new System.Drawing.Size(110, 40);
            this.btnAddLorry.TabIndex = 19;
            this.btnAddLorry.Text = "➕ Add";
            this.btnAddLorry.UseVisualStyleBackColor = false;
            this.btnAddLorry.Click += new System.EventHandler(this.btnAddLorry_Click);

            this.btnUpdateLorry.BackColor = System.Drawing.Color.LightBlue;
            this.btnUpdateLorry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateLorry.Location = new System.Drawing.Point(140, 480);
            this.btnUpdateLorry.Name = "btnUpdateLorry";
            this.btnUpdateLorry.Size = new System.Drawing.Size(110, 40);
            this.btnUpdateLorry.TabIndex = 20;
            this.btnUpdateLorry.Text = "✏️ Update";
            this.btnUpdateLorry.UseVisualStyleBackColor = false;
            this.btnUpdateLorry.Click += new System.EventHandler(this.btnUpdateLorry_Click);

            this.btnDeleteLorry.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeleteLorry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteLorry.Location = new System.Drawing.Point(260, 480);
            this.btnDeleteLorry.Name = "btnDeleteLorry";
            this.btnDeleteLorry.Size = new System.Drawing.Size(110, 40);
            this.btnDeleteLorry.TabIndex = 21;
            this.btnDeleteLorry.Text = "🗑️ Delete";
            this.btnDeleteLorry.UseVisualStyleBackColor = false;
            this.btnDeleteLorry.Click += new System.EventHandler(this.btnDeleteLorry_Click);


            // Driver Details GroupBox - Initialize all controls
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
            this.groupBoxDriverDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxDriverDetails.Location = new System.Drawing.Point(940, 20);
            this.groupBoxDriverDetails.Name = "groupBoxDriverDetails";
            this.groupBoxDriverDetails.Size = new System.Drawing.Size(380, 580);
            this.groupBoxDriverDetails.TabIndex = 1;
            this.groupBoxDriverDetails.TabStop = false;
            this.groupBoxDriverDetails.Text = "Driver Details";

            // License Number
            this.lblLicenseNumber.AutoSize = true;
            this.lblLicenseNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLicenseNumber.Location = new System.Drawing.Point(20, 30);
            this.lblLicenseNumber.Name = "lblLicenseNumber";
            this.lblLicenseNumber.Size = new System.Drawing.Size(95, 20);
            this.lblLicenseNumber.TabIndex = 0;
            this.lblLicenseNumber.Text = "License No:";

            this.txtLicenseNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLicenseNumber.Location = new System.Drawing.Point(130, 30);
            this.txtLicenseNumber.Name = "txtLicenseNumber";
            this.txtLicenseNumber.Size = new System.Drawing.Size(200, 27);
            this.txtLicenseNumber.TabIndex = 1;

            // First Name
            this.lblFirstNameDriver.AutoSize = true;
            this.lblFirstNameDriver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFirstNameDriver.Location = new System.Drawing.Point(20, 70);
            this.lblFirstNameDriver.Name = "lblFirstNameDriver";
            this.lblFirstNameDriver.Size = new System.Drawing.Size(84, 20);
            this.lblFirstNameDriver.TabIndex = 2;
            this.lblFirstNameDriver.Text = "First Name:";

            this.txtFirstNameDriver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFirstNameDriver.Location = new System.Drawing.Point(130, 70);
            this.txtFirstNameDriver.Name = "txtFirstNameDriver";
            this.txtFirstNameDriver.Size = new System.Drawing.Size(200, 27);
            this.txtFirstNameDriver.TabIndex = 3;

            // Last Name
            this.lblLastNameDriver.AutoSize = true;
            this.lblLastNameDriver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLastNameDriver.Location = new System.Drawing.Point(20, 110);
            this.lblLastNameDriver.Name = "lblLastNameDriver";
            this.lblLastNameDriver.Size = new System.Drawing.Size(83, 20);
            this.lblLastNameDriver.TabIndex = 4;
            this.lblLastNameDriver.Text = "Last Name:";

            this.txtLastNameDriver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLastNameDriver.Location = new System.Drawing.Point(130, 110);
            this.txtLastNameDriver.Name = "txtLastNameDriver";
            this.txtLastNameDriver.Size = new System.Drawing.Size(200, 27);
            this.txtLastNameDriver.TabIndex = 5;

            // Phone
            this.lblPhoneDriver.AutoSize = true;
            this.lblPhoneDriver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhoneDriver.Location = new System.Drawing.Point(20, 150);
            this.lblPhoneDriver.Name = "lblPhoneDriver";
            this.lblPhoneDriver.Size = new System.Drawing.Size(53, 20);
            this.lblPhoneDriver.TabIndex = 6;
            this.lblPhoneDriver.Text = "Phone:";

            this.txtPhoneDriver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhoneDriver.Location = new System.Drawing.Point(130, 150);
            this.txtPhoneDriver.Name = "txtPhoneDriver";
            this.txtPhoneDriver.Size = new System.Drawing.Size(200, 27);
            this.txtPhoneDriver.TabIndex = 7;

            // Email
            this.lblEmailDriver.AutoSize = true;
            this.lblEmailDriver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmailDriver.Location = new System.Drawing.Point(20, 190);
            this.lblEmailDriver.Name = "lblEmailDriver";
            this.lblEmailDriver.Size = new System.Drawing.Size(49, 20);
            this.lblEmailDriver.TabIndex = 8;
            this.lblEmailDriver.Text = "Email:";

            this.txtEmailDriver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmailDriver.Location = new System.Drawing.Point(130, 190);
            this.txtEmailDriver.Name = "txtEmailDriver";
            this.txtEmailDriver.Size = new System.Drawing.Size(200, 27);
            this.txtEmailDriver.TabIndex = 9;

            // Address
            this.lblAddressDriver.AutoSize = true;
            this.lblAddressDriver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAddressDriver.Location = new System.Drawing.Point(20, 230);
            this.lblAddressDriver.Name = "lblAddressDriver";
            this.lblAddressDriver.Size = new System.Drawing.Size(65, 20);
            this.lblAddressDriver.TabIndex = 10;
            this.lblAddressDriver.Text = "Address:";

            this.txtAddressDriver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddressDriver.Location = new System.Drawing.Point(130, 230);
            this.txtAddressDriver.Name = "txtAddressDriver";
            this.txtAddressDriver.Size = new System.Drawing.Size(200, 27);
            this.txtAddressDriver.TabIndex = 11;

            // License Expiry
            this.lblLicenseExpiry.AutoSize = true;
            this.lblLicenseExpiry.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLicenseExpiry.Location = new System.Drawing.Point(20, 270);
            this.lblLicenseExpiry.Name = "lblLicenseExpiry";
            this.lblLicenseExpiry.Size = new System.Drawing.Size(103, 20);
            this.lblLicenseExpiry.TabIndex = 12;
            this.lblLicenseExpiry.Text = "License Expiry:";

            this.dtpLicenseExpiry.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpLicenseExpiry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLicenseExpiry.Location = new System.Drawing.Point(130, 270);
            this.dtpLicenseExpiry.Name = "dtpLicenseExpiry";
            this.dtpLicenseExpiry.Size = new System.Drawing.Size(200, 27);
            this.dtpLicenseExpiry.TabIndex = 13;

            // License Class
            this.lblLicenseClass.AutoSize = true;
            this.lblLicenseClass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLicenseClass.Location = new System.Drawing.Point(20, 310);
            this.lblLicenseClass.Name = "lblLicenseClass";
            this.lblLicenseClass.Size = new System.Drawing.Size(96, 20);
            this.lblLicenseClass.TabIndex = 14;
            this.lblLicenseClass.Text = "License Class:";

            this.cmbLicenseClass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbLicenseClass.FormattingEnabled = true;
            this.cmbLicenseClass.Items.AddRange(new object[] { "Light", "Heavy", "Special" });
            this.cmbLicenseClass.Location = new System.Drawing.Point(130, 310);
            this.cmbLicenseClass.Name = "cmbLicenseClass";
            this.cmbLicenseClass.Size = new System.Drawing.Size(200, 28);
            this.cmbLicenseClass.TabIndex = 15;

            // Hourly Rate
            this.lblHourlyRateDriver.AutoSize = true;
            this.lblHourlyRateDriver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHourlyRateDriver.Location = new System.Drawing.Point(20, 350);
            this.lblHourlyRateDriver.Name = "lblHourlyRateDriver";
            this.lblHourlyRateDriver.Size = new System.Drawing.Size(90, 20);
            this.lblHourlyRateDriver.TabIndex = 16;
            this.lblHourlyRateDriver.Text = "Hourly Rate:";

            this.numHourlyRateDriver.DecimalPlaces = 2;
            this.numHourlyRateDriver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numHourlyRateDriver.Location = new System.Drawing.Point(130, 350);
            this.numHourlyRateDriver.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numHourlyRateDriver.Name = "numHourlyRateDriver";
            this.numHourlyRateDriver.Size = new System.Drawing.Size(200, 27);
            this.numHourlyRateDriver.TabIndex = 17;

            // Is Available
            this.chkIsAvailableDriver.AutoSize = true;
            this.chkIsAvailableDriver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkIsAvailableDriver.Location = new System.Drawing.Point(130, 390);
            this.chkIsAvailableDriver.Name = "chkIsAvailableDriver";
            this.chkIsAvailableDriver.Size = new System.Drawing.Size(109, 24);
            this.chkIsAvailableDriver.TabIndex = 18;
            this.chkIsAvailableDriver.Text = "Is Available";
            this.chkIsAvailableDriver.UseVisualStyleBackColor = true;

            // Buttons
            this.btnAddDriver.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddDriver.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddDriver.Location = new System.Drawing.Point(20, 480);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(100, 40);
            this.btnAddDriver.TabIndex = 19;
            this.btnAddDriver.Text = "➕ Add";
            this.btnAddDriver.UseVisualStyleBackColor = false;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);

            this.btnUpdateDriver.BackColor = System.Drawing.Color.LightBlue;
            this.btnUpdateDriver.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateDriver.Location = new System.Drawing.Point(130, 480);
            this.btnUpdateDriver.Name = "btnUpdateDriver";
            this.btnUpdateDriver.Size = new System.Drawing.Size(100, 40);
            this.btnUpdateDriver.TabIndex = 20;
            this.btnUpdateDriver.Text = "✏️ Update";
            this.btnUpdateDriver.UseVisualStyleBackColor = false;
            this.btnUpdateDriver.Click += new System.EventHandler(this.btnUpdateDriver_Click);

            this.btnDeleteDriver.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeleteDriver.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteDriver.Location = new System.Drawing.Point(240, 480);
            this.btnDeleteDriver.Name = "btnDeleteDriver";
            this.btnDeleteDriver.Size = new System.Drawing.Size(100, 40);
            this.btnDeleteDriver.TabIndex = 21;
            this.btnDeleteDriver.Text = "🗑️ Delete";
            this.btnDeleteDriver.UseVisualStyleBackColor = false;
            this.btnDeleteDriver.Click += new System.EventHandler(this.btnDeleteDriver_Click);

            // ==========================================
            // DRIVERS TAB
            // ==========================================
            this.tabDrivers.Controls.Add(this.groupBoxDrivers);
            this.tabDrivers.Controls.Add(this.groupBoxDriverDetails);
            this.tabDrivers.Location = new System.Drawing.Point(4, 32);
            this.tabDrivers.Name = "tabDrivers";
            this.tabDrivers.Size = new System.Drawing.Size(1342, 614);
            this.tabDrivers.TabIndex = 2;
            this.tabDrivers.Text = "👨‍💼 Drivers";
            this.tabDrivers.UseVisualStyleBackColor = true;

            // Drivers GroupBox
            this.groupBoxDrivers.Controls.Add(this.dgvDrivers);
            this.groupBoxDrivers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxDrivers.Location = new System.Drawing.Point(20, 20);
            this.groupBoxDrivers.Name = "groupBoxDrivers";
            this.groupBoxDrivers.Size = new System.Drawing.Size(900, 580);
            this.groupBoxDrivers.TabIndex = 0;
            this.groupBoxDrivers.TabStop = false;
            this.groupBoxDrivers.Text = "Drivers List";

            // Drivers DataGridView
            this.dgvDrivers.AllowUserToAddRows = false;
            this.dgvDrivers.AllowUserToDeleteRows = false;
            this.dgvDrivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDrivers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrivers.Location = new System.Drawing.Point(20, 30);
            this.dgvDrivers.MultiSelect = false;
            this.dgvDrivers.Name = "dgvDrivers";
            this.dgvDrivers.ReadOnly = true;
            this.dgvDrivers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrivers.Size = new System.Drawing.Size(860, 530);
            this.dgvDrivers.TabIndex = 0;
            this.dgvDrivers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrivers_CellClick);


            // ==========================================
            // CONTAINERS TAB INITIALIZATION
            // ==========================================

            // Container Details GroupBox - Initialize all controls
            this.groupBoxContainerDetails.Controls.Add(this.lblContainerNumber);
            this.groupBoxContainerDetails.Controls.Add(this.txtContainerNumber);
            this.groupBoxContainerDetails.Controls.Add(this.lblType);
            this.groupBoxContainerDetails.Controls.Add(this.cmbType);
            this.groupBoxContainerDetails.Controls.Add(this.lblCapacity);
            this.groupBoxContainerDetails.Controls.Add(this.numCapacity);
            this.groupBoxContainerDetails.Controls.Add(this.lblStatusContainer);
            this.groupBoxContainerDetails.Controls.Add(this.cmbStatusContainer);
            this.groupBoxContainerDetails.Controls.Add(this.chkIsAvailableContainer);
            this.groupBoxContainerDetails.Controls.Add(this.btnAddContainer);
            this.groupBoxContainerDetails.Controls.Add(this.btnUpdateContainer);
            this.groupBoxContainerDetails.Controls.Add(this.btnDeleteContainer);
            this.groupBoxContainerDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxContainerDetails.Location = new System.Drawing.Point(940, 20);
            this.groupBoxContainerDetails.Name = "groupBoxContainerDetails";
            this.groupBoxContainerDetails.Size = new System.Drawing.Size(380, 580);
            this.groupBoxContainerDetails.TabIndex = 1;
            this.groupBoxContainerDetails.TabStop = false;
            this.groupBoxContainerDetails.Text = "Container Details";

            // Container Number
            this.lblContainerNumber.AutoSize = true;
            this.lblContainerNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblContainerNumber.Location = new System.Drawing.Point(20, 30);
            this.lblContainerNumber.Name = "lblContainerNumber";
            this.lblContainerNumber.Size = new System.Drawing.Size(115, 20);
            this.lblContainerNumber.TabIndex = 0;
            this.lblContainerNumber.Text = "Container No:";

            this.txtContainerNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtContainerNumber.Location = new System.Drawing.Point(140, 30);
            this.txtContainerNumber.Name = "txtContainerNumber";
            this.txtContainerNumber.Size = new System.Drawing.Size(200, 27);
            this.txtContainerNumber.TabIndex = 1;

            // Type
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblType.Location = new System.Drawing.Point(20, 70);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(43, 20);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type:";

            this.cmbType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] { "Standard", "Fragile", "Small", "Large", "Refrigerated" });
            this.cmbType.Location = new System.Drawing.Point(140, 70);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(200, 28);
            this.cmbType.TabIndex = 3;

            // Capacity
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCapacity.Location = new System.Drawing.Point(20, 110);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(102, 20);
            this.lblCapacity.TabIndex = 4;
            this.lblCapacity.Text = "Capacity (m³):";

            this.numCapacity.DecimalPlaces = 2;
            this.numCapacity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numCapacity.Location = new System.Drawing.Point(140, 110);
            this.numCapacity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numCapacity.Name = "numCapacity";
            this.numCapacity.Size = new System.Drawing.Size(200, 27);
            this.numCapacity.TabIndex = 5;

            // Status
            this.lblStatusContainer.AutoSize = true;
            this.lblStatusContainer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatusContainer.Location = new System.Drawing.Point(20, 150);
            this.lblStatusContainer.Name = "lblStatusContainer";
            this.lblStatusContainer.Size = new System.Drawing.Size(52, 20);
            this.lblStatusContainer.TabIndex = 6;
            this.lblStatusContainer.Text = "Status:";

            this.cmbStatusContainer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbStatusContainer.FormattingEnabled = true;
            this.cmbStatusContainer.Items.AddRange(new object[] { "Available", "In Use", "Maintenance", "Inactive" });
            this.cmbStatusContainer.Location = new System.Drawing.Point(140, 150);
            this.cmbStatusContainer.Name = "cmbStatusContainer";
            this.cmbStatusContainer.Size = new System.Drawing.Size(200, 28);
            this.cmbStatusContainer.TabIndex = 7;

            // Is Available
            this.chkIsAvailableContainer.AutoSize = true;
            this.chkIsAvailableContainer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkIsAvailableContainer.Location = new System.Drawing.Point(140, 190);
            this.chkIsAvailableContainer.Name = "chkIsAvailableContainer";
            this.chkIsAvailableContainer.Size = new System.Drawing.Size(109, 24);
            this.chkIsAvailableContainer.TabIndex = 8;
            this.chkIsAvailableContainer.Text = "Is Available";
            this.chkIsAvailableContainer.UseVisualStyleBackColor = true;

            // Buttons
            this.btnAddContainer.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddContainer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddContainer.Location = new System.Drawing.Point(20, 480);
            this.btnAddContainer.Name = "btnAddContainer";
            this.btnAddContainer.Size = new System.Drawing.Size(100, 40);
            this.btnAddContainer.TabIndex = 9;
            this.btnAddContainer.Text = "➕ Add";
            this.btnAddContainer.UseVisualStyleBackColor = false;
            this.btnAddContainer.Click += new System.EventHandler(this.btnAddContainer_Click);

            this.btnUpdateContainer.BackColor = System.Drawing.Color.LightBlue;
            this.btnUpdateContainer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateContainer.Location = new System.Drawing.Point(130, 480);
            this.btnUpdateContainer.Name = "btnUpdateContainer";
            this.btnUpdateContainer.Size = new System.Drawing.Size(100, 40);
            this.btnUpdateContainer.TabIndex = 10;
            this.btnUpdateContainer.Text = "✏️ Update";
            this.btnUpdateContainer.UseVisualStyleBackColor = false;
            this.btnUpdateContainer.Click += new System.EventHandler(this.btnUpdateContainer_Click);

            this.btnDeleteContainer.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeleteContainer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteContainer.Location = new System.Drawing.Point(240, 480);
            this.btnDeleteContainer.Name = "btnDeleteContainer";
            this.btnDeleteContainer.Size = new System.Drawing.Size(100, 40);
            this.btnDeleteContainer.TabIndex = 11;
            this.btnDeleteContainer.Text = "🗑️ Delete";
            this.btnDeleteContainer.UseVisualStyleBackColor = false;
            this.btnDeleteContainer.Click += new System.EventHandler(this.btnDeleteContainer_Click);





            // ==========================================
            // ASSISTANTS TAB - DETAIL FORM INITIALIZATION
            // ==========================================

            // Assistant Details GroupBox - Initialize all form controls
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
            this.groupBoxAssistantDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxAssistantDetails.Location = new System.Drawing.Point(940, 20);
            this.groupBoxAssistantDetails.Name = "groupBoxAssistantDetails";
            this.groupBoxAssistantDetails.Size = new System.Drawing.Size(380, 580);
            this.groupBoxAssistantDetails.TabIndex = 1;
            this.groupBoxAssistantDetails.TabStop = false;
            this.groupBoxAssistantDetails.Text = "Assistant Details";

            // First Name
            this.lblFirstNameAssistant.AutoSize = true;
            this.lblFirstNameAssistant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFirstNameAssistant.Location = new System.Drawing.Point(20, 30);
            this.lblFirstNameAssistant.Name = "lblFirstNameAssistant";
            this.lblFirstNameAssistant.Size = new System.Drawing.Size(84, 20);
            this.lblFirstNameAssistant.TabIndex = 0;
            this.lblFirstNameAssistant.Text = "First Name:";

            this.txtFirstNameAssistant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFirstNameAssistant.Location = new System.Drawing.Point(130, 30);
            this.txtFirstNameAssistant.Name = "txtFirstNameAssistant";
            this.txtFirstNameAssistant.Size = new System.Drawing.Size(200, 27);
            this.txtFirstNameAssistant.TabIndex = 1;

            // Last Name
            this.lblLastNameAssistant.AutoSize = true;
            this.lblLastNameAssistant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLastNameAssistant.Location = new System.Drawing.Point(20, 70);
            this.lblLastNameAssistant.Name = "lblLastNameAssistant";
            this.lblLastNameAssistant.Size = new System.Drawing.Size(83, 20);
            this.lblLastNameAssistant.TabIndex = 2;
            this.lblLastNameAssistant.Text = "Last Name:";

            this.txtLastNameAssistant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLastNameAssistant.Location = new System.Drawing.Point(130, 70);
            this.txtLastNameAssistant.Name = "txtLastNameAssistant";
            this.txtLastNameAssistant.Size = new System.Drawing.Size(200, 27);
            this.txtLastNameAssistant.TabIndex = 3;

            // Phone
            this.lblPhoneAssistant.AutoSize = true;
            this.lblPhoneAssistant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhoneAssistant.Location = new System.Drawing.Point(20, 110);
            this.lblPhoneAssistant.Name = "lblPhoneAssistant";
            this.lblPhoneAssistant.Size = new System.Drawing.Size(53, 20);
            this.lblPhoneAssistant.TabIndex = 4;
            this.lblPhoneAssistant.Text = "Phone:";

            this.txtPhoneAssistant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhoneAssistant.Location = new System.Drawing.Point(130, 110);
            this.txtPhoneAssistant.Name = "txtPhoneAssistant";
            this.txtPhoneAssistant.Size = new System.Drawing.Size(200, 27);
            this.txtPhoneAssistant.TabIndex = 5;

            // Email
            this.lblEmailAssistant.AutoSize = true;
            this.lblEmailAssistant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmailAssistant.Location = new System.Drawing.Point(20, 150);
            this.lblEmailAssistant.Name = "lblEmailAssistant";
            this.lblEmailAssistant.Size = new System.Drawing.Size(49, 20);
            this.lblEmailAssistant.TabIndex = 6;
            this.lblEmailAssistant.Text = "Email:";

            this.txtEmailAssistant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmailAssistant.Location = new System.Drawing.Point(130, 150);
            this.txtEmailAssistant.Name = "txtEmailAssistant";
            this.txtEmailAssistant.Size = new System.Drawing.Size(200, 27);
            this.txtEmailAssistant.TabIndex = 7;

            // Address
            this.lblAddressAssistant.AutoSize = true;
            this.lblAddressAssistant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAddressAssistant.Location = new System.Drawing.Point(20, 190);
            this.lblAddressAssistant.Name = "lblAddressAssistant";
            this.lblAddressAssistant.Size = new System.Drawing.Size(65, 20);
            this.lblAddressAssistant.TabIndex = 8;
            this.lblAddressAssistant.Text = "Address:";

            this.txtAddressAssistant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddressAssistant.Location = new System.Drawing.Point(130, 190);
            this.txtAddressAssistant.Name = "txtAddressAssistant";
            this.txtAddressAssistant.Size = new System.Drawing.Size(200, 27);
            this.txtAddressAssistant.TabIndex = 9;

            // Hire Date
            this.lblHireDate.AutoSize = true;
            this.lblHireDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHireDate.Location = new System.Drawing.Point(20, 230);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(75, 20);
            this.lblHireDate.TabIndex = 10;
            this.lblHireDate.Text = "Hire Date:";

            this.dtpHireDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHireDate.Location = new System.Drawing.Point(130, 230);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(200, 27);
            this.dtpHireDate.TabIndex = 11;

            // Hourly Rate
            this.lblHourlyRateAssistant.AutoSize = true;
            this.lblHourlyRateAssistant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHourlyRateAssistant.Location = new System.Drawing.Point(20, 270);
            this.lblHourlyRateAssistant.Name = "lblHourlyRateAssistant";
            this.lblHourlyRateAssistant.Size = new System.Drawing.Size(90, 20);
            this.lblHourlyRateAssistant.TabIndex = 12;
            this.lblHourlyRateAssistant.Text = "Hourly Rate:";

            this.numHourlyRateAssistant.DecimalPlaces = 2;
            this.numHourlyRateAssistant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numHourlyRateAssistant.Location = new System.Drawing.Point(130, 270);
            this.numHourlyRateAssistant.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numHourlyRateAssistant.Name = "numHourlyRateAssistant";
            this.numHourlyRateAssistant.Size = new System.Drawing.Size(200, 27);
            this.numHourlyRateAssistant.TabIndex = 13;

            // Is Available
            this.chkIsAvailableAssistant.AutoSize = true;
            this.chkIsAvailableAssistant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkIsAvailableAssistant.Location = new System.Drawing.Point(130, 310);
            this.chkIsAvailableAssistant.Name = "chkIsAvailableAssistant";
            this.chkIsAvailableAssistant.Size = new System.Drawing.Size(109, 24);
            this.chkIsAvailableAssistant.TabIndex = 14;
            this.chkIsAvailableAssistant.Text = "Is Available";
            this.chkIsAvailableAssistant.UseVisualStyleBackColor = true;

            // Buttons
            this.btnAddAssistant.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddAssistant.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddAssistant.Location = new System.Drawing.Point(20, 480);
            this.btnAddAssistant.Name = "btnAddAssistant";
            this.btnAddAssistant.Size = new System.Drawing.Size(100, 40);
            this.btnAddAssistant.TabIndex = 15;
            this.btnAddAssistant.Text = "➕ Add";
            this.btnAddAssistant.UseVisualStyleBackColor = false;
            this.btnAddAssistant.Click += new System.EventHandler(this.btnAddAssistant_Click);

            this.btnUpdateAssistant.BackColor = System.Drawing.Color.LightBlue;
            this.btnUpdateAssistant.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateAssistant.Location = new System.Drawing.Point(130, 480);
            this.btnUpdateAssistant.Name = "btnUpdateAssistant";
            this.btnUpdateAssistant.Size = new System.Drawing.Size(100, 40);
            this.btnUpdateAssistant.TabIndex = 16;
            this.btnUpdateAssistant.Text = "✏️ Update";
            this.btnUpdateAssistant.UseVisualStyleBackColor = false;
            this.btnUpdateAssistant.Click += new System.EventHandler(this.btnUpdateAssistant_Click);

            this.btnDeleteAssistant.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeleteAssistant.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteAssistant.Location = new System.Drawing.Point(240, 480);
            this.btnDeleteAssistant.Name = "btnDeleteAssistant";
            this.btnDeleteAssistant.Size = new System.Drawing.Size(100, 40);
            this.btnDeleteAssistant.TabIndex = 17;
            this.btnDeleteAssistant.Text = "🗑️ Delete";
            this.btnDeleteAssistant.UseVisualStyleBackColor = false;
            this.btnDeleteAssistant.Click += new System.EventHandler(this.btnDeleteAssistant_Click);

            // ==========================================
            // BOTTOM CONTROLS
            // ==========================================
            // Status Label
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatus.Location = new System.Drawing.Point(20, 740);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 20);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Ready";

            // Refresh Button
            this.btnRefresh.BackColor = System.Drawing.Color.LightBlue;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(1200, 735);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 35);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "🔄 Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // Close Button
            this.btnClose.BackColor = System.Drawing.Color.LightCoral;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(1290, 735);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 35);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "❌ Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // Resume layout
            this.tabControl1.ResumeLayout(false);
            this.tabTransportUnits.ResumeLayout(false);
            this.tabLorries.ResumeLayout(false);
            this.groupBoxTransportUnits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportUnits)).EndInit();
            this.groupBoxTransportUnitDetails.ResumeLayout(false);
            this.groupBoxTransportUnitDetails.PerformLayout();
            this.groupBoxLorries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLorries)).EndInit();
            this.groupBoxLorryDetails.ResumeLayout(false);
            this.groupBoxLorryDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLoadCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVolumeCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // Control Declarations
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
        private System.Windows.Forms.Label lblStatusContainer;
        private System.Windows.Forms.ComboBox cmbStatusContainer;
        private System.Windows.Forms.CheckBox chkIsAvailableContainer;
        private System.Windows.Forms.Button btnAddContainer;
        private System.Windows.Forms.Button btnUpdateContainer;
        private System.Windows.Forms.Button btnDeleteContainer;

    }
}