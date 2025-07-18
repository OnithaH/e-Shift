namespace e_Shift
{
    partial class ProductManagementForm
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
            this.lblCategory = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.lblSearchProduct = new System.Windows.Forms.Label();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.groupBoxProducts = new System.Windows.Forms.GroupBox();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.groupBoxProductDetails = new System.Windows.Forms.GroupBox();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.comboBoxProductCategory = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.lblPricePerUnit = new System.Windows.Forms.Label();
            this.txtPricePerUnit = new System.Windows.Forms.TextBox();
            this.lblHandlingReq = new System.Windows.Forms.Label();
            this.txtHandlingReq = new System.Windows.Forms.TextBox();
            this.chkIsFragile = new System.Windows.Forms.CheckBox();
            this.chkRequiresSpecialCare = new System.Windows.Forms.CheckBox();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBoxFilters.SuspendLayout();
            this.groupBoxProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.groupBoxProductDetails.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(300, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(240, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Product Management";
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Controls.Add(this.btnShowAll);
            this.groupBoxFilters.Controls.Add(this.btnSearch);
            this.groupBoxFilters.Controls.Add(this.txtSearchProduct);
            this.groupBoxFilters.Controls.Add(this.lblSearchProduct);
            this.groupBoxFilters.Controls.Add(this.comboBoxCategory);
            this.groupBoxFilters.Controls.Add(this.lblCategory);
            this.groupBoxFilters.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxFilters.Location = new System.Drawing.Point(30, 70);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(800, 70);
            this.groupBoxFilters.TabIndex = 1;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Search & Filter";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCategory.Location = new System.Drawing.Point(20, 30);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(77, 23);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category:";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxCategory.Items.AddRange(new object[] {
            "All Categories",
            "Furniture",
            "Electronics",
            "Fragile",
            "Appliances",
            "Documents",
            "Clothing",
            "Books",
            "Automotive",
            "Other"});
            this.comboBoxCategory.Location = new System.Drawing.Point(110, 27);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(130, 31);
            this.comboBoxCategory.TabIndex = 1;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // lblSearchProduct
            // 
            this.lblSearchProduct.AutoSize = true;
            this.lblSearchProduct.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearchProduct.Location = new System.Drawing.Point(280, 30);
            this.lblSearchProduct.Name = "lblSearchProduct";
            this.lblSearchProduct.Size = new System.Drawing.Size(61, 23);
            this.lblSearchProduct.TabIndex = 2;
            this.lblSearchProduct.Text = "Search:";
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearchProduct.Location = new System.Drawing.Point(350, 27);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(150, 30);
            this.txtSearchProduct.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightBlue;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSearch.Location = new System.Drawing.Point(520, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 35);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.LightGray;
            this.btnShowAll.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnShowAll.Location = new System.Drawing.Point(620, 25);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(80, 35);
            this.btnShowAll.TabIndex = 5;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // groupBoxProducts
            // 
            this.groupBoxProducts.Controls.Add(this.dataGridViewProducts);
            this.groupBoxProducts.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxProducts.Location = new System.Drawing.Point(30, 150);
            this.groupBoxProducts.Name = "groupBoxProducts";
            this.groupBoxProducts.Size = new System.Drawing.Size(800, 220);
            this.groupBoxProducts.TabIndex = 2;
            this.groupBoxProducts.TabStop = false;
            this.groupBoxProducts.Text = "Products";
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(20, 30);
            this.dataGridViewProducts.MultiSelect = false;
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(760, 170);
            this.dataGridViewProducts.TabIndex = 0;
            this.dataGridViewProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellClick);
            // 
            // groupBoxProductDetails
            // 
            this.groupBoxProductDetails.Controls.Add(this.chkIsActive);
            this.groupBoxProductDetails.Controls.Add(this.chkRequiresSpecialCare);
            this.groupBoxProductDetails.Controls.Add(this.chkIsFragile);
            this.groupBoxProductDetails.Controls.Add(this.txtHandlingReq);
            this.groupBoxProductDetails.Controls.Add(this.lblHandlingReq);
            this.groupBoxProductDetails.Controls.Add(this.txtPricePerUnit);
            this.groupBoxProductDetails.Controls.Add(this.lblPricePerUnit);
            this.groupBoxProductDetails.Controls.Add(this.txtVolume);
            this.groupBoxProductDetails.Controls.Add(this.lblVolume);
            this.groupBoxProductDetails.Controls.Add(this.txtWeight);
            this.groupBoxProductDetails.Controls.Add(this.lblWeight);
            this.groupBoxProductDetails.Controls.Add(this.txtDescription);
            this.groupBoxProductDetails.Controls.Add(this.lblDescription);
            this.groupBoxProductDetails.Controls.Add(this.comboBoxProductCategory);
            this.groupBoxProductDetails.Controls.Add(this.lblProductCategory);
            this.groupBoxProductDetails.Controls.Add(this.txtProductName);
            this.groupBoxProductDetails.Controls.Add(this.lblProductName);
            this.groupBoxProductDetails.Controls.Add(this.txtProductCode);
            this.groupBoxProductDetails.Controls.Add(this.lblProductCode);
            this.groupBoxProductDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxProductDetails.Location = new System.Drawing.Point(30, 380);
            this.groupBoxProductDetails.Name = "groupBoxProductDetails";
            this.groupBoxProductDetails.Size = new System.Drawing.Size(600, 280);
            this.groupBoxProductDetails.TabIndex = 3;
            this.groupBoxProductDetails.TabStop = false;
            this.groupBoxProductDetails.Text = "Product Details";
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblProductCode.Location = new System.Drawing.Point(20, 30);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(113, 23);
            this.lblProductCode.TabIndex = 0;
            this.lblProductCode.Text = "Product Code:";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtProductCode.Location = new System.Drawing.Point(140, 27);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(120, 30);
            this.txtProductCode.TabIndex = 1;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblProductName.Location = new System.Drawing.Point(280, 30);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(116, 23);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Product Name:";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtProductName.Location = new System.Drawing.Point(410, 27);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(170, 30);
            this.txtProductName.TabIndex = 3;
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblProductCategory.Location = new System.Drawing.Point(20, 70);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(77, 23);
            this.lblProductCategory.TabIndex = 4;
            this.lblProductCategory.Text = "Category:";
            // 
            // comboBoxProductCategory
            // 
            this.comboBoxProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxProductCategory.Items.AddRange(new object[] {
            "Furniture",
            "Electronics",
            "Fragile",
            "Appliances",
            "Documents",
            "Clothing",
            "Books",
            "Automotive",
            "Other"});
            this.comboBoxProductCategory.Location = new System.Drawing.Point(140, 67);
            this.comboBoxProductCategory.Name = "comboBoxProductCategory";
            this.comboBoxProductCategory.Size = new System.Drawing.Size(120, 31);
            this.comboBoxProductCategory.TabIndex = 5;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDescription.Location = new System.Drawing.Point(280, 70);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(96, 23);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescription.Location = new System.Drawing.Point(280, 100);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(300, 45);
            this.txtDescription.TabIndex = 7;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWeight.Location = new System.Drawing.Point(20, 110);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(95, 23);
            this.lblWeight.TabIndex = 8;
            this.lblWeight.Text = "Weight (kg):";
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtWeight.Location = new System.Drawing.Point(140, 107);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(80, 30);
            this.txtWeight.TabIndex = 9;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblVolume.Location = new System.Drawing.Point(20, 150);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(100, 23);
            this.lblVolume.TabIndex = 10;
            this.lblVolume.Text = "Volume (m³):";
            // 
            // txtVolume
            // 
            this.txtVolume.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtVolume.Location = new System.Drawing.Point(140, 147);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(80, 30);
            this.txtVolume.TabIndex = 11;
            // 
            // lblPricePerUnit
            // 
            this.lblPricePerUnit.AutoSize = true;
            this.lblPricePerUnit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPricePerUnit.Location = new System.Drawing.Point(20, 190);
            this.lblPricePerUnit.Name = "lblPricePerUnit";
            this.lblPricePerUnit.Size = new System.Drawing.Size(108, 23);
            this.lblPricePerUnit.TabIndex = 12;
            this.lblPricePerUnit.Text = "Price Per Unit:";
            // 
            // txtPricePerUnit
            // 
            this.txtPricePerUnit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPricePerUnit.Location = new System.Drawing.Point(140, 187);
            this.txtPricePerUnit.Name = "txtPricePerUnit";
            this.txtPricePerUnit.Size = new System.Drawing.Size(100, 30);
            this.txtPricePerUnit.TabIndex = 13;
            // 
            // lblHandlingReq
            // 
            this.lblHandlingReq.AutoSize = true;
            this.lblHandlingReq.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHandlingReq.Location = new System.Drawing.Point(20, 230);
            this.lblHandlingReq.Name = "lblHandlingReq";
            this.lblHandlingReq.Size = new System.Drawing.Size(186, 23);
            this.lblHandlingReq.TabIndex = 14;
            this.lblHandlingReq.Text = "Handling Requirements:";
            // 
            // txtHandlingReq
            // 
            this.txtHandlingReq.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtHandlingReq.Location = new System.Drawing.Point(220, 227);
            this.txtHandlingReq.Name = "txtHandlingReq";
            this.txtHandlingReq.Size = new System.Drawing.Size(200, 30);
            this.txtHandlingReq.TabIndex = 15;
            // 
            // chkIsFragile
            // 
            this.chkIsFragile.AutoSize = true;
            this.chkIsFragile.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkIsFragile.Location = new System.Drawing.Point(280, 160);
            this.chkIsFragile.Name = "chkIsFragile";
            this.chkIsFragile.Size = new System.Drawing.Size(82, 27);
            this.chkIsFragile.TabIndex = 16;
            this.chkIsFragile.Text = "Fragile";
            this.chkIsFragile.UseVisualStyleBackColor = true;
            // 
            // chkRequiresSpecialCare
            // 
            this.chkRequiresSpecialCare.AutoSize = true;
            this.chkRequiresSpecialCare.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkRequiresSpecialCare.Location = new System.Drawing.Point(380, 160);
            this.chkRequiresSpecialCare.Name = "chkRequiresSpecialCare";
            this.chkRequiresSpecialCare.Size = new System.Drawing.Size(125, 27);
            this.chkRequiresSpecialCare.TabIndex = 17;
            this.chkRequiresSpecialCare.Text = "Special Care";
            this.chkRequiresSpecialCare.UseVisualStyleBackColor = true;
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkIsActive.Location = new System.Drawing.Point(280, 190);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(77, 27);
            this.chkIsActive.TabIndex = 18;
            this.chkIsActive.Text = "Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.btnDelete);
            this.groupBoxActions.Controls.Add(this.btnCancel);
            this.groupBoxActions.Controls.Add(this.btnSave);
            this.groupBoxActions.Controls.Add(this.btnEdit);
            this.groupBoxActions.Controls.Add(this.btnAddNew);
            this.groupBoxActions.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxActions.Location = new System.Drawing.Point(650, 380);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(180, 280);
            this.groupBoxActions.TabIndex = 4;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddNew.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAddNew.Location = new System.Drawing.Point(20, 30);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(140, 35);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LightBlue;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEdit.Location = new System.Drawing.Point(20, 75);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(140, 35);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightGreen;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(20, 120);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 35);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightYellow;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Location = new System.Drawing.Point(20, 165);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 35);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDelete.Location = new System.Drawing.Point(20, 210);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 35);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatus.Location = new System.Drawing.Point(30, 680);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(55, 23);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Ready";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightGray;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.Location = new System.Drawing.Point(740, 675);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 35);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ProductManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(860, 720);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.groupBoxProductDetails);
            this.Controls.Add(this.groupBoxProducts);
            this.Controls.Add(this.groupBoxFilters);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ProductManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-Shift - Product Management";
            this.Load += new System.EventHandler(this.ProductManagementForm_Load);
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
            this.groupBoxProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.groupBoxProductDetails.ResumeLayout(false);
            this.groupBoxProductDetails.PerformLayout();
            this.groupBoxActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label lblSearchProduct;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.GroupBox groupBoxProducts;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.GroupBox groupBoxProductDetails;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductCategory;
        private System.Windows.Forms.ComboBox comboBoxProductCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Label lblPricePerUnit;
        private System.Windows.Forms.TextBox txtPricePerUnit;
        private System.Windows.Forms.Label lblHandlingReq;
        private System.Windows.Forms.TextBox txtHandlingReq;
        private System.Windows.Forms.CheckBox chkIsFragile;
        private System.Windows.Forms.CheckBox chkRequiresSpecialCare;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnClose;
    }
}