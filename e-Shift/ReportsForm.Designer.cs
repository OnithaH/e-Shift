namespace e_Shift
{
    partial class ReportsForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBoxReportTypes = new System.Windows.Forms.GroupBox();
            this.rbRevenue = new System.Windows.Forms.RadioButton();
            this.rbJobStatistics = new System.Windows.Forms.RadioButton();
            this.rbTransportUtilization = new System.Windows.Forms.RadioButton();
            this.rbCustomerReport = new System.Windows.Forms.RadioButton();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnExportPDF = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvReportData = new System.Windows.Forms.DataGridView();
            this.groupBoxReportData = new System.Windows.Forms.GroupBox();
            this.lblReportSummary = new System.Windows.Forms.Label();
            this.txtReportSummary = new System.Windows.Forms.TextBox();
            this.lblStatusBar = new System.Windows.Forms.Label();
            this.groupBoxReportTypes.SuspendLayout();
            this.groupBoxFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportData)).BeginInit();
            this.groupBoxReportData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(300, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Reports Center";
            // 
            // groupBoxReportTypes
            // 
            this.groupBoxReportTypes.Controls.Add(this.rbRevenue);
            this.groupBoxReportTypes.Controls.Add(this.rbJobStatistics);
            this.groupBoxReportTypes.Controls.Add(this.rbTransportUtilization);
            this.groupBoxReportTypes.Controls.Add(this.rbCustomerReport);
            this.groupBoxReportTypes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxReportTypes.Location = new System.Drawing.Point(30, 80);
            this.groupBoxReportTypes.Name = "groupBoxReportTypes";
            this.groupBoxReportTypes.Size = new System.Drawing.Size(250, 180);
            this.groupBoxReportTypes.TabIndex = 1;
            this.groupBoxReportTypes.TabStop = false;
            this.groupBoxReportTypes.Text = "Report Types";
            // 
            // rbRevenue
            // 
            this.rbRevenue.AutoSize = true;
            this.rbRevenue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbRevenue.Location = new System.Drawing.Point(20, 140);
            this.rbRevenue.Name = "rbRevenue";
            this.rbRevenue.Size = new System.Drawing.Size(144, 27);
            this.rbRevenue.TabIndex = 3;
            this.rbRevenue.Text = "Revenue Report";
            this.rbRevenue.UseVisualStyleBackColor = true;
            this.rbRevenue.CheckedChanged += new System.EventHandler(this.rbRevenue_CheckedChanged);
            // 
            // rbJobStatistics
            // 
            this.rbJobStatistics.AutoSize = true;
            this.rbJobStatistics.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbJobStatistics.Location = new System.Drawing.Point(20, 105);
            this.rbJobStatistics.Name = "rbJobStatistics";
            this.rbJobStatistics.Size = new System.Drawing.Size(134, 27);
            this.rbJobStatistics.TabIndex = 2;
            this.rbJobStatistics.Text = "Job Statistics";
            this.rbJobStatistics.UseVisualStyleBackColor = true;
            this.rbJobStatistics.CheckedChanged += new System.EventHandler(this.rbJobStatistics_CheckedChanged);
            // 
            // rbTransportUtilization
            // 
            this.rbTransportUtilization.AutoSize = true;
            this.rbTransportUtilization.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbTransportUtilization.Location = new System.Drawing.Point(20, 70);
            this.rbTransportUtilization.Name = "rbTransportUtilization";
            this.rbTransportUtilization.Size = new System.Drawing.Size(184, 27);
            this.rbTransportUtilization.TabIndex = 1;
            this.rbTransportUtilization.Text = "Transport Utilization";
            this.rbTransportUtilization.UseVisualStyleBackColor = true;
            this.rbTransportUtilization.CheckedChanged += new System.EventHandler(this.rbTransportUtilization_CheckedChanged);
            // 
            // rbCustomerReport
            // 
            this.rbCustomerReport.AutoSize = true;
            this.rbCustomerReport.Checked = true;
            this.rbCustomerReport.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbCustomerReport.Location = new System.Drawing.Point(20, 35);
            this.rbCustomerReport.Name = "rbCustomerReport";
            this.rbCustomerReport.Size = new System.Drawing.Size(156, 27);
            this.rbCustomerReport.TabIndex = 0;
            this.rbCustomerReport.TabStop = true;
            this.rbCustomerReport.Text = "Customer Report";
            this.rbCustomerReport.UseVisualStyleBackColor = true;
            this.rbCustomerReport.CheckedChanged += new System.EventHandler(this.rbCustomerReport_CheckedChanged);
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Controls.Add(this.lblDateFrom);
            this.groupBoxFilters.Controls.Add(this.dtpDateFrom);
            this.groupBoxFilters.Controls.Add(this.lblDateTo);
            this.groupBoxFilters.Controls.Add(this.dtpDateTo);
            this.groupBoxFilters.Controls.Add(this.lblStatus);
            this.groupBoxFilters.Controls.Add(this.cmbStatus);
            this.groupBoxFilters.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxFilters.Location = new System.Drawing.Point(300, 80);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(300, 180);
            this.groupBoxFilters.TabIndex = 2;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Report Filters";
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDateFrom.Location = new System.Drawing.Point(20, 35);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(91, 23);
            this.lblDateFrom.TabIndex = 0;
            this.lblDateFrom.Text = "Date From:";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDateFrom.Location = new System.Drawing.Point(120, 35);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(160, 27);
            this.dtpDateFrom.TabIndex = 1;
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDateTo.Location = new System.Drawing.Point(20, 75);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(71, 23);
            this.lblDateTo.TabIndex = 2;
            this.lblDateTo.Text = "Date To:";
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDateTo.Location = new System.Drawing.Point(120, 75);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(160, 27);
            this.dtpDateTo.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatus.Location = new System.Drawing.Point(20, 115);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(61, 23);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "All",
            "Pending",
            "Approved",
            "InProgress",
            "Completed",
            "Declined"});
            this.cmbStatus.Location = new System.Drawing.Point(120, 115);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(160, 28);
            this.cmbStatus.TabIndex = 5;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.LightBlue;
            this.btnGenerateReport.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnGenerateReport.Location = new System.Drawing.Point(620, 100);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(140, 40);
            this.btnGenerateReport.TabIndex = 3;
            this.btnGenerateReport.Text = "📊 Generate";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.BackColor = System.Drawing.Color.LightCoral;
            this.btnExportPDF.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExportPDF.Location = new System.Drawing.Point(620, 150);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Size = new System.Drawing.Size(140, 35);
            this.btnExportPDF.TabIndex = 4;
            this.btnExportPDF.Text = "📄 Export PDF";
            this.btnExportPDF.UseVisualStyleBackColor = false;
            this.btnExportPDF.Click += new System.EventHandler(this.btnExportPDF_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.LightGreen;
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExportExcel.Location = new System.Drawing.Point(620, 195);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(140, 35);
            this.btnExportExcel.TabIndex = 5;
            this.btnExportExcel.Text = "📊 Export Excel";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightGray;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.Location = new System.Drawing.Point(680, 620);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvReportData
            // 
            this.dgvReportData.AllowUserToAddRows = false;
            this.dgvReportData.AllowUserToDeleteRows = false;
            this.dgvReportData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReportData.BackgroundColor = System.Drawing.Color.White;
            this.dgvReportData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportData.Location = new System.Drawing.Point(20, 30);
            this.dgvReportData.Name = "dgvReportData";
            this.dgvReportData.ReadOnly = true;
            this.dgvReportData.RowHeadersWidth = 51;
            this.dgvReportData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReportData.Size = new System.Drawing.Size(700, 200);
            this.dgvReportData.TabIndex = 0;
            // 
            // groupBoxReportData
            // 
            this.groupBoxReportData.Controls.Add(this.dgvReportData);
            this.groupBoxReportData.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxReportData.Location = new System.Drawing.Point(30, 280);
            this.groupBoxReportData.Name = "groupBoxReportData";
            this.groupBoxReportData.Size = new System.Drawing.Size(740, 250);
            this.groupBoxReportData.TabIndex = 7;
            this.groupBoxReportData.TabStop = false;
            this.groupBoxReportData.Text = "Report Data";
            // 
            // lblReportSummary
            // 
            this.lblReportSummary.AutoSize = true;
            this.lblReportSummary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblReportSummary.Location = new System.Drawing.Point(30, 550);
            this.lblReportSummary.Name = "lblReportSummary";
            this.lblReportSummary.Size = new System.Drawing.Size(142, 23);
            this.lblReportSummary.TabIndex = 8;
            this.lblReportSummary.Text = "Report Summary:";
            // 
            // txtReportSummary
            // 
            this.txtReportSummary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtReportSummary.Location = new System.Drawing.Point(30, 580);
            this.txtReportSummary.Multiline = true;
            this.txtReportSummary.Name = "txtReportSummary";
            this.txtReportSummary.ReadOnly = true;
            this.txtReportSummary.Size = new System.Drawing.Size(620, 60);
            this.txtReportSummary.TabIndex = 9;
            // 
            // lblStatusBar
            // 
            this.lblStatusBar.AutoSize = true;
            this.lblStatusBar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatusBar.Location = new System.Drawing.Point(30, 660);
            this.lblStatusBar.Name = "lblStatusBar";
            this.lblStatusBar.Size = new System.Drawing.Size(56, 23);
            this.lblStatusBar.TabIndex = 10;
            this.lblStatusBar.Text = "Ready";
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.lblStatusBar);
            this.Controls.Add(this.txtReportSummary);
            this.Controls.Add(this.lblReportSummary);
            this.Controls.Add(this.groupBoxReportData);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnExportPDF);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.groupBoxFilters);
            this.Controls.Add(this.groupBoxReportTypes);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "e-Shift - Reports Center";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.groupBoxReportTypes.ResumeLayout(false);
            this.groupBoxReportTypes.PerformLayout();
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportData)).EndInit();
            this.groupBoxReportData.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBoxReportTypes;
        private System.Windows.Forms.RadioButton rbRevenue;
        private System.Windows.Forms.RadioButton rbJobStatistics;
        private System.Windows.Forms.RadioButton rbTransportUtilization;
        private System.Windows.Forms.RadioButton rbCustomerReport;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnExportPDF;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvReportData;
        private System.Windows.Forms.GroupBox groupBoxReportData;
        private System.Windows.Forms.Label lblReportSummary;
        private System.Windows.Forms.TextBox txtReportSummary;
        private System.Windows.Forms.Label lblStatusBar;
    }
}