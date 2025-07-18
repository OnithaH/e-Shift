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
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBoxPickup = new System.Windows.Forms.GroupBox();
            this.lblPickupLocation = new System.Windows.Forms.Label();
            this.txtPickupLocation = new System.Windows.Forms.TextBox();
            this.lblPickupAddress = new System.Windows.Forms.Label();
            this.txtPickupAddress = new System.Windows.Forms.TextBox();
            this.lblPickupCity = new System.Windows.Forms.Label();
            this.txtPickupCity = new System.Windows.Forms.TextBox();
            this.lblPickupPostal = new System.Windows.Forms.Label();
            this.txtPickupPostal = new System.Windows.Forms.TextBox();
            this.groupBoxDelivery = new System.Windows.Forms.GroupBox();
            this.lblDeliveryLocation = new System.Windows.Forms.Label();
            this.txtDeliveryLocation = new System.Windows.Forms.TextBox();
            this.lblDeliveryAddress = new System.Windows.Forms.Label();
            this.txtDeliveryAddress = new System.Windows.Forms.TextBox();
            this.lblDeliveryCity = new System.Windows.Forms.Label();
            this.txtDeliveryCity = new System.Windows.Forms.TextBox();
            this.lblDeliveryPostal = new System.Windows.Forms.Label();
            this.txtDeliveryPostal = new System.Windows.Forms.TextBox();
            this.groupBoxJobDetails = new System.Windows.Forms.GroupBox();
            this.lblScheduledDate = new System.Windows.Forms.Label();
            this.dateTimePickerScheduled = new System.Windows.Forms.DateTimePicker();
            this.lblPriority = new System.Windows.Forms.Label();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.lblSpecialInstructions = new System.Windows.Forms.Label();
            this.txtSpecialInstructions = new System.Windows.Forms.TextBox();
            this.btnSubmitRequest = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBoxPickup.SuspendLayout();
            this.groupBoxDelivery.SuspendLayout();
            this.groupBoxJobDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(200, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(284, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "New Transport Request";
            // 
            // groupBoxPickup
            // 
            this.groupBoxPickup.Controls.Add(this.txtPickupPostal);
            this.groupBoxPickup.Controls.Add(this.lblPickupPostal);
            this.groupBoxPickup.Controls.Add(this.txtPickupCity);
            this.groupBoxPickup.Controls.Add(this.lblPickupCity);
            this.groupBoxPickup.Controls.Add(this.txtPickupAddress);
            this.groupBoxPickup.Controls.Add(this.lblPickupAddress);
            this.groupBoxPickup.Controls.Add(this.txtPickupLocation);
            this.groupBoxPickup.Controls.Add(this.lblPickupLocation);
            this.groupBoxPickup.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxPickup.Location = new System.Drawing.Point(30, 80);
            this.groupBoxPickup.Name = "groupBoxPickup";
            this.groupBoxPickup.Size = new System.Drawing.Size(320, 180);
            this.groupBoxPickup.TabIndex = 1;
            this.groupBoxPickup.TabStop = false;
            this.groupBoxPickup.Text = "📍 Pickup Location";
            // 
            // lblPickupLocation
            // 
            this.lblPickupLocation.AutoSize = true;
            this.lblPickupLocation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPickupLocation.Location = new System.Drawing.Point(20, 35);
            this.lblPickupLocation.Name = "lblPickupLocation";
            this.lblPickupLocation.Size = new System.Drawing.Size(82, 23);
            this.lblPickupLocation.TabIndex = 0;
            this.lblPickupLocation.Text = "Location *:";
            // 
            // txtPickupLocation
            // 
            this.txtPickupLocation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPickupLocation.Location = new System.Drawing.Point(110, 32);
            this.txtPickupLocation.Name = "txtPickupLocation";
            this.txtPickupLocation.Size = new System.Drawing.Size(180, 30);
            this.txtPickupLocation.TabIndex = 1;
            // 
            // lblPickupAddress
            // 
            this.lblPickupAddress.AutoSize = true;
            this.lblPickupAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPickupAddress.Location = new System.Drawing.Point(20, 70);
            this.lblPickupAddress.Name = "lblPickupAddress";
            this.lblPickupAddress.Size = new System.Drawing.Size(79, 23);
            this.lblPickupAddress.TabIndex = 2;
            this.lblPickupAddress.Text = "Address *:";
            // 
            // txtPickupAddress
            // 
            this.txtPickupAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPickupAddress.Location = new System.Drawing.Point(110, 67);
            this.txtPickupAddress.Name = "txtPickupAddress";
            this.txtPickupAddress.Size = new System.Drawing.Size(180, 30);
            this.txtPickupAddress.TabIndex = 3;
            // 
            // lblPickupCity
            // 
            this.lblPickupCity.AutoSize = true;
            this.lblPickupCity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPickupCity.Location = new System.Drawing.Point(20, 105);
            this.lblPickupCity.Name = "lblPickupCity";
            this.lblPickupCity.Size = new System.Drawing.Size(50, 23);
            this.lblPickupCity.TabIndex = 4;
            this.lblPickupCity.Text = "City *:";
            // 
            // txtPickupCity
            // 
            this.txtPickupCity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPickupCity.Location = new System.Drawing.Point(110, 102);
            this.txtPickupCity.Name = "txtPickupCity";
            this.txtPickupCity.Size = new System.Drawing.Size(120, 30);
            this.txtPickupCity.TabIndex = 5;
            // 
            // lblPickupPostal
            // 
            this.lblPickupPostal.AutoSize = true;
            this.lblPickupPostal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPickupPostal.Location = new System.Drawing.Point(20, 140);
            this.lblPickupPostal.Name = "lblPickupPostal";
            this.lblPickupPostal.Size = new System.Drawing.Size(97, 23);
            this.lblPickupPostal.TabIndex = 6;
            this.lblPickupPostal.Text = "Postal Code:";
            // 
            // txtPickupPostal
            // 
            this.txtPickupPostal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPickupPostal.Location = new System.Drawing.Point(130, 137);
            this.txtPickupPostal.Name = "txtPickupPostal";
            this.txtPickupPostal.Size = new System.Drawing.Size(100, 30);
            this.txtPickupPostal.TabIndex = 7;
            // 
            // groupBoxDelivery
            // 
            this.groupBoxDelivery.Controls.Add(this.txtDeliveryPostal);
            this.groupBoxDelivery.Controls.Add(this.lblDeliveryPostal);
            this.groupBoxDelivery.Controls.Add(this.txtDeliveryCity);
            this.groupBoxDelivery.Controls.Add(this.lblDeliveryCity);
            this.groupBoxDelivery.Controls.Add(this.txtDeliveryAddress);
            this.groupBoxDelivery.Controls.Add(this.lblDeliveryAddress);
            this.groupBoxDelivery.Controls.Add(this.txtDeliveryLocation);
            this.groupBoxDelivery.Controls.Add(this.lblDeliveryLocation);
            this.groupBoxDelivery.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxDelivery.Location = new System.Drawing.Point(370, 80);
            this.groupBoxDelivery.Name = "groupBoxDelivery";
            this.groupBoxDelivery.Size = new System.Drawing.Size(320, 180);
            this.groupBoxDelivery.TabIndex = 2;
            this.groupBoxDelivery.TabStop = false;
            this.groupBoxDelivery.Text = "🎯 Delivery Location";
            // 
            // lblDeliveryLocation
            // 
            this.lblDeliveryLocation.AutoSize = true;
            this.lblDeliveryLocation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDeliveryLocation.Location = new System.Drawing.Point(20, 35);
            this.lblDeliveryLocation.Name = "lblDeliveryLocation";
            this.lblDeliveryLocation.Size = new System.Drawing.Size(82, 23);
            this.lblDeliveryLocation.TabIndex = 0;
            this.lblDeliveryLocation.Text = "Location *:";
            // 
            // txtDeliveryLocation
            // 
            this.txtDeliveryLocation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDeliveryLocation.Location = new System.Drawing.Point(110, 32);
            this.txtDeliveryLocation.Name = "txtDeliveryLocation";
            this.txtDeliveryLocation.Size = new System.Drawing.Size(180, 30);
            this.txtDeliveryLocation.TabIndex = 1;
            // 
            // lblDeliveryAddress
            // 
            this.lblDeliveryAddress.AutoSize = true;
            this.lblDeliveryAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDeliveryAddress.Location = new System.Drawing.Point(20, 70);
            this.lblDeliveryAddress.Name = "lblDeliveryAddress";
            this.lblDeliveryAddress.Size = new System.Drawing.Size(79, 23);
            this.lblDeliveryAddress.TabIndex = 2;
            this.lblDeliveryAddress.Text = "Address *:";
            // 
            // txtDeliveryAddress
            // 
            this.txtDeliveryAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDeliveryAddress.Location = new System.Drawing.Point(110, 67);
            this.txtDeliveryAddress.Name = "txtDeliveryAddress";
            this.txtDeliveryAddress.Size = new System.Drawing.Size(180, 30);
            this.txtDeliveryAddress.TabIndex = 3;
            // 
            // lblDeliveryCity
            // 
            this.lblDeliveryCity.AutoSize = true;
            this.lblDeliveryCity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDeliveryCity.Location = new System.Drawing.Point(20, 105);
            this.lblDeliveryCity.Name = "lblDeliveryCity";
            this.lblDeliveryCity.Size = new System.Drawing.Size(50, 23);
            this.lblDeliveryCity.TabIndex = 4;
            this.lblDeliveryCity.Text = "City *:";
            // 
            // txtDeliveryCity
            // 
            this.txtDeliveryCity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDeliveryCity.Location = new System.Drawing.Point(110, 102);
            this.txtDeliveryCity.Name = "txtDeliveryCity";
            this.txtDeliveryCity.Size = new System.Drawing.Size(120, 30);
            this.txtDeliveryCity.TabIndex = 5;
            // 
            // lblDeliveryPostal
            // 
            this.lblDeliveryPostal.AutoSize = true;
            this.lblDeliveryPostal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDeliveryPostal.Location = new System.Drawing.Point(20, 140);
            this.lblDeliveryPostal.Name = "lblDeliveryPostal";
            this.lblDeliveryPostal.Size = new System.Drawing.Size(97, 23);
            this.lblDeliveryPostal.TabIndex = 6;
            this.lblDeliveryPostal.Text = "Postal Code:";
            // 
            // txtDeliveryPostal
            // 
            this.txtDeliveryPostal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDeliveryPostal.Location = new System.Drawing.Point(130, 137);
            this.txtDeliveryPostal.Name = "txtDeliveryPostal";
            this.txtDeliveryPostal.Size = new System.Drawing.Size(100, 30);
            this.txtDeliveryPostal.TabIndex = 7;
            // 
            // groupBoxJobDetails
            // 
            this.groupBoxJobDetails.Controls.Add(this.txtSpecialInstructions);
            this.groupBoxJobDetails.Controls.Add(this.lblSpecialInstructions);
            this.groupBoxJobDetails.Controls.Add(this.comboBoxPriority);
            this.groupBoxJobDetails.Controls.Add(this.lblPriority);
            this.groupBoxJobDetails.Controls.Add(this.dateTimePickerScheduled);
            this.groupBoxJobDetails.Controls.Add(this.lblScheduledDate);
            this.groupBoxJobDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxJobDetails.Location = new System.Drawing.Point(30, 280);
            this.groupBoxJobDetails.Name = "groupBoxJobDetails";
            this.groupBoxJobDetails.Size = new System.Drawing.Size(660, 150);
            this.groupBoxJobDetails.TabIndex = 3;
            this.groupBoxJobDetails.TabStop = false;
            this.groupBoxJobDetails.Text = "📋 Job Details";
            // 
            // lblScheduledDate
            // 
            this.lblScheduledDate.AutoSize = true;
            this.lblScheduledDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblScheduledDate.Location = new System.Drawing.Point(20, 35);
            this.lblScheduledDate.Name = "lblScheduledDate";
            this.lblScheduledDate.Size = new System.Drawing.Size(131, 23);
            this.lblScheduledDate.TabIndex = 0;
            this.lblScheduledDate.Text = "Preferred Date *:";
            // 
            // dateTimePickerScheduled
            // 
            this.dateTimePickerScheduled.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateTimePickerScheduled.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerScheduled.Location = new System.Drawing.Point(160, 32);
            this.dateTimePickerScheduled.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerScheduled.Name = "dateTimePickerScheduled";
            this.dateTimePickerScheduled.Size = new System.Drawing.Size(150, 30);
            this.dateTimePickerScheduled.TabIndex = 1;
            this.dateTimePickerScheduled.Value = new System.DateTime(2025, 7, 19, 0, 0, 0, 0);
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPriority.Location = new System.Drawing.Point(350, 35);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(69, 23);
            this.lblPriority.TabIndex = 2;
            this.lblPriority.Text = "Priority:";
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPriority.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High",
            "Urgent"});
            this.comboBoxPriority.Location = new System.Drawing.Point(430, 32);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(120, 31);
            this.comboBoxPriority.TabIndex = 3;
            // 
            // lblSpecialInstructions
            // 
            this.lblSpecialInstructions.AutoSize = true;
            this.lblSpecialInstructions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSpecialInstructions.Location = new System.Drawing.Point(20, 80);
            this.lblSpecialInstructions.Name = "lblSpecialInstructions";
            this.lblSpecialInstructions.Size = new System.Drawing.Size(148, 23);
            this.lblSpecialInstructions.TabIndex = 4;
            this.lblSpecialInstructions.Text = "Special Instructions:";
            // 
            // txtSpecialInstructions
            // 
            this.txtSpecialInstructions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSpecialInstructions.Location = new System.Drawing.Point(20, 110);
            this.txtSpecialInstructions.Multiline = true;
            this.txtSpecialInstructions.Name = "txtSpecialInstructions";
            this.txtSpecialInstructions.Size = new System.Drawing.Size(620, 25);
            this.txtSpecialInstructions.TabIndex = 5;
            // 
            // btnSubmitRequest
            // 
            this.btnSubmitRequest.BackColor = System.Drawing.Color.LightGreen;
            this.btnSubmitRequest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmitRequest.Location = new System.Drawing.Point(250, 460);
            this.btnSubmitRequest.Name = "btnSubmitRequest";
            this.btnSubmitRequest.Size = new System.Drawing.Size(150, 40);
            this.btnSubmitRequest.TabIndex = 4;
            this.btnSubmitRequest.Text = "Submit Request";
            this.btnSubmitRequest.UseVisualStyleBackColor = false;
            this.btnSubmitRequest.Click += new System.EventHandler(this.btnSubmitRequest_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(420, 460);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatus.Location = new System.Drawing.Point(30, 520);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 23);
            this.lblStatus.TabIndex = 6;
            // 
            // NewJobRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(720, 560);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmitRequest);
            this.Controls.Add(this.groupBoxJobDetails);
            this.Controls.Add(this.groupBoxDelivery);
            this.Controls.Add(this.groupBoxPickup);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "NewJobRequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "e-Shift - New Job Request";
            this.Load += new System.EventHandler(this.NewJobRequestForm_Load);
            this.groupBoxPickup.ResumeLayout(false);
            this.groupBoxPickup.PerformLayout();
            this.groupBoxDelivery.ResumeLayout(false);
            this.groupBoxDelivery.PerformLayout();
            this.groupBoxJobDetails.ResumeLayout(false);
            this.groupBoxJobDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
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
    }
}