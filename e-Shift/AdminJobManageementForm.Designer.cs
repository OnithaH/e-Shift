﻿namespace e_Shift
{
    partial class AdminJobManagementForm
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
            btnRefresh = new Button();
            comboBoxFilterStatus = new ComboBox();
            lblFilterStatus = new Label();
            groupBoxJobs = new GroupBox();
            dataGridViewJobs = new DataGridView();
            groupBoxJobDetails = new GroupBox();
            txtJobDetails = new TextBox();
            lblSpecialInstr = new Label();
            lblCurrentStatus = new Label();
            lblRequestDate = new Label();
            lblFromTo = new Label();
            lblCustomerName = new Label();
            lblJobNumber = new Label();
            groupBoxActions = new GroupBox();
            comboBoxNewStatus = new ComboBox();
            lblNewStatus = new Label();
            btnUpdateStatus = new Button();
            txtDeclineReason = new TextBox();
            lblDeclineReason = new Label();
            txtEstimatedCost = new TextBox();
            lblEstimatedCost = new Label();
            btnApprove = new Button();
            btnDecline = new Button();
            lblTransportUnit = new Label();
            cmbTransportUnit = new ComboBox();
            lblCapacityInfo = new Label();
            lblStatus = new Label();
            btnClose = new Button();
            groupBoxLoadInfo = new GroupBox();
            lblLoadDetails = new Label();
            txtLoadDetails = new TextBox();
            lblLoadWeight = new Label();
            lblWeightValue = new Label();
            lblLoadVolume = new Label();
            lblVolumeValue = new Label();
            lblLoadCost = new Label();
            lblCostValue = new Label();
            groupBoxFilters.SuspendLayout();
            groupBoxJobs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewJobs).BeginInit();
            groupBoxJobDetails.SuspendLayout();
            groupBoxActions.SuspendLayout();
            groupBoxLoadInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(300, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(241, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Job Management";
            // 
            // groupBoxFilters
            // 
            groupBoxFilters.Controls.Add(btnShowAll);
            groupBoxFilters.Controls.Add(btnRefresh);
            groupBoxFilters.Controls.Add(comboBoxFilterStatus);
            groupBoxFilters.Controls.Add(lblFilterStatus);
            groupBoxFilters.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxFilters.Location = new Point(30, 70);
            groupBoxFilters.Name = "groupBoxFilters";
            groupBoxFilters.Size = new Size(907, 60);
            groupBoxFilters.TabIndex = 1;
            groupBoxFilters.TabStop = false;
            groupBoxFilters.Text = "Filters";
            // 
            // btnShowAll
            // 
            btnShowAll.BackColor = Color.LightGray;
            btnShowAll.Font = new Font("Segoe UI", 10F);
            btnShowAll.Location = new Point(821, 18);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(80, 35);
            btnShowAll.TabIndex = 3;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = false;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LightBlue;
            btnRefresh.Font = new Font("Segoe UI", 10F);
            btnRefresh.Location = new Point(699, 18);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(114, 35);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "🔄 Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // comboBoxFilterStatus
            // 
            comboBoxFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilterStatus.Font = new Font("Segoe UI", 10F);
            comboBoxFilterStatus.FormattingEnabled = true;
            comboBoxFilterStatus.Items.AddRange(new object[] { "All", "Pending", "Approved", "InProgress", "Completed", "Declined" });
            comboBoxFilterStatus.Location = new Point(90, 22);
            comboBoxFilterStatus.Name = "comboBoxFilterStatus";
            comboBoxFilterStatus.Size = new Size(297, 31);
            comboBoxFilterStatus.TabIndex = 1;
            comboBoxFilterStatus.SelectedIndexChanged += comboBoxFilterStatus_SelectedIndexChanged;
            // 
            // lblFilterStatus
            // 
            lblFilterStatus.AutoSize = true;
            lblFilterStatus.Font = new Font("Segoe UI", 10F);
            lblFilterStatus.Location = new Point(20, 25);
            lblFilterStatus.Name = "lblFilterStatus";
            lblFilterStatus.Size = new Size(60, 23);
            lblFilterStatus.TabIndex = 0;
            lblFilterStatus.Text = "Status:";
            // 
            // groupBoxJobs
            // 
            groupBoxJobs.Controls.Add(dataGridViewJobs);
            groupBoxJobs.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxJobs.Location = new Point(30, 140);
            groupBoxJobs.Name = "groupBoxJobs";
            groupBoxJobs.Size = new Size(907, 250);
            groupBoxJobs.TabIndex = 2;
            groupBoxJobs.TabStop = false;
            groupBoxJobs.Text = "Job Requests";
            // 
            // dataGridViewJobs
            // 
            dataGridViewJobs.AllowUserToAddRows = false;
            dataGridViewJobs.AllowUserToDeleteRows = false;
            dataGridViewJobs.BackgroundColor = Color.White;
            dataGridViewJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewJobs.Location = new Point(20, 30);
            dataGridViewJobs.MultiSelect = false;
            dataGridViewJobs.Name = "dataGridViewJobs";
            dataGridViewJobs.ReadOnly = true;
            dataGridViewJobs.RowHeadersWidth = 51;
            dataGridViewJobs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewJobs.Size = new Size(867, 200);
            dataGridViewJobs.TabIndex = 0;
            dataGridViewJobs.CellContentClick += dataGridViewJobs_CellContentClick;
            dataGridViewJobs.SelectionChanged += dataGridViewJobs_SelectionChanged;
            // 
            // groupBoxJobDetails
            // 
            groupBoxJobDetails.Controls.Add(txtJobDetails);
            groupBoxJobDetails.Controls.Add(lblSpecialInstr);
            groupBoxJobDetails.Controls.Add(lblCurrentStatus);
            groupBoxJobDetails.Controls.Add(lblRequestDate);
            groupBoxJobDetails.Controls.Add(lblFromTo);
            groupBoxJobDetails.Controls.Add(lblCustomerName);
            groupBoxJobDetails.Controls.Add(lblJobNumber);
            groupBoxJobDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxJobDetails.Location = new Point(30, 400);
            groupBoxJobDetails.Name = "groupBoxJobDetails";
            groupBoxJobDetails.Size = new Size(467, 200);
            groupBoxJobDetails.TabIndex = 3;
            groupBoxJobDetails.TabStop = false;
            groupBoxJobDetails.Text = "Job Details";
            // 
            // txtJobDetails
            // 
            txtJobDetails.Font = new Font("Segoe UI", 9F);
            txtJobDetails.Location = new Point(120, 150);
            txtJobDetails.Multiline = true;
            txtJobDetails.Name = "txtJobDetails";
            txtJobDetails.ReadOnly = true;
            txtJobDetails.Size = new Size(260, 40);
            txtJobDetails.TabIndex = 6;
            // 
            // lblSpecialInstr
            // 
            lblSpecialInstr.AutoSize = true;
            lblSpecialInstr.Font = new Font("Segoe UI", 10F);
            lblSpecialInstr.Location = new Point(20, 150);
            lblSpecialInstr.Name = "lblSpecialInstr";
            lblSpecialInstr.Size = new Size(103, 23);
            lblSpecialInstr.TabIndex = 5;
            lblSpecialInstr.Text = "Instructions:";
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.Font = new Font("Segoe UI", 10F);
            lblCurrentStatus.Location = new Point(20, 125);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(60, 23);
            lblCurrentStatus.TabIndex = 4;
            lblCurrentStatus.Text = "Status:";
            // 
            // lblRequestDate
            // 
            lblRequestDate.AutoSize = true;
            lblRequestDate.Font = new Font("Segoe UI", 10F);
            lblRequestDate.Location = new Point(20, 100);
            lblRequestDate.Name = "lblRequestDate";
            lblRequestDate.Size = new Size(116, 23);
            lblRequestDate.TabIndex = 3;
            lblRequestDate.Text = "Request Date:";
            // 
            // lblFromTo
            // 
            lblFromTo.AutoSize = true;
            lblFromTo.Font = new Font("Segoe UI", 10F);
            lblFromTo.Location = new Point(20, 75);
            lblFromTo.Name = "lblFromTo";
            lblFromTo.Size = new Size(77, 23);
            lblFromTo.TabIndex = 2;
            lblFromTo.Text = "From/To:";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI", 10F);
            lblCustomerName.Location = new Point(20, 50);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(88, 23);
            lblCustomerName.TabIndex = 1;
            lblCustomerName.Text = "Customer:";
            // 
            // lblJobNumber
            // 
            lblJobNumber.AutoSize = true;
            lblJobNumber.Font = new Font("Segoe UI", 10F);
            lblJobNumber.Location = new Point(20, 25);
            lblJobNumber.Name = "lblJobNumber";
            lblJobNumber.Size = new Size(108, 23);
            lblJobNumber.TabIndex = 0;
            lblJobNumber.Text = "Job Number:";
            // 
            // groupBoxActions
            // 
            groupBoxActions.Controls.Add(comboBoxNewStatus);
            groupBoxActions.Controls.Add(lblNewStatus);
            groupBoxActions.Controls.Add(btnUpdateStatus);
            groupBoxActions.Controls.Add(txtDeclineReason);
            groupBoxActions.Controls.Add(lblDeclineReason);
            groupBoxActions.Controls.Add(txtEstimatedCost);
            groupBoxActions.Controls.Add(lblEstimatedCost);
            groupBoxActions.Controls.Add(btnApprove);
            groupBoxActions.Controls.Add(btnDecline);
            groupBoxActions.Controls.Add(lblTransportUnit);
            groupBoxActions.Controls.Add(cmbTransportUnit);
            groupBoxActions.Controls.Add(lblCapacityInfo);
            groupBoxActions.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxActions.Location = new Point(503, 400);
            groupBoxActions.Name = "groupBoxActions";
            groupBoxActions.Size = new Size(434, 312);
            groupBoxActions.TabIndex = 4;
            groupBoxActions.TabStop = false;
            groupBoxActions.Text = "Actions";
            groupBoxActions.Enter += groupBoxActions_Enter;
            // 
            // comboBoxNewStatus
            // 
            comboBoxNewStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNewStatus.Font = new Font("Segoe UI", 9F);
            comboBoxNewStatus.FormattingEnabled = true;
            comboBoxNewStatus.Items.AddRange(new object[] { "Approved", "InProgress", "Completed" });
            comboBoxNewStatus.Location = new Point(74, 170);
            comboBoxNewStatus.Name = "comboBoxNewStatus";
            comboBoxNewStatus.Size = new Size(120, 28);
            comboBoxNewStatus.TabIndex = 8;
            comboBoxNewStatus.SelectedIndexChanged += comboBoxNewStatus_SelectedIndexChanged;
            // 
            // lblNewStatus
            // 
            lblNewStatus.AutoSize = true;
            lblNewStatus.Font = new Font("Segoe UI", 9F);
            lblNewStatus.Location = new Point(16, 177);
            lblNewStatus.Name = "lblNewStatus";
            lblNewStatus.Size = new Size(52, 20);
            lblNewStatus.TabIndex = 7;
            lblNewStatus.Text = "Status:";
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.BackColor = Color.LightBlue;
            btnUpdateStatus.Font = new Font("Segoe UI", 9F);
            btnUpdateStatus.Location = new Point(226, 170);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(159, 35);
            btnUpdateStatus.TabIndex = 6;
            btnUpdateStatus.Text = "Update";
            btnUpdateStatus.UseVisualStyleBackColor = false;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // txtDeclineReason
            // 
            txtDeclineReason.Font = new Font("Segoe UI", 9F);
            txtDeclineReason.Location = new Point(148, 82);
            txtDeclineReason.Name = "txtDeclineReason";
            txtDeclineReason.Size = new Size(280, 27);
            txtDeclineReason.TabIndex = 5;
            // 
            // lblDeclineReason
            // 
            lblDeclineReason.AutoSize = true;
            lblDeclineReason.Font = new Font("Segoe UI", 10F);
            lblDeclineReason.Location = new Point(14, 86);
            lblDeclineReason.Name = "lblDeclineReason";
            lblDeclineReason.Size = new Size(130, 23);
            lblDeclineReason.TabIndex = 4;
            lblDeclineReason.Text = "Decline Reason:";
            // 
            // txtEstimatedCost
            // 
            txtEstimatedCost.Font = new Font("Segoe UI", 10F);
            txtEstimatedCost.Location = new Point(150, 33);
            txtEstimatedCost.Name = "txtEstimatedCost";
            txtEstimatedCost.Size = new Size(137, 30);
            txtEstimatedCost.TabIndex = 3;
            // 
            // lblEstimatedCost
            // 
            lblEstimatedCost.AutoSize = true;
            lblEstimatedCost.Font = new Font("Segoe UI", 10F);
            lblEstimatedCost.Location = new Point(16, 36);
            lblEstimatedCost.Name = "lblEstimatedCost";
            lblEstimatedCost.Size = new Size(128, 23);
            lblEstimatedCost.TabIndex = 2;
            lblEstimatedCost.Text = "Estimated Cost:";
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.LightGreen;
            btnApprove.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnApprove.Location = new Point(41, 218);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(153, 35);
            btnApprove.TabIndex = 0;
            btnApprove.Text = "✅ Approve";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnDecline
            // 
            btnDecline.BackColor = Color.LightCoral;
            btnDecline.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDecline.Location = new Point(226, 218);
            btnDecline.Name = "btnDecline";
            btnDecline.Size = new Size(170, 35);
            btnDecline.TabIndex = 1;
            btnDecline.Text = "❌ Decline";
            btnDecline.UseVisualStyleBackColor = false;
            btnDecline.Click += btnDecline_Click;
            // 
            // lblTransportUnit
            // 
            lblTransportUnit.AutoSize = true;
            lblTransportUnit.Font = new Font("Segoe UI", 9F);
            lblTransportUnit.Location = new Point(14, 127);
            lblTransportUnit.Name = "lblTransportUnit";
            lblTransportUnit.Size = new Size(152, 20);
            lblTransportUnit.TabIndex = 9;
            lblTransportUnit.Text = "Assign Transport Unit:";
            lblTransportUnit.Click += lblTransportUnit_Click;
            // 
            // cmbTransportUnit
            // 
            cmbTransportUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTransportUnit.Font = new Font("Segoe UI", 9F);
            cmbTransportUnit.Location = new Point(178, 119);
            cmbTransportUnit.Name = "cmbTransportUnit";
            cmbTransportUnit.Size = new Size(250, 28);
            cmbTransportUnit.TabIndex = 10;
            cmbTransportUnit.SelectedIndexChanged += cmbTransportUnit_SelectedIndexChanged;
            // 
            // lblCapacityInfo
            // 
            lblCapacityInfo.AutoSize = true;
            lblCapacityInfo.Font = new Font("Segoe UI", 8F);
            lblCapacityInfo.Location = new Point(130, 145);
            lblCapacityInfo.Name = "lblCapacityInfo";
            lblCapacityInfo.Size = new Size(0, 19);
            lblCapacityInfo.TabIndex = 11;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10F);
            lblStatus.Location = new Point(30, 784);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(56, 23);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Ready";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.LightGray;
            btnClose.Font = new Font("Segoe UI", 10F);
            btnClose.Location = new Point(802, 743);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(115, 53);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // groupBoxLoadInfo
            // 
            groupBoxLoadInfo.Controls.Add(lblLoadDetails);
            groupBoxLoadInfo.Controls.Add(txtLoadDetails);
            groupBoxLoadInfo.Controls.Add(lblLoadWeight);
            groupBoxLoadInfo.Controls.Add(lblWeightValue);
            groupBoxLoadInfo.Controls.Add(lblLoadVolume);
            groupBoxLoadInfo.Controls.Add(lblVolumeValue);
            groupBoxLoadInfo.Controls.Add(lblLoadCost);
            groupBoxLoadInfo.Controls.Add(lblCostValue);
            groupBoxLoadInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxLoadInfo.Location = new Point(30, 612);
            groupBoxLoadInfo.Name = "groupBoxLoadInfo";
            groupBoxLoadInfo.Size = new Size(467, 100);
            groupBoxLoadInfo.TabIndex = 8;
            groupBoxLoadInfo.TabStop = false;
            groupBoxLoadInfo.Text = "📦 Load Information";
            // 
            // lblLoadDetails
            // 
            lblLoadDetails.AutoSize = true;
            lblLoadDetails.Font = new Font("Segoe UI", 9F);
            lblLoadDetails.Location = new Point(20, 25);
            lblLoadDetails.Name = "lblLoadDetails";
            lblLoadDetails.Size = new Size(48, 20);
            lblLoadDetails.TabIndex = 0;
            lblLoadDetails.Text = "Items:";
            // 
            // txtLoadDetails
            // 
            txtLoadDetails.BackColor = Color.LightGray;
            txtLoadDetails.Font = new Font("Segoe UI", 9F);
            txtLoadDetails.Location = new Point(70, 22);
            txtLoadDetails.Multiline = true;
            txtLoadDetails.Name = "txtLoadDetails";
            txtLoadDetails.ReadOnly = true;
            txtLoadDetails.Size = new Size(371, 25);
            txtLoadDetails.TabIndex = 1;
            // 
            // lblLoadWeight
            // 
            lblLoadWeight.AutoSize = true;
            lblLoadWeight.Font = new Font("Segoe UI", 9F);
            lblLoadWeight.Location = new Point(20, 60);
            lblLoadWeight.Name = "lblLoadWeight";
            lblLoadWeight.Size = new Size(59, 20);
            lblLoadWeight.TabIndex = 2;
            lblLoadWeight.Text = "Weight:";
            // 
            // lblWeightValue
            // 
            lblWeightValue.AutoSize = true;
            lblWeightValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblWeightValue.ForeColor = Color.DarkBlue;
            lblWeightValue.Location = new Point(80, 60);
            lblWeightValue.Name = "lblWeightValue";
            lblWeightValue.Size = new Size(18, 20);
            lblWeightValue.TabIndex = 3;
            lblWeightValue.Text = "0";
            // 
            // lblLoadVolume
            // 
            lblLoadVolume.AutoSize = true;
            lblLoadVolume.Font = new Font("Segoe UI", 9F);
            lblLoadVolume.Location = new Point(184, 60);
            lblLoadVolume.Name = "lblLoadVolume";
            lblLoadVolume.Size = new Size(62, 20);
            lblLoadVolume.TabIndex = 4;
            lblLoadVolume.Text = "Volume:";
            // 
            // lblVolumeValue
            // 
            lblVolumeValue.AutoSize = true;
            lblVolumeValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblVolumeValue.ForeColor = Color.DarkBlue;
            lblVolumeValue.Location = new Point(252, 60);
            lblVolumeValue.Name = "lblVolumeValue";
            lblVolumeValue.Size = new Size(18, 20);
            lblVolumeValue.TabIndex = 5;
            lblVolumeValue.Text = "0";
            // 
            // lblLoadCost
            // 
            lblLoadCost.AutoSize = true;
            lblLoadCost.Font = new Font("Segoe UI", 9F);
            lblLoadCost.Location = new Point(369, 60);
            lblLoadCost.Name = "lblLoadCost";
            lblLoadCost.Size = new Size(41, 20);
            lblLoadCost.TabIndex = 6;
            lblLoadCost.Text = "Cost:";
            // 
            // lblCostValue
            // 
            lblCostValue.AutoSize = true;
            lblCostValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCostValue.ForeColor = Color.DarkGreen;
            lblCostValue.Location = new Point(414, 60);
            lblCostValue.Name = "lblCostValue";
            lblCostValue.Size = new Size(27, 20);
            lblCostValue.TabIndex = 7;
            lblCostValue.Text = "$0";
            // 
            // AdminJobManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(949, 828);
            Controls.Add(groupBoxLoadInfo);
            Controls.Add(btnClose);
            Controls.Add(lblStatus);
            Controls.Add(groupBoxActions);
            Controls.Add(groupBoxJobDetails);
            Controls.Add(groupBoxJobs);
            Controls.Add(groupBoxFilters);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AdminJobManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-Shift - Admin Job Management";
            Load += AdminJobManagementForm_Load;
            groupBoxFilters.ResumeLayout(false);
            groupBoxFilters.PerformLayout();
            groupBoxJobs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewJobs).EndInit();
            groupBoxJobDetails.ResumeLayout(false);
            groupBoxJobDetails.PerformLayout();
            groupBoxActions.ResumeLayout(false);
            groupBoxActions.PerformLayout();
            groupBoxLoadInfo.ResumeLayout(false);
            groupBoxLoadInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.ComboBox comboBoxFilterStatus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.GroupBox groupBoxJobs;
        private System.Windows.Forms.DataGridView dataGridViewJobs;
        private System.Windows.Forms.GroupBox groupBoxJobDetails;
        private System.Windows.Forms.Label lblJobNumber;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblFromTo;
        private System.Windows.Forms.Label lblRequestDate;
        private System.Windows.Forms.Label lblCurrentStatus;
        private System.Windows.Forms.Label lblSpecialInstr;
        private System.Windows.Forms.TextBox txtJobDetails;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.Label lblEstimatedCost;
        private System.Windows.Forms.TextBox txtEstimatedCost;
        private System.Windows.Forms.Label lblDeclineReason;
        private System.Windows.Forms.TextBox txtDeclineReason;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Label lblNewStatus;
        private System.Windows.Forms.ComboBox comboBoxNewStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnClose;

        private System.Windows.Forms.GroupBox groupBoxLoadInfo;
        private System.Windows.Forms.Label lblLoadDetails;
        private System.Windows.Forms.TextBox txtLoadDetails;
        private System.Windows.Forms.Label lblLoadWeight;
        private System.Windows.Forms.Label lblLoadVolume;
        private System.Windows.Forms.Label lblLoadCost;
        private System.Windows.Forms.Label lblWeightValue;
        private System.Windows.Forms.Label lblVolumeValue;
        private System.Windows.Forms.Label lblCostValue;

        private Label lblTransportUnit;
        private ComboBox cmbTransportUnit;
        private Label lblCapacityInfo;
    }
}