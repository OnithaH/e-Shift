namespace e_Shift
{
    partial class NewJobRequestForm
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
            groupBoxPickup = new GroupBox();
            txtPickupPostal = new TextBox();
            lblPickupPostal = new Label();
            txtPickupCity = new TextBox();
            lblPickupCity = new Label();
            txtPickupAddress = new TextBox();
            lblPickupAddress = new Label();
            txtPickupLocation = new TextBox();
            lblPickupLocation = new Label();
            groupBoxDelivery = new GroupBox();
            txtDeliveryPostal = new TextBox();
            lblDeliveryPostal = new Label();
            txtDeliveryCity = new TextBox();
            lblDeliveryCity = new Label();
            txtDeliveryAddress = new TextBox();
            lblDeliveryAddress = new Label();
            txtDeliveryLocation = new TextBox();
            lblDeliveryLocation = new Label();
            groupBoxJobDetails = new GroupBox();
            txtSpecialInstructions = new TextBox();
            lblSpecialInstructions = new Label();
            comboBoxPriority = new ComboBox();
            lblPriority = new Label();
            dateTimePickerScheduled = new DateTimePicker();
            lblScheduledDate = new Label();
            btnSubmitRequest = new Button();
            btnCancel = new Button();
            lblStatus = new Label();
            groupBoxProductSelection = new GroupBox();
            lblSelectProducts = new Label();
            dgvProductSelection = new DataGridView();
            groupBoxCalculatedTotals = new GroupBox();
            lblTotalWeight = new Label();
            lblWeightValue = new Label();
            lblTotalVolume = new Label();
            lblVolumeValue = new Label();
            lblEstimatedCost = new Label();
            lblCostValue = new Label();
            groupBoxPickup.SuspendLayout();
            groupBoxDelivery.SuspendLayout();
            groupBoxJobDetails.SuspendLayout();
            groupBoxProductSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductSelection).BeginInit();
            groupBoxCalculatedTotals.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(200, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(317, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "New Transport Request";
            // 
            // groupBoxPickup
            // 
            groupBoxPickup.Controls.Add(txtPickupPostal);
            groupBoxPickup.Controls.Add(lblPickupPostal);
            groupBoxPickup.Controls.Add(txtPickupCity);
            groupBoxPickup.Controls.Add(lblPickupCity);
            groupBoxPickup.Controls.Add(txtPickupAddress);
            groupBoxPickup.Controls.Add(lblPickupAddress);
            groupBoxPickup.Controls.Add(txtPickupLocation);
            groupBoxPickup.Controls.Add(lblPickupLocation);
            groupBoxPickup.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBoxPickup.Location = new Point(30, 80);
            groupBoxPickup.Name = "groupBoxPickup";
            groupBoxPickup.Size = new Size(320, 180);
            groupBoxPickup.TabIndex = 1;
            groupBoxPickup.TabStop = false;
            groupBoxPickup.Text = "📍 Pickup Location";
            // 
            // txtPickupPostal
            // 
            txtPickupPostal.Font = new Font("Segoe UI", 10F);
            txtPickupPostal.Location = new Point(130, 137);
            txtPickupPostal.Name = "txtPickupPostal";
            txtPickupPostal.Size = new Size(100, 30);
            txtPickupPostal.TabIndex = 7;
            // 
            // lblPickupPostal
            // 
            lblPickupPostal.AutoSize = true;
            lblPickupPostal.Font = new Font("Segoe UI", 10F);
            lblPickupPostal.Location = new Point(20, 140);
            lblPickupPostal.Name = "lblPickupPostal";
            lblPickupPostal.Size = new Size(104, 23);
            lblPickupPostal.TabIndex = 6;
            lblPickupPostal.Text = "Postal Code:";
            // 
            // txtPickupCity
            // 
            txtPickupCity.Font = new Font("Segoe UI", 10F);
            txtPickupCity.Location = new Point(110, 102);
            txtPickupCity.Name = "txtPickupCity";
            txtPickupCity.Size = new Size(120, 30);
            txtPickupCity.TabIndex = 5;
            // 
            // lblPickupCity
            // 
            lblPickupCity.AutoSize = true;
            lblPickupCity.Font = new Font("Segoe UI", 10F);
            lblPickupCity.Location = new Point(20, 105);
            lblPickupCity.Name = "lblPickupCity";
            lblPickupCity.Size = new Size(55, 23);
            lblPickupCity.TabIndex = 4;
            lblPickupCity.Text = "City *:";
            // 
            // txtPickupAddress
            // 
            txtPickupAddress.Font = new Font("Segoe UI", 10F);
            txtPickupAddress.Location = new Point(110, 67);
            txtPickupAddress.Name = "txtPickupAddress";
            txtPickupAddress.Size = new Size(180, 30);
            txtPickupAddress.TabIndex = 3;
            // 
            // lblPickupAddress
            // 
            lblPickupAddress.AutoSize = true;
            lblPickupAddress.Font = new Font("Segoe UI", 10F);
            lblPickupAddress.Location = new Point(20, 70);
            lblPickupAddress.Name = "lblPickupAddress";
            lblPickupAddress.Size = new Size(86, 23);
            lblPickupAddress.TabIndex = 2;
            lblPickupAddress.Text = "Address *:";
            // 
            // txtPickupLocation
            // 
            txtPickupLocation.Font = new Font("Segoe UI", 10F);
            txtPickupLocation.Location = new Point(110, 32);
            txtPickupLocation.Name = "txtPickupLocation";
            txtPickupLocation.Size = new Size(180, 30);
            txtPickupLocation.TabIndex = 1;
            // 
            // lblPickupLocation
            // 
            lblPickupLocation.AutoSize = true;
            lblPickupLocation.Font = new Font("Segoe UI", 10F);
            lblPickupLocation.Location = new Point(20, 35);
            lblPickupLocation.Name = "lblPickupLocation";
            lblPickupLocation.Size = new Size(91, 23);
            lblPickupLocation.TabIndex = 0;
            lblPickupLocation.Text = "Location *:";
            // 
            // groupBoxDelivery
            // 
            groupBoxDelivery.Controls.Add(txtDeliveryPostal);
            groupBoxDelivery.Controls.Add(lblDeliveryPostal);
            groupBoxDelivery.Controls.Add(txtDeliveryCity);
            groupBoxDelivery.Controls.Add(lblDeliveryCity);
            groupBoxDelivery.Controls.Add(txtDeliveryAddress);
            groupBoxDelivery.Controls.Add(lblDeliveryAddress);
            groupBoxDelivery.Controls.Add(txtDeliveryLocation);
            groupBoxDelivery.Controls.Add(lblDeliveryLocation);
            groupBoxDelivery.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBoxDelivery.Location = new Point(370, 80);
            groupBoxDelivery.Name = "groupBoxDelivery";
            groupBoxDelivery.Size = new Size(320, 180);
            groupBoxDelivery.TabIndex = 2;
            groupBoxDelivery.TabStop = false;
            groupBoxDelivery.Text = "🎯 Delivery Location";
            // 
            // txtDeliveryPostal
            // 
            txtDeliveryPostal.Font = new Font("Segoe UI", 10F);
            txtDeliveryPostal.Location = new Point(130, 137);
            txtDeliveryPostal.Name = "txtDeliveryPostal";
            txtDeliveryPostal.Size = new Size(100, 30);
            txtDeliveryPostal.TabIndex = 7;
            // 
            // lblDeliveryPostal
            // 
            lblDeliveryPostal.AutoSize = true;
            lblDeliveryPostal.Font = new Font("Segoe UI", 10F);
            lblDeliveryPostal.Location = new Point(20, 140);
            lblDeliveryPostal.Name = "lblDeliveryPostal";
            lblDeliveryPostal.Size = new Size(104, 23);
            lblDeliveryPostal.TabIndex = 6;
            lblDeliveryPostal.Text = "Postal Code:";
            // 
            // txtDeliveryCity
            // 
            txtDeliveryCity.Font = new Font("Segoe UI", 10F);
            txtDeliveryCity.Location = new Point(110, 102);
            txtDeliveryCity.Name = "txtDeliveryCity";
            txtDeliveryCity.Size = new Size(120, 30);
            txtDeliveryCity.TabIndex = 5;
            // 
            // lblDeliveryCity
            // 
            lblDeliveryCity.AutoSize = true;
            lblDeliveryCity.Font = new Font("Segoe UI", 10F);
            lblDeliveryCity.Location = new Point(20, 105);
            lblDeliveryCity.Name = "lblDeliveryCity";
            lblDeliveryCity.Size = new Size(55, 23);
            lblDeliveryCity.TabIndex = 4;
            lblDeliveryCity.Text = "City *:";
            // 
            // txtDeliveryAddress
            // 
            txtDeliveryAddress.Font = new Font("Segoe UI", 10F);
            txtDeliveryAddress.Location = new Point(110, 67);
            txtDeliveryAddress.Name = "txtDeliveryAddress";
            txtDeliveryAddress.Size = new Size(180, 30);
            txtDeliveryAddress.TabIndex = 3;
            // 
            // lblDeliveryAddress
            // 
            lblDeliveryAddress.AutoSize = true;
            lblDeliveryAddress.Font = new Font("Segoe UI", 10F);
            lblDeliveryAddress.Location = new Point(20, 70);
            lblDeliveryAddress.Name = "lblDeliveryAddress";
            lblDeliveryAddress.Size = new Size(86, 23);
            lblDeliveryAddress.TabIndex = 2;
            lblDeliveryAddress.Text = "Address *:";
            // 
            // txtDeliveryLocation
            // 
            txtDeliveryLocation.Font = new Font("Segoe UI", 10F);
            txtDeliveryLocation.Location = new Point(110, 32);
            txtDeliveryLocation.Name = "txtDeliveryLocation";
            txtDeliveryLocation.Size = new Size(180, 30);
            txtDeliveryLocation.TabIndex = 1;
            // 
            // lblDeliveryLocation
            // 
            lblDeliveryLocation.AutoSize = true;
            lblDeliveryLocation.Font = new Font("Segoe UI", 10F);
            lblDeliveryLocation.Location = new Point(20, 35);
            lblDeliveryLocation.Name = "lblDeliveryLocation";
            lblDeliveryLocation.Size = new Size(91, 23);
            lblDeliveryLocation.TabIndex = 0;
            lblDeliveryLocation.Text = "Location *:";
            // 
            // groupBoxJobDetails
            // 
            groupBoxJobDetails.Controls.Add(txtSpecialInstructions);
            groupBoxJobDetails.Controls.Add(lblSpecialInstructions);
            groupBoxJobDetails.Controls.Add(comboBoxPriority);
            groupBoxJobDetails.Controls.Add(lblPriority);
            groupBoxJobDetails.Controls.Add(dateTimePickerScheduled);
            groupBoxJobDetails.Controls.Add(lblScheduledDate);
            groupBoxJobDetails.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBoxJobDetails.Location = new Point(30, 280);
            groupBoxJobDetails.Name = "groupBoxJobDetails";
            groupBoxJobDetails.Size = new Size(660, 150);
            groupBoxJobDetails.TabIndex = 3;
            groupBoxJobDetails.TabStop = false;
            groupBoxJobDetails.Text = "📋 Job Details";
            // 
            // txtSpecialInstructions
            // 
            txtSpecialInstructions.Font = new Font("Segoe UI", 10F);
            txtSpecialInstructions.Location = new Point(20, 110);
            txtSpecialInstructions.Multiline = true;
            txtSpecialInstructions.Name = "txtSpecialInstructions";
            txtSpecialInstructions.Size = new Size(620, 25);
            txtSpecialInstructions.TabIndex = 5;
            // 
            // lblSpecialInstructions
            // 
            lblSpecialInstructions.AutoSize = true;
            lblSpecialInstructions.Font = new Font("Segoe UI", 10F);
            lblSpecialInstructions.Location = new Point(20, 80);
            lblSpecialInstructions.Name = "lblSpecialInstructions";
            lblSpecialInstructions.Size = new Size(161, 23);
            lblSpecialInstructions.TabIndex = 4;
            lblSpecialInstructions.Text = "Special Instructions:";
            // 
            // comboBoxPriority
            // 
            comboBoxPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPriority.Font = new Font("Segoe UI", 10F);
            comboBoxPriority.FormattingEnabled = true;
            comboBoxPriority.Items.AddRange(new object[] { "Low", "Medium", "High", "Urgent" });
            comboBoxPriority.Location = new Point(430, 32);
            comboBoxPriority.Name = "comboBoxPriority";
            comboBoxPriority.Size = new Size(120, 31);
            comboBoxPriority.TabIndex = 3;
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Font = new Font("Segoe UI", 10F);
            lblPriority.Location = new Point(350, 35);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(68, 23);
            lblPriority.TabIndex = 2;
            lblPriority.Text = "Priority:";
            // 
            // dateTimePickerScheduled
            // 
            dateTimePickerScheduled.Font = new Font("Segoe UI", 10F);
            dateTimePickerScheduled.Format = DateTimePickerFormat.Short;
            dateTimePickerScheduled.Location = new Point(160, 32);
            dateTimePickerScheduled.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dateTimePickerScheduled.Name = "dateTimePickerScheduled";
            dateTimePickerScheduled.Size = new Size(150, 30);
            dateTimePickerScheduled.TabIndex = 1;
            dateTimePickerScheduled.Value = new DateTime(2025, 7, 19, 0, 0, 0, 0);
            // 
            // lblScheduledDate
            // 
            lblScheduledDate.AutoSize = true;
            lblScheduledDate.Font = new Font("Segoe UI", 10F);
            lblScheduledDate.Location = new Point(20, 35);
            lblScheduledDate.Name = "lblScheduledDate";
            lblScheduledDate.Size = new Size(137, 23);
            lblScheduledDate.TabIndex = 0;
            lblScheduledDate.Text = "Preferred Date *:";
            // 
            // btnSubmitRequest
            // 
            btnSubmitRequest.BackColor = Color.LightGreen;
            btnSubmitRequest.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSubmitRequest.Location = new Point(230, 640);
            btnSubmitRequest.Name = "btnSubmitRequest";
            btnSubmitRequest.Size = new Size(150, 40);
            btnSubmitRequest.TabIndex = 4;
            btnSubmitRequest.Text = "Submit Request";
            btnSubmitRequest.UseVisualStyleBackColor = false;
            btnSubmitRequest.Click += btnSubmitRequest_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightCoral;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancel.Location = new Point(390, 640);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 40);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10F);
            lblStatus.Location = new Point(30, 520);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 23);
            lblStatus.TabIndex = 6;
            // 
            // groupBoxProductSelection
            // 
            groupBoxProductSelection.Controls.Add(lblSelectProducts);
            groupBoxProductSelection.Controls.Add(dgvProductSelection);
            groupBoxProductSelection.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxProductSelection.Location = new Point(30, 350);
            groupBoxProductSelection.Name = "groupBoxProductSelection";
            groupBoxProductSelection.Size = new Size(660, 200);
            groupBoxProductSelection.TabIndex = 7;
            groupBoxProductSelection.TabStop = false;
            groupBoxProductSelection.Text = "📦 Select Items to Move";
            // 
            // lblSelectProducts
            // 
            lblSelectProducts.AutoSize = true;
            lblSelectProducts.Font = new Font("Segoe UI", 9F);
            lblSelectProducts.Location = new Point(20, 25);
            lblSelectProducts.Name = "lblSelectProducts";
            lblSelectProducts.Size = new Size(362, 20);
            lblSelectProducts.TabIndex = 0;
            lblSelectProducts.Text = "Check items you want to move and specify quantities:";
            // 
            // dgvProductSelection
            // 
            dgvProductSelection.AllowUserToAddRows = false;
            dgvProductSelection.AllowUserToDeleteRows = false;
            dgvProductSelection.AllowUserToResizeRows = false;
            dgvProductSelection.BackgroundColor = Color.White;
            dgvProductSelection.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductSelection.Location = new Point(20, 50);
            dgvProductSelection.Name = "dgvProductSelection";
            dgvProductSelection.RowHeadersVisible = false;
            dgvProductSelection.RowHeadersWidth = 51;
            dgvProductSelection.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductSelection.Size = new Size(620, 140);
            dgvProductSelection.TabIndex = 1;
            dgvProductSelection.CellValueChanged += dgvProductSelection_CellValueChanged;
            // 
            // groupBoxCalculatedTotals
            // 
            groupBoxCalculatedTotals.Controls.Add(lblTotalWeight);
            groupBoxCalculatedTotals.Controls.Add(lblWeightValue);
            groupBoxCalculatedTotals.Controls.Add(lblTotalVolume);
            groupBoxCalculatedTotals.Controls.Add(lblVolumeValue);
            groupBoxCalculatedTotals.Controls.Add(lblEstimatedCost);
            groupBoxCalculatedTotals.Controls.Add(lblCostValue);
            groupBoxCalculatedTotals.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxCalculatedTotals.Location = new Point(30, 560);
            groupBoxCalculatedTotals.Name = "groupBoxCalculatedTotals";
            groupBoxCalculatedTotals.Size = new Size(660, 60);
            groupBoxCalculatedTotals.TabIndex = 8;
            groupBoxCalculatedTotals.TabStop = false;
            groupBoxCalculatedTotals.Text = "💰 Calculated Totals";
            // 
            // lblTotalWeight
            // 
            lblTotalWeight.AutoSize = true;
            lblTotalWeight.Font = new Font("Segoe UI", 10F);
            lblTotalWeight.Location = new Point(20, 30);
            lblTotalWeight.Name = "lblTotalWeight";
            lblTotalWeight.Size = new Size(109, 23);
            lblTotalWeight.TabIndex = 0;
            lblTotalWeight.Text = "Total Weight:";
            // 
            // lblWeightValue
            // 
            lblWeightValue.AutoSize = true;
            lblWeightValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblWeightValue.ForeColor = Color.DarkBlue;
            lblWeightValue.Location = new Point(130, 30);
            lblWeightValue.Name = "lblWeightValue";
            lblWeightValue.Size = new Size(46, 23);
            lblWeightValue.TabIndex = 1;
            lblWeightValue.Text = "0 kg";
            // 
            // lblTotalVolume
            // 
            lblTotalVolume.AutoSize = true;
            lblTotalVolume.Font = new Font("Segoe UI", 10F);
            lblTotalVolume.Location = new Point(200, 30);
            lblTotalVolume.Name = "lblTotalVolume";
            lblTotalVolume.Size = new Size(113, 23);
            lblTotalVolume.TabIndex = 2;
            lblTotalVolume.Text = "Total Volume:";
            // 
            // lblVolumeValue
            // 
            lblVolumeValue.AutoSize = true;
            lblVolumeValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblVolumeValue.ForeColor = Color.DarkBlue;
            lblVolumeValue.Location = new Point(310, 30);
            lblVolumeValue.Name = "lblVolumeValue";
            lblVolumeValue.Size = new Size(48, 23);
            lblVolumeValue.TabIndex = 3;
            lblVolumeValue.Text = "0 m³";
            // 
            // lblEstimatedCost
            // 
            lblEstimatedCost.AutoSize = true;
            lblEstimatedCost.Font = new Font("Segoe UI", 10F);
            lblEstimatedCost.Location = new Point(400, 30);
            lblEstimatedCost.Name = "lblEstimatedCost";
            lblEstimatedCost.Size = new Size(128, 23);
            lblEstimatedCost.TabIndex = 4;
            lblEstimatedCost.Text = "Estimated Cost:";
            // 
            // lblCostValue
            // 
            lblCostValue.AutoSize = true;
            lblCostValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCostValue.ForeColor = Color.DarkGreen;
            lblCostValue.Location = new Point(530, 27);
            lblCostValue.Name = "lblCostValue";
            lblCostValue.Size = new Size(65, 28);
            lblCostValue.TabIndex = 5;
            lblCostValue.Text = "$0.00";
            // 
            // NewJobRequestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(720, 700);
            Controls.Add(groupBoxProductSelection);
            Controls.Add(groupBoxCalculatedTotals);
            Controls.Add(lblStatus);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmitRequest);
            Controls.Add(groupBoxJobDetails);
            Controls.Add(groupBoxDelivery);
            Controls.Add(groupBoxPickup);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "NewJobRequestForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "e-Shift - New Job Request";
            Load += NewJobRequestForm_Load;
            groupBoxPickup.ResumeLayout(false);
            groupBoxPickup.PerformLayout();
            groupBoxDelivery.ResumeLayout(false);
            groupBoxDelivery.PerformLayout();
            groupBoxJobDetails.ResumeLayout(false);
            groupBoxJobDetails.PerformLayout();
            groupBoxProductSelection.ResumeLayout(false);
            groupBoxProductSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductSelection).EndInit();
            groupBoxCalculatedTotals.ResumeLayout(false);
            groupBoxCalculatedTotals.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBoxPickup;
        private System.Windows.Forms.Label lblPickupLocation;
        private System.Windows.Forms.TextBox txtPickupLocation;
        private System.Windows.Forms.Label lblPickupAddress;
        private System.Windows.Forms.TextBox txtPickupAddress;
        private System.Windows.Forms.Label lblPickupCity;
        private System.Windows.Forms.TextBox txtPickupCity;
        private System.Windows.Forms.Label lblPickupPostal;
        private System.Windows.Forms.TextBox txtPickupPostal;
        private System.Windows.Forms.GroupBox groupBoxDelivery;
        private System.Windows.Forms.Label lblDeliveryLocation;
        private System.Windows.Forms.TextBox txtDeliveryLocation;
        private System.Windows.Forms.Label lblDeliveryAddress;
        private System.Windows.Forms.TextBox txtDeliveryAddress;
        private System.Windows.Forms.Label lblDeliveryCity;
        private System.Windows.Forms.TextBox txtDeliveryCity;
        private System.Windows.Forms.Label lblDeliveryPostal;
        private System.Windows.Forms.TextBox txtDeliveryPostal;
        private System.Windows.Forms.GroupBox groupBoxJobDetails;
        private System.Windows.Forms.Label lblScheduledDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerScheduled;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.Label lblSpecialInstructions;
        private System.Windows.Forms.TextBox txtSpecialInstructions;
        private System.Windows.Forms.Button btnSubmitRequest;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblStatus;

        private System.Windows.Forms.GroupBox groupBoxProductSelection;
        private System.Windows.Forms.Label lblSelectProducts;
        private System.Windows.Forms.DataGridView dgvProductSelection;
        private System.Windows.Forms.GroupBox groupBoxCalculatedTotals;
        private System.Windows.Forms.Label lblTotalWeight;
        private System.Windows.Forms.Label lblTotalVolume;
        private System.Windows.Forms.Label lblEstimatedCost;
        private System.Windows.Forms.Label lblWeightValue;
        private System.Windows.Forms.Label lblVolumeValue;
        private System.Windows.Forms.Label lblCostValue;
    }
}