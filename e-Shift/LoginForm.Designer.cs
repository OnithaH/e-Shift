namespace e_Shift
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            rbCustomer = new RadioButton();
            rbAdmin = new RadioButton();
            btnLogin = new Button();
            btnExit = new Button();
            lblStatus = new Label();
            groupBoxLoginType = new GroupBox();
            btnRegister = new Button();
            groupBoxLoginType.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(94, 33);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(317, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "e-Shift Management System";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(52, 120);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(94, 23);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(52, 174);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(90, 23);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(179, 120);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(296, 27);
            txtUsername.TabIndex = 3;
            txtUsername.KeyPress += txtUsername_KeyPress;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(179, 174);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(296, 27);
            txtPassword.TabIndex = 4;
            txtPassword.KeyPress += txtPassword_KeyPress;
            // 
            // rbCustomer
            // 
            rbCustomer.AutoSize = true;
            rbCustomer.Checked = true;
            rbCustomer.Location = new Point(42, 29);
            rbCustomer.Name = "rbCustomer";
            rbCustomer.Size = new Size(134, 24);
            rbCustomer.TabIndex = 5;
            rbCustomer.TabStop = true;
            rbCustomer.Text = "Customer Login";
            rbCustomer.UseVisualStyleBackColor = true;
            rbCustomer.CheckedChanged += rbCustomer_CheckedChanged_1;
            // 
            // rbAdmin
            // 
            rbAdmin.AutoSize = true;
            rbAdmin.Location = new Point(226, 29);
            rbAdmin.Name = "rbAdmin";
            rbAdmin.Size = new Size(115, 24);
            rbAdmin.TabIndex = 6;
            rbAdmin.Text = "Admin Login";
            rbAdmin.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(51, 312);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(122, 44);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(228, 312);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(122, 44);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(52, 388);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(50, 20);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "label1";
            // 
            // groupBoxLoginType
            // 
            groupBoxLoginType.Controls.Add(rbAdmin);
            groupBoxLoginType.Controls.Add(rbCustomer);
            groupBoxLoginType.Location = new Point(52, 233);
            groupBoxLoginType.Name = "groupBoxLoginType";
            groupBoxLoginType.Size = new Size(423, 73);
            groupBoxLoginType.TabIndex = 10;
            groupBoxLoginType.TabStop = false;
            groupBoxLoginType.Text = "Login Type";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(388, 312);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(122, 44);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 471);
            Controls.Add(btnRegister);
            Controls.Add(groupBoxLoginType);
            Controls.Add(lblStatus);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblTitle);
            Name = "LoginForm";
            Text = "e-Shift - Login";
            Load += LoginForm_Load;
            groupBoxLoginType.ResumeLayout(false);
            groupBoxLoginType.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private RadioButton rbCustomer;
        private RadioButton rbAdmin;
        private Button btnLogin;
        private Button btnExit;
        private Label lblStatus;
        private GroupBox groupBoxLoginType;
        private Button btnRegister;
    }
}
