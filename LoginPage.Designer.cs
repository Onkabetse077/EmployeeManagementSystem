namespace Employee_Management_System
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            pnlLoginPage = new Panel();
            pbEmployeeLogin = new PictureBox();
            lblEMSLogin = new Label();
            btnSignupLogin = new Button();
            lblRegisterAccountLogin = new Label();
            lblExitLogin = new Label();
            lblLoginAccount = new Label();
            lblUsernameLogin = new Label();
            tbUsernameLogin = new TextBox();
            tbPasswordLogin = new TextBox();
            lblPasswordLogin = new Label();
            cbShowPasswordLogin = new CheckBox();
            btnLogin = new Button();
            pnlLoginPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbEmployeeLogin).BeginInit();
            SuspendLayout();
            // 
            // pnlLoginPage
            // 
            pnlLoginPage.BackColor = SystemColors.Highlight;
            pnlLoginPage.Controls.Add(pbEmployeeLogin);
            pnlLoginPage.Controls.Add(lblEMSLogin);
            pnlLoginPage.Controls.Add(btnSignupLogin);
            pnlLoginPage.Controls.Add(lblRegisterAccountLogin);
            pnlLoginPage.Dock = DockStyle.Left;
            pnlLoginPage.Location = new Point(0, 0);
            pnlLoginPage.Name = "pnlLoginPage";
            pnlLoginPage.Size = new Size(300, 450);
            pnlLoginPage.TabIndex = 0;
            // 
            // pbEmployeeLogin
            // 
            pbEmployeeLogin.Image = (Image)resources.GetObject("pbEmployeeLogin.Image");
            pbEmployeeLogin.Location = new Point(75, 39);
            pbEmployeeLogin.Name = "pbEmployeeLogin";
            pbEmployeeLogin.Size = new Size(128, 128);
            pbEmployeeLogin.TabIndex = 12;
            pbEmployeeLogin.TabStop = false;
            // 
            // lblEMSLogin
            // 
            lblEMSLogin.AutoSize = true;
            lblEMSLogin.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEMSLogin.ForeColor = SystemColors.ButtonHighlight;
            lblEMSLogin.Location = new Point(3, 183);
            lblEMSLogin.Name = "lblEMSLogin";
            lblEMSLogin.Size = new Size(286, 21);
            lblEMSLogin.TabIndex = 11;
            lblEMSLogin.Text = "Employee Management System";
            // 
            // btnSignupLogin
            // 
            btnSignupLogin.BackColor = SystemColors.HotTrack;
            btnSignupLogin.FlatAppearance.BorderSize = 0;
            btnSignupLogin.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            btnSignupLogin.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            btnSignupLogin.FlatStyle = FlatStyle.Flat;
            btnSignupLogin.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignupLogin.ForeColor = SystemColors.ButtonHighlight;
            btnSignupLogin.Location = new Point(3, 381);
            btnSignupLogin.Name = "btnSignupLogin";
            btnSignupLogin.Size = new Size(294, 29);
            btnSignupLogin.TabIndex = 10;
            btnSignupLogin.Text = "Signup";
            btnSignupLogin.UseVisualStyleBackColor = false;
            btnSignupLogin.Click += btnSignupLogin_Click;
            // 
            // lblRegisterAccountLogin
            // 
            lblRegisterAccountLogin.AutoSize = true;
            lblRegisterAccountLogin.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegisterAccountLogin.ForeColor = SystemColors.ButtonHighlight;
            lblRegisterAccountLogin.Location = new Point(52, 327);
            lblRegisterAccountLogin.Name = "lblRegisterAccountLogin";
            lblRegisterAccountLogin.Size = new Size(201, 20);
            lblRegisterAccountLogin.TabIndex = 9;
            lblRegisterAccountLogin.Text = "Don't have an Account?";
            // 
            // lblExitLogin
            // 
            lblExitLogin.AutoSize = true;
            lblExitLogin.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExitLogin.Location = new Point(562, 9);
            lblExitLogin.Name = "lblExitLogin";
            lblExitLogin.Size = new Size(26, 28);
            lblExitLogin.TabIndex = 1;
            lblExitLogin.Text = "x";
            lblExitLogin.Click += lblExit_Click;
            // 
            // lblLoginAccount
            // 
            lblLoginAccount.AutoSize = true;
            lblLoginAccount.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginAccount.Location = new Point(306, 77);
            lblLoginAccount.Name = "lblLoginAccount";
            lblLoginAccount.Size = new Size(153, 24);
            lblLoginAccount.TabIndex = 2;
            lblLoginAccount.Text = "Login Account";
            lblLoginAccount.Click += label2_Click;
            // 
            // lblUsernameLogin
            // 
            lblUsernameLogin.AutoSize = true;
            lblUsernameLogin.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUsernameLogin.Location = new Point(306, 150);
            lblUsernameLogin.Name = "lblUsernameLogin";
            lblUsernameLogin.Size = new Size(88, 17);
            lblUsernameLogin.TabIndex = 3;
            lblUsernameLogin.Text = "Username:";
            // 
            // tbUsernameLogin
            // 
            tbUsernameLogin.Location = new Point(306, 170);
            tbUsernameLogin.Multiline = true;
            tbUsernameLogin.Name = "tbUsernameLogin";
            tbUsernameLogin.Size = new Size(282, 34);
            tbUsernameLogin.TabIndex = 4;
            tbUsernameLogin.TextChanged += tbUsername_TextChanged;
            // 
            // tbPasswordLogin
            // 
            tbPasswordLogin.Location = new Point(306, 238);
            tbPasswordLogin.Multiline = true;
            tbPasswordLogin.Name = "tbPasswordLogin";
            tbPasswordLogin.PasswordChar = '*';
            tbPasswordLogin.Size = new Size(282, 34);
            tbPasswordLogin.TabIndex = 6;
            // 
            // lblPasswordLogin
            // 
            lblPasswordLogin.AutoSize = true;
            lblPasswordLogin.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPasswordLogin.Location = new Point(306, 218);
            lblPasswordLogin.Name = "lblPasswordLogin";
            lblPasswordLogin.Size = new Size(85, 17);
            lblPasswordLogin.TabIndex = 5;
            lblPasswordLogin.Text = "Password:";
            // 
            // cbShowPasswordLogin
            // 
            cbShowPasswordLogin.AutoSize = true;
            cbShowPasswordLogin.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbShowPasswordLogin.Location = new Point(442, 278);
            cbShowPasswordLogin.Name = "cbShowPasswordLogin";
            cbShowPasswordLogin.Size = new Size(146, 21);
            cbShowPasswordLogin.TabIndex = 7;
            cbShowPasswordLogin.Text = "Show Password";
            cbShowPasswordLogin.UseVisualStyleBackColor = true;
            cbShowPasswordLogin.CheckedChanged += cbShowPasswordLogin_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Highlight;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            btnLogin.FlatAppearance.MouseOverBackColor = SystemColors.HotTrack;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(306, 318);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(600, 450);
            Controls.Add(btnLogin);
            Controls.Add(cbShowPasswordLogin);
            Controls.Add(tbPasswordLogin);
            Controls.Add(lblPasswordLogin);
            Controls.Add(tbUsernameLogin);
            Controls.Add(lblUsernameLogin);
            Controls.Add(lblLoginAccount);
            Controls.Add(lblExitLogin);
            Controls.Add(pnlLoginPage);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += LoginPage_Load;
            pnlLoginPage.ResumeLayout(false);
            pnlLoginPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbEmployeeLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlLoginPage;
        private Label lblExitLogin;
        private Label lblLoginAccount;
        private Label lblUsernameLogin;
        private TextBox tbUsernameLogin;
        private TextBox tbPasswordLogin;
        private Label lblPasswordLogin;
        private CheckBox cbShowPasswordLogin;
        private Button btnLogin;
        private Label lblRegisterAccountLogin;
        private Button btnSignupLogin;
        private Label lblEMSLogin;
        private PictureBox pbEmployeeLogin;
    }
}
