namespace e_Shift
{
    partial class CustomerDashboard
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
            lblWelcome = new Label();
            lblCustomerNumber = new Label();
            lblLoginTime = new Label();
            groupBoxStats = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblCompletedJobs = new Label();
            lblApprovedJobs = new Label();
            lblPendingJobs = new Label();
            lblTotalJobs = new Label();
            groupBoxActions = new GroupBox();
            btnLogout = new Button();
            btnNewJobRequest = new Button();
            groupBoxRecentJobs = new GroupBox();
            dataGridViewJobs = new DataGridView();
            lblStatus = new Label();
            groupBoxStats.SuspendLayout();
            groupBoxActions.SuspendLayout();
            groupBoxRecentJobs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewJobs).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(30, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(351, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "e-Shift Customer Portal";
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
            // lblCustomerNumber
            // 
            lblCustomerNumber.AutoSize = true;
            lblCustomerNumber.Font = new Font("Segoe UI", 10F);
            lblCustomerNumber.Location = new Point(30, 100);
            lblCustomerNumber.Name = "lblCustomerNumber";
            lblCustomerNumber.Size = new Size(152, 23);
            lblCustomerNumber.TabIndex = 2;
            lblCustomerNumber.Text = "Customer Number";
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
            // groupBoxStats
            // 
            groupBoxStats.Controls.Add(label4);
            groupBoxStats.Controls.Add(label3);
            groupBoxStats.Controls.Add(label2);
            groupBoxStats.Controls.Add(label1);
            groupBoxStats.Controls.Add(lblCompletedJobs);
            groupBoxStats.Controls.Add(lblApprovedJobs);
            groupBoxStats.Controls.Add(lblPendingJobs);
            groupBoxStats.Controls.Add(lblTotalJobs);
            groupBoxStats.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBoxStats.Location = new Point(30, 170);
            groupBoxStats.Name = "groupBoxStats";
            groupBoxStats.Size = new Size(393, 200);
            groupBoxStats.TabIndex = 4;
            groupBoxStats.TabStop = false;
            groupBoxStats.Text = "My Job Statistics";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(20, 150);
            label4.Name = "label4";
            label4.Size = new Size(136, 23);
            label4.TabIndex = 7;
            label4.Text = "Completed Jobs:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(20, 115);
            label3.Name = "label3";
            label3.Size = new Size(126, 23);
            label3.TabIndex = 6;
            label3.Text = "Approved Jobs:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(20, 80);
            label2.Name = "label2";
            label2.Size = new Size(114, 23);
            label2.TabIndex = 5;
            label2.Text = "Pending Jobs:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(20, 45);
            label1.Name = "label1";
            label1.Size = new Size(88, 23);
            label1.TabIndex = 4;
            label1.Text = "Total Jobs:";
            // 
            // lblCompletedJobs
            // 
            lblCompletedJobs.AutoSize = true;
            lblCompletedJobs.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCompletedJobs.ForeColor = Color.Green;
            lblCompletedJobs.Location = new Point(200, 145);
            lblCompletedJobs.Name = "lblCompletedJobs";
            lblCompletedJobs.Size = new Size(28, 32);
            lblCompletedJobs.TabIndex = 3;
            lblCompletedJobs.Text = "0";
            // 
            // lblApprovedJobs
            // 
            lblApprovedJobs.AutoSize = true;
            lblApprovedJobs.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblApprovedJobs.ForeColor = Color.Blue;
            lblApprovedJobs.Location = new Point(200, 110);
            lblApprovedJobs.Name = "lblApprovedJobs";
            lblApprovedJobs.Size = new Size(28, 32);
            lblApprovedJobs.TabIndex = 2;
            lblApprovedJobs.Text = "0";
            // 
            // lblPendingJobs
            // 
            lblPendingJobs.AutoSize = true;
            lblPendingJobs.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPendingJobs.ForeColor = Color.Orange;
            lblPendingJobs.Location = new Point(200, 75);
            lblPendingJobs.Name = "lblPendingJobs";
            lblPendingJobs.Size = new Size(28, 32);
            lblPendingJobs.TabIndex = 1;
            lblPendingJobs.Text = "0";
            // 
            // lblTotalJobs
            // 
            lblTotalJobs.AutoSize = true;
            lblTotalJobs.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalJobs.ForeColor = Color.DarkBlue;
            lblTotalJobs.Location = new Point(200, 40);
            lblTotalJobs.Name = "lblTotalJobs";
            lblTotalJobs.Size = new Size(28, 32);
            lblTotalJobs.TabIndex = 0;
            lblTotalJobs.Text = "0";
            // 
            // groupBoxActions
            // 
            groupBoxActions.Controls.Add(btnLogout);
            groupBoxActions.Controls.Add(btnNewJobRequest);
            groupBoxActions.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBoxActions.Location = new Point(429, 170);
            groupBoxActions.Name = "groupBoxActions";
            groupBoxActions.Size = new Size(353, 200);
            groupBoxActions.TabIndex = 5;
            groupBoxActions.TabStop = false;
            groupBoxActions.Text = "Quick Actions";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.LightPink;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogout.Location = new Point(20, 80);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(327, 38);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnNewJobRequest
            // 
            btnNewJobRequest.BackColor = Color.LightGreen;
            btnNewJobRequest.Font = new Font("Segoe UI", 10F);
            btnNewJobRequest.Location = new Point(20, 35);
            btnNewJobRequest.Name = "btnNewJobRequest";
            btnNewJobRequest.Size = new Size(327, 35);
            btnNewJobRequest.TabIndex = 0;
            btnNewJobRequest.Text = "📦 New Job Request";
            btnNewJobRequest.UseVisualStyleBackColor = false;
            btnNewJobRequest.Click += btnNewJobRequest_Click;
            // 
            // groupBoxRecentJobs
            // 
            groupBoxRecentJobs.Controls.Add(dataGridViewJobs);
            groupBoxRecentJobs.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBoxRecentJobs.Location = new Point(30, 390);
            groupBoxRecentJobs.Name = "groupBoxRecentJobs";
            groupBoxRecentJobs.Size = new Size(746, 425);
            groupBoxRecentJobs.TabIndex = 6;
            groupBoxRecentJobs.TabStop = false;
            groupBoxRecentJobs.Text = "Recent Job Requests";
            // 
            // dataGridViewJobs
            // 
            dataGridViewJobs.AllowUserToAddRows = false;
            dataGridViewJobs.AllowUserToDeleteRows = false;
            dataGridViewJobs.BackgroundColor = Color.White;
            dataGridViewJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewJobs.Location = new Point(20, 30);
            dataGridViewJobs.Name = "dataGridViewJobs";
            dataGridViewJobs.ReadOnly = true;
            dataGridViewJobs.RowHeadersWidth = 51;
            dataGridViewJobs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewJobs.Size = new Size(705, 380);
            dataGridViewJobs.TabIndex = 0;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10F);
            lblStatus.Location = new Point(30, 849);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(56, 23);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Ready";
            // 
            // CustomerDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(794, 890);
            Controls.Add(lblStatus);
            Controls.Add(groupBoxRecentJobs);
            Controls.Add(groupBoxActions);
            Controls.Add(groupBoxStats);
            Controls.Add(lblLoginTime);
            Controls.Add(lblCustomerNumber);
            Controls.Add(lblWelcome);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CustomerDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-Shift - Customer Dashboard";
            FormClosing += CustomerDashboard_FormClosing;
            Load += CustomerDashboard_Load;
            groupBoxStats.ResumeLayout(false);
            groupBoxStats.PerformLayout();
            groupBoxActions.ResumeLayout(false);
            groupBoxRecentJobs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewJobs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblCustomerNumber;
        private System.Windows.Forms.Label lblLoginTime;
        private System.Windows.Forms.GroupBox groupBoxStats;
        private System.Windows.Forms.Label lblTotalJobs;
        private System.Windows.Forms.Label lblPendingJobs;
        private System.Windows.Forms.Label lblApprovedJobs;
        private System.Windows.Forms.Label lblCompletedJobs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Button btnNewJobRequest;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox groupBoxRecentJobs;
        private System.Windows.Forms.DataGridView dataGridViewJobs;
        private System.Windows.Forms.Label lblStatus;
    }
}