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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlSalary = new Panel();
            btnClearSalary = new Button();
            btnUpdateSalary = new Button();
            tbSalarySalary = new TextBox();
            lblSalarySalary = new Label();
            tbPositonSalary = new TextBox();
            lblPositionSalary = new Label();
            tbFullNamesSalary = new TextBox();
            lblFullNamesSalary = new Label();
            tbEmployeeIDSalary = new TextBox();
            lblEmployeeIDSalary = new Label();
            panel1 = new Panel();
            lblEmployeesSalary = new Label();
            dgvEmployeesData = new DataGridView();
            pnlSalary.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeesData).BeginInit();
            SuspendLayout();
            // 
            // pnlSalary
            // 
            pnlSalary.BackColor = SystemColors.ButtonHighlight;
            pnlSalary.Controls.Add(btnClearSalary);
            pnlSalary.Controls.Add(btnUpdateSalary);
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
            // btnClearSalary
            // 
            btnClearSalary.BackColor = SystemColors.Highlight;
            btnClearSalary.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            btnClearSalary.FlatAppearance.BorderSize = 0;
            btnClearSalary.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            btnClearSalary.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            btnClearSalary.FlatStyle = FlatStyle.Flat;
            btnClearSalary.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearSalary.ForeColor = SystemColors.ButtonHighlight;
            btnClearSalary.Location = new Point(168, 511);
            btnClearSalary.Name = "btnClearSalary";
            btnClearSalary.Size = new Size(114, 50);
            btnClearSalary.TabIndex = 17;
            btnClearSalary.Text = "Clear";
            btnClearSalary.UseVisualStyleBackColor = false;
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
            btnUpdateSalary.Location = new Point(15, 511);
            btnUpdateSalary.Name = "btnUpdateSalary";
            btnUpdateSalary.Size = new Size(114, 50);
            btnUpdateSalary.TabIndex = 15;
            btnUpdateSalary.Text = "Update";
            btnUpdateSalary.UseVisualStyleBackColor = false;
            btnUpdateSalary.Click += btnUpdateSalary_Click;
            // 
            // tbSalarySalary
            // 
            tbSalarySalary.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            tbSalarySalary.Location = new Point(15, 440);
            tbSalarySalary.Multiline = true;
            tbSalarySalary.Name = "tbSalarySalary";
            tbSalarySalary.Size = new Size(267, 34);
            tbSalarySalary.TabIndex = 8;
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
            // tbPositonSalary
            // 
            tbPositonSalary.Font = new Font("Tahoma", 9F, FontStyle.Bold);
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
            // tbFullNamesSalary
            // 
            tbFullNamesSalary.Font = new Font("Tahoma", 9F, FontStyle.Bold);
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
            // 
            // tbEmployeeIDSalary
            // 
            tbEmployeeIDSalary.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            tbEmployeeIDSalary.Location = new Point(15, 125);
            tbEmployeeIDSalary.Multiline = true;
            tbEmployeeIDSalary.Name = "tbEmployeeIDSalary";
            tbEmployeeIDSalary.Size = new Size(267, 34);
            tbEmployeeIDSalary.TabIndex = 2;
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
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(dgvEmployeesData);
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
            // dgvEmployeesData
            // 
            dgvEmployeesData.AllowUserToAddRows = false;
            dgvEmployeesData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEmployeesData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEmployeesData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.MenuText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvEmployeesData.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEmployeesData.EnableHeadersVisualStyles = false;
            dgvEmployeesData.Location = new Point(22, 80);
            dgvEmployeesData.Name = "dgvEmployeesData";
            dgvEmployeesData.ReadOnly = true;
            dgvEmployeesData.RowHeadersVisible = false;
            dgvEmployeesData.RowHeadersWidth = 51;
            dgvEmployeesData.Size = new Size(436, 551);
            dgvEmployeesData.TabIndex = 2;
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
            ((System.ComponentModel.ISupportInitialize)dgvEmployeesData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSalary;
        private Panel panel1;
        private Label lblEmployeesSalary;
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
        private Button btnClearSalary;
        private Button btnDeleteSalary;
        private DataGridView dgvEmployeesData;
    }
}
