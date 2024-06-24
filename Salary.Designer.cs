namespace Employee_Management_System
{
    partial class Salary
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlSalary = new Panel();
            panel1 = new Panel();
            lblEmployeesSalary = new Label();
            dgvEmployeesSalary = new DataGridView();
            lblEmployeeIDSalary = new Label();
            tbEmployeeIDSalary = new TextBox();
            tbFullNamesSalary = new TextBox();
            lblFullNamesSalary = new Label();
            tbPositonSalary = new TextBox();
            lblPositionSalary = new Label();
            tbSalarySalary = new TextBox();
            lblSalarySalary = new Label();
            btnUpdateSalary = new Button();
            btnAddSalary = new Button();
            brnClearSalary = new Button();
            btnDeleteSalary = new Button();
            pnlSalary.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeesSalary).BeginInit();
            SuspendLayout();
            // 
            // pnlSalary
            // 
            pnlSalary.BackColor = SystemColors.ButtonHighlight;
            pnlSalary.Controls.Add(brnClearSalary);
            pnlSalary.Controls.Add(btnDeleteSalary);
            pnlSalary.Controls.Add(btnUpdateSalary);
            pnlSalary.Controls.Add(btnAddSalary);
            pnlSalary.Controls.Add(tbSalarySalary);
            pnlSalary.Controls.Add(lblSalarySalary);
            pnlSalary.Controls.Add(tbPositonSalary);
            pnlSalary.Controls.Add(lblPositionSalary);
            pnlSalary.Controls.Add(tbFullNamesSalary);
            pnlSalary.Controls.Add(lblFullNamesSalary);
            pnlSalary.Controls.Add(tbEmployeeIDSalary);
            pnlSalary.Controls.Add(lblEmployeeIDSalary);
            pnlSalary.Location = new Point(29, 21);
            pnlSalary.Name = "pnlSalary";
            pnlSalary.Size = new Size(294, 656);
            pnlSalary.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(dgvEmployeesSalary);
            panel1.Controls.Add(lblEmployeesSalary);
            panel1.Location = new Point(343, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(481, 656);
            panel1.TabIndex = 1;
            // 
            // lblEmployeesSalary
            // 
            lblEmployeesSalary.AutoSize = true;
            lblEmployeesSalary.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployeesSalary.Location = new Point(22, 28);
            lblEmployeesSalary.Name = "lblEmployeesSalary";
            lblEmployeesSalary.Size = new Size(136, 28);
            lblEmployeesSalary.TabIndex = 0;
            lblEmployeesSalary.Text = "Employees";
            // 
            // dgvEmployeesSalary
            // 
            dgvEmployeesSalary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployeesSalary.Location = new Point(22, 80);
            dgvEmployeesSalary.Name = "dgvEmployeesSalary";
            dgvEmployeesSalary.RowHeadersWidth = 51;
            dgvEmployeesSalary.Size = new Size(440, 555);
            dgvEmployeesSalary.TabIndex = 1;
            // 
            // lblEmployeeIDSalary
            // 
            lblEmployeeIDSalary.AutoSize = true;
            lblEmployeeIDSalary.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployeeIDSalary.Location = new Point(15, 80);
            lblEmployeeIDSalary.Name = "lblEmployeeIDSalary";
            lblEmployeeIDSalary.Size = new Size(107, 18);
            lblEmployeeIDSalary.TabIndex = 0;
            lblEmployeeIDSalary.Text = "Employee ID:";
            // 
            // tbEmployeeIDSalary
            // 
            tbEmployeeIDSalary.Location = new Point(15, 125);
            tbEmployeeIDSalary.Multiline = true;
            tbEmployeeIDSalary.Name = "tbEmployeeIDSalary";
            tbEmployeeIDSalary.Size = new Size(267, 34);
            tbEmployeeIDSalary.TabIndex = 2;
            // 
            // tbFullNamesSalary
            // 
            tbFullNamesSalary.Location = new Point(15, 227);
            tbFullNamesSalary.Multiline = true;
            tbFullNamesSalary.Name = "tbFullNamesSalary";
            tbFullNamesSalary.Size = new Size(267, 34);
            tbFullNamesSalary.TabIndex = 4;
            // 
            // lblFullNamesSalary
            // 
            lblFullNamesSalary.AutoSize = true;
            lblFullNamesSalary.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullNamesSalary.Location = new Point(15, 182);
            lblFullNamesSalary.Name = "lblFullNamesSalary";
            lblFullNamesSalary.Size = new Size(96, 18);
            lblFullNamesSalary.TabIndex = 3;
            lblFullNamesSalary.Text = "Full Names:";
            lblFullNamesSalary.Click += label1_Click;
            // 
            // tbPositonSalary
            // 
            tbPositonSalary.Location = new Point(15, 329);
            tbPositonSalary.Multiline = true;
            tbPositonSalary.Name = "tbPositonSalary";
            tbPositonSalary.Size = new Size(267, 34);
            tbPositonSalary.TabIndex = 6;
            // 
            // lblPositionSalary
            // 
            lblPositionSalary.AutoSize = true;
            lblPositionSalary.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPositionSalary.Location = new Point(15, 284);
            lblPositionSalary.Name = "lblPositionSalary";
            lblPositionSalary.Size = new Size(74, 18);
            lblPositionSalary.TabIndex = 5;
            lblPositionSalary.Text = "Position:";
            // 
            // tbSalarySalary
            // 
            tbSalarySalary.Location = new Point(15, 440);
            tbSalarySalary.Multiline = true;
            tbSalarySalary.Name = "tbSalarySalary";
            tbSalarySalary.Size = new Size(267, 34);
            tbSalarySalary.TabIndex = 8;
            tbSalarySalary.TextChanged += textBox1_TextChanged;
            // 
            // lblSalarySalary
            // 
            lblSalarySalary.AutoSize = true;
            lblSalarySalary.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalarySalary.Location = new Point(15, 395);
            lblSalarySalary.Name = "lblSalarySalary";
            lblSalarySalary.Size = new Size(57, 18);
            lblSalarySalary.TabIndex = 7;
            lblSalarySalary.Text = "Salary";
            // 
            // btnUpdateSalary
            // 
            btnUpdateSalary.BackColor = SystemColors.Highlight;
            btnUpdateSalary.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            btnUpdateSalary.FlatAppearance.BorderSize = 0;
            btnUpdateSalary.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            btnUpdateSalary.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            btnUpdateSalary.FlatStyle = FlatStyle.Flat;
            btnUpdateSalary.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateSalary.ForeColor = SystemColors.ButtonHighlight;
            btnUpdateSalary.Location = new Point(147, 508);
            btnUpdateSalary.Name = "btnUpdateSalary";
            btnUpdateSalary.Size = new Size(114, 50);
            btnUpdateSalary.TabIndex = 15;
            btnUpdateSalary.Text = "Update";
            btnUpdateSalary.UseVisualStyleBackColor = false;
            // 
            // btnAddSalary
            // 
            btnAddSalary.BackColor = SystemColors.Highlight;
            btnAddSalary.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            btnAddSalary.FlatAppearance.BorderSize = 0;
            btnAddSalary.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            btnAddSalary.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            btnAddSalary.FlatStyle = FlatStyle.Flat;
            btnAddSalary.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddSalary.ForeColor = SystemColors.ButtonHighlight;
            btnAddSalary.Location = new Point(27, 508);
            btnAddSalary.Name = "btnAddSalary";
            btnAddSalary.Size = new Size(114, 50);
            btnAddSalary.TabIndex = 14;
            btnAddSalary.Text = "Add";
            btnAddSalary.UseVisualStyleBackColor = false;
            btnAddSalary.Click += btnAdd_Click;
            // 
            // brnClearSalary
            // 
            brnClearSalary.BackColor = SystemColors.Highlight;
            brnClearSalary.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            brnClearSalary.FlatAppearance.BorderSize = 0;
            brnClearSalary.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            brnClearSalary.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            brnClearSalary.FlatStyle = FlatStyle.Flat;
            brnClearSalary.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            brnClearSalary.ForeColor = SystemColors.ButtonHighlight;
            brnClearSalary.Location = new Point(147, 574);
            brnClearSalary.Name = "brnClearSalary";
            brnClearSalary.Size = new Size(114, 50);
            brnClearSalary.TabIndex = 17;
            brnClearSalary.Text = "Clear";
            brnClearSalary.UseVisualStyleBackColor = false;
            // 
            // btnDeleteSalary
            // 
            btnDeleteSalary.BackColor = SystemColors.Highlight;
            btnDeleteSalary.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            btnDeleteSalary.FlatAppearance.BorderSize = 0;
            btnDeleteSalary.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            btnDeleteSalary.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            btnDeleteSalary.FlatStyle = FlatStyle.Flat;
            btnDeleteSalary.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteSalary.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteSalary.Location = new Point(27, 574);
            btnDeleteSalary.Name = "btnDeleteSalary";
            btnDeleteSalary.Size = new Size(114, 50);
            btnDeleteSalary.TabIndex = 16;
            btnDeleteSalary.Text = "Delete";
            btnDeleteSalary.UseVisualStyleBackColor = false;
            // 
            // Salary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(pnlSalary);
            Name = "Salary";
            Size = new Size(847, 710);
            pnlSalary.ResumeLayout(false);
            pnlSalary.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeesSalary).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSalary;
        private Panel panel1;
        private Label lblEmployeesSalary;
        private DataGridView dgvEmployeesSalary;
        private Label lblEmployeeIDSalary;
        private TextBox tbEmployeeIDSalary;
        private TextBox tbFullNamesSalary;
        private Label lblFullNamesSalary;
        private TextBox tbSalarySalary;
        private Label lblSalarySalary;
        private TextBox tbPositonSalary;
        private Label lblPositionSalary;
        private Button btnUpdateSalary;
        private Button btnAddSalary;
        private Button brnClearSalary;
        private Button btnDeleteSalary;
    }
}
