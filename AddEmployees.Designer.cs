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
            pnlAddEmployees2 = new Panel();
            lblEmployeesData = new Label();
            dataGridView1 = new DataGridView();
            lblEmployeeID = new Label();
            tbEmployeeID = new TextBox();
            tbFullNames = new TextBox();
            lblFullNames = new Label();
            lblGender = new Label();
            cbGender = new ComboBox();
            tbPhoneNumbers = new TextBox();
            lblPhoneNumbers = new Label();
            comboBox2 = new ComboBox();
            label1 = new Label();
            pbAddEmployees = new PictureBox();
            btnImport = new Button();
            btnAdd = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pnlAddEmployees.SuspendLayout();
            pnlAddEmployees2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAddEmployees).BeginInit();
            SuspendLayout();
            // 
            // pnlAddEmployees
            // 
            pnlAddEmployees.BackColor = SystemColors.ButtonHighlight;
            pnlAddEmployees.Controls.Add(dataGridView1);
            pnlAddEmployees.Controls.Add(lblEmployeesData);
            pnlAddEmployees.Location = new Point(26, 22);
            pnlAddEmployees.Name = "pnlAddEmployees";
            pnlAddEmployees.Size = new Size(789, 323);
            pnlAddEmployees.TabIndex = 0;
            // 
            // pnlAddEmployees2
            // 
            pnlAddEmployees2.BackColor = SystemColors.ButtonHighlight;
            pnlAddEmployees2.Controls.Add(button2);
            pnlAddEmployees2.Controls.Add(button3);
            pnlAddEmployees2.Controls.Add(button1);
            pnlAddEmployees2.Controls.Add(btnAdd);
            pnlAddEmployees2.Controls.Add(btnImport);
            pnlAddEmployees2.Controls.Add(pbAddEmployees);
            pnlAddEmployees2.Controls.Add(comboBox2);
            pnlAddEmployees2.Controls.Add(label1);
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(730, 227);
            dataGridView1.TabIndex = 1;
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
            // tbEmployeeID
            // 
            tbEmployeeID.BorderStyle = BorderStyle.FixedSingle;
            tbEmployeeID.Location = new Point(149, 37);
            tbEmployeeID.Name = "tbEmployeeID";
            tbEmployeeID.Size = new Size(135, 27);
            tbEmployeeID.TabIndex = 1;
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
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            cbGender.Location = new Point(149, 134);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(196, 28);
            cbGender.TabIndex = 5;
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
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Male", "Female", "Others" });
            comboBox2.Location = new Point(465, 80);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(125, 28);
            comboBox2.TabIndex = 9;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(390, 88);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 8;
            label1.Text = "Gender:";
            // 
            // pbAddEmployees
            // 
            pbAddEmployees.Location = new Point(645, 26);
            pbAddEmployees.Name = "pbAddEmployees";
            pbAddEmployees.Size = new Size(115, 125);
            pbAddEmployees.TabIndex = 10;
            pbAddEmployees.TabStop = false;
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
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            button1.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(250, 229);
            button1.Name = "button1";
            button1.Size = new Size(134, 50);
            button1.TabIndex = 13;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            button2.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(530, 229);
            button2.Name = "button2";
            button2.Size = new Size(134, 50);
            button2.TabIndex = 15;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Highlight;
            button3.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            button3.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(390, 229);
            button3.Name = "button3";
            button3.Size = new Size(134, 50);
            button3.TabIndex = 14;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = false;
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
            pnlAddEmployees2.ResumeLayout(false);
            pnlAddEmployees2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAddEmployees).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlAddEmployees;
        private Panel pnlAddEmployees2;
        private Label lblEmployeesData;
        private DataGridView dataGridView1;
        private TextBox tbEmployeeID;
        private Label lblEmployeeID;
        private ComboBox cbGender;
        private Label lblGender;
        private TextBox tbFullNames;
        private Label lblFullNames;
        private TextBox tbPhoneNumbers;
        private Label lblPhoneNumbers;
        private ComboBox comboBox2;
        private Label label1;
        private PictureBox pbAddEmployees;
        private Button btnImport;
        private Button btnAdd;
        private Button button2;
        private Button button3;
        private Button button1;
    }
}
