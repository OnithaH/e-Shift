namespace e_Shift
{
    partial class AdminDashboard
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblLoginTime = new System.Windows.Forms.Label();
            this.groupBoxStatistics = new System.Windows.Forms.GroupBox();
            this.lblPendingJobs = new System.Windows.Forms.Label();
            this.lblApprovedJobs = new System.Windows.Forms.Label();
            this.lblCompletedJobs = new System.Windows.Forms.Label();
            this.lblAvailableUnits = new System.Windows.Forms.Label();
            this.lblTotalCustomers = new System.Windows.Forms.Label();
            this.lblActiveProducts = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxNavigation = new System.Windows.Forms.GroupBox();
            this.btnCustomerManagement = new System.Windows.Forms.Button();
            this.btnProductManagement = new System.Windows.Forms.Button();
            this.btnJobManagement = new System.Windows.Forms.Button();
            this.btnTransportManagement = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnUserProfile = new System.Windows.Forms.Button();
            this.groupBoxQuickActions = new System.Windows.Forms.GroupBox();
            this.btnQuickAddCustomer = new System.Windows.Forms.Button();
            this.btnViewRecentActivity = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBoxStatistics.SuspendLayout();
            this.groupBoxNavigation.SuspendLayout();
            this.groupBoxQuickActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(318, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "e-Shift Admin Dashboard";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(30, 70);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(87, 28);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRole.Location = new System.Drawing.Point(30, 100);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(43, 23);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Role";
            // 
            // lblLoginTime
            // 
            this.lblLoginTime.AutoSize = true;
            this.lblLoginTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoginTime.Location = new System.Drawing.Point(30, 125);
            this.lblLoginTime.Name = "lblLoginTime";
            this.lblLoginTime.Size = new System.Drawing.Size(94, 23);
            this.lblLoginTime.TabIndex = 3;
            this.lblLoginTime.Text = "Login Time";
            // 
            // groupBoxStatistics
            // 
            this.groupBoxStatistics.Controls.Add(this.label7);
            this.groupBoxStatistics.Controls.Add(this.label6);
            this.groupBoxStatistics.Controls.Add(this.label5);
            this.groupBoxStatistics.Controls.Add(this.label4);
            this.groupBoxStatistics.Controls.Add(this.label3);
            this.groupBoxStatistics.Controls.Add(this.label2);
            this.groupBoxStatistics.Controls.Add(this.label1);
            this.groupBoxStatistics.Controls.Add(this.lblTotalRevenue);
            this.groupBoxStatistics.Controls.Add(this.lblActiveProducts);
            this.groupBoxStatistics.Controls.Add(this.lblTotalCustomers);
            this.groupBoxStatistics.Controls.Add(this.lblAvailableUnits);
            this.groupBoxStatistics.Controls.Add(this.lblCompletedJobs);
            this.groupBoxStatistics.Controls.Add(this.lblApprovedJobs);
            this.groupBoxStatistics.Controls.Add(this.lblPendingJobs);
            this.groupBoxStatistics.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxStatistics.Location = new System.Drawing.Point(30, 170);
            this.groupBoxStatistics.Name = "groupBoxStatistics";
            this.groupBoxStatistics.Size = new System.Drawing.Size(500, 300);
            this.groupBoxStatistics.TabIndex = 4;
            this.groupBoxStatistics.TabStop = false;
            this.groupBoxStatistics.Text = "System Statistics";
            // 
            // lblPendingJobs
            // 
            this.lblPendingJobs.AutoSize = true;
            this.lblPendingJobs.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPendingJobs.ForeColor = System.Drawing.Color.Orange;
            this.lblPendingJobs.Location = new System.Drawing.Point(200, 40);
            this.lblPendingJobs.Name = "lblPendingJobs";
            this.lblPendingJobs.Size = new System.Drawing.Size(27, 32);
            this.lblPendingJobs.TabIndex = 0;
            this.lblPendingJobs.Text = "0";
            // 
            // lblApprovedJobs
            // 
            this.lblApprovedJobs.AutoSize = true;
            this.lblApprovedJobs.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApprovedJobs.ForeColor = System.Drawing.Color.Blue;
            this.lblApprovedJobs.Location = new System.Drawing.Point(200, 75);
            this.lblApprovedJobs.Name = "lblApprovedJobs";
            this.lblApprovedJobs.Size = new System.Drawing.Size(27, 32);
            this.lblApprovedJobs.TabIndex = 1;
            this.lblApprovedJobs.Text = "0";
            // 
            // lblCompletedJobs
            // 
            this.lblCompletedJobs.AutoSize = true;
            this.lblCompletedJobs.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCompletedJobs.ForeColor = System.Drawing.Color.Green;
            this.lblCompletedJobs.Location = new System.Drawing.Point(200, 110);
            this.lblCompletedJobs.Name = "lblCompletedJobs";
            this.lblCompletedJobs.Size = new System.Drawing.Size(27, 32);
            this.lblCompletedJobs.TabIndex = 2;
            this.lblCompletedJobs.Text = "0";
            // 
            // lblAvailableUnits
            // 
            this.lblAvailableUnits.AutoSize = true;
            this.lblAvailableUnits.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAvailableUnits.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblAvailableUnits.Location = new System.Drawing.Point(200, 145);
            this.lblAvailableUnits.Name = "lblAvailableUnits";
            this.lblAvailableUnits.Size = new System.Drawing.Size(27, 32);
            this.lblAvailableUnits.TabIndex = 3;
            this.lblAvailableUnits.Text = "0";
            // 
            // lblTotalCustomers
            // 
            this.lblTotalCustomers.AutoSize = true;
            this.lblTotalCustomers.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalCustomers.ForeColor = System.Drawing.Color.Purple;
            this.lblTotalCustomers.Location = new System.Drawing.Point(200, 180);
            this.lblTotalCustomers.Name = "lblTotalCustomers";
            this.lblTotalCustomers.Size = new System.Drawing.Size(27, 32);
            this.lblTotalCustomers.TabIndex = 4;
            this.lblTotalCustomers.Text = "0";
            // 
            // lblActiveProducts
            // 
            this.lblActiveProducts.AutoSize = true;
            this.lblActiveProducts.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActiveProducts.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblActiveProducts.Location = new System.Drawing.Point(200, 215);
            this.lblActiveProducts.Name = "lblActiveProducts";
            this.lblActiveProducts.Size = new System.Drawing.Size(27, 32);
            this.lblActiveProducts.TabIndex = 5;
            this.lblActiveProducts.Text = "0";
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTotalRevenue.Location = new System.Drawing.Point(200, 250);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(63, 32);
            this.lblTotalRevenue.TabIndex = 6;
            this.lblTotalRevenue.Text = "$0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pending Jobs:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Approved Jobs:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(20, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Completed Jobs:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(20, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Available Transport:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(20, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total Customers:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(20, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Active Products:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(20, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total Revenue:";
            // 
            // groupBoxNavigation
            // 
            this.groupBoxNavigation.Controls.Add(this.btnUserProfile);
            this.groupBoxNavigation.Controls.Add(this.btnReports);
            this.groupBoxNavigation.Controls.Add(this.btnTransportManagement);
            this.groupBoxNavigation.Controls.Add(this.btnJobManagement);
            this.groupBoxNavigation.Controls.Add(this.btnProductManagement);
            this.groupBoxNavigation.Controls.Add(this.btnCustomerManagement);
            this.groupBoxNavigation.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxNavigation.Location = new System.Drawing.Point(560, 170);
            this.groupBoxNavigation.Name = "groupBoxNavigation";
            this.groupBoxNavigation.Size = new System.Drawing.Size(300, 300);
            this.groupBoxNavigation.TabIndex = 5;
            this.groupBoxNavigation.TabStop = false;
            this.groupBoxNavigation.Text = "Navigation Menu";
            // 
            // btnCustomerManagement
            // 
            this.btnCustomerManagement.BackColor = System.Drawing.Color.LightBlue;
            this.btnCustomerManagement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCustomerManagement.Location = new System.Drawing.Point(20, 35);
            this.btnCustomerManagement.Name = "btnCustomerManagement";
            this.btnCustomerManagement.Size = new System.Drawing.Size(250, 35);
            this.btnCustomerManagement.TabIndex = 0;
            this.btnCustomerManagement.Text = "👥 Customer Management";
            this.btnCustomerManagement.UseVisualStyleBackColor = false;
            this.btnCustomerManagement.Click += new System.EventHandler(this.btnCustomerManagement_Click);
            // 
            // btnProductManagement
            // 
            this.btnProductManagement.BackColor = System.Drawing.Color.LightGreen;
            this.btnProductManagement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProductManagement.Location = new System.Drawing.Point(20, 80);
            this.btnProductManagement.Name = "btnProductManagement";
            this.btnProductManagement.Size = new System.Drawing.Size(250, 35);
            this.btnProductManagement.TabIndex = 1;
            this.btnProductManagement.Text = "📦 Product Management";
            this.btnProductManagement.UseVisualStyleBackColor = false;
            this.btnProductManagement.Click += new System.EventHandler(this.btnProductManagement_Click);
            // 
            // btnJobManagement
            // 
            this.btnJobManagement.BackColor = System.Drawing.Color.LightCoral;
            this.btnJobManagement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnJobManagement.Location = new System.Drawing.Point(20, 125);
            this.btnJobManagement.Name = "btnJobManagement";
            this.btnJobManagement.Size = new System.Drawing.Size(250, 35);
            this.btnJobManagement.TabIndex = 2;
            this.btnJobManagement.Text = "🚛 Job Management";
            this.btnJobManagement.UseVisualStyleBackColor = false;
            this.btnJobManagement.Click += new System.EventHandler(this.btnJobManagement_Click);
            // 
            // btnTransportManagement
            // 
            this.btnTransportManagement.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnTransportManagement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTransportManagement.Location = new System.Drawing.Point(20, 170);
            this.btnTransportManagement.Name = "btnTransportManagement";
            this.btnTransportManagement.Size = new System.Drawing.Size(250, 35);
            this.btnTransportManagement.TabIndex = 3;
            this.btnTransportManagement.Text = "🚚 Transport Management";
            this.btnTransportManagement.UseVisualStyleBackColor = false;
            this.btnTransportManagement.Click += new System.EventHandler(this.btnTransportManagement_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Plum;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReports.Location = new System.Drawing.Point(20, 215);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(250, 35);
            this.btnReports.TabIndex = 4;
            this.btnReports.Text = "📊 Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnUserProfile
            // 
            this.btnUserProfile.BackColor = System.Drawing.Color.LightSalmon;
            this.btnUserProfile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUserProfile.Location = new System.Drawing.Point(20, 260);
            this.btnUserProfile.Name = "btnUserProfile";
            this.btnUserProfile.Size = new System.Drawing.Size(250, 35);
            this.btnUserProfile.TabIndex = 5;
            this.btnUserProfile.Text = "👤 User Profile";
            this.btnUserProfile.UseVisualStyleBackColor = false;
            this.btnUserProfile.Click += new System.EventHandler(this.btnUserProfile_Click);
            // 
            // groupBoxQuickActions
            // 
            this.groupBoxQuickActions.Controls.Add(this.btnLogout);
            this.groupBoxQuickActions.Controls.Add(this.btnRefresh);
            this.groupBoxQuickActions.Controls.Add(this.btnViewRecentActivity);
            this.groupBoxQuickActions.Controls.Add(this.btnQuickAddCustomer);
            this.groupBoxQuickActions.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxQuickActions.Location = new System.Drawing.Point(890, 170);
            this.groupBoxQuickActions.Name = "groupBoxQuickActions";
            this.groupBoxQuickActions.Size = new System.Drawing.Size(280, 300);
            this.groupBoxQuickActions.TabIndex = 6;
            this.groupBoxQuickActions.TabStop = false;
            this.groupBoxQuickActions.Text = "Quick Actions";
            // 
            // btnQuickAddCustomer
            // 
            this.btnQuickAddCustomer.BackColor = System.Drawing.Color.PaleGreen;
            this.btnQuickAddCustomer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuickAddCustomer.Location = new System.Drawing.Point(15, 35);
            this.btnQuickAddCustomer.Name = "btnQuickAddCustomer";
            this.btnQuickAddCustomer.Size = new System.Drawing.Size(250, 45);
            this.btnQuickAddCustomer.TabIndex = 0;
            this.btnQuickAddCustomer.Text = "➕ Quick Add Customer";
            this.btnQuickAddCustomer.UseVisualStyleBackColor = false;
            this.btnQuickAddCustomer.Click += new System.EventHandler(this.btnQuickAddCustomer_Click);
            // 
            // btnViewRecentActivity
            // 
            this.btnViewRecentActivity.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnViewRecentActivity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewRecentActivity.Location = new System.Drawing.Point(15, 90);
            this.btnViewRecentActivity.Name = "btnViewRecentActivity";
            this.btnViewRecentActivity.Size = new System.Drawing.Size(250, 45);
            this.btnViewRecentActivity.TabIndex = 1;
            this.btnViewRecentActivity.Text = "📋 View Recent Activity";
            this.btnViewRecentActivity.UseVisualStyleBackColor = false;
            this.btnViewRecentActivity.Click += new System.EventHandler(this.btnViewRecentActivity_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(15, 145);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(250, 45);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "🔄 Refresh Dashboard";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.LightPink;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(15, 200);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(250, 45);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "🚪 Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(30, 500);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(55, 23);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Ready";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1200, 550);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.groupBoxQuickActions);
            this.Controls.Add(this.groupBoxNavigation);
            this.Controls.Add(this.groupBoxStatistics);
            this.Controls.Add(this.lblLoginTime);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblTitle);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-Shift - Admin Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminDashboard_FormClosing);
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.groupBoxStatistics.ResumeLayout(false);
            this.groupBoxStatistics.PerformLayout();
            this.groupBoxNavigation.ResumeLayout(false);
            this.groupBoxQuickActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Label lblWelcome;
        private Label lblRole;
        private Label lblLoginTime;
        private GroupBox groupBoxStatistics;
        private Label lblPendingJobs;
        private Label lblApprovedJobs;
        private Label lblCompletedJobs;
        private Label lblAvailableUnits;
        private Label lblTotalCustomers;
        private Label lblActiveProducts;
        private Label lblTotalRevenue;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private GroupBox groupBoxNavigation;
        private Button btnCustomerManagement;
        private Button btnProductManagement;
        private Button btnJobManagement;
        private Button btnTransportManagement;
        private Button btnReports;
        private Button btnUserProfile;
        private GroupBox groupBoxQuickActions;
        private Button btnQuickAddCustomer;
        private Button btnViewRecentActivity;
        private Button btnRefresh;
        private Button btnLogout;
        private Label lblStatus;
    }
}