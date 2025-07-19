using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using e_Shift.Database;
using e_Shift.Utils;

namespace e_Shift
{
    public partial class ReportsForm : Form
    {
        private string currentReportType = "Customer";
        private DataTable currentReportData;

        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            // Check admin access
            if (!UserSession.IsLoggedIn || !UserSession.IsAdmin())
            {
                MessageBox.Show("Access denied! Admin privileges required.",
                              "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // Initialize form
            InitializeForm();
            ShowMessage("Reports Center loaded. Select a report type and click Generate.", false);
        }

        private void InitializeForm()
        {
            // Set default date range (last 30 days)
            dtpDateTo.Value = DateTime.Now;
            dtpDateFrom.Value = DateTime.Now.AddDays(-30);

            // Set default status
            cmbStatus.SelectedIndex = 0; // "All"

            // Set default report type
            rbCustomerReport.Checked = true;
            currentReportType = "Customer";

            // Initialize export buttons (disabled until report is generated)
            btnExportPDF.Enabled = false;
            btnExportExcel.Enabled = false;
        }

        #region Report Type Selection Events

        private void rbCustomerReport_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCustomerReport.Checked)
            {
                currentReportType = "Customer";
                ShowMessage("Customer Report selected - Shows customer details and activity", false);
            }
        }

        private void rbTransportUtilization_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTransportUtilization.Checked)
            {
                currentReportType = "Transport";
                ShowMessage("Transport Utilization Report selected - Shows vehicle and driver usage", false);
            }
        }

        private void rbJobStatistics_CheckedChanged(object sender, EventArgs e)
        {
            if (rbJobStatistics.Checked)
            {
                currentReportType = "JobStats";
                ShowMessage("Job Statistics Report selected - Shows job performance metrics", false);
            }
        }

        private void rbRevenue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRevenue.Checked)
            {
                currentReportType = "Revenue";
                ShowMessage("Revenue Report selected - Shows financial performance", false);
            }
        }

        #endregion

        #region Report Generation

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                ShowMessage("Generating report...", false);
                btnGenerateReport.Enabled = false;
                this.Cursor = Cursors.WaitCursor;

                // Generate report based on selected type
                switch (currentReportType)
                {
                    case "Customer":
                        GenerateCustomerReport();
                        break;
                    case "Transport":
                        GenerateTransportUtilizationReport();
                        break;
                    case "JobStats":
                        GenerateJobStatisticsReport();
                        break;
                    case "Revenue":
                        GenerateRevenueReport();
                        break;
                    default:
                        ShowMessage("Please select a report type", true);
                        return;
                }

                // Enable export buttons if data is available
                if (currentReportData != null && currentReportData.Rows.Count > 0)
                {
                    btnExportPDF.Enabled = true;
                    btnExportExcel.Enabled = true;
                    ShowMessage($"Report generated successfully! {currentReportData.Rows.Count} records found.", false);
                }
                else
                {
                    ShowMessage("No data found for the selected criteria.", true);
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error generating report: {ex.Message}", true);
            }
            finally
            {
                btnGenerateReport.Enabled = true;
                this.Cursor = Cursors.Default;
            }
        }

        private void GenerateCustomerReport()
        {
            string query = @"
                SELECT 
                    c.CustomerNumber,
                    c.FirstName + ' ' + c.LastName AS FullName,
                    c.Email,
                    c.Phone,
                    c.City,
                    c.RegistrationDate,
                    CASE WHEN c.IsActive = 1 THEN 'Active' ELSE 'Inactive' END AS Status,
                    COUNT(j.JobID) AS TotalJobs,
                    SUM(CASE WHEN j.Status = 'Completed' THEN 1 ELSE 0 END) AS CompletedJobs,
                    ISNULL(SUM(CASE WHEN j.Status = 'Completed' THEN j.ActualCost ELSE 0 END), 0) AS TotalSpent
                FROM Customers c
                LEFT JOIN Jobs j ON c.CustomerID = j.CustomerID 
                    AND j.IsDeleted = 0 
                    AND j.RequestDate BETWEEN @DateFrom AND @DateTo
                WHERE c.IsDeleted = 0
                GROUP BY c.CustomerID, c.CustomerNumber, c.FirstName, c.LastName, 
                         c.Email, c.Phone, c.City, c.RegistrationDate, c.IsActive
                ORDER BY c.CustomerNumber";

            SqlParameter[] parameters = {
                new SqlParameter("@DateFrom", dtpDateFrom.Value.Date),
                new SqlParameter("@DateTo", dtpDateTo.Value.Date.AddDays(1).AddSeconds(-1))
            };

            currentReportData = DatabaseConnection.FillDataTable(query, parameters);
            dgvReportData.DataSource = currentReportData;

            // Generate summary
            if (currentReportData.Rows.Count > 0)
            {
                int totalCustomers = currentReportData.Rows.Count;
                int activeCustomers = 0;
                decimal totalRevenue = 0;
                int totalJobs = 0;

                foreach (DataRow row in currentReportData.Rows)
                {
                    if (row["Status"].ToString() == "Active") activeCustomers++;
                    totalRevenue += Convert.ToDecimal(row["TotalSpent"]);
                    totalJobs += Convert.ToInt32(row["TotalJobs"]);
                }

                txtReportSummary.Text = $"Total Customers: {totalCustomers} | Active: {activeCustomers} | " +
                                       $"Total Jobs: {totalJobs} | Total Revenue: ${totalRevenue:F2}";
            }
        }

        private void GenerateTransportUtilizationReport()
        {
            string query = @"
                SELECT 
                    tu.UnitNumber,
                    l.RegistrationNumber AS LorryReg,
                    l.Make + ' ' + l.Model AS LorryDetails,
                    d.FirstName + ' ' + d.LastName AS DriverName,
                    a.FirstName + ' ' + a.LastName AS AssistantName,
                    c.ContainerNumber,
                    CASE WHEN tu.IsAvailable = 1 THEN 'Available' ELSE 'In Use' END AS Status,
                    COUNT(ld.LoadID) AS TotalLoads,
                    SUM(CASE WHEN ld.Status = 'Completed' THEN 1 ELSE 0 END) AS CompletedLoads,
                    ISNULL(AVG(ld.LoadCost), 0) AS AvgLoadCost
                FROM TransportUnits tu
                INNER JOIN Lorries l ON tu.LorryID = l.LorryID
                INNER JOIN Drivers d ON tu.DriverID = d.DriverID
                INNER JOIN Assistants a ON tu.AssistantID = a.AssistantID
                INNER JOIN Containers c ON tu.ContainerID = c.ContainerID
                LEFT JOIN Loads ld ON tu.TransportUnitID = ld.TransportUnitID 
                    AND ld.IsDeleted = 0
                    AND ld.CreatedDate BETWEEN @DateFrom AND @DateTo
                WHERE tu.IsDeleted = 0
                GROUP BY tu.TransportUnitID, tu.UnitNumber, l.RegistrationNumber, 
                         l.Make, l.Model, d.FirstName, d.LastName, 
                         a.FirstName, a.LastName, c.ContainerNumber, tu.IsAvailable
                ORDER BY tu.UnitNumber";

            SqlParameter[] parameters = {
                new SqlParameter("@DateFrom", dtpDateFrom.Value.Date),
                new SqlParameter("@DateTo", dtpDateTo.Value.Date.AddDays(1).AddSeconds(-1))
            };

            currentReportData = DatabaseConnection.FillDataTable(query, parameters);
            dgvReportData.DataSource = currentReportData;

            // Generate summary
            if (currentReportData.Rows.Count > 0)
            {
                int totalUnits = currentReportData.Rows.Count;
                int availableUnits = 0;
                int totalLoads = 0;
                decimal avgCost = 0;

                foreach (DataRow row in currentReportData.Rows)
                {
                    if (row["Status"].ToString() == "Available") availableUnits++;
                    totalLoads += Convert.ToInt32(row["TotalLoads"]);
                    avgCost += Convert.ToDecimal(row["AvgLoadCost"]);
                }

                avgCost = totalUnits > 0 ? avgCost / totalUnits : 0;

                txtReportSummary.Text = $"Total Transport Units: {totalUnits} | Available: {availableUnits} | " +
                                       $"Total Loads Handled: {totalLoads} | Avg Load Cost: ${avgCost:F2}";
            }
        }

        private void GenerateJobStatisticsReport()
        {
            string statusFilter = cmbStatus.Text == "All" ? "" : $"AND j.Status = '{cmbStatus.Text}'";

            string query = $@"
                SELECT 
                    j.JobNumber,
                    c.CustomerNumber,
                    c.FirstName + ' ' + c.LastName AS CustomerName,
                    j.StartLocation + ' -> ' + j.Destination AS Route,
                    j.Status,
                    j.Priority,
                    j.RequestDate,
                    j.ScheduledDate,
                    j.CompletionDate,
                    j.EstimatedCost,
                    j.ActualCost,
                    CASE 
                        WHEN j.Status = 'Completed' AND j.CompletionDate <= j.ScheduledDate THEN 'On Time'
                        WHEN j.Status = 'Completed' AND j.CompletionDate > j.ScheduledDate THEN 'Late'
                        WHEN j.Status != 'Completed' AND GETDATE() > j.ScheduledDate THEN 'Overdue'
                        ELSE 'On Schedule'
                    END AS Performance,
                    COUNT(ld.LoadID) AS TotalLoads
                FROM Jobs j
                INNER JOIN Customers c ON j.CustomerID = c.CustomerID
                LEFT JOIN Loads ld ON j.JobID = ld.JobID AND ld.IsDeleted = 0
                WHERE j.IsDeleted = 0 
                    AND j.RequestDate BETWEEN @DateFrom AND @DateTo
                    {statusFilter}
                GROUP BY j.JobID, j.JobNumber, c.CustomerNumber, c.FirstName, c.LastName,
                         j.StartLocation, j.Destination, j.Status, j.Priority,
                         j.RequestDate, j.ScheduledDate, j.CompletionDate,
                         j.EstimatedCost, j.ActualCost
                ORDER BY j.RequestDate DESC";

            SqlParameter[] parameters = {
                new SqlParameter("@DateFrom", dtpDateFrom.Value.Date),
                new SqlParameter("@DateTo", dtpDateTo.Value.Date.AddDays(1).AddSeconds(-1))
            };

            currentReportData = DatabaseConnection.FillDataTable(query, parameters);
            dgvReportData.DataSource = currentReportData;

            // Generate summary
            if (currentReportData.Rows.Count > 0)
            {
                int totalJobs = currentReportData.Rows.Count;
                int completedJobs = 0;
                int onTimeJobs = 0;
                int overdueJobs = 0;
                decimal totalRevenue = 0;

                foreach (DataRow row in currentReportData.Rows)
                {
                    string status = row["Status"].ToString();
                    string performance = row["Performance"].ToString();

                    if (status == "Completed")
                    {
                        completedJobs++;
                        totalRevenue += Convert.ToDecimal(row["ActualCost"]);
                    }

                    if (performance == "On Time") onTimeJobs++;
                    if (performance == "Overdue") overdueJobs++;
                }

                double completionRate = totalJobs > 0 ? (double)completedJobs / totalJobs * 100 : 0;
                double onTimeRate = completedJobs > 0 ? (double)onTimeJobs / completedJobs * 100 : 0;

                txtReportSummary.Text = $"Total Jobs: {totalJobs} | Completed: {completedJobs} ({completionRate:F1}%) | " +
                                       $"On Time: {onTimeJobs} ({onTimeRate:F1}%) | Revenue: ${totalRevenue:F2}";
            }
        }

        private void GenerateRevenueReport()
        {
            string query = @"
                SELECT 
                    YEAR(j.CompletionDate) AS Year,
                    MONTH(j.CompletionDate) AS Month,
                    DATENAME(MONTH, j.CompletionDate) AS MonthName,
                    COUNT(j.JobID) AS CompletedJobs,
                    SUM(j.ActualCost) AS MonthlyRevenue,
                    AVG(j.ActualCost) AS AvgJobValue,
                    MIN(j.ActualCost) AS MinJobValue,
                    MAX(j.ActualCost) AS MaxJobValue
                FROM Jobs j
                WHERE j.Status = 'Completed' 
                    AND j.CompletionDate BETWEEN @DateFrom AND @DateTo
                    AND j.IsDeleted = 0
                GROUP BY YEAR(j.CompletionDate), MONTH(j.CompletionDate), DATENAME(MONTH, j.CompletionDate)
                
                UNION ALL
                
                SELECT 
                    9999 AS Year,
                    13 AS Month,
                    'TOTAL' AS MonthName,
                    COUNT(j.JobID) AS CompletedJobs,
                    SUM(j.ActualCost) AS MonthlyRevenue,
                    AVG(j.ActualCost) AS AvgJobValue,
                    MIN(j.ActualCost) AS MinJobValue,
                    MAX(j.ActualCost) AS MaxJobValue
                FROM Jobs j
                WHERE j.Status = 'Completed' 
                    AND j.CompletionDate BETWEEN @DateFrom AND @DateTo
                    AND j.IsDeleted = 0
                
                ORDER BY Year, Month";

            SqlParameter[] parameters = {
                new SqlParameter("@DateFrom", dtpDateFrom.Value.Date),
                new SqlParameter("@DateTo", dtpDateTo.Value.Date.AddDays(1).AddSeconds(-1))
            };

            currentReportData = DatabaseConnection.FillDataTable(query, parameters);
            dgvReportData.DataSource = currentReportData;

            // Generate summary
            if (currentReportData.Rows.Count > 1) // > 1 because we always have TOTAL row
            {
                DataRow totalRow = currentReportData.Rows[currentReportData.Rows.Count - 1];

                int totalJobs = Convert.ToInt32(totalRow["CompletedJobs"]);
                decimal totalRevenue = Convert.ToDecimal(totalRow["MonthlyRevenue"]);
                decimal avgJobValue = Convert.ToDecimal(totalRow["AvgJobValue"]);
                decimal minJobValue = Convert.ToDecimal(totalRow["MinJobValue"]);
                decimal maxJobValue = Convert.ToDecimal(totalRow["MaxJobValue"]);

                txtReportSummary.Text = $"Period: {dtpDateFrom.Value:MMM yyyy} - {dtpDateTo.Value:MMM yyyy} | " +
                                       $"Total Revenue: ${totalRevenue:F2} | Jobs: {totalJobs} | " +
                                       $"Avg: ${avgJobValue:F2} | Range: ${minJobValue:F2} - ${maxJobValue:F2}";
            }
        }

        #endregion

        #region Export Functions

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            if (currentReportData == null || currentReportData.Rows.Count == 0)
            {
                MessageBox.Show("No data to export. Please generate a report first.",
                              "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog
                {
                    Filter = "PDF files (*.pdf)|*.pdf",
                    FileName = $"eShift_{currentReportType}_Report_{DateTime.Now:yyyyMMdd}.pdf",
                    Title = "Export Report to PDF"
                };

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    // Simple text-based PDF export (for basic functionality)
                    ExportToPDF(saveDialog.FileName);
                    MessageBox.Show($"Report exported successfully to:\n{saveDialog.FileName}",
                                  "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to PDF: {ex.Message}",
                              "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (currentReportData == null || currentReportData.Rows.Count == 0)
            {
                MessageBox.Show("No data to export. Please generate a report first.",
                              "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog
                {
                    Filter = "CSV files (*.csv)|*.csv|Excel files (*.xlsx)|*.xlsx",
                    FileName = $"eShift_{currentReportType}_Report_{DateTime.Now:yyyyMMdd}.csv",
                    Title = "Export Report to Excel/CSV"
                };

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    if (saveDialog.FileName.EndsWith(".csv"))
                    {
                        ExportToCSV(saveDialog.FileName);
                    }
                    else
                    {
                        ExportToExcel(saveDialog.FileName);
                    }

                    MessageBox.Show($"Report exported successfully to:\n{saveDialog.FileName}",
                                  "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting file: {ex.Message}",
                              "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportToPDF(string fileName)
        {
            // Simple text-based "PDF" export (actually creates a formatted text file)
            StringBuilder content = new StringBuilder();

            content.AppendLine("=".PadRight(80, '='));
            content.AppendLine($"e-SHIFT {currentReportType.ToUpper()} REPORT");
            content.AppendLine("=".PadRight(80, '='));
            content.AppendLine($"Generated: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
            content.AppendLine($"Generated by: {UserSession.GetFullName()}");
            content.AppendLine($"Date Range: {dtpDateFrom.Value:yyyy-MM-dd} to {dtpDateTo.Value:yyyy-MM-dd}");
            content.AppendLine($"Status Filter: {cmbStatus.Text}");
            content.AppendLine();

            if (!string.IsNullOrEmpty(txtReportSummary.Text))
            {
                content.AppendLine("SUMMARY:");
                content.AppendLine(txtReportSummary.Text);
                content.AppendLine();
            }

            content.AppendLine("DETAILED DATA:");
            content.AppendLine("-".PadRight(80, '-'));

            // Add column headers
            string headerLine = "";
            foreach (DataColumn column in currentReportData.Columns)
            {
                headerLine += column.ColumnName.PadRight(20) + " | ";
            }
            content.AppendLine(headerLine);
            content.AppendLine("-".PadRight(80, '-'));

            // Add data rows
            foreach (DataRow row in currentReportData.Rows)
            {
                string dataLine = "";
                foreach (var item in row.ItemArray)
                {
                    string value = item?.ToString() ?? "";
                    if (value.Length > 18) value = value.Substring(0, 18);
                    dataLine += value.PadRight(20) + " | ";
                }
                content.AppendLine(dataLine);
            }

            content.AppendLine();
            content.AppendLine("=".PadRight(80, '='));
            content.AppendLine("End of Report");

            File.WriteAllText(fileName.Replace(".pdf", ".txt"), content.ToString());
        }

        private void ExportToCSV(string fileName)
        {
            StringBuilder csvContent = new StringBuilder();

            // Add headers
            string[] columnNames = new string[currentReportData.Columns.Count];
            for (int i = 0; i < currentReportData.Columns.Count; i++)
            {
                columnNames[i] = currentReportData.Columns[i].ColumnName;
            }
            csvContent.AppendLine(string.Join(",", columnNames));

            // Add data rows
            foreach (DataRow row in currentReportData.Rows)
            {
                string[] values = new string[row.ItemArray.Length];
                for (int i = 0; i < row.ItemArray.Length; i++)
                {
                    values[i] = $"\"{row.ItemArray[i]}\"";
                }
                csvContent.AppendLine(string.Join(",", values));
            }

            File.WriteAllText(fileName, csvContent.ToString());
        }

        private void ExportToExcel(string fileName)
        {
            // For now, export as CSV with Excel extension
            // In a real application, you would use a library like EPPlus or ClosedXML
            ExportToCSV(fileName);
        }

        #endregion

        #region Helper Methods

        private void ShowMessage(string message, bool isError)
        {
            if (lblStatusBar != null)
            {
                lblStatusBar.Text = message;
                lblStatusBar.ForeColor = isError ? Color.Red : Color.DarkGreen;

                // Auto-clear message after 5 seconds
                if (!string.IsNullOrEmpty(message))
                {
                    System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                    timer.Interval = 5000;
                    timer.Tick += (s, e) => {
                        lblStatusBar.Text = "Ready";
                        lblStatusBar.ForeColor = Color.Black;
                        timer.Stop();
                        timer.Dispose();
                    };
                    timer.Start();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}