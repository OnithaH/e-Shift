namespace e_Shift
{
    partial class TransportUnitManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // Form components
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();

            // Transport Units Tab
            this.tabTransportUnits = new System.Windows.Forms.TabPage();
            this.groupBoxTransportUnits = new System.Windows.Forms.GroupBox();
            this.dgvTransportUnits = new System.Windows.Forms.DataGridView();
            this.groupBoxTransportUnitDetails = new System.Windows.Forms.GroupBox();
            this.txtUnitNumber = new System.Windows.Forms.TextBox();
            this.cmbStatusTU = new System.Windows.Forms.ComboBox();
            this.cmbLorryTU = new System.Windows.Forms.ComboBox();
            this.cmbDriverTU = new System.Windows.Forms.ComboBox();
            this.cmbAssistantTU = new System.Windows.Forms.ComboBox();
            this.cmbContainerTU = new System.Windows.Forms.ComboBox();
            this.chkIsAvailableUnit = new System.Windows.Forms.CheckBox();
            this.btnCreateTransportUnit = new System.Windows.Forms.Button();
            this.btnUpdateTransportUnit = new System.Windows.Forms.Button();
            this.btnDeleteTransportUnit = new System.Windows.Forms.Button();

            // Lorries Tab
            this.tabLorries = new System.Windows.Forms.TabPage();
            this.groupBoxLorries = new System.Windows.Forms.GroupBox();
            this.dgvLorries = new System.Windows.Forms.DataGridView();
            this.groupBoxLorryDetails = new System.Windows.Forms.GroupBox();
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

            // Drivers Tab
            this.tabDrivers = new System.Windows.Forms.TabPage();
            this.groupBoxDrivers = new System.Windows.Forms.GroupBox();
            this.dgvDrivers = new System.Windows.Forms.DataGridView();
            this.groupBoxDriverDetails = new System.Windows.Forms.GroupBox();
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

            // Assistants Tab
            this.tabAssistants = new System.Windows.Forms.TabPage();
            this.groupBoxAssistants = new System.Windows.Forms.GroupBox();
            this.dgvAssistants = new System.Windows.Forms.DataGridView();
            this.groupBoxAssistantDetails = new System.Windows.Forms.GroupBox();
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

            // Containers Tab
            this.tabContainers = new System.Windows.Forms.TabPage();
            this.groupBoxContainers = new System.Windows.Forms.GroupBox();
            this.dgvContainers = new System.Windows.Forms.DataGridView();
            this.groupBoxContainerDetails = new System.Windows.Forms.GroupBox();
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

            // Labels
            this.lblUnitNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();

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

            // 
            // Form Layout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.MinimumSize = new System.Drawing.Size(1200, 750);
            this.Name = "TransportUnitManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-Shift - Transport Management";
            this.Load += new System.EventHandler(this.TransportUnitManagementForm_Load);

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(311, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Transport Management";

            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTransportUnits);
            this.tabControl1.Controls.Add(this.tabLorries);
            this.tabControl1.Controls.Add(this.tabDrivers);
            this.tabControl1.Controls.Add(this.tabAssistants);
            this.tabControl1.Controls.Add(this.tabContainers);
            this.tabControl1.Location = new System.Drawing.Point(20, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1160, 600);
            this.tabControl1.TabIndex = 1;

            // 
            // Transport Units Tab Setup
            // 
            this.tabTransportUnits.Controls.Add(this.groupBoxTransportUnits);
            this.tabTransportUnits.Controls.Add(this.groupBoxTransportUnitDetails);
            this.tabTransportUnits.Location = new System.Drawing.Point(4, 29);
            this.tabTransportUnits.Name = "tabTransportUnits";
            this.tabTransportUnits.Size = new System.Drawing.Size(1152, 567);
            this.tabTransportUnits.TabIndex = 0;
            this.tabTransportUnits.Text = "🚚 Transport Units";
            this.tabTransportUnits.UseVisualStyleBackColor = true;

            // Transport Units List
            this.groupBoxTransportUnits.Controls.Add(this.dgvTransportUnits);
            this.groupBoxTransportUnits.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxTransportUnits.Location = new System.Drawing.Point(20, 20);
            this.groupBoxTransportUnits.Name = "groupBoxTransportUnits";
            this.groupBoxTransportUnits.Size = new System.Drawing.Size(700, 520);
            this.groupBoxTransportUnits.TabIndex = 0;
            this.groupBoxTransportUnits.TabStop = false;
            this.groupBoxTransportUnits.Text = "Transport Units List";

            this.dgvTransportUnits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransportUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransportUnits.Location = new System.Drawing.Point(10, 30);
            this.dgvTransportUnits.MultiSelect = false;
            this.dgvTransportUnits.Name = "dgvTransportUnits";
            this.dgvTransportUnits.ReadOnly = true;
            this.dgvTransportUnits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransportUnits.Size = new System.Drawing.Size(680, 480);
            this.dgvTransportUnits.TabIndex = 0;
            this.dgvTransportUnits.SelectionChanged += new System.EventHandler(this.dgvTransportUnits_SelectionChanged);

            // Transport Unit Details Panel
            this.groupBoxTransportUnitDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxTransportUnitDetails.Location = new System.Drawing.Point(740, 20);
            this.groupBoxTransportUnitDetails.Name = "groupBoxTransportUnitDetails";
            this.groupBoxTransportUnitDetails.Size = new System.Drawing.Size(400, 520);
            this.groupBoxTransportUnitDetails.TabIndex = 1;
            this.groupBoxTransportUnitDetails.TabStop = false;
            this.groupBoxTransportUnitDetails.Text = "Transport Unit Details";

            // Transport Unit Controls
            this.lblUnitNumber.AutoSize = true;
            this.lblUnitNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUnitNumber.Location = new System.Drawing.Point(30, 40);
            this.lblUnitNumber.Name = "lblUnitNumber";
            this.lblUnitNumber.Size = new System.Drawing.Size(98, 20);
            this.lblUnitNumber.TabIndex = 0;
            this.lblUnitNumber.Text = "Unit Number:";

            this.txtUnitNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUnitNumber.Location = new System.Drawing.Point(150, 37);
            this.txtUnitNumber.Name = "txtUnitNumber";
            this.txtUnitNumber.Size = new System.Drawing.Size(220, 27);
            this.txtUnitNumber.TabIndex = 1;

            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(30, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Status:";

            this.cmbStatusTU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusTU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbStatusTU.FormattingEnabled = true;
            this.cmbStatusTU.Items.AddRange(new object[] { "Available", "Assigned", "In Transit", "Maintenance" });
            this.cmbStatusTU.Location = new System.Drawing.Point(150, 77);
            this.cmbStatusTU.Name = "cmbStatusTU";
            this.cmbStatusTU.Size = new System.Drawing.Size(220, 28);
            this.cmbStatusTU.TabIndex = 3;

            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(30, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lorry:";

            this.cmbLorryTU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLorryTU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbLorryTU.FormattingEnabled = true;
            this.cmbLorryTU.Location = new System.Drawing.Point(150, 117);
            this.cmbLorryTU.Name = "cmbLorryTU";
            this.cmbLorryTU.Size = new System.Drawing.Size(220, 28);
            this.cmbLorryTU.TabIndex = 5;

            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(30, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Driver:";

            this.cmbDriverTU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDriverTU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbDriverTU.FormattingEnabled = true;
            this.cmbDriverTU.Location = new System.Drawing.Point(150, 157);
            this.cmbDriverTU.Name = "cmbDriverTU";
            this.cmbDriverTU.Size = new System.Drawing.Size(220, 28);
            this.cmbDriverTU.TabIndex = 7;

            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(30, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Assistant:";

            this.cmbAssistantTU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssistantTU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbAssistantTU.FormattingEnabled = true;
            this.cmbAssistantTU.Location = new System.Drawing.Point(150, 197);
            this.cmbAssistantTU.Name = "cmbAssistantTU";
            this.cmbAssistantTU.Size = new System.Drawing.Size(220, 28);
            this.cmbAssistantTU.TabIndex = 9;

            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(30, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Container:";

            this.cmbContainerTU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContainerTU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbContainerTU.FormattingEnabled = true;
            this.cmbContainerTU.Location = new System.Drawing.Point(150, 237);
            this.cmbContainerTU.Name = "cmbContainerTU";
            this.cmbContainerTU.Size = new System.Drawing.Size(220, 28);
            this.cmbContainerTU.TabIndex = 11;

            this.chkIsAvailableUnit.AutoSize = true;
            this.chkIsAvailableUnit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkIsAvailableUnit.Location = new System.Drawing.Point(150, 280);
            this.chkIsAvailableUnit.Name = "chkIsAvailableUnit";
            this.chkIsAvailableUnit.Size = new System.Drawing.Size(100, 24);
            this.chkIsAvailableUnit.TabIndex = 12;
            this.chkIsAvailableUnit.Text = "Is Available";
            this.chkIsAvailableUnit.UseVisualStyleBackColor = true;

            // Transport Unit Buttons
            this.btnCreateTransportUnit.BackColor = System.Drawing.Color.LightGreen;
            this.btnCreateTransportUnit.Location = new System.Drawing.Point(30, 450);
            this.btnCreateTransportUnit.Name = "btnCreateTransportUnit";
            this.btnCreateTransportUnit.Size = new System.Drawing.Size(100, 40);
            this.btnCreateTransportUnit.TabIndex = 13;
            this.btnCreateTransportUnit.Text = "Create";
            this.btnCreateTransportUnit.UseVisualStyleBackColor = false;
            this.btnCreateTransportUnit.Click += new System.EventHandler(this.btnCreateTransportUnit_Click);

            this.btnUpdateTransportUnit.BackColor = System.Drawing.Color.LightBlue;
            this.btnUpdateTransportUnit.Location = new System.Drawing.Point(150, 450);
            this.btnUpdateTransportUnit.Name = "btnUpdateTransportUnit";
            this.btnUpdateTransportUnit.Size = new System.Drawing.Size(100, 40);
            this.btnUpdateTransportUnit.TabIndex = 14;
            this.btnUpdateTransportUnit.Text = "Update";
            this.btnUpdateTransportUnit.UseVisualStyleBackColor = false;
            this.btnUpdateTransportUnit.Click += new System.EventHandler(this.btnUpdateTransportUnit_Click);

            this.btnDeleteTransportUnit.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeleteTransportUnit.Location = new System.Drawing.Point(270, 450);
            this.btnDeleteTransportUnit.Name = "btnDeleteTransportUnit";
            this.btnDeleteTransportUnit.Size = new System.Drawing.Size(100, 40);
            this.btnDeleteTransportUnit.TabIndex = 15;
            this.btnDeleteTransportUnit.Text = "Delete";
            this.btnDeleteTransportUnit.UseVisualStyleBackColor = false;
            this.btnDeleteTransportUnit.Click += new System.EventHandler(this.btnDeleteTransportUnit_Click);

            // Add controls to Transport Unit Details group
            this.groupBoxTransportUnitDetails.Controls.Add(this.lblUnitNumber);
            this.groupBoxTransportUnitDetails.Controls.Add(this.txtUnitNumber);
            this.groupBoxTransportUnitDetails.Controls.Add(this.label1);
            this.groupBoxTransportUnitDetails.Controls.Add(this.cmbStatusTU);
            this.groupBoxTransportUnitDetails.Controls.Add(this.label2);
            this.groupBoxTransportUnitDetails.Controls.Add(this.cmbLorryTU);
            this.groupBoxTransportUnitDetails.Controls.Add(this.label3);
            this.groupBoxTransportUnitDetails.Controls.Add(this.cmbDriverTU);
            this.groupBoxTransportUnitDetails.Controls.Add(this.label4);
            this.groupBoxTransportUnitDetails.Controls.Add(this.cmbAssistantTU);
            this.groupBoxTransportUnitDetails.Controls.Add(this.label5);
            this.groupBoxTransportUnitDetails.Controls.Add(this.cmbContainerTU);
            this.groupBoxTransportUnitDetails.Controls.Add(this.chkIsAvailableUnit);
            this.groupBoxTransportUnitDetails.Controls.Add(this.btnCreateTransportUnit);
            this.groupBoxTransportUnitDetails.Controls.Add(this.btnUpdateTransportUnit);
            this.groupBoxTransportUnitDetails.Controls.Add(this.btnDeleteTransportUnit);

            // Setup other tabs (simplified setup - similar pattern for Lorries, Drivers, Assistants, Containers)
            this.SetupOtherTabs();

            // Form Controls
            this.btnRefresh.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(900, 690);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(130, 40);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "🔄 Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.btnClose.BackColor = System.Drawing.Color.LightCoral;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(1050, 690);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 40);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "❌ Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatus.Location = new System.Drawing.Point(20, 700);
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
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void SetupOtherTabs()
        {
            // Setup Lorries Tab
            this.tabLorries.Location = new System.Drawing.Point(4, 29);
            this.tabLorries.Name = "tabLorries";
            this.tabLorries.Size = new System.Drawing.Size(1152, 567);
            this.tabLorries.TabIndex = 1;
            this.tabLorries.Text = "🚛 Lorries";
            this.tabLorries.UseVisualStyleBackColor = true;

            this.groupBoxLorries.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxLorries.Location = new System.Drawing.Point(20, 20);
            this.groupBoxLorries.Name = "groupBoxLorries";
            this.groupBoxLorries.Size = new System.Drawing.Size(700, 520);
            this.groupBoxLorries.TabIndex = 0;
            this.groupBoxLorries.TabStop = false;
            this.groupBoxLorries.Text = "Lorries List";

            this.dgvLorries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLorries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLorries.Location = new System.Drawing.Point(10, 30);
            this.dgvLorries.MultiSelect = false;
            this.dgvLorries.Name = "dgvLorries";
            this.dgvLorries.ReadOnly = true;
            this.dgvLorries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLorries.Size = new System.Drawing.Size(680, 480);
            this.dgvLorries.TabIndex = 0;
            this.dgvLorries.SelectionChanged += new System.EventHandler(this.dgvLorries_SelectionChanged);

            this.groupBoxLorryDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxLorryDetails.Location = new System.Drawing.Point(740, 20);
            this.groupBoxLorryDetails.Name = "groupBoxLorryDetails";
            this.groupBoxLorryDetails.Size = new System.Drawing.Size(400, 520);
            this.groupBoxLorryDetails.TabIndex = 1;
            this.groupBoxLorryDetails.TabStop = false;
            this.groupBoxLorryDetails.Text = "Lorry Details";

            this.groupBoxLorries.Controls.Add(this.dgvLorries);
            this.tabLorries.Controls.Add(this.groupBoxLorries);
            this.tabLorries.Controls.Add(this.groupBoxLorryDetails);

            // Setup Drivers Tab
            this.tabDrivers.Location = new System.Drawing.Point(4, 29);
            this.tabDrivers.Name = "tabDrivers";
            this.tabDrivers.Size = new System.Drawing.Size(1152, 567);
            this.tabDrivers.TabIndex = 2;
            this.tabDrivers.Text = "👨‍💼 Drivers";
            this.tabDrivers.UseVisualStyleBackColor = true;

            this.groupBoxDrivers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxDrivers.Location = new System.Drawing.Point(20, 20);
            this.groupBoxDrivers.Name = "groupBoxDrivers";
            this.groupBoxDrivers.Size = new System.Drawing.Size(700, 520);
            this.groupBoxDrivers.TabIndex = 0;
            this.groupBoxDrivers.TabStop = false;
            this.groupBoxDrivers.Text = "Drivers List";

            this.dgvDrivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrivers.Location = new System.Drawing.Point(10, 30);
            this.dgvDrivers.MultiSelect = false;
            this.dgvDrivers.Name = "dgvDrivers";
            this.dgvDrivers.ReadOnly = true;
            this.dgvDrivers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrivers.Size = new System.Drawing.Size(680, 480);
            this.dgvDrivers.TabIndex = 0;
            this.dgvDrivers.SelectionChanged += new System.EventHandler(this.dgvDrivers_SelectionChanged);

            this.groupBoxDriverDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxDriverDetails.Location = new System.Drawing.Point(740, 20);
            this.groupBoxDriverDetails.Name = "groupBoxDriverDetails";
            this.groupBoxDriverDetails.Size = new System.Drawing.Size(400, 520);
            this.groupBoxDriverDetails.TabIndex = 1;
            this.groupBoxDriverDetails.TabStop = false;
            this.groupBoxDriverDetails.Text = "Driver Details";

            this.groupBoxDrivers.Controls.Add(this.dgvDrivers);
            this.tabDrivers.Controls.Add(this.groupBoxDrivers);
            this.tabDrivers.Controls.Add(this.groupBoxDriverDetails);

            // Setup Assistants Tab
            this.tabAssistants.Location = new System.Drawing.Point(4, 29);
            this.tabAssistants.Name = "tabAssistants";
            this.tabAssistants.Size = new System.Drawing.Size(1152, 567);
            this.tabAssistants.TabIndex = 3;
            this.tabAssistants.Text = "👷‍♂️ Assistants";
            this.tabAssistants.UseVisualStyleBackColor = true;

            this.groupBoxAssistants.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxAssistants.Location = new System.Drawing.Point(20, 20);
            this.groupBoxAssistants.Name = "groupBoxAssistants";
            this.groupBoxAssistants.Size = new System.Drawing.Size(700, 520);
            this.groupBoxAssistants.TabIndex = 0;
            this.groupBoxAssistants.TabStop = false;
            this.groupBoxAssistants.Text = "Assistants List";

            this.dgvAssistants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssistants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssistants.Location = new System.Drawing.Point(10, 30);
            this.dgvAssistants.MultiSelect = false;
            this.dgvAssistants.Name = "dgvAssistants";
            this.dgvAssistants.ReadOnly = true;
            this.dgvAssistants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssistants.Size = new System.Drawing.Size(680, 480);
            this.dgvAssistants.TabIndex = 0;
            this.dgvAssistants.SelectionChanged += new System.EventHandler(this.dgvAssistants_SelectionChanged);

            this.groupBoxAssistantDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxAssistantDetails.Location = new System.Drawing.Point(740, 20);
            this.groupBoxAssistantDetails.Name = "groupBoxAssistantDetails";
            this.groupBoxAssistantDetails.Size = new System.Drawing.Size(400, 520);
            this.groupBoxAssistantDetails.TabIndex = 1;
            this.groupBoxAssistantDetails.TabStop = false;
            this.groupBoxAssistantDetails.Text = "Assistant Details";

            this.groupBoxAssistants.Controls.Add(this.dgvAssistants);
            this.tabAssistants.Controls.Add(this.groupBoxAssistants);
            this.tabAssistants.Controls.Add(this.groupBoxAssistantDetails);

            // Setup Containers Tab
            this.tabContainers.Location = new System.Drawing.Point(4, 29);
            this.tabContainers.Name = "tabContainers";
            this.tabContainers.Size = new System.Drawing.Size(1152, 567);
            this.tabContainers.TabIndex = 4;
            this.tabContainers.Text = "📦 Containers";
            this.tabContainers.UseVisualStyleBackColor = true;

            this.groupBoxContainers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxContainers.Location = new System.Drawing.Point(20, 20);
            this.groupBoxContainers.Name = "groupBoxContainers";
            this.groupBoxContainers.Size = new System.Drawing.Size(700, 520);
            this.groupBoxContainers.TabIndex = 0;
            this.groupBoxContainers.TabStop = false;
            this.groupBoxContainers.Text = "Containers List";

            this.dgvContainers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContainers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContainers.Location = new System.Drawing.Point(10, 30);
            this.dgvContainers.MultiSelect = false;
            this.dgvContainers.Name = "dgvContainers";
            this.dgvContainers.ReadOnly = true;
            this.dgvContainers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContainers.Size = new System.Drawing.Size(680, 480);
            this.dgvContainers.TabIndex = 0;
            this.dgvContainers.SelectionChanged += new System.EventHandler(this.dgvContainers_SelectionChanged);

            this.groupBoxContainerDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxContainerDetails.Location = new System.Drawing.Point(740, 20);
            this.groupBoxContainerDetails.Name = "groupBoxContainerDetails";
            this.groupBoxContainerDetails.Size = new System.Drawing.Size(400, 520);
            this.groupBoxContainerDetails.TabIndex = 1;
            this.groupBoxContainerDetails.TabStop = false;
            this.groupBoxContainerDetails.Text = "Container Details";

            this.groupBoxContainers.Controls.Add(this.dgvContainers);
            this.tabContainers.Controls.Add(this.groupBoxContainers);
            this.tabContainers.Controls.Add(this.groupBoxContainerDetails);

            // Initialize all numeric controls and other tab-specific controls
            this.InitializeControlsForAllTabs();
        }

        private void InitializeControlsForAllTabs()
        {
            // Initialize Lorry controls
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

            // Initialize Driver controls
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

            // Initialize Assistant controls
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

            // Initialize Container controls
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
            this.cmbFuelType.Items.AddRange(new object[] { "Diesel", "Petrol", "Electric", "Hybrid" });
            this.cmbStatusLorry.Items.AddRange(new object[] { "Available", "In Use", "Maintenance", "Out of Service" });
            this.cmbLicenseClass.Items.AddRange(new object[] { "Light", "Heavy", "Commercial" });
            this.cmbType.Items.AddRange(new object[] { "Standard", "Refrigerated", "Fragile", "Liquid", "Special" });
            this.cmbMaterial.Items.AddRange(new object[] { "Steel", "Aluminum", "Fiberglass", "Wood" });
            this.cmbStatusContainer.Items.AddRange(new object[] { "Available", "In Use", "Maintenance", "Damaged" });

            // Setup numeric controls ranges
            this.numYear.Minimum = 1990;
            this.numYear.Maximum = 2030;
            this.numYear.Value = 2020;
            this.numLoadCapacity.Maximum = 50000;
            this.numLoadCapacity.DecimalPlaces = 2;
            this.numVolumeCapacity.Maximum = 1000;
            this.numVolumeCapacity.DecimalPlaces = 2;
            this.numHourlyRateDriver.Maximum = 10000;
            this.numHourlyRateDriver.DecimalPlaces = 2;
            this.numHourlyRateAssistant.Maximum = 10000;
            this.numHourlyRateAssistant.DecimalPlaces = 2;
            this.numCapacity.Maximum = 1000;
            this.numCapacity.DecimalPlaces = 2;
            this.numLength.Maximum = 20;
            this.numLength.DecimalPlaces = 2;
            this.numWidth.Maximum = 10;
            this.numWidth.DecimalPlaces = 2;
            this.numHeight.Maximum = 10;
            this.numHeight.DecimalPlaces = 2;
        }

        #endregion
    }
}