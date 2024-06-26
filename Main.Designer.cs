﻿namespace Employee_Management_System
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            pnlHeader = new Panel();
            lblEMSMain = new Label();
            lblExitMain = new Label();
            pnlASideMain = new Panel();
            lblSignoutMain = new Label();
            btnLogoutMain = new Button();
            btnSalaryMain = new Button();
            btnAddEmployeeMain = new Button();
            btnHomeMain = new Button();
            lblWelcomeMain = new Label();
            pbEmployeeMain = new PictureBox();
            pnlMainMain = new Panel();
            dashBoard1 = new DashBoard();
            salary1 = new Salary();
            addEmployees1 = new AddEmployees();
            pnlHeader.SuspendLayout();
            pnlASideMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbEmployeeMain).BeginInit();
            pnlMainMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = SystemColors.Highlight;
            pnlHeader.Controls.Add(lblEMSMain);
            pnlHeader.Controls.Add(lblExitMain);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1100, 40);
            pnlHeader.TabIndex = 0;
            // 
            // lblEMSMain
            // 
            lblEMSMain.AutoSize = true;
            lblEMSMain.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEMSMain.ForeColor = SystemColors.ButtonHighlight;
            lblEMSMain.Location = new Point(3, 9);
            lblEMSMain.Name = "lblEMSMain";
            lblEMSMain.Size = new Size(377, 28);
            lblEMSMain.TabIndex = 1;
            lblEMSMain.Text = "Employee Management System";
            // 
            // lblExitMain
            // 
            lblExitMain.AutoSize = true;
            lblExitMain.BackColor = SystemColors.Highlight;
            lblExitMain.Cursor = Cursors.Hand;
            lblExitMain.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExitMain.ForeColor = SystemColors.ButtonHighlight;
            lblExitMain.Location = new Point(1069, 9);
            lblExitMain.Name = "lblExitMain";
            lblExitMain.Size = new Size(28, 28);
            lblExitMain.TabIndex = 1;
            lblExitMain.Text = "X";
            lblExitMain.Click += lblExitMain_Click;
            // 
            // pnlASideMain
            // 
            pnlASideMain.BackColor = SystemColors.Highlight;
            pnlASideMain.Controls.Add(lblSignoutMain);
            pnlASideMain.Controls.Add(btnLogoutMain);
            pnlASideMain.Controls.Add(btnSalaryMain);
            pnlASideMain.Controls.Add(btnAddEmployeeMain);
            pnlASideMain.Controls.Add(btnHomeMain);
            pnlASideMain.Controls.Add(lblWelcomeMain);
            pnlASideMain.Controls.Add(pbEmployeeMain);
            pnlASideMain.Dock = DockStyle.Left;
            pnlASideMain.Location = new Point(0, 40);
            pnlASideMain.Name = "pnlASideMain";
            pnlASideMain.Size = new Size(253, 710);
            pnlASideMain.TabIndex = 2;
            // 
            // lblSignoutMain
            // 
            lblSignoutMain.AutoSize = true;
            lblSignoutMain.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignoutMain.ForeColor = SystemColors.ButtonHighlight;
            lblSignoutMain.Location = new Point(68, 659);
            lblSignoutMain.Name = "lblSignoutMain";
            lblSignoutMain.Size = new Size(88, 24);
            lblSignoutMain.TabIndex = 6;
            lblSignoutMain.Text = "Signout";
            // 
            // btnLogoutMain
            // 
            btnLogoutMain.Cursor = Cursors.Hand;
            btnLogoutMain.FlatAppearance.BorderSize = 0;
            btnLogoutMain.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            btnLogoutMain.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            btnLogoutMain.FlatStyle = FlatStyle.Flat;
            btnLogoutMain.ForeColor = SystemColors.HotTrack;
            btnLogoutMain.Image = (Image)resources.GetObject("btnLogoutMain.Image");
            btnLogoutMain.Location = new Point(12, 648);
            btnLogoutMain.Name = "btnLogoutMain";
            btnLogoutMain.Size = new Size(50, 50);
            btnLogoutMain.TabIndex = 5;
            btnLogoutMain.UseVisualStyleBackColor = true;
            btnLogoutMain.Click += btnLogoutMain_Click;
            // 
            // btnSalaryMain
            // 
            btnSalaryMain.BackColor = SystemColors.HotTrack;
            btnSalaryMain.Cursor = Cursors.Hand;
            btnSalaryMain.FlatAppearance.BorderSize = 0;
            btnSalaryMain.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            btnSalaryMain.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            btnSalaryMain.FlatStyle = FlatStyle.Flat;
            btnSalaryMain.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalaryMain.ForeColor = SystemColors.ButtonHighlight;
            btnSalaryMain.Image = (Image)resources.GetObject("btnSalaryMain.Image");
            btnSalaryMain.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalaryMain.Location = new Point(0, 363);
            btnSalaryMain.Name = "btnSalaryMain";
            btnSalaryMain.Size = new Size(253, 60);
            btnSalaryMain.TabIndex = 4;
            btnSalaryMain.Text = "Salary";
            btnSalaryMain.UseVisualStyleBackColor = false;
            btnSalaryMain.Click += btnSalaryMain_Click;
            // 
            // btnAddEmployeeMain
            // 
            btnAddEmployeeMain.BackColor = SystemColors.HotTrack;
            btnAddEmployeeMain.Cursor = Cursors.Hand;
            btnAddEmployeeMain.FlatAppearance.BorderSize = 0;
            btnAddEmployeeMain.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            btnAddEmployeeMain.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            btnAddEmployeeMain.FlatStyle = FlatStyle.Flat;
            btnAddEmployeeMain.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddEmployeeMain.ForeColor = SystemColors.ButtonHighlight;
            btnAddEmployeeMain.Image = (Image)resources.GetObject("btnAddEmployeeMain.Image");
            btnAddEmployeeMain.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddEmployeeMain.Location = new Point(0, 297);
            btnAddEmployeeMain.Name = "btnAddEmployeeMain";
            btnAddEmployeeMain.Size = new Size(253, 60);
            btnAddEmployeeMain.TabIndex = 3;
            btnAddEmployeeMain.Text = "Add Employee";
            btnAddEmployeeMain.UseVisualStyleBackColor = false;
            btnAddEmployeeMain.Click += btnAddEmployeeMain_Click;
            // 
            // btnHomeMain
            // 
            btnHomeMain.BackColor = SystemColors.HotTrack;
            btnHomeMain.Cursor = Cursors.Hand;
            btnHomeMain.FlatAppearance.BorderSize = 0;
            btnHomeMain.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            btnHomeMain.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            btnHomeMain.FlatStyle = FlatStyle.Flat;
            btnHomeMain.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHomeMain.ForeColor = SystemColors.ButtonHighlight;
            btnHomeMain.Image = (Image)resources.GetObject("btnHomeMain.Image");
            btnHomeMain.ImageAlign = ContentAlignment.MiddleLeft;
            btnHomeMain.Location = new Point(0, 231);
            btnHomeMain.Name = "btnHomeMain";
            btnHomeMain.Size = new Size(253, 60);
            btnHomeMain.TabIndex = 2;
            btnHomeMain.Text = "Home";
            btnHomeMain.UseVisualStyleBackColor = false;
            btnHomeMain.Click += btnHomeMain_Click;
            // 
            // lblWelcomeMain
            // 
            lblWelcomeMain.AutoSize = true;
            lblWelcomeMain.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            lblWelcomeMain.ForeColor = SystemColors.ButtonFace;
            lblWelcomeMain.Location = new Point(63, 180);
            lblWelcomeMain.Name = "lblWelcomeMain";
            lblWelcomeMain.Size = new Size(124, 29);
            lblWelcomeMain.TabIndex = 1;
            lblWelcomeMain.Text = "Welcome";
            // 
            // pbEmployeeMain
            // 
            pbEmployeeMain.Image = (Image)resources.GetObject("pbEmployeeMain.Image");
            pbEmployeeMain.Location = new Point(63, 36);
            pbEmployeeMain.Name = "pbEmployeeMain";
            pbEmployeeMain.Size = new Size(125, 125);
            pbEmployeeMain.TabIndex = 0;
            pbEmployeeMain.TabStop = false;
            // 
            // pnlMainMain
            // 
            pnlMainMain.Controls.Add(addEmployees1);
            pnlMainMain.Controls.Add(dashBoard1);
            pnlMainMain.Controls.Add(salary1);
            pnlMainMain.Dock = DockStyle.Fill;
            pnlMainMain.Location = new Point(253, 40);
            pnlMainMain.Name = "pnlMainMain";
            pnlMainMain.Size = new Size(847, 710);
            pnlMainMain.TabIndex = 3;
            // 
            // dashBoard1
            // 
            dashBoard1.Location = new Point(0, 0);
            dashBoard1.Name = "dashBoard1";
            dashBoard1.Size = new Size(1059, 888);
            dashBoard1.TabIndex = 1;
            // 
            // salary1
            // 
            salary1.Location = new Point(0, 0);
            salary1.Name = "salary1";
            salary1.Size = new Size(1059, 888);
            salary1.TabIndex = 0;
            // 
            // addEmployees1
            // 
            addEmployees1.Location = new Point(0, 0);
            addEmployees1.Name = "addEmployees1";
            addEmployees1.Size = new Size(1059, 888);
            addEmployees1.TabIndex = 2;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 750);
            Controls.Add(pnlMainMain);
            Controls.Add(pnlASideMain);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlASideMain.ResumeLayout(false);
            pnlASideMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbEmployeeMain).EndInit();
            pnlMainMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblExitMain;
        private Label lblEMSMain;
        private Panel pnlASideMain;
        private PictureBox pbEmployeeMain;
        private Label lblWelcomeMain;
        private Button btnHomeMain;
        private Button btnSalaryMain;
        private Button btnAddEmployeeMain;
        private Button btnLogoutMain;
        private Label lblSignoutMain;
        private Panel pnlMainMain;
        private AddEmployees addEmployees1;
        private DashBoard dashBoard1;
        private Salary salary1;
    }
}