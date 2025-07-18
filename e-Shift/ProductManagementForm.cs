using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using e_Shift.Database;
using e_Shift.Utils;

namespace e_Shift
{
    public partial class ProductManagementForm : Form
    {
        private int selectedProductId = -1;
        private bool isEditing = false;
        private bool isAddingNew = false;

        public ProductManagementForm()
        {
            InitializeComponent();
        }

        private void ProductManagementForm_Load(object sender, EventArgs e)
        {
            // Check if admin is logged in
            if (!UserSession.IsLoggedIn || !UserSession.IsAdmin())
            {
                MessageBox.Show("Access denied! Admin privileges required.",
                              "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // Set default values
            comboBoxCategory.SelectedIndex = 0; // "All Categories"
            comboBoxProductCategory.SelectedIndex = 0; // "Furniture"

            // Load products
            LoadProducts();

            // Set initial state
            SetFormState(FormState.Viewing);

            ShowMessage("Product management loaded successfully", false);
        }

        private void LoadProducts(string categoryFilter = "All Categories", string searchText = "")
        {
            try
            {
                string query = @"
                    SELECT 
                        ProductID, ProductCode, ProductName, Category, Description,
                        Weight, Volume, PricePerUnit, HandlingRequirements,
                        IsFragile, RequiresSpecialCare, IsActive, CreatedDate
                    FROM Products 
                    WHERE IsDeleted = 0";

                var parameters = new List<SqlParameter>();

                if (categoryFilter != "All Categories")
                {
                    query += " AND Category = @Category";
                    parameters.Add(new SqlParameter("@Category", categoryFilter));
                }

                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    query += " AND (ProductCode LIKE @Search OR ProductName LIKE @Search OR Description LIKE @Search)";
                    parameters.Add(new SqlParameter("@Search", $"%{searchText}%"));
                }

                query += " ORDER BY ProductCode";

                DataTable productsData = DatabaseConnection.FillDataTable(query, parameters.ToArray());

                if (productsData != null)
                {
                    dataGridViewProducts.DataSource = productsData;
                    FormatProductsGrid();
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error loading products: {ex.Message}", true);
            }
        }

        private void FormatProductsGrid()
        {
            try
            {
                if (dataGridViewProducts.Columns.Count > 0)
                {
                    // Hide unnecessary columns
                    dataGridViewProducts.Columns["ProductID"].Visible = false;

                    // Set column headers
                    dataGridViewProducts.Columns["ProductCode"].HeaderText = "Code";
                    dataGridViewProducts.Columns["ProductName"].HeaderText = "Product Name";
                    dataGridViewProducts.Columns["Category"].HeaderText = "Category";
                    dataGridViewProducts.Columns["Weight"].HeaderText = "Weight (kg)";
                    dataGridViewProducts.Columns["Volume"].HeaderText = "Volume (m³)";
                    dataGridViewProducts.Columns["PricePerUnit"].HeaderText = "Price";
                    dataGridViewProducts.Columns["IsFragile"].HeaderText = "Fragile";
                    dataGridViewProducts.Columns["IsActive"].HeaderText = "Active";

                    // Set column widths
                    dataGridViewProducts.Columns["ProductCode"].Width = 80;
                    dataGridViewProducts.Columns["ProductName"].Width = 150;
                    dataGridViewProducts.Columns["Category"].Width = 100;
                    dataGridViewProducts.Columns["Description"].Width = 200;
                    dataGridViewProducts.Columns["Weight"].Width = 80;
                    dataGridViewProducts.Columns["Volume"].Width = 80;
                    dataGridViewProducts.Columns["PricePerUnit"].Width = 80;
                    dataGridViewProducts.Columns["IsFragile"].Width = 60;
                    dataGridViewProducts.Columns["IsActive"].Width = 60;

                    // Format columns
                    dataGridViewProducts.Columns["Weight"].DefaultCellStyle.Format = "F2";
                    dataGridViewProducts.Columns["Volume"].DefaultCellStyle.Format = "F2";
                    dataGridViewProducts.Columns["PricePerUnit"].DefaultCellStyle.Format = "C";
                    dataGridViewProducts.Columns["PricePerUnit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    // Hide detailed columns that are shown in details panel
                    dataGridViewProducts.Columns["HandlingRequirements"].Visible = false;
                    dataGridViewProducts.Columns["RequiresSpecialCare"].Visible = false;
                    dataGridViewProducts.Columns["CreatedDate"].Visible = false;

                    // Color code rows
                    foreach (DataGridViewRow row in dataGridViewProducts.Rows)
                    {
                        bool isActive = Convert.ToBoolean(row.Cells["IsActive"].Value);
                        if (!isActive)
                        {
                            row.DefaultCellStyle.BackColor = Color.LightGray;
                            row.DefaultCellStyle.ForeColor = Color.DarkGray;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error formatting grid: {ex.Message}");
            }
        }

        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !isEditing && !isAddingNew)
            {
                DataGridViewRow selectedRow = dataGridViewProducts.Rows[e.RowIndex];
                selectedProductId = Convert.ToInt32(selectedRow.Cells["ProductID"].Value);
                LoadProductDetails(selectedRow);
                SetFormState(FormState.Viewing);
            }
        }

        private void LoadProductDetails(DataGridViewRow row)
        {
            try
            {
                txtProductCode.Text = row.Cells["ProductCode"].Value?.ToString();
                txtProductName.Text = row.Cells["ProductName"].Value?.ToString();
                comboBoxProductCategory.Text = row.Cells["Category"].Value?.ToString();
                txtDescription.Text = row.Cells["Description"].Value?.ToString();
                txtWeight.Text = row.Cells["Weight"].Value?.ToString();
                txtVolume.Text = row.Cells["Volume"].Value?.ToString();
                txtPricePerUnit.Text = row.Cells["PricePerUnit"].Value?.ToString();
                txtHandlingReq.Text = row.Cells["HandlingRequirements"].Value?.ToString();
                chkIsFragile.Checked = Convert.ToBoolean(row.Cells["IsFragile"].Value ?? false);
                chkRequiresSpecialCare.Checked = Convert.ToBoolean(row.Cells["RequiresSpecialCare"].Value ?? false);
                chkIsActive.Checked = Convert.ToBoolean(row.Cells["IsActive"].Value ?? true);
            }
            catch (Exception ex)
            {
                ShowMessage($"Error loading product details: {ex.Message}", true);
            }
        }

        private void ClearProductDetails()
        {
            txtProductCode.Text = "";
            txtProductName.Text = "";
            comboBoxProductCategory.SelectedIndex = 0;
            txtDescription.Text = "";
            txtWeight.Text = "0.00";
            txtVolume.Text = "0.00";
            txtPricePerUnit.Text = "0.00";
            txtHandlingReq.Text = "";
            chkIsFragile.Checked = false;
            chkRequiresSpecialCare.Checked = false;
            chkIsActive.Checked = true;
        }

        private enum FormState
        {
            Viewing,
            Adding,
            Editing
        }

        private void SetFormState(FormState state)
        {
            switch (state)
            {
                case FormState.Viewing:
                    isEditing = false;
                    isAddingNew = false;
                    SetFieldsEditable(false);
                    btnAddNew.Enabled = true;
                    btnEdit.Enabled = selectedProductId != -1;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnDelete.Enabled = selectedProductId != -1;
                    break;

                case FormState.Adding:
                    isAddingNew = true;
                    isEditing = false;
                    SetFieldsEditable(true);
                    ClearProductDetails();
                    btnAddNew.Enabled = false;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnDelete.Enabled = false;
                    txtProductCode.Focus();
                    break;

                case FormState.Editing:
                    isEditing = true;
                    isAddingNew = false;
                    SetFieldsEditable(true);
                    btnAddNew.Enabled = false;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnDelete.Enabled = false;
                    txtProductName.Focus();
                    break;
            }
        }

        private void SetFieldsEditable(bool editable)
        {
            txtProductCode.ReadOnly = !editable;
            txtProductName.ReadOnly = !editable;
            comboBoxProductCategory.Enabled = editable;
            txtDescription.ReadOnly = !editable;
            txtWeight.ReadOnly = !editable;
            txtVolume.ReadOnly = !editable;
            txtPricePerUnit.ReadOnly = !editable;
            txtHandlingReq.ReadOnly = !editable;
            chkIsFragile.Enabled = editable;
            chkRequiresSpecialCare.Enabled = editable;
            chkIsActive.Enabled = editable;

            // Change background color to indicate edit mode
            Color bgColor = editable ? Color.White : Color.WhiteSmoke;
            txtProductCode.BackColor = bgColor;
            txtProductName.BackColor = bgColor;
            txtDescription.BackColor = bgColor;
            txtWeight.BackColor = bgColor;
            txtVolume.BackColor = bgColor;
            txtPricePerUnit.BackColor = bgColor;
            txtHandlingReq.BackColor = bgColor;
        }

        // Button click events
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            selectedProductId = -1;
            SetFormState(FormState.Adding);
            ShowMessage("Enter new product details and click Save", false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedProductId == -1)
            {
                ShowMessage("Please select a product to edit", true);
                return;
            }

            SetFormState(FormState.Editing);
            ShowMessage("Edit product details and click Save", false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateProductData())
                return;

            if (isAddingNew)
            {
                if (SaveNewProduct())
                {
                    ShowMessage("Product added successfully!", false);
                    LoadProducts();
                    SetFormState(FormState.Viewing);
                }
            }
            else if (isEditing)
            {
                if (UpdateProduct())
                {
                    ShowMessage("Product updated successfully!", false);
                    LoadProducts();
                    SetFormState(FormState.Viewing);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (selectedProductId != -1)
            {
                // Reload the selected product details
                foreach (DataGridViewRow row in dataGridViewProducts.Rows)
                {
                    if (Convert.ToInt32(row.Cells["ProductID"].Value) == selectedProductId)
                    {
                        LoadProductDetails(row);
                        break;
                    }
                }
            }
            else
            {
                ClearProductDetails();
            }

            SetFormState(FormState.Viewing);
            ShowMessage("Changes cancelled", false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedProductId == -1)
            {
                ShowMessage("Please select a product to delete", true);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete this product?\n\nProduct: {txtProductName.Text}\nCode: {txtProductCode.Text}\n\nThis action cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (DeleteProduct())
                {
                    ShowMessage("Product deleted successfully!", false);
                    LoadProducts();
                    ClearProductDetails();
                    selectedProductId = -1;
                    SetFormState(FormState.Viewing);
                }
            }
        }

        private bool ValidateProductData()
        {
            if (string.IsNullOrWhiteSpace(txtProductCode.Text))
            {
                ShowMessage("Product code is required", true);
                txtProductCode.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                ShowMessage("Product name is required", true);
                txtProductName.Focus();
                return false;
            }

            if (comboBoxProductCategory.SelectedIndex == -1)
            {
                ShowMessage("Please select a category", true);
                comboBoxProductCategory.Focus();
                return false;
            }

            // Validate numeric fields
            if (!decimal.TryParse(txtWeight.Text, out decimal weight) || weight < 0)
            {
                ShowMessage("Please enter a valid weight", true);
                txtWeight.Focus();
                return false;
            }

            if (!decimal.TryParse(txtVolume.Text, out decimal volume) || volume < 0)
            {
                ShowMessage("Please enter a valid volume", true);
                txtVolume.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPricePerUnit.Text, out decimal price) || price <= 0)
            {
                ShowMessage("Please enter a valid price per unit", true);
                txtPricePerUnit.Focus();
                return false;
            }

            // Check for duplicate product code (only for new products or if code changed)
            if (isAddingNew || (isEditing && ProductCodeExists(txtProductCode.Text, selectedProductId)))
            {
                if (ProductCodeExists(txtProductCode.Text))
                {
                    ShowMessage("Product code already exists", true);
                    txtProductCode.Focus();
                    return false;
                }
            }

            return true;
        }

        private bool ProductCodeExists(string productCode, int excludeProductId = -1)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM Products WHERE ProductCode = @ProductCode AND IsDeleted = 0";
                var parameters = new List<SqlParameter> { new SqlParameter("@ProductCode", productCode) };

                if (excludeProductId != -1)
                {
                    query += " AND ProductID != @ProductID";
                    parameters.Add(new SqlParameter("@ProductID", excludeProductId));
                }

                object result = DatabaseConnection.ExecuteScalar(query, parameters.ToArray());
                return Convert.ToInt32(result) > 0;
            }
            catch
            {
                return false;
            }
        }

        private bool SaveNewProduct()
        {
            try
            {
                string query = @"
                    INSERT INTO Products (
                        ProductCode, ProductName, Category, Description, Weight, Volume,
                        PricePerUnit, HandlingRequirements, IsFragile, RequiresSpecialCare, IsActive
                    ) VALUES (
                        @ProductCode, @ProductName, @Category, @Description, @Weight, @Volume,
                        @PricePerUnit, @HandlingRequirements, @IsFragile, @RequiresSpecialCare, @IsActive
                    )";

                SqlParameter[] parameters = CreateProductParameters();

                int result = DatabaseConnection.ExecuteNonQuery(query, parameters);

                if (result > 0)
                {
                    LogProductAction("Product_Added", $"Added new product: {txtProductName.Text}");
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                ShowMessage($"Error adding product: {ex.Message}", true);
                return false;
            }
        }

        private bool UpdateProduct()
        {
            try
            {
                string query = @"
                    UPDATE Products SET
                        ProductCode = @ProductCode,
                        ProductName = @ProductName,
                        Category = @Category,
                        Description = @Description,
                        Weight = @Weight,
                        Volume = @Volume,
                        PricePerUnit = @PricePerUnit,
                        HandlingRequirements = @HandlingRequirements,
                        IsFragile = @IsFragile,
                        RequiresSpecialCare = @RequiresSpecialCare,
                        IsActive = @IsActive,
                        ModifiedDate = @ModifiedDate
                    WHERE ProductID = @ProductID";

                var parameterList = CreateProductParameters().ToList();
                parameterList.Add(new SqlParameter("@ModifiedDate", DateTime.Now));
                parameterList.Add(new SqlParameter("@ProductID", selectedProductId));

                int result = DatabaseConnection.ExecuteNonQuery(query, parameterList.ToArray());

                if (result > 0)
                {
                    LogProductAction("Product_Updated", $"Updated product: {txtProductName.Text}");
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                ShowMessage($"Error updating product: {ex.Message}", true);
                return false;
            }
        }

        private bool DeleteProduct()
        {
            try
            {
                // Soft delete
                string query = @"
                    UPDATE Products SET
                        IsDeleted = 1,
                        IsActive = 0,
                        ModifiedDate = @ModifiedDate
                    WHERE ProductID = @ProductID";

                SqlParameter[] parameters = {
                    new SqlParameter("@ModifiedDate", DateTime.Now),
                    new SqlParameter("@ProductID", selectedProductId)
                };

                int result = DatabaseConnection.ExecuteNonQuery(query, parameters);

                if (result > 0)
                {
                    LogProductAction("Product_Deleted", $"Deleted product: {txtProductName.Text}");
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                ShowMessage($"Error deleting product: {ex.Message}", true);
                return false;
            }
        }

        private SqlParameter[] CreateProductParameters()
        {
            return new SqlParameter[]
            {
                new SqlParameter("@ProductCode", txtProductCode.Text.Trim()),
                new SqlParameter("@ProductName", txtProductName.Text.Trim()),
                new SqlParameter("@Category", comboBoxProductCategory.Text),
                new SqlParameter("@Description", txtDescription.Text.Trim()),
                new SqlParameter("@Weight", Convert.ToDecimal(txtWeight.Text)),
                new SqlParameter("@Volume", Convert.ToDecimal(txtVolume.Text)),
                new SqlParameter("@PricePerUnit", Convert.ToDecimal(txtPricePerUnit.Text)),
                new SqlParameter("@HandlingRequirements", txtHandlingReq.Text.Trim()),
                new SqlParameter("@IsFragile", chkIsFragile.Checked),
                new SqlParameter("@RequiresSpecialCare", chkRequiresSpecialCare.Checked),
                new SqlParameter("@IsActive", chkIsActive.Checked)
            };
        }

        private void LogProductAction(string actionType, string details)
        {
            try
            {
                string query = @"
                    INSERT INTO SystemLogs (LogType, UserType, UserID, Action, Details, LogDate, IPAddress)
                    VALUES (@LogType, @UserType, @UserID, @Action, @Details, @LogDate, @IPAddress)";

                SqlParameter[] parameters = {
                    new SqlParameter("@LogType", actionType),
                    new SqlParameter("@UserType", "Admin"),
                    new SqlParameter("@UserID", UserSession.UserId),
                    new SqlParameter("@Action", actionType),
                    new SqlParameter("@Details", details),
                    new SqlParameter("@LogDate", DateTime.Now),
                    new SqlParameter("@IPAddress", "127.0.0.1")
                };

                DatabaseConnection.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to log product action: {ex.Message}");
            }
        }

        // Search and filter events
        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCategory.SelectedIndex != -1)
            {
                LoadProducts(comboBoxCategory.Text, txtSearchProduct.Text);
                ClearProductDetails();
                selectedProductId = -1;
                SetFormState(FormState.Viewing);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadProducts(comboBoxCategory.Text, txtSearchProduct.Text);
            ClearProductDetails();
            selectedProductId = -1;
            SetFormState(FormState.Viewing);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            comboBoxCategory.SelectedIndex = 0; // "All Categories"
            txtSearchProduct.Text = "";
            LoadProducts();
            ClearProductDetails();
            selectedProductId = -1;
            SetFormState(FormState.Viewing);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (isEditing || isAddingNew)
            {
                DialogResult result = MessageBox.Show(
                    "You have unsaved changes. Are you sure you want to close?",
                    "Unsaved Changes",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    return;
            }

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
    }
}