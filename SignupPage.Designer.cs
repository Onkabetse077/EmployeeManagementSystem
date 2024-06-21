namespace Employee_Management_System
{
    partial class SignupPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupPage));
            btnSignupRegister = new Button();
            cbShowPasswordSignup = new CheckBox();
            tbPasswordSignup = new TextBox();
            lblPasswordSignup = new Label();
            tbUsernameSignup = new TextBox();
            lblUsernameSignup = new Label();
            lblRegisterAccountRegister = new Label();
            lblExitSignUp = new Label();
            pnlRegisterPage = new Panel();
            pbEmployeeRegister = new PictureBox();
            lblEMSSignup = new Label();
            btnSigninRegister = new Button();
            lblSigninAccountRegister = new Label();
            pnlRegisterPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbEmployeeRegister).BeginInit();
            SuspendLayout();
            // 
            // btnSignupRegister
            // 
            btnSignupRegister.BackColor = SystemColors.Highlight;
            btnSignupRegister.FlatAppearance.BorderSize = 0;
            btnSignupRegister.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            btnSignupRegister.FlatAppearance.MouseOverBackColor = SystemColors.HotTrack;
            btnSignupRegister.FlatStyle = FlatStyle.Flat;
            btnSignupRegister.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignupRegister.Location = new Point(312, 318);
            btnSignupRegister.Name = "btnSignupRegister";
            btnSignupRegister.Size = new Size(94, 29);
            btnSignupRegister.TabIndex = 17;
            btnSignupRegister.Text = "Signup";
            btnSignupRegister.UseVisualStyleBackColor = false;
            btnSignupRegister.Click += btnSignupRegister_Click;
            // 
            // cbShowPasswordSignup
            // 
            cbShowPasswordSignup.AutoSize = true;
            cbShowPasswordSignup.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbShowPasswordSignup.Location = new Point(448, 278);
            cbShowPasswordSignup.Name = "cbShowPasswordSignup";
            cbShowPasswordSignup.Size = new Size(146, 21);
            cbShowPasswordSignup.TabIndex = 16;
            cbShowPasswordSignup.Text = "Show Password";
            cbShowPasswordSignup.UseVisualStyleBackColor = true;
            cbShowPasswordSignup.CheckedChanged += cbShowPasswordSignup_CheckedChanged;
            // 
            // tbPasswordSignup
            // 
            tbPasswordSignup.Location = new Point(312, 238);
            tbPasswordSignup.Multiline = true;
            tbPasswordSignup.Name = "tbPasswordSignup";
            tbPasswordSignup.PasswordChar = '*';
            tbPasswordSignup.Size = new Size(282, 34);
            tbPasswordSignup.TabIndex = 15;
            // 
            // lblPasswordSignup
            // 
            lblPasswordSignup.AutoSize = true;
            lblPasswordSignup.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPasswordSignup.Location = new Point(312, 218);
            lblPasswordSignup.Name = "lblPasswordSignup";
            lblPasswordSignup.Size = new Size(85, 17);
            lblPasswordSignup.TabIndex = 14;
            lblPasswordSignup.Text = "Password:";
            // 
            // tbUsernameSignup
            // 
            tbUsernameSignup.Location = new Point(312, 170);
            tbUsernameSignup.Multiline = true;
            tbUsernameSignup.Name = "tbUsernameSignup";
            tbUsernameSignup.Size = new Size(282, 34);
            tbUsernameSignup.TabIndex = 13;
            // 
            // lblUsernameSignup
            // 
            lblUsernameSignup.AutoSize = true;
            lblUsernameSignup.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUsernameSignup.Location = new Point(312, 150);
            lblUsernameSignup.Name = "lblUsernameSignup";
            lblUsernameSignup.Size = new Size(88, 17);
            lblUsernameSignup.TabIndex = 12;
            lblUsernameSignup.Text = "Username:";
            // 
            // lblRegisterAccountRegister
            // 
            lblRegisterAccountRegister.AutoSize = true;
            lblRegisterAccountRegister.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegisterAccountRegister.Location = new Point(312, 77);
            lblRegisterAccountRegister.Name = "lblRegisterAccountRegister";
            lblRegisterAccountRegister.Size = new Size(183, 24);
            lblRegisterAccountRegister.TabIndex = 11;
            lblRegisterAccountRegister.Text = "Register Account";
            // 
            // lblExitSignUp
            // 
            lblExitSignUp.AutoSize = true;
            lblExitSignUp.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExitSignUp.Location = new Point(568, 9);
            lblExitSignUp.Name = "lblExitSignUp";
            lblExitSignUp.Size = new Size(26, 28);
            lblExitSignUp.TabIndex = 10;
            lblExitSignUp.Text = "x";
            lblExitSignUp.Click += lblExit_Click;
            // 
            // pnlRegisterPage
            // 
            pnlRegisterPage.BackColor = SystemColors.Highlight;
            pnlRegisterPage.Controls.Add(pbEmployeeRegister);
            pnlRegisterPage.Controls.Add(lblEMSSignup);
            pnlRegisterPage.Controls.Add(btnSigninRegister);
            pnlRegisterPage.Controls.Add(lblSigninAccountRegister);
            pnlRegisterPage.Dock = DockStyle.Left;
            pnlRegisterPage.Location = new Point(0, 0);
            pnlRegisterPage.Name = "pnlRegisterPage";
            pnlRegisterPage.Size = new Size(300, 450);
            pnlRegisterPage.TabIndex = 9;
            // 
            // pbEmployeeRegister
            // 
            pbEmployeeRegister.Image = (Image)resources.GetObject("pbEmployeeRegister.Image");
            pbEmployeeRegister.Location = new Point(75, 39);
            pbEmployeeRegister.Name = "pbEmployeeRegister";
            pbEmployeeRegister.Size = new Size(128, 128);
            pbEmployeeRegister.TabIndex = 12;
            pbEmployeeRegister.TabStop = false;
            // 
            // lblEMSSignup
            // 
            lblEMSSignup.AutoSize = true;
            lblEMSSignup.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEMSSignup.ForeColor = SystemColors.ButtonHighlight;
            lblEMSSignup.Location = new Point(3, 183);
            lblEMSSignup.Name = "lblEMSSignup";
            lblEMSSignup.Size = new Size(286, 21);
            lblEMSSignup.TabIndex = 11;
            lblEMSSignup.Text = "Employee Management System";
            // 
            // btnSigninRegister
            // 
            btnSigninRegister.BackColor = SystemColors.HotTrack;
            btnSigninRegister.FlatAppearance.BorderSize = 0;
            btnSigninRegister.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            btnSigninRegister.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            btnSigninRegister.FlatStyle = FlatStyle.Flat;
            btnSigninRegister.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSigninRegister.ForeColor = SystemColors.ButtonHighlight;
            btnSigninRegister.Location = new Point(3, 381);
            btnSigninRegister.Name = "btnSigninRegister";
            btnSigninRegister.Size = new Size(294, 29);
            btnSigninRegister.TabIndex = 10;
            btnSigninRegister.Text = "Signin";
            btnSigninRegister.UseVisualStyleBackColor = false;
            btnSigninRegister.Click += btnSigninRegister_Click;
            // 
            // lblSigninAccountRegister
            // 
            lblSigninAccountRegister.AutoSize = true;
            lblSigninAccountRegister.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSigninAccountRegister.ForeColor = SystemColors.ButtonHighlight;
            lblSigninAccountRegister.Location = new Point(43, 327);
            lblSigninAccountRegister.Name = "lblSigninAccountRegister";
            lblSigninAccountRegister.Size = new Size(212, 20);
            lblSigninAccountRegister.TabIndex = 9;
            lblSigninAccountRegister.Text = "Already have an Acount?";
            // 
            // SignupPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 450);
            Controls.Add(btnSignupRegister);
            Controls.Add(cbShowPasswordSignup);
            Controls.Add(tbPasswordSignup);
            Controls.Add(lblPasswordSignup);
            Controls.Add(tbUsernameSignup);
            Controls.Add(lblUsernameSignup);
            Controls.Add(lblRegisterAccountRegister);
            Controls.Add(lblExitSignUp);
            Controls.Add(pnlRegisterPage);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignupPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignupPage";
            Load += SignupPage_Load;
            pnlRegisterPage.ResumeLayout(false);
            pnlRegisterPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbEmployeeRegister).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignupRegister;
        private CheckBox cbShowPasswordSignup;
        private TextBox tbPasswordSignup;
        private Label lblPasswordSignup;
        private TextBox tbUsernameSignup;
        private Label lblUsernameSignup;
        private Label lblRegisterAccountRegister;
        private Label lblExitSignUp;
        private Panel pnlRegisterPage;
        private PictureBox pbEmployeeRegister;
        private Label lblEMSSignup;
        private Button btnSigninRegister;
        private Label lblSigninAccountRegister;
    }
}