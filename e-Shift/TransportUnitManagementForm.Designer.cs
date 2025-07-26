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
            lblTitle = new Label();
            tabControl1 = new TabControl();
            tabTransportUnits = new TabPage();
            groupBoxTransportUnits = new GroupBox();
            dgvTransportUnits = new DataGridView();
            groupBoxTransportUnitDetails = new GroupBox();
            lblUnitNumber = new Label();
            txtUnitNumber = new TextBox();
            lblStatusTU = new Label();
            cmbStatusTU = new ComboBox();
            lblLorryTU = new Label();
            cmbLorryTU = new ComboBox();
            lblDriverTU = new Label();
            cmbDriverTU = new ComboBox();
            lblAssistantTU = new Label();
            cmbAssistantTU = new ComboBox();
            lblContainerTU = new Label();
            cmbContainerTU = new ComboBox();
            chkIsAvailableUnit = new CheckBox();
            btnCreateTransportUnit = new Button();
            btnUpdateTransportUnit = new Button();
            btnDeleteTransportUnit = new Button();
            tabLorries = new TabPage();
            groupBoxLorries = new GroupBox();
            dgvLorries = new DataGridView();
            groupBoxLorryDetails = new GroupBox();
            lblRegistrationNumber = new Label();
            txtRegistrationNumber = new TextBox();
            lblMake = new Label();
            txtMake = new TextBox();
            lblModel = new Label();
            txtModel = new TextBox();
            lblYear = new Label();
            numYear = new NumericUpDown();
            lblLoadCapacity = new Label();
            numLoadCapacity = new NumericUpDown();
            lblVolumeCapacity = new Label();
            numVolumeCapacity = new NumericUpDown();
            lblFuelType = new Label();
            cmbFuelType = new ComboBox();
            lblLastMaintenance = new Label();
            dtpLastMaintenance = new DateTimePicker();
            lblStatusLorry = new Label();
            cmbStatusLorry = new ComboBox();
            chkIsAvailableLorry = new CheckBox();
            btnAddLorry = new Button();
            btnUpdateLorry = new Button();
            btnDeleteLorry = new Button();
            tabDrivers = new TabPage();
            groupBoxDrivers = new GroupBox();
            dgvDrivers = new DataGridView();
            groupBoxDriverDetails = new GroupBox();
            lblLicenseNumber = new Label();
            txtLicenseNumber = new TextBox();
            lblFirstNameDriver = new Label();
            txtFirstNameDriver = new TextBox();
            lblLastNameDriver = new Label();
            txtLastNameDriver = new TextBox();
            lblPhoneDriver = new Label();
            txtPhoneDriver = new TextBox();
            lblEmailDriver = new Label();
            txtEmailDriver = new TextBox();
            lblAddressDriver = new Label();
            txtAddressDriver = new TextBox();
            lblLicenseExpiry = new Label();
            dtpLicenseExpiry = new DateTimePicker();
            lblLicenseClass = new Label();
            cmbLicenseClass = new ComboBox();
            lblHourlyRateDriver = new Label();
            numHourlyRateDriver = new NumericUpDown();
            chkIsAvailableDriver = new CheckBox();
            btnAddDriver = new Button();
            btnUpdateDriver = new Button();
            btnDeleteDriver = new Button();
            tabAssistants = new TabPage();
            groupBoxAssistants = new GroupBox();
            dgvAssistants = new DataGridView();
            groupBoxAssistantDetails = new GroupBox();
            lblFirstNameAssistant = new Label();
            txtFirstNameAssistant = new TextBox();
            lblLastNameAssistant = new Label();
            txtLastNameAssistant = new TextBox();
            lblPhoneAssistant = new Label();
            txtPhoneAssistant = new TextBox();
            lblEmailAssistant = new Label();
            txtEmailAssistant = new TextBox();
            lblAddressAssistant = new Label();
            txtAddressAssistant = new TextBox();
            lblHireDate = new Label();
            dtpHireDate = new DateTimePicker();
            lblHourlyRateAssistant = new Label();
            numHourlyRateAssistant = new NumericUpDown();
            chkIsAvailableAssistant = new CheckBox();
            btnAddAssistant = new Button();
            btnUpdateAssistant = new Button();
            btnDeleteAssistant = new Button();
            tabContainers = new TabPage();
            groupBoxContainers = new GroupBox();
            dgvContainers = new DataGridView();
            groupBoxContainerDetails = new GroupBox();
            lblContainerNumber = new Label();
            txtContainerNumber = new TextBox();
            lblType = new Label();
            cmbType = new ComboBox();
            lblCapacity = new Label();
            numCapacity = new NumericUpDown();
            lblStatusContainer = new Label();
            cmbStatusContainer = new ComboBox();
            chkIsAvailableContainer = new CheckBox();
            btnAddContainer = new Button();
            btnUpdateContainer = new Button();
            btnDeleteContainer = new Button();
            btnRefresh = new Button();
            btnClose = new Button();
            lblStatus = new Label();
            tabControl1.SuspendLayout();
            tabTransportUnits.SuspendLayout();
            groupBoxTransportUnits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransportUnits).BeginInit();
            groupBoxTransportUnitDetails.SuspendLayout();
            tabLorries.SuspendLayout();
            groupBoxLorries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLorries).BeginInit();
            groupBoxLorryDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLoadCapacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numVolumeCapacity).BeginInit();
            tabDrivers.SuspendLayout();
            groupBoxDrivers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDrivers).BeginInit();
            groupBoxDriverDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numHourlyRateDriver).BeginInit();
            tabAssistants.SuspendLayout();
            groupBoxAssistants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAssistants).BeginInit();
            groupBoxAssistantDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numHourlyRateAssistant).BeginInit();
            tabContainers.SuspendLayout();
            groupBoxContainers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContainers).BeginInit();
            groupBoxContainerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCapacity).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(382, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Transport Unit Management";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabTransportUnits);
            tabControl1.Controls.Add(tabLorries);
            tabControl1.Controls.Add(tabDrivers);
            tabControl1.Controls.Add(tabAssistants);
            tabControl1.Controls.Add(tabContainers);
            tabControl1.Font = new Font("Segoe UI", 10F);
            tabControl1.Location = new Point(20, 70);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1350, 650);
            tabControl1.TabIndex = 1;
            // 
            // tabTransportUnits
            // 
            tabTransportUnits.Controls.Add(groupBoxTransportUnits);
            tabTransportUnits.Controls.Add(groupBoxTransportUnitDetails);
            tabTransportUnits.Location = new Point(4, 32);
            tabTransportUnits.Name = "tabTransportUnits";
            tabTransportUnits.Size = new Size(1342, 614);
            tabTransportUnits.TabIndex = 0;
            tabTransportUnits.Text = "🚛 Transport Units";
            tabTransportUnits.UseVisualStyleBackColor = true;
            // 
            // groupBoxTransportUnits
            // 
            groupBoxTransportUnits.Controls.Add(dgvTransportUnits);
            groupBoxTransportUnits.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxTransportUnits.Location = new Point(20, 20);
            groupBoxTransportUnits.Name = "groupBoxTransportUnits";
            groupBoxTransportUnits.Size = new Size(900, 580);
            groupBoxTransportUnits.TabIndex = 0;
            groupBoxTransportUnits.TabStop = false;
            groupBoxTransportUnits.Text = "Transport Units List";
            // 
            // dgvTransportUnits
            // 
            dgvTransportUnits.AllowUserToAddRows = false;
            dgvTransportUnits.AllowUserToDeleteRows = false;
            dgvTransportUnits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransportUnits.BackgroundColor = SystemColors.Window;
            dgvTransportUnits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransportUnits.Location = new Point(20, 30);
            dgvTransportUnits.MultiSelect = false;
            dgvTransportUnits.Name = "dgvTransportUnits";
            dgvTransportUnits.ReadOnly = true;
            dgvTransportUnits.RowHeadersWidth = 51;
            dgvTransportUnits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransportUnits.Size = new Size(860, 530);
            dgvTransportUnits.TabIndex = 0;
            dgvTransportUnits.CellClick += dgvTransportUnits_CellClick;
           // dgvTransportUnits.CellContentClick += dgvTransportUnits_CellContentClick;
            // 
            // groupBoxTransportUnitDetails
            // 
            groupBoxTransportUnitDetails.Controls.Add(lblUnitNumber);
            groupBoxTransportUnitDetails.Controls.Add(txtUnitNumber);
            groupBoxTransportUnitDetails.Controls.Add(lblStatusTU);
            groupBoxTransportUnitDetails.Controls.Add(cmbStatusTU);
            groupBoxTransportUnitDetails.Controls.Add(lblLorryTU);
            groupBoxTransportUnitDetails.Controls.Add(cmbLorryTU);
            groupBoxTransportUnitDetails.Controls.Add(lblDriverTU);
            groupBoxTransportUnitDetails.Controls.Add(cmbDriverTU);
            groupBoxTransportUnitDetails.Controls.Add(lblAssistantTU);
            groupBoxTransportUnitDetails.Controls.Add(cmbAssistantTU);
            groupBoxTransportUnitDetails.Controls.Add(lblContainerTU);
            groupBoxTransportUnitDetails.Controls.Add(cmbContainerTU);
            groupBoxTransportUnitDetails.Controls.Add(chkIsAvailableUnit);
            groupBoxTransportUnitDetails.Controls.Add(btnCreateTransportUnit);
            groupBoxTransportUnitDetails.Controls.Add(btnUpdateTransportUnit);
            groupBoxTransportUnitDetails.Controls.Add(btnDeleteTransportUnit);
            groupBoxTransportUnitDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxTransportUnitDetails.Location = new Point(940, 20);
            groupBoxTransportUnitDetails.Name = "groupBoxTransportUnitDetails";
            groupBoxTransportUnitDetails.Size = new Size(380, 580);
            groupBoxTransportUnitDetails.TabIndex = 1;
            groupBoxTransportUnitDetails.TabStop = false;
            groupBoxTransportUnitDetails.Text = "Transport Unit Details";
            // 
            // lblUnitNumber
            // 
            lblUnitNumber.AutoSize = true;
            lblUnitNumber.Font = new Font("Segoe UI", 9F);
            lblUnitNumber.Location = new Point(20, 40);
            lblUnitNumber.Name = "lblUnitNumber";
            lblUnitNumber.Size = new Size(97, 20);
            lblUnitNumber.TabIndex = 0;
            lblUnitNumber.Text = "Unit Number:";
            // 
            // txtUnitNumber
            // 
            txtUnitNumber.Font = new Font("Segoe UI", 9F);
            txtUnitNumber.Location = new Point(130, 37);
            txtUnitNumber.Name = "txtUnitNumber";
            txtUnitNumber.Size = new Size(220, 27);
            txtUnitNumber.TabIndex = 1;
            // 
            // lblStatusTU
            // 
            lblStatusTU.AutoSize = true;
            lblStatusTU.Font = new Font("Segoe UI", 9F);
            lblStatusTU.Location = new Point(20, 80);
            lblStatusTU.Name = "lblStatusTU";
            lblStatusTU.Size = new Size(52, 20);
            lblStatusTU.TabIndex = 2;
            lblStatusTU.Text = "Status:";
            // 
            // cmbStatusTU
            // 
            cmbStatusTU.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusTU.Font = new Font("Segoe UI", 9F);
            cmbStatusTU.Location = new Point(130, 77);
            cmbStatusTU.Name = "cmbStatusTU";
            cmbStatusTU.Size = new Size(220, 28);
            cmbStatusTU.TabIndex = 3;
            // 
            // lblLorryTU
            // 
            lblLorryTU.AutoSize = true;
            lblLorryTU.Font = new Font("Segoe UI", 9F);
            lblLorryTU.Location = new Point(20, 120);
            lblLorryTU.Name = "lblLorryTU";
            lblLorryTU.Size = new Size(45, 20);
            lblLorryTU.TabIndex = 4;
            lblLorryTU.Text = "Lorry:";
            // 
            // cmbLorryTU
            // 
            cmbLorryTU.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLorryTU.Font = new Font("Segoe UI", 9F);
            cmbLorryTU.Location = new Point(130, 117);
            cmbLorryTU.Name = "cmbLorryTU";
            cmbLorryTU.Size = new Size(220, 28);
            cmbLorryTU.TabIndex = 5;
            // 
            // lblDriverTU
            // 
            lblDriverTU.AutoSize = true;
            lblDriverTU.Font = new Font("Segoe UI", 9F);
            lblDriverTU.Location = new Point(20, 160);
            lblDriverTU.Name = "lblDriverTU";
            lblDriverTU.Size = new Size(52, 20);
            lblDriverTU.TabIndex = 6;
            lblDriverTU.Text = "Driver:";
            // 
            // cmbDriverTU
            // 
            cmbDriverTU.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDriverTU.Font = new Font("Segoe UI", 9F);
            cmbDriverTU.Location = new Point(130, 157);
            cmbDriverTU.Name = "cmbDriverTU";
            cmbDriverTU.Size = new Size(220, 28);
            cmbDriverTU.TabIndex = 7;
            // 
            // lblAssistantTU
            // 
            lblAssistantTU.AutoSize = true;
            lblAssistantTU.Font = new Font("Segoe UI", 9F);
            lblAssistantTU.Location = new Point(20, 200);
            lblAssistantTU.Name = "lblAssistantTU";
            lblAssistantTU.Size = new Size(70, 20);
            lblAssistantTU.TabIndex = 8;
            lblAssistantTU.Text = "Assistant:";
            // 
            // cmbAssistantTU
            // 
            cmbAssistantTU.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAssistantTU.Font = new Font("Segoe UI", 9F);
            cmbAssistantTU.Location = new Point(130, 197);
            cmbAssistantTU.Name = "cmbAssistantTU";
            cmbAssistantTU.Size = new Size(220, 28);
            cmbAssistantTU.TabIndex = 9;
            // 
            // lblContainerTU
            // 
            lblContainerTU.AutoSize = true;
            lblContainerTU.Font = new Font("Segoe UI", 9F);
            lblContainerTU.Location = new Point(20, 240);
            lblContainerTU.Name = "lblContainerTU";
            lblContainerTU.Size = new Size(76, 20);
            lblContainerTU.TabIndex = 10;
            lblContainerTU.Text = "Container:";
            // 
            // cmbContainerTU
            // 
            cmbContainerTU.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbContainerTU.Font = new Font("Segoe UI", 9F);
            cmbContainerTU.Location = new Point(130, 237);
            cmbContainerTU.Name = "cmbContainerTU";
            cmbContainerTU.Size = new Size(220, 28);
            cmbContainerTU.TabIndex = 11;
            // 
            // chkIsAvailableUnit
            // 
            chkIsAvailableUnit.AutoSize = true;
            chkIsAvailableUnit.Font = new Font("Segoe UI", 9F);
            chkIsAvailableUnit.Location = new Point(130, 280);
            chkIsAvailableUnit.Name = "chkIsAvailableUnit";
            chkIsAvailableUnit.Size = new Size(107, 24);
            chkIsAvailableUnit.TabIndex = 12;
            chkIsAvailableUnit.Text = "Is Available";
            chkIsAvailableUnit.UseVisualStyleBackColor = true;
            // 
            // btnCreateTransportUnit
            // 
            btnCreateTransportUnit.BackColor = Color.LightGreen;
            btnCreateTransportUnit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCreateTransportUnit.Location = new Point(20, 480);
            btnCreateTransportUnit.Name = "btnCreateTransportUnit";
            btnCreateTransportUnit.Size = new Size(110, 40);
            btnCreateTransportUnit.TabIndex = 13;
            btnCreateTransportUnit.Text = "➕ Create";
            btnCreateTransportUnit.UseVisualStyleBackColor = false;
            btnCreateTransportUnit.Click += btnCreateTransportUnit_Click;
            // 
            // btnUpdateTransportUnit
            // 
            btnUpdateTransportUnit.BackColor = Color.LightBlue;
            btnUpdateTransportUnit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdateTransportUnit.Location = new Point(140, 480);
            btnUpdateTransportUnit.Name = "btnUpdateTransportUnit";
            btnUpdateTransportUnit.Size = new Size(110, 40);
            btnUpdateTransportUnit.TabIndex = 14;
            btnUpdateTransportUnit.Text = "✏️ Update";
            btnUpdateTransportUnit.UseVisualStyleBackColor = false;
            btnUpdateTransportUnit.Click += btnUpdateTransportUnit_Click;
            // 
            // btnDeleteTransportUnit
            // 
            btnDeleteTransportUnit.BackColor = Color.LightCoral;
            btnDeleteTransportUnit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeleteTransportUnit.Location = new Point(260, 480);
            btnDeleteTransportUnit.Name = "btnDeleteTransportUnit";
            btnDeleteTransportUnit.Size = new Size(110, 40);
            btnDeleteTransportUnit.TabIndex = 15;
            btnDeleteTransportUnit.Text = "🗑️ Delete";
            btnDeleteTransportUnit.UseVisualStyleBackColor = false;
            btnDeleteTransportUnit.Click += btnDeleteTransportUnit_Click;
            // 
            // tabLorries
            // 
            tabLorries.Controls.Add(groupBoxLorries);
            tabLorries.Controls.Add(groupBoxLorryDetails);
            tabLorries.Location = new Point(4, 32);
            tabLorries.Name = "tabLorries";
            tabLorries.Size = new Size(1342, 614);
            tabLorries.TabIndex = 1;
            tabLorries.Text = "🚛 Lorries";
            tabLorries.UseVisualStyleBackColor = true;
            // 
            // groupBoxLorries
            // 
            groupBoxLorries.Controls.Add(dgvLorries);
            groupBoxLorries.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxLorries.Location = new Point(20, 20);
            groupBoxLorries.Name = "groupBoxLorries";
            groupBoxLorries.Size = new Size(900, 580);
            groupBoxLorries.TabIndex = 0;
            groupBoxLorries.TabStop = false;
            groupBoxLorries.Text = "Lorries List";
            // 
            // dgvLorries
            // 
            dgvLorries.AllowUserToAddRows = false;
            dgvLorries.AllowUserToDeleteRows = false;
            dgvLorries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLorries.BackgroundColor = SystemColors.Window;
            dgvLorries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLorries.Location = new Point(20, 30);
            dgvLorries.MultiSelect = false;
            dgvLorries.Name = "dgvLorries";
            dgvLorries.ReadOnly = true;
            dgvLorries.RowHeadersWidth = 51;
            dgvLorries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLorries.Size = new Size(860, 530);
            dgvLorries.TabIndex = 0;
            dgvLorries.CellClick += dgvLorries_CellClick;
            // 
            // groupBoxLorryDetails
            // 
            groupBoxLorryDetails.Controls.Add(lblRegistrationNumber);
            groupBoxLorryDetails.Controls.Add(txtRegistrationNumber);
            groupBoxLorryDetails.Controls.Add(lblMake);
            groupBoxLorryDetails.Controls.Add(txtMake);
            groupBoxLorryDetails.Controls.Add(lblModel);
            groupBoxLorryDetails.Controls.Add(txtModel);
            groupBoxLorryDetails.Controls.Add(lblYear);
            groupBoxLorryDetails.Controls.Add(numYear);
            groupBoxLorryDetails.Controls.Add(lblLoadCapacity);
            groupBoxLorryDetails.Controls.Add(numLoadCapacity);
            groupBoxLorryDetails.Controls.Add(lblVolumeCapacity);
            groupBoxLorryDetails.Controls.Add(numVolumeCapacity);
            groupBoxLorryDetails.Controls.Add(lblFuelType);
            groupBoxLorryDetails.Controls.Add(cmbFuelType);
            groupBoxLorryDetails.Controls.Add(lblLastMaintenance);
            groupBoxLorryDetails.Controls.Add(dtpLastMaintenance);
            groupBoxLorryDetails.Controls.Add(lblStatusLorry);
            groupBoxLorryDetails.Controls.Add(cmbStatusLorry);
            groupBoxLorryDetails.Controls.Add(chkIsAvailableLorry);
            groupBoxLorryDetails.Controls.Add(btnAddLorry);
            groupBoxLorryDetails.Controls.Add(btnUpdateLorry);
            groupBoxLorryDetails.Controls.Add(btnDeleteLorry);
            groupBoxLorryDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxLorryDetails.Location = new Point(940, 20);
            groupBoxLorryDetails.Name = "groupBoxLorryDetails";
            groupBoxLorryDetails.Size = new Size(380, 580);
            groupBoxLorryDetails.TabIndex = 1;
            groupBoxLorryDetails.TabStop = false;
            groupBoxLorryDetails.Text = "Lorry Details";
            // 
            // lblRegistrationNumber
            // 
            lblRegistrationNumber.AutoSize = true;
            lblRegistrationNumber.Font = new Font("Segoe UI", 9F);
            lblRegistrationNumber.Location = new Point(20, 40);
            lblRegistrationNumber.Name = "lblRegistrationNumber";
            lblRegistrationNumber.Size = new Size(92, 20);
            lblRegistrationNumber.TabIndex = 0;
            lblRegistrationNumber.Text = "Registration:";
            // 
            // txtRegistrationNumber
            // 
            txtRegistrationNumber.Font = new Font("Segoe UI", 9F);
            txtRegistrationNumber.Location = new Point(130, 37);
            txtRegistrationNumber.Name = "txtRegistrationNumber";
            txtRegistrationNumber.Size = new Size(220, 27);
            txtRegistrationNumber.TabIndex = 1;
            // 
            // lblMake
            // 
            lblMake.AutoSize = true;
            lblMake.Font = new Font("Segoe UI", 9F);
            lblMake.Location = new Point(20, 80);
            lblMake.Name = "lblMake";
            lblMake.Size = new Size(48, 20);
            lblMake.TabIndex = 2;
            lblMake.Text = "Make:";
            // 
            // txtMake
            // 
            txtMake.Font = new Font("Segoe UI", 9F);
            txtMake.Location = new Point(130, 77);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(220, 27);
            txtMake.TabIndex = 3;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Font = new Font("Segoe UI", 9F);
            lblModel.Location = new Point(20, 120);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(55, 20);
            lblModel.TabIndex = 4;
            lblModel.Text = "Model:";
            // 
            // txtModel
            // 
            txtModel.Font = new Font("Segoe UI", 9F);
            txtModel.Location = new Point(130, 117);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(220, 27);
            txtModel.TabIndex = 5;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 9F);
            lblYear.Location = new Point(20, 160);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(40, 20);
            lblYear.TabIndex = 6;
            lblYear.Text = "Year:";
            // 
            // numYear
            // 
            numYear.Font = new Font("Segoe UI", 9F);
            numYear.Location = new Point(130, 157);
            numYear.Maximum = new decimal(new int[] { 2030, 0, 0, 0 });
            numYear.Minimum = new decimal(new int[] { 1980, 0, 0, 0 });
            numYear.Name = "numYear";
            numYear.Size = new Size(100, 27);
            numYear.TabIndex = 7;
            numYear.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // lblLoadCapacity
            // 
            lblLoadCapacity.AutoSize = true;
            lblLoadCapacity.Font = new Font("Segoe UI", 9F);
            lblLoadCapacity.Location = new Point(20, 200);
            lblLoadCapacity.Name = "lblLoadCapacity";
            lblLoadCapacity.Size = new Size(106, 20);
            lblLoadCapacity.TabIndex = 8;
            lblLoadCapacity.Text = "Load Capacity:";
            // 
            // numLoadCapacity
            // 
            numLoadCapacity.Font = new Font("Segoe UI", 9F);
            numLoadCapacity.Location = new Point(130, 197);
            numLoadCapacity.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            numLoadCapacity.Name = "numLoadCapacity";
            numLoadCapacity.Size = new Size(120, 27);
            numLoadCapacity.TabIndex = 9;
            // 
            // lblVolumeCapacity
            // 
            lblVolumeCapacity.AutoSize = true;
            lblVolumeCapacity.Font = new Font("Segoe UI", 9F);
            lblVolumeCapacity.Location = new Point(20, 240);
            lblVolumeCapacity.Name = "lblVolumeCapacity";
            lblVolumeCapacity.Size = new Size(123, 20);
            lblVolumeCapacity.TabIndex = 10;
            lblVolumeCapacity.Text = "Volume Capacity:";
            // 
            // numVolumeCapacity
            // 
            numVolumeCapacity.Font = new Font("Segoe UI", 9F);
            numVolumeCapacity.Location = new Point(150, 237);
            numVolumeCapacity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numVolumeCapacity.Name = "numVolumeCapacity";
            numVolumeCapacity.Size = new Size(100, 27);
            numVolumeCapacity.TabIndex = 11;
            // 
            // lblFuelType
            // 
            lblFuelType.AutoSize = true;
            lblFuelType.Font = new Font("Segoe UI", 9F);
            lblFuelType.Location = new Point(20, 280);
            lblFuelType.Name = "lblFuelType";
            lblFuelType.Size = new Size(74, 20);
            lblFuelType.TabIndex = 12;
            lblFuelType.Text = "Fuel Type:";
            // 
            // cmbFuelType
            // 
            cmbFuelType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFuelType.Font = new Font("Segoe UI", 9F);
            cmbFuelType.Location = new Point(130, 277);
            cmbFuelType.Name = "cmbFuelType";
            cmbFuelType.Size = new Size(120, 28);
            cmbFuelType.TabIndex = 13;
            // 
            // lblLastMaintenance
            // 
            lblLastMaintenance.AutoSize = true;
            lblLastMaintenance.Font = new Font("Segoe UI", 9F);
            lblLastMaintenance.Location = new Point(20, 320);
            lblLastMaintenance.Name = "lblLastMaintenance";
            lblLastMaintenance.Size = new Size(127, 20);
            lblLastMaintenance.TabIndex = 14;
            lblLastMaintenance.Text = "Last Maintenance:";
            // 
            // dtpLastMaintenance
            // 
            dtpLastMaintenance.Font = new Font("Segoe UI", 9F);
            dtpLastMaintenance.Location = new Point(150, 317);
            dtpLastMaintenance.Name = "dtpLastMaintenance";
            dtpLastMaintenance.Size = new Size(200, 27);
            dtpLastMaintenance.TabIndex = 15;
            // 
            // lblStatusLorry
            // 
            lblStatusLorry.AutoSize = true;
            lblStatusLorry.Font = new Font("Segoe UI", 9F);
            lblStatusLorry.Location = new Point(20, 360);
            lblStatusLorry.Name = "lblStatusLorry";
            lblStatusLorry.Size = new Size(52, 20);
            lblStatusLorry.TabIndex = 16;
            lblStatusLorry.Text = "Status:";
            // 
            // cmbStatusLorry
            // 
            cmbStatusLorry.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusLorry.Font = new Font("Segoe UI", 9F);
            cmbStatusLorry.Location = new Point(130, 357);
            cmbStatusLorry.Name = "cmbStatusLorry";
            cmbStatusLorry.Size = new Size(120, 28);
            cmbStatusLorry.TabIndex = 17;
            // 
            // chkIsAvailableLorry
            // 
            chkIsAvailableLorry.AutoSize = true;
            chkIsAvailableLorry.Font = new Font("Segoe UI", 9F);
            chkIsAvailableLorry.Location = new Point(130, 400);
            chkIsAvailableLorry.Name = "chkIsAvailableLorry";
            chkIsAvailableLorry.Size = new Size(107, 24);
            chkIsAvailableLorry.TabIndex = 18;
            chkIsAvailableLorry.Text = "Is Available";
            chkIsAvailableLorry.UseVisualStyleBackColor = true;
            // 
            // btnAddLorry
            // 
            btnAddLorry.BackColor = Color.LightGreen;
            btnAddLorry.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddLorry.Location = new Point(20, 480);
            btnAddLorry.Name = "btnAddLorry";
            btnAddLorry.Size = new Size(110, 40);
            btnAddLorry.TabIndex = 19;
            btnAddLorry.Text = "➕ Add";
            btnAddLorry.UseVisualStyleBackColor = false;
            btnAddLorry.Click += btnAddLorry_Click;
            // 
            // btnUpdateLorry
            // 
            btnUpdateLorry.BackColor = Color.LightBlue;
            btnUpdateLorry.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdateLorry.Location = new Point(140, 480);
            btnUpdateLorry.Name = "btnUpdateLorry";
            btnUpdateLorry.Size = new Size(110, 40);
            btnUpdateLorry.TabIndex = 20;
            btnUpdateLorry.Text = "✏️ Update";
            btnUpdateLorry.UseVisualStyleBackColor = false;
            btnUpdateLorry.Click += btnUpdateLorry_Click;
            // 
            // btnDeleteLorry
            // 
            btnDeleteLorry.BackColor = Color.LightCoral;
            btnDeleteLorry.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeleteLorry.Location = new Point(260, 480);
            btnDeleteLorry.Name = "btnDeleteLorry";
            btnDeleteLorry.Size = new Size(110, 40);
            btnDeleteLorry.TabIndex = 21;
            btnDeleteLorry.Text = "🗑️ Delete";
            btnDeleteLorry.UseVisualStyleBackColor = false;
            btnDeleteLorry.Click += btnDeleteLorry_Click;
            // 
            // tabDrivers
            // 
            tabDrivers.Controls.Add(groupBoxDrivers);
            tabDrivers.Controls.Add(groupBoxDriverDetails);
            tabDrivers.Location = new Point(4, 32);
            tabDrivers.Name = "tabDrivers";
            tabDrivers.Size = new Size(1342, 614);
            tabDrivers.TabIndex = 2;
            tabDrivers.Text = "👨‍💼 Drivers";
            tabDrivers.UseVisualStyleBackColor = true;
            // 
            // groupBoxDrivers
            // 
            groupBoxDrivers.Controls.Add(dgvDrivers);
            groupBoxDrivers.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxDrivers.Location = new Point(20, 20);
            groupBoxDrivers.Name = "groupBoxDrivers";
            groupBoxDrivers.Size = new Size(900, 580);
            groupBoxDrivers.TabIndex = 0;
            groupBoxDrivers.TabStop = false;
            groupBoxDrivers.Text = "Drivers List";
            // 
            // dgvDrivers
            // 
            dgvDrivers.AllowUserToAddRows = false;
            dgvDrivers.AllowUserToDeleteRows = false;
            dgvDrivers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDrivers.BackgroundColor = SystemColors.Window;
            dgvDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrivers.Location = new Point(20, 30);
            dgvDrivers.MultiSelect = false;
            dgvDrivers.Name = "dgvDrivers";
            dgvDrivers.ReadOnly = true;
            dgvDrivers.RowHeadersWidth = 51;
            dgvDrivers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDrivers.Size = new Size(860, 530);
            dgvDrivers.TabIndex = 0;
            dgvDrivers.CellClick += dgvDrivers_CellClick;
            // 
            // groupBoxDriverDetails
            // 
            groupBoxDriverDetails.Controls.Add(lblLicenseNumber);
            groupBoxDriverDetails.Controls.Add(txtLicenseNumber);
            groupBoxDriverDetails.Controls.Add(lblFirstNameDriver);
            groupBoxDriverDetails.Controls.Add(txtFirstNameDriver);
            groupBoxDriverDetails.Controls.Add(lblLastNameDriver);
            groupBoxDriverDetails.Controls.Add(txtLastNameDriver);
            groupBoxDriverDetails.Controls.Add(lblPhoneDriver);
            groupBoxDriverDetails.Controls.Add(txtPhoneDriver);
            groupBoxDriverDetails.Controls.Add(lblEmailDriver);
            groupBoxDriverDetails.Controls.Add(txtEmailDriver);
            groupBoxDriverDetails.Controls.Add(lblAddressDriver);
            groupBoxDriverDetails.Controls.Add(txtAddressDriver);
            groupBoxDriverDetails.Controls.Add(lblLicenseExpiry);
            groupBoxDriverDetails.Controls.Add(dtpLicenseExpiry);
            groupBoxDriverDetails.Controls.Add(lblLicenseClass);
            groupBoxDriverDetails.Controls.Add(cmbLicenseClass);
            groupBoxDriverDetails.Controls.Add(lblHourlyRateDriver);
            groupBoxDriverDetails.Controls.Add(numHourlyRateDriver);
            groupBoxDriverDetails.Controls.Add(chkIsAvailableDriver);
            groupBoxDriverDetails.Controls.Add(btnAddDriver);
            groupBoxDriverDetails.Controls.Add(btnUpdateDriver);
            groupBoxDriverDetails.Controls.Add(btnDeleteDriver);
            groupBoxDriverDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxDriverDetails.Location = new Point(940, 20);
            groupBoxDriverDetails.Name = "groupBoxDriverDetails";
            groupBoxDriverDetails.Size = new Size(380, 580);
            groupBoxDriverDetails.TabIndex = 1;
            groupBoxDriverDetails.TabStop = false;
            groupBoxDriverDetails.Text = "Driver Details";
            // 
            // lblLicenseNumber
            // 
            lblLicenseNumber.AutoSize = true;
            lblLicenseNumber.Font = new Font("Segoe UI", 9F);
            lblLicenseNumber.Location = new Point(20, 30);
            lblLicenseNumber.Name = "lblLicenseNumber";
            lblLicenseNumber.Size = new Size(84, 20);
            lblLicenseNumber.TabIndex = 0;
            lblLicenseNumber.Text = "License No:";
            // 
            // txtLicenseNumber
            // 
            txtLicenseNumber.Font = new Font("Segoe UI", 9F);
            txtLicenseNumber.Location = new Point(130, 30);
            txtLicenseNumber.Name = "txtLicenseNumber";
            txtLicenseNumber.Size = new Size(200, 27);
            txtLicenseNumber.TabIndex = 1;
            // 
            // lblFirstNameDriver
            // 
            lblFirstNameDriver.AutoSize = true;
            lblFirstNameDriver.Font = new Font("Segoe UI", 9F);
            lblFirstNameDriver.Location = new Point(20, 70);
            lblFirstNameDriver.Name = "lblFirstNameDriver";
            lblFirstNameDriver.Size = new Size(83, 20);
            lblFirstNameDriver.TabIndex = 2;
            lblFirstNameDriver.Text = "First Name:";
            // 
            // txtFirstNameDriver
            // 
            txtFirstNameDriver.Font = new Font("Segoe UI", 9F);
            txtFirstNameDriver.Location = new Point(130, 70);
            txtFirstNameDriver.Name = "txtFirstNameDriver";
            txtFirstNameDriver.Size = new Size(200, 27);
            txtFirstNameDriver.TabIndex = 3;
            // 
            // lblLastNameDriver
            // 
            lblLastNameDriver.AutoSize = true;
            lblLastNameDriver.Font = new Font("Segoe UI", 9F);
            lblLastNameDriver.Location = new Point(20, 110);
            lblLastNameDriver.Name = "lblLastNameDriver";
            lblLastNameDriver.Size = new Size(82, 20);
            lblLastNameDriver.TabIndex = 4;
            lblLastNameDriver.Text = "Last Name:";
            // 
            // txtLastNameDriver
            // 
            txtLastNameDriver.Font = new Font("Segoe UI", 9F);
            txtLastNameDriver.Location = new Point(130, 110);
            txtLastNameDriver.Name = "txtLastNameDriver";
            txtLastNameDriver.Size = new Size(200, 27);
            txtLastNameDriver.TabIndex = 5;
            // 
            // lblPhoneDriver
            // 
            lblPhoneDriver.AutoSize = true;
            lblPhoneDriver.Font = new Font("Segoe UI", 9F);
            lblPhoneDriver.Location = new Point(20, 150);
            lblPhoneDriver.Name = "lblPhoneDriver";
            lblPhoneDriver.Size = new Size(53, 20);
            lblPhoneDriver.TabIndex = 6;
            lblPhoneDriver.Text = "Phone:";
            // 
            // txtPhoneDriver
            // 
            txtPhoneDriver.Font = new Font("Segoe UI", 9F);
            txtPhoneDriver.Location = new Point(130, 150);
            txtPhoneDriver.Name = "txtPhoneDriver";
            txtPhoneDriver.Size = new Size(200, 27);
            txtPhoneDriver.TabIndex = 7;
            // 
            // lblEmailDriver
            // 
            lblEmailDriver.AutoSize = true;
            lblEmailDriver.Font = new Font("Segoe UI", 9F);
            lblEmailDriver.Location = new Point(20, 190);
            lblEmailDriver.Name = "lblEmailDriver";
            lblEmailDriver.Size = new Size(49, 20);
            lblEmailDriver.TabIndex = 8;
            lblEmailDriver.Text = "Email:";
            // 
            // txtEmailDriver
            // 
            txtEmailDriver.Font = new Font("Segoe UI", 9F);
            txtEmailDriver.Location = new Point(130, 190);
            txtEmailDriver.Name = "txtEmailDriver";
            txtEmailDriver.Size = new Size(200, 27);
            txtEmailDriver.TabIndex = 9;
            // 
            // lblAddressDriver
            // 
            lblAddressDriver.AutoSize = true;
            lblAddressDriver.Font = new Font("Segoe UI", 9F);
            lblAddressDriver.Location = new Point(20, 230);
            lblAddressDriver.Name = "lblAddressDriver";
            lblAddressDriver.Size = new Size(65, 20);
            lblAddressDriver.TabIndex = 10;
            lblAddressDriver.Text = "Address:";
            // 
            // txtAddressDriver
            // 
            txtAddressDriver.Font = new Font("Segoe UI", 9F);
            txtAddressDriver.Location = new Point(130, 230);
            txtAddressDriver.Name = "txtAddressDriver";
            txtAddressDriver.Size = new Size(200, 27);
            txtAddressDriver.TabIndex = 11;
            // 
            // lblLicenseExpiry
            // 
            lblLicenseExpiry.AutoSize = true;
            lblLicenseExpiry.Font = new Font("Segoe UI", 9F);
            lblLicenseExpiry.Location = new Point(20, 270);
            lblLicenseExpiry.Name = "lblLicenseExpiry";
            lblLicenseExpiry.Size = new Size(104, 20);
            lblLicenseExpiry.TabIndex = 12;
            lblLicenseExpiry.Text = "License Expiry:";
            // 
            // dtpLicenseExpiry
            // 
            dtpLicenseExpiry.Font = new Font("Segoe UI", 9F);
            dtpLicenseExpiry.Format = DateTimePickerFormat.Short;
            dtpLicenseExpiry.Location = new Point(130, 270);
            dtpLicenseExpiry.Name = "dtpLicenseExpiry";
            dtpLicenseExpiry.Size = new Size(200, 27);
            dtpLicenseExpiry.TabIndex = 13;
            // 
            // lblLicenseClass
            // 
            lblLicenseClass.AutoSize = true;
            lblLicenseClass.Font = new Font("Segoe UI", 9F);
            lblLicenseClass.Location = new Point(20, 310);
            lblLicenseClass.Name = "lblLicenseClass";
            lblLicenseClass.Size = new Size(97, 20);
            lblLicenseClass.TabIndex = 14;
            lblLicenseClass.Text = "License Class:";
            // 
            // cmbLicenseClass
            // 
            cmbLicenseClass.Font = new Font("Segoe UI", 9F);
            cmbLicenseClass.FormattingEnabled = true;
            cmbLicenseClass.Items.AddRange(new object[] { "Light", "Heavy", "Special" });
            cmbLicenseClass.Location = new Point(130, 310);
            cmbLicenseClass.Name = "cmbLicenseClass";
            cmbLicenseClass.Size = new Size(200, 28);
            cmbLicenseClass.TabIndex = 15;
            // 
            // lblHourlyRateDriver
            // 
            lblHourlyRateDriver.AutoSize = true;
            lblHourlyRateDriver.Font = new Font("Segoe UI", 9F);
            lblHourlyRateDriver.Location = new Point(20, 350);
            lblHourlyRateDriver.Name = "lblHourlyRateDriver";
            lblHourlyRateDriver.Size = new Size(90, 20);
            lblHourlyRateDriver.TabIndex = 16;
            lblHourlyRateDriver.Text = "Hourly Rate:";
            // 
            // numHourlyRateDriver
            // 
            numHourlyRateDriver.DecimalPlaces = 2;
            numHourlyRateDriver.Font = new Font("Segoe UI", 9F);
            numHourlyRateDriver.Location = new Point(130, 350);
            numHourlyRateDriver.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numHourlyRateDriver.Name = "numHourlyRateDriver";
            numHourlyRateDriver.Size = new Size(200, 27);
            numHourlyRateDriver.TabIndex = 17;
            // 
            // chkIsAvailableDriver
            // 
            chkIsAvailableDriver.AutoSize = true;
            chkIsAvailableDriver.Font = new Font("Segoe UI", 9F);
            chkIsAvailableDriver.Location = new Point(130, 390);
            chkIsAvailableDriver.Name = "chkIsAvailableDriver";
            chkIsAvailableDriver.Size = new Size(109, 24);
            chkIsAvailableDriver.TabIndex = 18;
            chkIsAvailableDriver.Text = "Is Available";
            chkIsAvailableDriver.UseVisualStyleBackColor = true;
            // 
            // btnAddDriver
            // 
            btnAddDriver.BackColor = Color.LightGreen;
            btnAddDriver.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddDriver.Location = new Point(20, 480);
            btnAddDriver.Name = "btnAddDriver";
            btnAddDriver.Size = new Size(100, 40);
            btnAddDriver.TabIndex = 19;
            btnAddDriver.Text = "➕ Add";
            btnAddDriver.UseVisualStyleBackColor = false;
            btnAddDriver.Click += btnAddDriver_Click;
            // 
            // btnUpdateDriver
            // 
            btnUpdateDriver.BackColor = Color.LightBlue;
            btnUpdateDriver.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdateDriver.Location = new Point(130, 480);
            btnUpdateDriver.Name = "btnUpdateDriver";
            btnUpdateDriver.Size = new Size(100, 40);
            btnUpdateDriver.TabIndex = 20;
            btnUpdateDriver.Text = "✏️ Update";
            btnUpdateDriver.UseVisualStyleBackColor = false;
            btnUpdateDriver.Click += btnUpdateDriver_Click;
            // 
            // btnDeleteDriver
            // 
            btnDeleteDriver.BackColor = Color.LightCoral;
            btnDeleteDriver.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeleteDriver.Location = new Point(240, 480);
            btnDeleteDriver.Name = "btnDeleteDriver";
            btnDeleteDriver.Size = new Size(100, 40);
            btnDeleteDriver.TabIndex = 21;
            btnDeleteDriver.Text = "🗑️ Delete";
            btnDeleteDriver.UseVisualStyleBackColor = false;
            btnDeleteDriver.Click += btnDeleteDriver_Click;
            // 
            // tabAssistants
            // 
            tabAssistants.Controls.Add(groupBoxAssistants);
            tabAssistants.Controls.Add(groupBoxAssistantDetails);
            tabAssistants.Location = new Point(4, 32);
            tabAssistants.Name = "tabAssistants";
            tabAssistants.Size = new Size(1342, 614);
            tabAssistants.TabIndex = 3;
            tabAssistants.Text = "👷‍♂️ Assistants";
            tabAssistants.UseVisualStyleBackColor = true;
            // 
            // groupBoxAssistants
            // 
            groupBoxAssistants.Controls.Add(dgvAssistants);
            groupBoxAssistants.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxAssistants.Location = new Point(20, 20);
            groupBoxAssistants.Name = "groupBoxAssistants";
            groupBoxAssistants.Size = new Size(900, 580);
            groupBoxAssistants.TabIndex = 0;
            groupBoxAssistants.TabStop = false;
            groupBoxAssistants.Text = "Assistants List";
            // 
            // dgvAssistants
            // 
            dgvAssistants.AllowUserToAddRows = false;
            dgvAssistants.AllowUserToDeleteRows = false;
            dgvAssistants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAssistants.BackgroundColor = SystemColors.Window;
            dgvAssistants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAssistants.Location = new Point(20, 30);
            dgvAssistants.MultiSelect = false;
            dgvAssistants.Name = "dgvAssistants";
            dgvAssistants.ReadOnly = true;
            dgvAssistants.RowHeadersWidth = 51;
            dgvAssistants.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAssistants.Size = new Size(860, 530);
            dgvAssistants.TabIndex = 0;
            dgvAssistants.CellClick += dgvAssistants_CellClick;
            // 
            // groupBoxAssistantDetails
            // 
            groupBoxAssistantDetails.Controls.Add(lblFirstNameAssistant);
            groupBoxAssistantDetails.Controls.Add(txtFirstNameAssistant);
            groupBoxAssistantDetails.Controls.Add(lblLastNameAssistant);
            groupBoxAssistantDetails.Controls.Add(txtLastNameAssistant);
            groupBoxAssistantDetails.Controls.Add(lblPhoneAssistant);
            groupBoxAssistantDetails.Controls.Add(txtPhoneAssistant);
            groupBoxAssistantDetails.Controls.Add(lblEmailAssistant);
            groupBoxAssistantDetails.Controls.Add(txtEmailAssistant);
            groupBoxAssistantDetails.Controls.Add(lblAddressAssistant);
            groupBoxAssistantDetails.Controls.Add(txtAddressAssistant);
            groupBoxAssistantDetails.Controls.Add(lblHireDate);
            groupBoxAssistantDetails.Controls.Add(dtpHireDate);
            groupBoxAssistantDetails.Controls.Add(lblHourlyRateAssistant);
            groupBoxAssistantDetails.Controls.Add(numHourlyRateAssistant);
            groupBoxAssistantDetails.Controls.Add(chkIsAvailableAssistant);
            groupBoxAssistantDetails.Controls.Add(btnAddAssistant);
            groupBoxAssistantDetails.Controls.Add(btnUpdateAssistant);
            groupBoxAssistantDetails.Controls.Add(btnDeleteAssistant);
            groupBoxAssistantDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxAssistantDetails.Location = new Point(940, 20);
            groupBoxAssistantDetails.Name = "groupBoxAssistantDetails";
            groupBoxAssistantDetails.Size = new Size(380, 580);
            groupBoxAssistantDetails.TabIndex = 1;
            groupBoxAssistantDetails.TabStop = false;
            groupBoxAssistantDetails.Text = "Assistant Details";
            // 
            // lblFirstNameAssistant
            // 
            lblFirstNameAssistant.AutoSize = true;
            lblFirstNameAssistant.Font = new Font("Segoe UI", 9F);
            lblFirstNameAssistant.Location = new Point(20, 30);
            lblFirstNameAssistant.Name = "lblFirstNameAssistant";
            lblFirstNameAssistant.Size = new Size(83, 20);
            lblFirstNameAssistant.TabIndex = 0;
            lblFirstNameAssistant.Text = "First Name:";
            // 
            // txtFirstNameAssistant
            // 
            txtFirstNameAssistant.Font = new Font("Segoe UI", 9F);
            txtFirstNameAssistant.Location = new Point(130, 30);
            txtFirstNameAssistant.Name = "txtFirstNameAssistant";
            txtFirstNameAssistant.Size = new Size(200, 27);
            txtFirstNameAssistant.TabIndex = 1;
            // 
            // lblLastNameAssistant
            // 
            lblLastNameAssistant.AutoSize = true;
            lblLastNameAssistant.Font = new Font("Segoe UI", 9F);
            lblLastNameAssistant.Location = new Point(20, 70);
            lblLastNameAssistant.Name = "lblLastNameAssistant";
            lblLastNameAssistant.Size = new Size(82, 20);
            lblLastNameAssistant.TabIndex = 2;
            lblLastNameAssistant.Text = "Last Name:";
            // 
            // txtLastNameAssistant
            // 
            txtLastNameAssistant.Font = new Font("Segoe UI", 9F);
            txtLastNameAssistant.Location = new Point(130, 70);
            txtLastNameAssistant.Name = "txtLastNameAssistant";
            txtLastNameAssistant.Size = new Size(200, 27);
            txtLastNameAssistant.TabIndex = 3;
            // 
            // lblPhoneAssistant
            // 
            lblPhoneAssistant.AutoSize = true;
            lblPhoneAssistant.Font = new Font("Segoe UI", 9F);
            lblPhoneAssistant.Location = new Point(20, 110);
            lblPhoneAssistant.Name = "lblPhoneAssistant";
            lblPhoneAssistant.Size = new Size(53, 20);
            lblPhoneAssistant.TabIndex = 4;
            lblPhoneAssistant.Text = "Phone:";
            // 
            // txtPhoneAssistant
            // 
            txtPhoneAssistant.Font = new Font("Segoe UI", 9F);
            txtPhoneAssistant.Location = new Point(130, 110);
            txtPhoneAssistant.Name = "txtPhoneAssistant";
            txtPhoneAssistant.Size = new Size(200, 27);
            txtPhoneAssistant.TabIndex = 5;
            // 
            // lblEmailAssistant
            // 
            lblEmailAssistant.AutoSize = true;
            lblEmailAssistant.Font = new Font("Segoe UI", 9F);
            lblEmailAssistant.Location = new Point(20, 150);
            lblEmailAssistant.Name = "lblEmailAssistant";
            lblEmailAssistant.Size = new Size(49, 20);
            lblEmailAssistant.TabIndex = 6;
            lblEmailAssistant.Text = "Email:";
            // 
            // txtEmailAssistant
            // 
            txtEmailAssistant.Font = new Font("Segoe UI", 9F);
            txtEmailAssistant.Location = new Point(130, 150);
            txtEmailAssistant.Name = "txtEmailAssistant";
            txtEmailAssistant.Size = new Size(200, 27);
            txtEmailAssistant.TabIndex = 7;
            // 
            // lblAddressAssistant
            // 
            lblAddressAssistant.AutoSize = true;
            lblAddressAssistant.Font = new Font("Segoe UI", 9F);
            lblAddressAssistant.Location = new Point(20, 190);
            lblAddressAssistant.Name = "lblAddressAssistant";
            lblAddressAssistant.Size = new Size(65, 20);
            lblAddressAssistant.TabIndex = 8;
            lblAddressAssistant.Text = "Address:";
            // 
            // txtAddressAssistant
            // 
            txtAddressAssistant.Font = new Font("Segoe UI", 9F);
            txtAddressAssistant.Location = new Point(130, 190);
            txtAddressAssistant.Name = "txtAddressAssistant";
            txtAddressAssistant.Size = new Size(200, 27);
            txtAddressAssistant.TabIndex = 9;
            // 
            // lblHireDate
            // 
            lblHireDate.AutoSize = true;
            lblHireDate.Font = new Font("Segoe UI", 9F);
            lblHireDate.Location = new Point(20, 230);
            lblHireDate.Name = "lblHireDate";
            lblHireDate.Size = new Size(76, 20);
            lblHireDate.TabIndex = 10;
            lblHireDate.Text = "Hire Date:";
            // 
            // dtpHireDate
            // 
            dtpHireDate.Font = new Font("Segoe UI", 9F);
            dtpHireDate.Format = DateTimePickerFormat.Short;
            dtpHireDate.Location = new Point(130, 230);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(200, 27);
            dtpHireDate.TabIndex = 11;
            // 
            // lblHourlyRateAssistant
            // 
            lblHourlyRateAssistant.AutoSize = true;
            lblHourlyRateAssistant.Font = new Font("Segoe UI", 9F);
            lblHourlyRateAssistant.Location = new Point(20, 270);
            lblHourlyRateAssistant.Name = "lblHourlyRateAssistant";
            lblHourlyRateAssistant.Size = new Size(90, 20);
            lblHourlyRateAssistant.TabIndex = 12;
            lblHourlyRateAssistant.Text = "Hourly Rate:";
            // 
            // numHourlyRateAssistant
            // 
            numHourlyRateAssistant.DecimalPlaces = 2;
            numHourlyRateAssistant.Font = new Font("Segoe UI", 9F);
            numHourlyRateAssistant.Location = new Point(130, 270);
            numHourlyRateAssistant.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numHourlyRateAssistant.Name = "numHourlyRateAssistant";
            numHourlyRateAssistant.Size = new Size(200, 27);
            numHourlyRateAssistant.TabIndex = 13;
            // 
            // chkIsAvailableAssistant
            // 
            chkIsAvailableAssistant.AutoSize = true;
            chkIsAvailableAssistant.Font = new Font("Segoe UI", 9F);
            chkIsAvailableAssistant.Location = new Point(130, 310);
            chkIsAvailableAssistant.Name = "chkIsAvailableAssistant";
            chkIsAvailableAssistant.Size = new Size(109, 24);
            chkIsAvailableAssistant.TabIndex = 14;
            chkIsAvailableAssistant.Text = "Is Available";
            chkIsAvailableAssistant.UseVisualStyleBackColor = true;
            // 
            // btnAddAssistant
            // 
            btnAddAssistant.BackColor = Color.LightGreen;
            btnAddAssistant.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddAssistant.Location = new Point(20, 480);
            btnAddAssistant.Name = "btnAddAssistant";
            btnAddAssistant.Size = new Size(100, 40);
            btnAddAssistant.TabIndex = 15;
            btnAddAssistant.Text = "➕ Add";
            btnAddAssistant.UseVisualStyleBackColor = false;
            btnAddAssistant.Click += btnAddAssistant_Click;
            // 
            // btnUpdateAssistant
            // 
            btnUpdateAssistant.BackColor = Color.LightBlue;
            btnUpdateAssistant.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdateAssistant.Location = new Point(130, 480);
            btnUpdateAssistant.Name = "btnUpdateAssistant";
            btnUpdateAssistant.Size = new Size(100, 40);
            btnUpdateAssistant.TabIndex = 16;
            btnUpdateAssistant.Text = "✏️ Update";
            btnUpdateAssistant.UseVisualStyleBackColor = false;
            btnUpdateAssistant.Click += btnUpdateAssistant_Click;
            // 
            // btnDeleteAssistant
            // 
            btnDeleteAssistant.BackColor = Color.LightCoral;
            btnDeleteAssistant.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeleteAssistant.Location = new Point(240, 480);
            btnDeleteAssistant.Name = "btnDeleteAssistant";
            btnDeleteAssistant.Size = new Size(100, 40);
            btnDeleteAssistant.TabIndex = 17;
            btnDeleteAssistant.Text = "🗑️ Delete";
            btnDeleteAssistant.UseVisualStyleBackColor = false;
            btnDeleteAssistant.Click += btnDeleteAssistant_Click;
            // 
            // tabContainers
            // 
            tabContainers.Controls.Add(groupBoxContainers);
            tabContainers.Controls.Add(groupBoxContainerDetails);
            tabContainers.Location = new Point(4, 32);
            tabContainers.Name = "tabContainers";
            tabContainers.Size = new Size(1342, 614);
            tabContainers.TabIndex = 4;
            tabContainers.Text = "📦 Containers";
            tabContainers.UseVisualStyleBackColor = true;
            // 
            // groupBoxContainers
            // 
            groupBoxContainers.Controls.Add(dgvContainers);
            groupBoxContainers.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxContainers.Location = new Point(20, 20);
            groupBoxContainers.Name = "groupBoxContainers";
            groupBoxContainers.Size = new Size(900, 580);
            groupBoxContainers.TabIndex = 0;
            groupBoxContainers.TabStop = false;
            groupBoxContainers.Text = "Containers List";
            // 
            // dgvContainers
            // 
            dgvContainers.AllowUserToAddRows = false;
            dgvContainers.AllowUserToDeleteRows = false;
            dgvContainers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvContainers.BackgroundColor = SystemColors.Window;
            dgvContainers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContainers.Location = new Point(20, 30);
            dgvContainers.MultiSelect = false;
            dgvContainers.Name = "dgvContainers";
            dgvContainers.ReadOnly = true;
            dgvContainers.RowHeadersWidth = 51;
            dgvContainers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContainers.Size = new Size(860, 530);
            dgvContainers.TabIndex = 0;
            dgvContainers.CellClick += dgvContainers_CellClick;
            // 
            // groupBoxContainerDetails
            // 
            groupBoxContainerDetails.Controls.Add(lblContainerNumber);
            groupBoxContainerDetails.Controls.Add(txtContainerNumber);
            groupBoxContainerDetails.Controls.Add(lblType);
            groupBoxContainerDetails.Controls.Add(cmbType);
            groupBoxContainerDetails.Controls.Add(lblCapacity);
            groupBoxContainerDetails.Controls.Add(numCapacity);
            groupBoxContainerDetails.Controls.Add(lblStatusContainer);
            groupBoxContainerDetails.Controls.Add(cmbStatusContainer);
            groupBoxContainerDetails.Controls.Add(chkIsAvailableContainer);
            groupBoxContainerDetails.Controls.Add(btnAddContainer);
            groupBoxContainerDetails.Controls.Add(btnUpdateContainer);
            groupBoxContainerDetails.Controls.Add(btnDeleteContainer);
            groupBoxContainerDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxContainerDetails.Location = new Point(940, 20);
            groupBoxContainerDetails.Name = "groupBoxContainerDetails";
            groupBoxContainerDetails.Size = new Size(380, 580);
            groupBoxContainerDetails.TabIndex = 1;
            groupBoxContainerDetails.TabStop = false;
            groupBoxContainerDetails.Text = "Container Details";
            // 
            // lblContainerNumber
            // 
            lblContainerNumber.AutoSize = true;
            lblContainerNumber.Font = new Font("Segoe UI", 9F);
            lblContainerNumber.Location = new Point(20, 30);
            lblContainerNumber.Name = "lblContainerNumber";
            lblContainerNumber.Size = new Size(100, 20);
            lblContainerNumber.TabIndex = 0;
            lblContainerNumber.Text = "Container No:";
            // 
            // txtContainerNumber
            // 
            txtContainerNumber.Font = new Font("Segoe UI", 9F);
            txtContainerNumber.Location = new Point(140, 30);
            txtContainerNumber.Name = "txtContainerNumber";
            txtContainerNumber.Size = new Size(200, 27);
            txtContainerNumber.TabIndex = 1;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 9F);
            lblType.Location = new Point(20, 70);
            lblType.Name = "lblType";
            lblType.Size = new Size(43, 20);
            lblType.TabIndex = 2;
            lblType.Text = "Type:";
            // 
            // cmbType
            // 
            cmbType.Font = new Font("Segoe UI", 9F);
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "Standard", "Fragile", "Small", "Large", "Refrigerated" });
            cmbType.Location = new Point(140, 70);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(200, 28);
            cmbType.TabIndex = 3;
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.Font = new Font("Segoe UI", 9F);
            lblCapacity.Location = new Point(20, 110);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(102, 20);
            lblCapacity.TabIndex = 4;
            lblCapacity.Text = "Capacity (m³):";
            // 
            // numCapacity
            // 
            numCapacity.DecimalPlaces = 2;
            numCapacity.Font = new Font("Segoe UI", 9F);
            numCapacity.Location = new Point(140, 110);
            numCapacity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numCapacity.Name = "numCapacity";
            numCapacity.Size = new Size(200, 27);
            numCapacity.TabIndex = 5;
            // 
            // lblStatusContainer
            // 
            lblStatusContainer.AutoSize = true;
            lblStatusContainer.Font = new Font("Segoe UI", 9F);
            lblStatusContainer.Location = new Point(20, 150);
            lblStatusContainer.Name = "lblStatusContainer";
            lblStatusContainer.Size = new Size(52, 20);
            lblStatusContainer.TabIndex = 6;
            lblStatusContainer.Text = "Status:";
            // 
            // cmbStatusContainer
            // 
            cmbStatusContainer.Font = new Font("Segoe UI", 9F);
            cmbStatusContainer.FormattingEnabled = true;
            cmbStatusContainer.Items.AddRange(new object[] { "Available", "In Use", "Maintenance", "Inactive" });
            cmbStatusContainer.Location = new Point(140, 150);
            cmbStatusContainer.Name = "cmbStatusContainer";
            cmbStatusContainer.Size = new Size(200, 28);
            cmbStatusContainer.TabIndex = 7;
            // 
            // chkIsAvailableContainer
            // 
            chkIsAvailableContainer.AutoSize = true;
            chkIsAvailableContainer.Font = new Font("Segoe UI", 9F);
            chkIsAvailableContainer.Location = new Point(140, 190);
            chkIsAvailableContainer.Name = "chkIsAvailableContainer";
            chkIsAvailableContainer.Size = new Size(109, 24);
            chkIsAvailableContainer.TabIndex = 8;
            chkIsAvailableContainer.Text = "Is Available";
            chkIsAvailableContainer.UseVisualStyleBackColor = true;
            // 
            // btnAddContainer
            // 
            btnAddContainer.BackColor = Color.LightGreen;
            btnAddContainer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddContainer.Location = new Point(20, 480);
            btnAddContainer.Name = "btnAddContainer";
            btnAddContainer.Size = new Size(100, 40);
            btnAddContainer.TabIndex = 9;
            btnAddContainer.Text = "➕ Add";
            btnAddContainer.UseVisualStyleBackColor = false;
            btnAddContainer.Click += btnAddContainer_Click;
            // 
            // btnUpdateContainer
            // 
            btnUpdateContainer.BackColor = Color.LightBlue;
            btnUpdateContainer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdateContainer.Location = new Point(130, 480);
            btnUpdateContainer.Name = "btnUpdateContainer";
            btnUpdateContainer.Size = new Size(100, 40);
            btnUpdateContainer.TabIndex = 10;
            btnUpdateContainer.Text = "✏️ Update";
            btnUpdateContainer.UseVisualStyleBackColor = false;
            btnUpdateContainer.Click += btnUpdateContainer_Click;
            // 
            // btnDeleteContainer
            // 
            btnDeleteContainer.BackColor = Color.LightCoral;
            btnDeleteContainer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeleteContainer.Location = new Point(240, 480);
            btnDeleteContainer.Name = "btnDeleteContainer";
            btnDeleteContainer.Size = new Size(100, 40);
            btnDeleteContainer.TabIndex = 11;
            btnDeleteContainer.Text = "🗑️ Delete";
            btnDeleteContainer.UseVisualStyleBackColor = false;
            btnDeleteContainer.Click += btnDeleteContainer_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LightBlue;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.Location = new Point(1200, 735);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(80, 35);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "🔄 Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.LightCoral;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClose.Location = new Point(1290, 735);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(80, 35);
            btnClose.TabIndex = 4;
            btnClose.Text = "❌ Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F);
            lblStatus.Location = new Point(20, 740);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(50, 20);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Ready";
            // 
            // TransportUnitManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 800);
            Controls.Add(lblTitle);
            Controls.Add(tabControl1);
            Controls.Add(btnRefresh);
            Controls.Add(btnClose);
            Controls.Add(lblStatus);
            Name = "TransportUnitManagementForm";
            Text = "Transport Unit Management";
            Load += TransportUnitManagementForm_Load;
            tabControl1.ResumeLayout(false);
            tabTransportUnits.ResumeLayout(false);
            groupBoxTransportUnits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTransportUnits).EndInit();
            groupBoxTransportUnitDetails.ResumeLayout(false);
            groupBoxTransportUnitDetails.PerformLayout();
            tabLorries.ResumeLayout(false);
            groupBoxLorries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLorries).EndInit();
            groupBoxLorryDetails.ResumeLayout(false);
            groupBoxLorryDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLoadCapacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numVolumeCapacity).EndInit();
            tabDrivers.ResumeLayout(false);
            groupBoxDrivers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDrivers).EndInit();
            groupBoxDriverDetails.ResumeLayout(false);
            groupBoxDriverDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numHourlyRateDriver).EndInit();
            tabAssistants.ResumeLayout(false);
            groupBoxAssistants.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAssistants).EndInit();
            groupBoxAssistantDetails.ResumeLayout(false);
            groupBoxAssistantDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numHourlyRateAssistant).EndInit();
            tabContainers.ResumeLayout(false);
            groupBoxContainers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvContainers).EndInit();
            groupBoxContainerDetails.ResumeLayout(false);
            groupBoxContainerDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCapacity).EndInit();
            ResumeLayout(false);
            PerformLayout();
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