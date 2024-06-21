namespace Employee_Management_System
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
            lblExitMain = new Label();
            lblEMSMain = new Label();
            pnlASideMain = new Panel();
            pbEmployeeMain = new PictureBox();
            lblWelcomeMain = new Label();
            btnHomeMain = new Button();
            btnAddEmployeeMain = new Button();
            btnSalaryMain = new Button();
            button1 = new Button();
            pnlHeader.SuspendLayout();
            pnlASideMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbEmployeeMain).BeginInit();
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
            // lblExitMain
            // 
            lblExitMain.AutoSize = true;
            lblExitMain.BackColor = SystemColors.Highlight;
            lblExitMain.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExitMain.ForeColor = SystemColors.ButtonHighlight;
            lblExitMain.Location = new Point(1069, 9);
            lblExitMain.Name = "lblExitMain";
            lblExitMain.Size = new Size(28, 28);
            lblExitMain.TabIndex = 1;
            lblExitMain.Text = "X";
            lblExitMain.Click += lblExitMain_Click;
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
            lblEMSMain.Click += label1_Click;
            // 
            // pnlASideMain
            // 
            pnlASideMain.BackColor = SystemColors.Highlight;
            pnlASideMain.Controls.Add(button1);
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
            // pbEmployeeMain
            // 
            pbEmployeeMain.Image = (Image)resources.GetObject("pbEmployeeMain.Image");
            pbEmployeeMain.Location = new Point(63, 36);
            pbEmployeeMain.Name = "pbEmployeeMain";
            pbEmployeeMain.Size = new Size(125, 125);
            pbEmployeeMain.TabIndex = 0;
            pbEmployeeMain.TabStop = false;
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
            lblWelcomeMain.Click += label1_Click_1;
            // 
            // btnHomeMain
            // 
            btnHomeMain.BackColor = SystemColors.HotTrack;
            btnHomeMain.FlatAppearance.BorderSize = 0;
            btnHomeMain.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            btnHomeMain.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            btnHomeMain.FlatStyle = FlatStyle.Flat;
            btnHomeMain.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHomeMain.ForeColor = SystemColors.ButtonHighlight;
            btnHomeMain.Location = new Point(0, 231);
            btnHomeMain.Name = "btnHomeMain";
            btnHomeMain.Size = new Size(253, 29);
            btnHomeMain.TabIndex = 2;
            btnHomeMain.Text = "Home";
            btnHomeMain.UseVisualStyleBackColor = false;
            // 
            // btnAddEmployeeMain
            // 
            btnAddEmployeeMain.BackColor = SystemColors.HotTrack;
            btnAddEmployeeMain.FlatAppearance.BorderSize = 0;
            btnAddEmployeeMain.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            btnAddEmployeeMain.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            btnAddEmployeeMain.FlatStyle = FlatStyle.Flat;
            btnAddEmployeeMain.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddEmployeeMain.ForeColor = SystemColors.ButtonHighlight;
            btnAddEmployeeMain.Location = new Point(0, 266);
            btnAddEmployeeMain.Name = "btnAddEmployeeMain";
            btnAddEmployeeMain.Size = new Size(253, 29);
            btnAddEmployeeMain.TabIndex = 3;
            btnAddEmployeeMain.Text = "Add Employee";
            btnAddEmployeeMain.UseVisualStyleBackColor = false;
            // 
            // btnSalaryMain
            // 
            btnSalaryMain.BackColor = SystemColors.HotTrack;
            btnSalaryMain.FlatAppearance.BorderSize = 0;
            btnSalaryMain.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            btnSalaryMain.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            btnSalaryMain.FlatStyle = FlatStyle.Flat;
            btnSalaryMain.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalaryMain.ForeColor = SystemColors.ButtonHighlight;
            btnSalaryMain.Location = new Point(0, 301);
            btnSalaryMain.Name = "btnSalaryMain";
            btnSalaryMain.Size = new Size(253, 29);
            btnSalaryMain.TabIndex = 4;
            btnSalaryMain.Text = "Salary";
            btnSalaryMain.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Location = new Point(12, 669);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 750);
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
        private Button button1;
    }
}