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
            // For brevity, I'm showing the structure - you can expand this pattern

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

            this.tabControl1.ResumeLayout(false);
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