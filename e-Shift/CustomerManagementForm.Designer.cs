namespace e_Shift
{
    partial class CustomerManagementForm
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
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblStatusFilter = new System.Windows.Forms.Label();
            this.comboBoxStatusFilter = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.groupBoxCustomers = new System.Windows.Forms.GroupBox();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.groupBoxCustomerDetails = new System.Windows.Forms.GroupBox();
            this.lblCustomerNumber = new System.Windows.Forms.Label();
            this.txtCustomerNumber = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnActivateDeactivate = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBoxFilters.SuspendLayout();
            this.groupBoxCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.groupBoxCustomerDetails.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(267, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Customer Management";
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Controls.Add(this.btnShowAll);
            this.groupBoxFilters.Controls.Add(this.btnSearch);
            this.groupBoxFilters.Controls.Add(this.comboBoxStatusFilter);
            this.groupBoxFilters.Controls.Add(this.lblStatusFilter);
            this.groupBoxFilters.Controls.Add(this.txtSearch);
            this.groupBoxFilters.Controls.Add(this.lblSearch);
            this.groupBoxFilters.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxFilters.Location = new System.Drawing.Point(30, 70);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(800, 70);
            this.groupBoxFilters.TabIndex = 1;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Search & Filters";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearch.Location = new System.Drawing.Point(20, 30);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(59, 23);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(85, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Name, Email, Customer Number...";
            this.txtSearch.Size = new System.Drawing.Size(250, 30);
            this.txtSearch.TabIndex = 1;
            // 
            // lblStatusFilter
            // 
            this.lblStatusFilter.AutoSize = true;
            this.lblStatusFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatusFilter.Location = new System.Drawing.Point(360, 30);
            this.lblStatusFilter.Name = "lblStatusFilter";
            this.lblStatusFilter.Size = new System.Drawing.Size(57, 23);
            this.lblStatusFilter.TabIndex = 2;
            this.lblStatusFilter.Text = "Status:";
            // 
            // comboBoxStatusFilter
            // 
            this.comboBoxStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatusFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxStatusFilter.FormattingEnabled = true;
            this.comboBoxStatusFilter.Items.AddRange(new object[] {
            "All",
            "Active",
            "Inactive"});
            this.comboBoxStatusFilter.Location = new System.Drawing.Point(425, 27);
            this.comboBoxStatusFilter.Name = "comboBoxStatusFilter";
            this.comboBoxStatusFilter.Size = new System.Drawing.Size(120, 31);
            this.comboBoxStatusFilter.TabIndex = 3;
            this.comboBoxStatusFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatusFilter_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightBlue;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSearch.Location = new System.Drawing.Point(570, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 35);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "🔍 Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.LightGray;
            this.btnShowAll.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnShowAll.Location = new System.Drawing.Point(680, 25);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(100, 35);
            this.btnShowAll.TabIndex = 5;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // groupBoxCustomers
            // 
            this.groupBoxCustomers.Controls.Add(this.dataGridViewCustomers);
            this.groupBoxCustomers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxCustomers.Location = new System.Drawing.Point(30, 150);
            this.groupBoxCustomers.Name = "groupBoxCustomers";
            this.groupBoxCustomers.Size = new System.Drawing.Size(800, 300);
            this.groupBoxCustomers.TabIndex = 2;
            this.groupBoxCustomers.TabStop = false;
            this.groupBoxCustomers.Text = "Customers List";
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.AllowUserToAddRows = false;
            this.dataGridViewCustomers.AllowUserToDeleteRows = false;
            this.dataGridViewCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCustomers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(15, 30);
            this.dataGridViewCustomers.MultiSelect = false;
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.ReadOnly = true;
            this.dataGridViewCustomers.RowHeadersWidth = 51;
            this.dataGridViewCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(770, 255);
            this.dataGridViewCustomers.TabIndex = 0;
            this.dataGridViewCustomers.SelectionChanged += new System.EventHandler(this.dataGridViewCustomers_SelectionChanged);
            // 
            // groupBoxCustomerDetails
            // 
            this.groupBoxCustomerDetails.Controls.Add(this.chkIsActive);
            this.groupBoxCustomerDetails.Controls.Add(this.txtPostalCode);
            this.groupBoxCustomerDetails.Controls.Add(this.lblPostalCode);
            this.groupBoxCustomerDetails.Controls.Add(this.txtCity);
            this.groupBoxCustomerDetails.Controls.Add(this.lblCity);
            this.groupBoxCustomerDetails.Controls.Add(this.txtAddress);
            this.groupBoxCustomerDetails.Controls.Add(this.lblAddress);
            this.groupBoxCustomerDetails.Controls.Add(this.txtPhone);
            this.groupBoxCustomerDetails.Controls.Add(this.lblPhone);
            this.groupBoxCustomerDetails.Controls.Add(this.txtEmail);
            this.groupBoxCustomerDetails.Controls.Add(this.lblEmail);
            this.groupBoxCustomerDetails.Controls.Add(this.txtLastName);
            this.groupBoxCustomerDetails.Controls.Add(this.lblLastName);
            this.groupBoxCustomerDetails.Controls.Add(this.txtFirstName);
            this.groupBoxCustomerDetails.Controls.Add(this.lblFirstName);
            this.groupBoxCustomerDetails.Controls.Add(this.txtCustomerNumber);
            this.groupBoxCustomerDetails.Controls.Add(this.lblCustomerNumber);
            this.groupBoxCustomerDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxCustomerDetails.Location = new System.Drawing.Point(30, 470);
            this.groupBoxCustomerDetails.Name = "groupBoxCustomerDetails";
            this.groupBoxCustomerDetails.Size = new System.Drawing.Size(600, 220);
            this.groupBoxCustomerDetails.TabIndex = 3;
            this.groupBoxCustomerDetails.TabStop = false;
            this.groupBoxCustomerDetails.Text = "Customer Details";
            // 
            // lblCustomerNumber
            // 
            this.lblCustomerNumber.AutoSize = true;
            this.lblCustomerNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCustomerNumber.Location = new System.Drawing.Point(20, 30);
            this.lblCustomerNumber.Name = "lblCustomerNumber";
            this.lblCustomerNumber.Size = new System.Drawing.Size(138, 23);
            this.lblCustomerNumber.TabIndex = 0;
            this.lblCustomerNumber.Text = "Customer Number:";
            // 
            // txtCustomerNumber
            // 
            this.txtCustomerNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCustomerNumber.Location = new System.Drawing.Point(165, 27);
            this.txtCustomerNumber.Name = "txtCustomerNumber";
            this.txtCustomerNumber.ReadOnly = true;
            this.txtCustomerNumber.Size = new System.Drawing.Size(150, 30);
            this.txtCustomerNumber.TabIndex = 1;
            this.txtCustomerNumber.BackColor = System.Drawing.Color.LightGray;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFirstName.Location = new System.Drawing.Point(20, 70);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(92, 23);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFirstName.Location = new System.Drawing.Point(120, 67);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(150, 30);
            this.txtFirstName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLastName.Location = new System.Drawing.Point(290, 70);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(91, 23);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLastName.Location = new System.Drawing.Point(390, 67);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(150, 30);
            this.txtLastName.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.Location = new System.Drawing.Point(20, 110);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 23);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(80, 107);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 30);
            this.txtEmail.TabIndex = 7;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhone.Location = new System.Drawing.Point(300, 110);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(56, 23);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhone.Location = new System.Drawing.Point(365, 107);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(150, 30);
            this.txtPhone.TabIndex = 9;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAddress.Location = new System.Drawing.Point(20, 150);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(70, 23);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAddress.Location = new System.Drawing.Point(100, 147);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(300, 30);
            this.txtAddress.TabIndex = 11;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCity.Location = new System.Drawing.Point(420, 150);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(41, 23);
            this.lblCity.TabIndex = 12;
            this.lblCity.Text = "City:";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCity.Location = new System.Drawing.Point(470, 147);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(120, 30);
            this.txtCity.TabIndex = 13;
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPostalCode.Location = new System.Drawing.Point(20, 190);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(96, 23);
            this.lblPostalCode.TabIndex = 14;
            this.lblPostalCode.Text = "Postal Code:";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPostalCode.Location = new System.Drawing.Point(125, 187);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(100, 30);
            this.txtPostalCode.TabIndex = 15;
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkIsActive.Location = new System.Drawing.Point(250, 190);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(77, 27);
            this.chkIsActive.TabIndex = 16;
            this.chkIsActive.Text = "Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            this.chkIsActive.CheckedChanged += new System.EventHandler(this.chkIsActive_CheckedChanged);
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.btnActivateDeactivate);
            this.groupBoxActions.Controls.Add(this.btnDelete);
            this.groupBoxActions.Controls.Add(this.btnCancel);
            this.groupBoxActions.Controls.Add(this.btnSave);
            this.groupBoxActions.Controls.Add(this.btnEdit);
            this.groupBoxActions.Controls.Add(this.btnAddNew);
            this.groupBoxActions.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxActions.Location = new System.Drawing.Point(650, 470);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(180, 220);
            this.groupBoxActions.TabIndex = 4;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddNew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddNew.Location = new System.Drawing.Point(20, 30);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(140, 35);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "➕ Add New";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LightBlue;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Location = new System.Drawing.Point(20, 75);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(140, 35);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "✏️ Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightGreen;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(20, 120);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 35);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "💾 Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(95, 120);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 35);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "❌ Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(20, 165);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 35);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "🗑️ Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnActivateDeactivate
            // 
            this.btnActivateDeactivate.BackColor = System.Drawing.Color.LightYellow;
            this.btnActivateDeactivate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnActivateDeactivate.Location = new System.Drawing.Point(95, 165);
            this.btnActivateDeactivate.Name = "btnActivateDeactivate";
            this.btnActivateDeactivate.Size = new System.Drawing.Size(65, 35);
            this.btnActivateDeactivate.TabIndex = 5;
            this.btnActivateDeactivate.Text = "✅ Activate";
            this.btnActivateDeactivate.UseVisualStyleBackColor = false;
            this.btnActivateDeactivate.Click += new System.EventHandler(this.btnActivateDeactivate_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatus.Location = new System.Drawing.Point(30, 710);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(54, 23);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Ready";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightGray;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(740, 705);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 35);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CustomerManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(870, 750);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.groupBoxCustomerDetails);
            this.Controls.Add(this.groupBoxCustomers);
            this.Controls.Add(this.groupBoxFilters);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CustomerManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-Shift - Customer Management";
            this.Load += new System.EventHandler(this.CustomerManagementForm_Load);
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
            this.groupBoxCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.groupBoxCustomerDetails.ResumeLayout(false);
            this.groupBoxCustomerDetails.PerformLayout();
            this.groupBoxActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnActivateDeactivate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnClose; 
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblStatusFilter;
        private System.Windows.Forms.ComboBox comboBoxStatusFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.GroupBox groupBoxCustomers;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.GroupBox groupBoxCustomerDetails;
        private System.Windows.Forms.Label lblCustomerNumber;
        private System.Windows.Forms.TextBox txtCustomerNumber;
        private System.Windows.Forms.Label lblTitle;

        /*
                 private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblStatusFilter;
        private System.Windows.Forms.ComboBox comboBoxStatusFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.GroupBox groupBoxCustomers;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.GroupBox groupBoxCustomerDetails;
        private System.Windows.Forms.Label lblCustomerNumber;
        private System.Windows.Forms.TextBox txtCustomerNumber;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnActivateDeactivate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnClose;
         */


    }
}

