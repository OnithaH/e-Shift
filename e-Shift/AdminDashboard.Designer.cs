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
            lblTitle = new Label();
            lblWelcome = new Label();
            lblRole = new Label();
            lblLoginTime = new Label();
            groupBoxStatistics = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblTotalRevenue = new Label();
            lblActiveProducts = new Label();
            lblTotalCustomers = new Label();
            lblAvailableUnits = new Label();
            lblCompletedJobs = new Label();
            lblApprovedJobs = new Label();
            lblPendingJobs = new Label();
            groupBoxNavigation = new GroupBox();
            btnUserProfile = new Button();
            btnReports = new Button();
            btnTransportManagement = new Button();
            btnJobManagement = new Button();
            btnProductManagement = new Button();
            btnCustomerManagement = new Button();
            groupBoxQuickActions = new GroupBox();
            btnLogout = new Button();
            btnRefresh = new Button();
            btnViewRecentActivity = new Button();
            lblStatus = new Label();
            groupBoxStatistics.SuspendLayout();
            groupBoxNavigation.SuspendLayout();
            groupBoxQuickActions.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(30, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(378, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "e-Shift Admin Dashboard";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12F);
            lblWelcome.Location = new Point(30, 70);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(93, 28);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 10F);
            lblRole.Location = new Point(30, 100);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(43, 23);
            lblRole.TabIndex = 2;
            lblRole.Text = "Role";
            // 
            // lblLoginTime
            // 
            lblLoginTime.AutoSize = true;
            lblLoginTime.Font = new Font("Segoe UI", 10F);
            lblLoginTime.Location = new Point(30, 125);
            lblLoginTime.Name = "lblLoginTime";
            lblLoginTime.Size = new Size(94, 23);
            lblLoginTime.TabIndex = 3;
            lblLoginTime.Text = "Login Time";
            // 
            // groupBoxStatistics
            // 
            groupBoxStatistics.Controls.Add(label7);
            groupBoxStatistics.Controls.Add(label6);
            groupBoxStatistics.Controls.Add(label5);
            groupBoxStatistics.Controls.Add(label4);
            groupBoxStatistics.Controls.Add(label3);
            groupBoxStatistics.Controls.Add(label2);
            groupBoxStatistics.Controls.Add(label1);
            groupBoxStatistics.Controls.Add(lblTotalRevenue);
            groupBoxStatistics.Controls.Add(lblActiveProducts);
            groupBoxStatistics.Controls.Add(lblTotalCustomers);
            groupBoxStatistics.Controls.Add(lblAvailableUnits);
            groupBoxStatistics.Controls.Add(lblCompletedJobs);
            groupBoxStatistics.Controls.Add(lblApprovedJobs);
            groupBoxStatistics.Controls.Add(lblPendingJobs);
            groupBoxStatistics.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBoxStatistics.Location = new Point(30, 170);
            groupBoxStatistics.Name = "groupBoxStatistics";
            groupBoxStatistics.Size = new Size(500, 300);
            groupBoxStatistics.TabIndex = 4;
            groupBoxStatistics.TabStop = false;
            groupBoxStatistics.Text = "System Statistics";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(20, 255);
            label7.Name = "label7";
            label7.Size = new Size(120, 23);
            label7.TabIndex = 13;
            label7.Text = "Total Revenue:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(20, 220);
            label6.Name = "label6";
            label6.Size = new Size(132, 23);
            label6.TabIndex = 12;
            label6.Text = "Active Products:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(20, 185);
            label5.Name = "label5";
            label5.Size = new Size(136, 23);
            label5.TabIndex = 11;
            label5.Text = "Total Customers:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(20, 150);
            label4.Name = "label4";
            label4.Size = new Size(159, 23);
            label4.TabIndex = 10;
            label4.Text = "Available Transport:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(20, 115);
            label3.Name = "label3";
            label3.Size = new Size(136, 23);
            label3.TabIndex = 9;
            label3.Text = "Completed Jobs:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(20, 80);
            label2.Name = "label2";
            label2.Size = new Size(126, 23);
            label2.TabIndex = 8;
            label2.Text = "Approved Jobs:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(20, 45);
            label1.Name = "label1";
            label1.Size = new Size(114, 23);
            label1.TabIndex = 7;
            label1.Text = "Pending Jobs:";
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalRevenue.ForeColor = Color.DarkGreen;
            lblTotalRevenue.Location = new Point(200, 250);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(77, 32);
            lblTotalRevenue.TabIndex = 6;
            lblTotalRevenue.Text = "$0.00";
            // 
            // lblActiveProducts
            // 
            lblActiveProducts.AutoSize = true;
            lblActiveProducts.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblActiveProducts.ForeColor = Color.DarkBlue;
            lblActiveProducts.Location = new Point(200, 215);
            lblActiveProducts.Name = "lblActiveProducts";
            lblActiveProducts.Size = new Size(28, 32);
            lblActiveProducts.TabIndex = 5;
            lblActiveProducts.Text = "0";
            // 
            // lblTotalCustomers
            // 
            lblTotalCustomers.AutoSize = true;
            lblTotalCustomers.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalCustomers.ForeColor = Color.Purple;
            lblTotalCustomers.Location = new Point(200, 180);
            lblTotalCustomers.Name = "lblTotalCustomers";
            lblTotalCustomers.Size = new Size(28, 32);
            lblTotalCustomers.TabIndex = 4;
            lblTotalCustomers.Text = "0";
            // 
            // lblAvailableUnits
            // 
            lblAvailableUnits.AutoSize = true;
            lblAvailableUnits.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblAvailableUnits.ForeColor = Color.DarkGreen;
            lblAvailableUnits.Location = new Point(200, 145);
            lblAvailableUnits.Name = "lblAvailableUnits";
            lblAvailableUnits.Size = new Size(28, 32);
            lblAvailableUnits.TabIndex = 3;
            lblAvailableUnits.Text = "0";
            // 
            // lblCompletedJobs
            // 
            lblCompletedJobs.AutoSize = true;
            lblCompletedJobs.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCompletedJobs.ForeColor = Color.Green;
            lblCompletedJobs.Location = new Point(200, 110);
            lblCompletedJobs.Name = "lblCompletedJobs";
            lblCompletedJobs.Size = new Size(28, 32);
            lblCompletedJobs.TabIndex = 2;
            lblCompletedJobs.Text = "0";
            // 
            // lblApprovedJobs
            // 
            lblApprovedJobs.AutoSize = true;
            lblApprovedJobs.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblApprovedJobs.ForeColor = Color.Blue;
            lblApprovedJobs.Location = new Point(200, 75);
            lblApprovedJobs.Name = "lblApprovedJobs";
            lblApprovedJobs.Size = new Size(28, 32);
            lblApprovedJobs.TabIndex = 1;
            lblApprovedJobs.Text = "0";
            // 
            // lblPendingJobs
            // 
            lblPendingJobs.AutoSize = true;
            lblPendingJobs.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPendingJobs.ForeColor = Color.Orange;
            lblPendingJobs.Location = new Point(200, 40);
            lblPendingJobs.Name = "lblPendingJobs";
            lblPendingJobs.Size = new Size(28, 32);
            lblPendingJobs.TabIndex = 0;
            lblPendingJobs.Text = "0";
            // 
            // groupBoxNavigation
            // 
            groupBoxNavigation.Controls.Add(btnUserProfile);
            groupBoxNavigation.Controls.Add(btnReports);
            groupBoxNavigation.Controls.Add(btnTransportManagement);
            groupBoxNavigation.Controls.Add(btnJobManagement);
            groupBoxNavigation.Controls.Add(btnProductManagement);
            groupBoxNavigation.Controls.Add(btnCustomerManagement);
            groupBoxNavigation.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBoxNavigation.Location = new Point(560, 170);
            groupBoxNavigation.Name = "groupBoxNavigation";
            groupBoxNavigation.Size = new Size(300, 300);
            groupBoxNavigation.TabIndex = 5;
            groupBoxNavigation.TabStop = false;
            groupBoxNavigation.Text = "Navigation Menu";
            // 
            // btnUserProfile
            // 
            btnUserProfile.BackColor = Color.LightSalmon;
            btnUserProfile.Font = new Font("Segoe UI", 10F);
            btnUserProfile.Location = new Point(20, 260);
            btnUserProfile.Name = "btnUserProfile";
            btnUserProfile.Size = new Size(250, 35);
            btnUserProfile.TabIndex = 5;
            btnUserProfile.Text = "👤 User Profile";
            btnUserProfile.UseVisualStyleBackColor = false;
            btnUserProfile.Click += btnUserProfile_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.Plum;
            btnReports.Font = new Font("Segoe UI", 10F);
            btnReports.Location = new Point(20, 215);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(250, 35);
            btnReports.TabIndex = 4;
            btnReports.Text = "📊 Reports";
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnTransportManagement
            // 
            btnTransportManagement.BackColor = Color.LightGoldenrodYellow;
            btnTransportManagement.Font = new Font("Segoe UI", 10F);
            btnTransportManagement.Location = new Point(20, 170);
            btnTransportManagement.Name = "btnTransportManagement";
            btnTransportManagement.Size = new Size(250, 35);
            btnTransportManagement.TabIndex = 3;
            btnTransportManagement.Text = "🚚 Transport Management";
            btnTransportManagement.UseVisualStyleBackColor = false;
            btnTransportManagement.Click += btnTransportManagement_Click;
            // 
            // btnJobManagement
            // 
            btnJobManagement.BackColor = Color.LightCoral;
            btnJobManagement.Font = new Font("Segoe UI", 10F);
            btnJobManagement.Location = new Point(20, 125);
            btnJobManagement.Name = "btnJobManagement";
            btnJobManagement.Size = new Size(250, 35);
            btnJobManagement.TabIndex = 2;
            btnJobManagement.Text = "🚛 Job Management";
            btnJobManagement.UseVisualStyleBackColor = false;
            btnJobManagement.Click += btnJobManagement_Click;
            // 
            // btnProductManagement
            // 
            btnProductManagement.BackColor = Color.LightGreen;
            btnProductManagement.Font = new Font("Segoe UI", 10F);
            btnProductManagement.Location = new Point(20, 80);
            btnProductManagement.Name = "btnProductManagement";
            btnProductManagement.Size = new Size(250, 35);
            btnProductManagement.TabIndex = 1;
            btnProductManagement.Text = "📦 Product Management";
            btnProductManagement.UseVisualStyleBackColor = false;
            btnProductManagement.Click += btnProductManagement_Click;
            // 
            // btnCustomerManagement
            // 
            btnCustomerManagement.BackColor = Color.LightBlue;
            btnCustomerManagement.Font = new Font("Segoe UI", 10F);
            btnCustomerManagement.Location = new Point(20, 35);
            btnCustomerManagement.Name = "btnCustomerManagement";
            btnCustomerManagement.Size = new Size(250, 35);
            btnCustomerManagement.TabIndex = 0;
            btnCustomerManagement.Text = "👥 Customer Management";
            btnCustomerManagement.UseVisualStyleBackColor = false;
            btnCustomerManagement.Click += btnCustomerManagement_Click;
            // 
            // groupBoxQuickActions
            // 
            groupBoxQuickActions.Controls.Add(btnLogout);
            groupBoxQuickActions.Controls.Add(btnRefresh);
            groupBoxQuickActions.Controls.Add(btnViewRecentActivity);
            groupBoxQuickActions.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBoxQuickActions.Location = new Point(890, 170);
            groupBoxQuickActions.Name = "groupBoxQuickActions";
            groupBoxQuickActions.Size = new Size(280, 300);
            groupBoxQuickActions.TabIndex = 6;
            groupBoxQuickActions.TabStop = false;
            groupBoxQuickActions.Text = "Quick Actions";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.LightPink;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogout.Location = new Point(17, 150);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(250, 45);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "🚪 Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LightSteelBlue;
            btnRefresh.Font = new Font("Segoe UI", 10F);
            btnRefresh.Location = new Point(17, 95);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(250, 45);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "🔄 Refresh Dashboard";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnViewRecentActivity
            // 
            btnViewRecentActivity.BackColor = Color.PaleTurquoise;
            btnViewRecentActivity.Font = new Font("Segoe UI", 10F);
            btnViewRecentActivity.Location = new Point(17, 40);
            btnViewRecentActivity.Name = "btnViewRecentActivity";
            btnViewRecentActivity.Size = new Size(250, 45);
            btnViewRecentActivity.TabIndex = 1;
            btnViewRecentActivity.Text = "📋 View Recent Activity";
            btnViewRecentActivity.UseVisualStyleBackColor = false;
            btnViewRecentActivity.Click += btnViewRecentActivity_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10F);
            lblStatus.Location = new Point(30, 500);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(56, 23);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Ready";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1200, 553);
            Controls.Add(lblStatus);
            Controls.Add(groupBoxQuickActions);
            Controls.Add(groupBoxNavigation);
            Controls.Add(groupBoxStatistics);
            Controls.Add(lblLoginTime);
            Controls.Add(lblRole);
            Controls.Add(lblWelcome);
            Controls.Add(lblTitle);
            MinimumSize = new Size(1000, 600);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-Shift - Admin Dashboard";
            FormClosing += AdminDashboard_FormClosing;
            Load += AdminDashboard_Load;
            groupBoxStatistics.ResumeLayout(false);
            groupBoxStatistics.PerformLayout();
            groupBoxNavigation.ResumeLayout(false);
            groupBoxQuickActions.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

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
        private Button btnViewRecentActivity;
        private Button btnRefresh;
        private Button btnLogout;
        private Label lblStatus;
    }
}