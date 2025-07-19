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
            lblTitle = new Label();
            groupBoxFilters = new GroupBox();
            btnShowAll = new Button();
            btnSearch = new Button();
            comboBoxStatusFilter = new ComboBox();
            lblStatusFilter = new Label();
            txtSearch = new TextBox();
            lblSearch = new Label();
            groupBoxCustomers = new GroupBox();
            dataGridViewCustomers = new DataGridView();
            groupBoxCustomerDetails = new GroupBox();
            chkIsActive = new CheckBox();
            txtPostalCode = new TextBox();
            lblPostalCode = new Label();
            txtCity = new TextBox();
            lblCity = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            txtPhone = new TextBox();
            lblPhone = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            txtCustomerNumber = new TextBox();
            lblCustomerNumber = new Label();
            groupBoxActions = new GroupBox();
            btnActivateDeactivate = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            btnEdit = new Button();
            btnAddNew = new Button();
            lblStatus = new Label();
            btnClose = new Button();
            groupBoxFilters.SuspendLayout();
            groupBoxCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).BeginInit();
            groupBoxCustomerDetails.SuspendLayout();
            groupBoxActions.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(30, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(319, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Customer Management";
            // 
            // groupBoxFilters
            // 
            groupBoxFilters.Controls.Add(btnShowAll);
            groupBoxFilters.Controls.Add(btnSearch);
            groupBoxFilters.Controls.Add(comboBoxStatusFilter);
            groupBoxFilters.Controls.Add(lblStatusFilter);
            groupBoxFilters.Controls.Add(txtSearch);
            groupBoxFilters.Controls.Add(lblSearch);
            groupBoxFilters.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxFilters.Location = new Point(30, 70);
            groupBoxFilters.Name = "groupBoxFilters";
            groupBoxFilters.Size = new Size(1112, 70);
            groupBoxFilters.TabIndex = 1;
            groupBoxFilters.TabStop = false;
            groupBoxFilters.Text = "Search & Filters";
            // 
            // btnShowAll
            // 
            btnShowAll.BackColor = Color.LightGray;
            btnShowAll.Font = new Font("Segoe UI", 10F);
            btnShowAll.Location = new Point(1006, 24);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(100, 35);
            btnShowAll.TabIndex = 5;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = false;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LightBlue;
            btnSearch.Font = new Font("Segoe UI", 10F);
            btnSearch.Location = new Point(896, 24);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 35);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "🔍 Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // comboBoxStatusFilter
            // 
            comboBoxStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatusFilter.Font = new Font("Segoe UI", 10F);
            comboBoxStatusFilter.FormattingEnabled = true;
            comboBoxStatusFilter.Items.AddRange(new object[] { "All", "Active", "Inactive" });
            comboBoxStatusFilter.Location = new Point(753, 26);
            comboBoxStatusFilter.Name = "comboBoxStatusFilter";
            comboBoxStatusFilter.Size = new Size(120, 31);
            comboBoxStatusFilter.TabIndex = 3;
            comboBoxStatusFilter.SelectedIndexChanged += comboBoxStatusFilter_SelectedIndexChanged;
            // 
            // lblStatusFilter
            // 
            lblStatusFilter.AutoSize = true;
            lblStatusFilter.Font = new Font("Segoe UI", 10F);
            lblStatusFilter.Location = new Point(688, 29);
            lblStatusFilter.Name = "lblStatusFilter";
            lblStatusFilter.Size = new Size(60, 23);
            lblStatusFilter.TabIndex = 2;
            lblStatusFilter.Text = "Status:";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(85, 27);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Name, Email, Customer Number...";
            txtSearch.Size = new Size(351, 30);
            txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F);
            lblSearch.Location = new Point(20, 30);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(65, 23);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search:";
            // 
            // groupBoxCustomers
            // 
            groupBoxCustomers.Controls.Add(dataGridViewCustomers);
            groupBoxCustomers.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxCustomers.Location = new Point(30, 150);
            groupBoxCustomers.Name = "groupBoxCustomers";
            groupBoxCustomers.Size = new Size(1112, 300);
            groupBoxCustomers.TabIndex = 2;
            groupBoxCustomers.TabStop = false;
            groupBoxCustomers.Text = "Customers List";
            // 
            // dataGridViewCustomers
            // 
            dataGridViewCustomers.AllowUserToAddRows = false;
            dataGridViewCustomers.AllowUserToDeleteRows = false;
            dataGridViewCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCustomers.BackgroundColor = Color.White;
            dataGridViewCustomers.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomers.Location = new Point(15, 30);
            dataGridViewCustomers.MultiSelect = false;
            dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCustomers.ReadOnly = true;
            dataGridViewCustomers.RowHeadersWidth = 51;
            dataGridViewCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCustomers.Size = new Size(1069, 255);
            dataGridViewCustomers.TabIndex = 0;
            dataGridViewCustomers.SelectionChanged += dataGridViewCustomers_SelectionChanged;
            // 
            // groupBoxCustomerDetails
            // 
            groupBoxCustomerDetails.Controls.Add(chkIsActive);
            groupBoxCustomerDetails.Controls.Add(txtPostalCode);
            groupBoxCustomerDetails.Controls.Add(lblPostalCode);
            groupBoxCustomerDetails.Controls.Add(txtCity);
            groupBoxCustomerDetails.Controls.Add(lblCity);
            groupBoxCustomerDetails.Controls.Add(txtAddress);
            groupBoxCustomerDetails.Controls.Add(lblAddress);
            groupBoxCustomerDetails.Controls.Add(txtPhone);
            groupBoxCustomerDetails.Controls.Add(lblPhone);
            groupBoxCustomerDetails.Controls.Add(txtEmail);
            groupBoxCustomerDetails.Controls.Add(lblEmail);
            groupBoxCustomerDetails.Controls.Add(txtLastName);
            groupBoxCustomerDetails.Controls.Add(lblLastName);
            groupBoxCustomerDetails.Controls.Add(txtFirstName);
            groupBoxCustomerDetails.Controls.Add(lblFirstName);
            groupBoxCustomerDetails.Controls.Add(txtCustomerNumber);
            groupBoxCustomerDetails.Controls.Add(lblCustomerNumber);
            groupBoxCustomerDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxCustomerDetails.Location = new Point(30, 470);
            groupBoxCustomerDetails.Name = "groupBoxCustomerDetails";
            groupBoxCustomerDetails.Size = new Size(670, 220);
            groupBoxCustomerDetails.TabIndex = 3;
            groupBoxCustomerDetails.TabStop = false;
            groupBoxCustomerDetails.Text = "Customer Details";
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Font = new Font("Segoe UI", 10F);
            chkIsActive.Location = new Point(250, 190);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(78, 27);
            chkIsActive.TabIndex = 16;
            chkIsActive.Text = "Active";
            chkIsActive.UseVisualStyleBackColor = true;
            chkIsActive.CheckedChanged += chkIsActive_CheckedChanged;
            // 
            // txtPostalCode
            // 
            txtPostalCode.Font = new Font("Segoe UI", 10F);
            txtPostalCode.Location = new Point(125, 187);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(100, 30);
            txtPostalCode.TabIndex = 15;
            // 
            // lblPostalCode
            // 
            lblPostalCode.AutoSize = true;
            lblPostalCode.Font = new Font("Segoe UI", 10F);
            lblPostalCode.Location = new Point(20, 190);
            lblPostalCode.Name = "lblPostalCode";
            lblPostalCode.Size = new Size(104, 23);
            lblPostalCode.TabIndex = 14;
            lblPostalCode.Text = "Postal Code:";
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 10F);
            txtCity.Location = new Point(492, 147);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(120, 30);
            txtCity.TabIndex = 13;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI", 10F);
            lblCity.Location = new Point(442, 150);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(43, 23);
            lblCity.TabIndex = 12;
            lblCity.Text = "City:";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 10F);
            txtAddress.Location = new Point(100, 147);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(300, 30);
            txtAddress.TabIndex = 11;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 10F);
            lblAddress.Location = new Point(20, 150);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(74, 23);
            lblAddress.TabIndex = 10;
            lblAddress.Text = "Address:";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 10F);
            txtPhone.Location = new Point(387, 107);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(150, 30);
            txtPhone.TabIndex = 9;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10F);
            lblPhone.Location = new Point(322, 110);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(63, 23);
            lblPhone.TabIndex = 8;
            lblPhone.Text = "Phone:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(80, 107);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 30);
            txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.Location = new Point(20, 110);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(55, 23);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email:";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 10F);
            txtLastName.Location = new Point(412, 67);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 30);
            txtLastName.TabIndex = 5;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 10F);
            lblLastName.Location = new Point(312, 70);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(95, 23);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 10F);
            txtFirstName.Location = new Point(120, 67);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(150, 30);
            txtFirstName.TabIndex = 3;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 10F);
            lblFirstName.Location = new Point(20, 70);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(96, 23);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "First Name:";
            // 
            // txtCustomerNumber
            // 
            txtCustomerNumber.BackColor = Color.LightGray;
            txtCustomerNumber.Font = new Font("Segoe UI", 10F);
            txtCustomerNumber.Location = new Point(165, 27);
            txtCustomerNumber.Name = "txtCustomerNumber";
            txtCustomerNumber.ReadOnly = true;
            txtCustomerNumber.Size = new Size(150, 30);
            txtCustomerNumber.TabIndex = 1;
            // 
            // lblCustomerNumber
            // 
            lblCustomerNumber.AutoSize = true;
            lblCustomerNumber.Font = new Font("Segoe UI", 10F);
            lblCustomerNumber.Location = new Point(20, 30);
            lblCustomerNumber.Name = "lblCustomerNumber";
            lblCustomerNumber.Size = new Size(156, 23);
            lblCustomerNumber.TabIndex = 0;
            lblCustomerNumber.Text = "Customer Number:";
            // 
            // groupBoxActions
            // 
            groupBoxActions.Controls.Add(btnActivateDeactivate);
            groupBoxActions.Controls.Add(btnDelete);
            groupBoxActions.Controls.Add(btnCancel);
            groupBoxActions.Controls.Add(btnSave);
            groupBoxActions.Controls.Add(btnEdit);
            groupBoxActions.Controls.Add(btnAddNew);
            groupBoxActions.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxActions.Location = new Point(890, 470);
            groupBoxActions.Name = "groupBoxActions";
            groupBoxActions.Size = new Size(252, 220);
            groupBoxActions.TabIndex = 4;
            groupBoxActions.TabStop = false;
            groupBoxActions.Text = "Actions";
            // 
            // btnActivateDeactivate
            // 
            btnActivateDeactivate.BackColor = Color.LightYellow;
            btnActivateDeactivate.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnActivateDeactivate.Location = new Point(121, 165);
            btnActivateDeactivate.Name = "btnActivateDeactivate";
            btnActivateDeactivate.Size = new Size(104, 35);
            btnActivateDeactivate.TabIndex = 5;
            btnActivateDeactivate.Text = "✅ Activate";
            btnActivateDeactivate.UseVisualStyleBackColor = false;
            btnActivateDeactivate.Click += btnActivateDeactivate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.Location = new Point(20, 165);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 35);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "🗑️ Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightGray;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancel.Location = new Point(121, 120);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(104, 35);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "❌ Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightGreen;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.Location = new Point(20, 120);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(95, 35);
            btnSave.TabIndex = 2;
            btnSave.Text = "💾 Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.LightBlue;
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEdit.Location = new Point(20, 75);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(205, 35);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "✏️ Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.LightGreen;
            btnAddNew.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddNew.Location = new Point(20, 30);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(205, 35);
            btnAddNew.TabIndex = 0;
            btnAddNew.Text = "➕ Add New";
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10F);
            lblStatus.Location = new Point(30, 710);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(56, 23);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Ready";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.LightGray;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClose.Location = new Point(979, 710);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(90, 35);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // CustomerManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1154, 750);
            Controls.Add(btnClose);
            Controls.Add(lblStatus);
            Controls.Add(groupBoxActions);
            Controls.Add(groupBoxCustomerDetails);
            Controls.Add(groupBoxCustomers);
            Controls.Add(groupBoxFilters);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CustomerManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-Shift - Customer Management";
            Load += CustomerManagementForm_Load;
            groupBoxFilters.ResumeLayout(false);
            groupBoxFilters.PerformLayout();
            groupBoxCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).EndInit();
            groupBoxCustomerDetails.ResumeLayout(false);
            groupBoxCustomerDetails.PerformLayout();
            groupBoxActions.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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

      
        

    }
}

