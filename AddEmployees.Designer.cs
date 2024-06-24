namespace Employee_Management_System
{
    partial class AddEmployees
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
            pnlAddEmployees = new Panel();
            dgvEmployeesData = new DataGridView();
            lblEmployeesData = new Label();
            pnlAddEmployees2 = new Panel();
            cbStatus = new ComboBox();
            lblStatus = new Label();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnImport = new Button();
            pbAddEmployees = new PictureBox();
            cbPosition = new ComboBox();
            lblPosition = new Label();
            tbPhoneNumbers = new TextBox();
            lblPhoneNumbers = new Label();
            cbGender = new ComboBox();
            lblGender = new Label();
            tbFullNames = new TextBox();
            lblFullNames = new Label();
            tbEmployeeID = new TextBox();
            lblEmployeeID = new Label();
            pnlAddEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeesData).BeginInit();
            pnlAddEmployees2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAddEmployees).BeginInit();
            SuspendLayout();
            // 
            // pnlAddEmployees
            // 
            pnlAddEmployees.BackColor = SystemColors.ButtonHighlight;
            pnlAddEmployees.Controls.Add(dgvEmployeesData);
            pnlAddEmployees.Controls.Add(lblEmployeesData);
            pnlAddEmployees.Location = new Point(26, 22);
            pnlAddEmployees.Name = "pnlAddEmployees";
            pnlAddEmployees.Size = new Size(789, 323);
            pnlAddEmployees.TabIndex = 0;
            // 
            // dgvEmployeesData
            // 
            dgvEmployeesData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployeesData.Location = new Point(30, 67);
            dgvEmployeesData.Name = "dgvEmployeesData";
            dgvEmployeesData.RowHeadersWidth = 51;
            dgvEmployeesData.Size = new Size(730, 227);
            dgvEmployeesData.TabIndex = 1;
            // 
            // lblEmployeesData
            // 
            lblEmployeesData.AutoSize = true;
            lblEmployeesData.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployeesData.Location = new Point(30, 22);
            lblEmployeesData.Name = "lblEmployeesData";
            lblEmployeesData.Size = new Size(204, 28);
            lblEmployeesData.TabIndex = 0;
            lblEmployeesData.Text = "Employee's Data";
            // 
            // pnlAddEmployees2
            // 
            pnlAddEmployees2.BackColor = SystemColors.ButtonHighlight;
            pnlAddEmployees2.Controls.Add(cbStatus);
            pnlAddEmployees2.Controls.Add(lblStatus);
            pnlAddEmployees2.Controls.Add(btnClear);
            pnlAddEmployees2.Controls.Add(btnDelete);
            pnlAddEmployees2.Controls.Add(btnUpdate);
            pnlAddEmployees2.Controls.Add(btnAdd);
            pnlAddEmployees2.Controls.Add(btnImport);
            pnlAddEmployees2.Controls.Add(pbAddEmployees);
            pnlAddEmployees2.Controls.Add(cbPosition);
            pnlAddEmployees2.Controls.Add(lblPosition);
            pnlAddEmployees2.Controls.Add(tbPhoneNumbers);
            pnlAddEmployees2.Controls.Add(lblPhoneNumbers);
            pnlAddEmployees2.Controls.Add(cbGender);
            pnlAddEmployees2.Controls.Add(lblGender);
            pnlAddEmployees2.Controls.Add(tbFullNames);
            pnlAddEmployees2.Controls.Add(lblFullNames);
            pnlAddEmployees2.Controls.Add(tbEmployeeID);
            pnlAddEmployees2.Controls.Add(lblEmployeeID);
            pnlAddEmployees2.Location = new Point(26, 371);
            pnlAddEmployees2.Name = "pnlAddEmployees2";
            pnlAddEmployees2.Size = new Size(789, 305);
            pnlAddEmployees2.TabIndex = 1;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Active", "Inactive" });
            cbStatus.Location = new Point(465, 128);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(125, 28);
            cbStatus.TabIndex = 17;
            cbStatus.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(390, 136);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(63, 21);
            lblStatus.TabIndex = 16;
            lblStatus.Text = "Status:";
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.Highlight;
            btnClear.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            btnClear.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.ButtonHighlight;
            btnClear.Location = new Point(530, 229);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(134, 50);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Highlight;
            btnDelete.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            btnDelete.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(390, 229);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(134, 50);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Highlight;
            btnUpdate.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            btnUpdate.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(250, 229);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(134, 50);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Highlight;
            btnAdd.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            btnAdd.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(110, 229);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(134, 50);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnImport
            // 
            btnImport.BackColor = SystemColors.Highlight;
            btnImport.FlatAppearance.BorderSize = 0;
            btnImport.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            btnImport.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            btnImport.FlatStyle = FlatStyle.Flat;
            btnImport.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnImport.ForeColor = SystemColors.ButtonHighlight;
            btnImport.Location = new Point(645, 157);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(115, 29);
            btnImport.TabIndex = 11;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = false;
            // 
            // pbAddEmployees
            // 
            pbAddEmployees.BackColor = SystemColors.ControlDarkDark;
            pbAddEmployees.Location = new Point(645, 26);
            pbAddEmployees.Name = "pbAddEmployees";
            pbAddEmployees.Size = new Size(115, 125);
            pbAddEmployees.TabIndex = 10;
            pbAddEmployees.TabStop = false;
            // 
            // cbPosition
            // 
            cbPosition.FormattingEnabled = true;
            cbPosition.Items.AddRange(new object[] { "Male", "Female", "Others" });
            cbPosition.Location = new Point(465, 80);
            cbPosition.Name = "cbPosition";
            cbPosition.Size = new Size(125, 28);
            cbPosition.TabIndex = 9;
            cbPosition.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPosition.Location = new Point(390, 88);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(70, 21);
            lblPosition.TabIndex = 8;
            lblPosition.Text = "Postion:";
            // 
            // tbPhoneNumbers
            // 
            tbPhoneNumbers.BorderStyle = BorderStyle.FixedSingle;
            tbPhoneNumbers.Location = new Point(465, 31);
            tbPhoneNumbers.Name = "tbPhoneNumbers";
            tbPhoneNumbers.Size = new Size(141, 27);
            tbPhoneNumbers.TabIndex = 7;
            // 
            // lblPhoneNumbers
            // 
            lblPhoneNumbers.AutoSize = true;
            lblPhoneNumbers.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhoneNumbers.Location = new Point(327, 37);
            lblPhoneNumbers.Name = "lblPhoneNumbers";
            lblPhoneNumbers.Size = new Size(132, 21);
            lblPhoneNumbers.TabIndex = 6;
            lblPhoneNumbers.Text = "Phone Numbers:";
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            cbGender.Location = new Point(149, 134);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(196, 28);
            cbGender.TabIndex = 5;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(61, 141);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(69, 21);
            lblGender.TabIndex = 4;
            lblGender.Text = "Gender:";
            lblGender.Click += lblGender_Click;
            // 
            // tbFullNames
            // 
            tbFullNames.BorderStyle = BorderStyle.FixedSingle;
            tbFullNames.Location = new Point(149, 82);
            tbFullNames.Name = "tbFullNames";
            tbFullNames.Size = new Size(196, 27);
            tbFullNames.TabIndex = 3;
            // 
            // lblFullNames
            // 
            lblFullNames.AutoSize = true;
            lblFullNames.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullNames.Location = new Point(32, 88);
            lblFullNames.Name = "lblFullNames";
            lblFullNames.Size = new Size(98, 21);
            lblFullNames.TabIndex = 2;
            lblFullNames.Text = "Full Names:";
            lblFullNames.Click += lblFullNames_Click;
            // 
            // tbEmployeeID
            // 
            tbEmployeeID.BorderStyle = BorderStyle.FixedSingle;
            tbEmployeeID.Location = new Point(149, 37);
            tbEmployeeID.Name = "tbEmployeeID";
            tbEmployeeID.Size = new Size(135, 27);
            tbEmployeeID.TabIndex = 1;
            // 
            // lblEmployeeID
            // 
            lblEmployeeID.AutoSize = true;
            lblEmployeeID.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmployeeID.Location = new Point(19, 43);
            lblEmployeeID.Name = "lblEmployeeID";
            lblEmployeeID.Size = new Size(111, 21);
            lblEmployeeID.TabIndex = 0;
            lblEmployeeID.Text = "Employee ID:";
            // 
            // AddEmployees
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlAddEmployees2);
            Controls.Add(pnlAddEmployees);
            Cursor = Cursors.Hand;
            Name = "AddEmployees";
            Size = new Size(847, 710);
            pnlAddEmployees.ResumeLayout(false);
            pnlAddEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeesData).EndInit();
            pnlAddEmployees2.ResumeLayout(false);
            pnlAddEmployees2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAddEmployees).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlAddEmployees;
        private Panel pnlAddEmployees2;
        private Label lblEmployeesData;
        private DataGridView dgvEmployeesData;
        private TextBox tbEmployeeID;
        private Label lblEmployeeID;
        private ComboBox cbGender;
        private Label lblGender;
        private TextBox tbFullNames;
        private Label lblFullNames;
        private TextBox tbPhoneNumbers;
        private Label lblPhoneNumbers;
        private ComboBox cbPosition;
        private Label lblPosition;
        private PictureBox pbAddEmployees;
        private Button btnImport;
        private Button btnAdd;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private ComboBox cbStatus;
        private Label lblStatus;
    }
}
