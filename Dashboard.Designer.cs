namespace Employee_Management_System
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            pnlDashboard2 = new Panel();
            pnlDashboard3 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            pnlDashboar1 = new Panel();
            pbDashboard1 = new PictureBox();
            pbDashboard2 = new PictureBox();
            pbDashboard3 = new PictureBox();
            pnlDashboard3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlDashboar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDashboard1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDashboard2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDashboard3).BeginInit();
            SuspendLayout();
            // 
            // pnlDashboard2
            // 
            pnlDashboard2.BackColor = SystemColors.ButtonHighlight;
            pnlDashboard2.Location = new Point(32, 280);
            pnlDashboard2.Name = "pnlDashboard2";
            pnlDashboard2.Size = new Size(785, 407);
            pnlDashboard2.TabIndex = 1;
            // 
            // pnlDashboard3
            // 
            pnlDashboard3.BackColor = SystemColors.Highlight;
            pnlDashboard3.Controls.Add(pbDashboard1);
            pnlDashboard3.Location = new Point(43, 35);
            pnlDashboard3.Name = "pnlDashboard3";
            pnlDashboard3.Size = new Size(212, 145);
            pnlDashboard3.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(pbDashboard2);
            panel1.Location = new Point(289, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(212, 145);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(pbDashboard3);
            panel2.Location = new Point(538, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(212, 145);
            panel2.TabIndex = 2;
            // 
            // pnlDashboar1
            // 
            pnlDashboar1.BackColor = SystemColors.ButtonHighlight;
            pnlDashboar1.Controls.Add(panel2);
            pnlDashboar1.Controls.Add(panel1);
            pnlDashboar1.Controls.Add(pnlDashboard3);
            pnlDashboar1.Location = new Point(32, 29);
            pnlDashboar1.Name = "pnlDashboar1";
            pnlDashboar1.Size = new Size(785, 214);
            pnlDashboar1.TabIndex = 0;
            // 
            // pbDashboard1
            // 
            pbDashboard1.Image = (Image)resources.GetObject("pbDashboard1.Image");
            pbDashboard1.Location = new Point(20, 46);
            pbDashboard1.Name = "pbDashboard1";
            pbDashboard1.Size = new Size(60, 60);
            pbDashboard1.TabIndex = 0;
            pbDashboard1.TabStop = false;
            // 
            // pbDashboard2
            // 
            pbDashboard2.Image = (Image)resources.GetObject("pbDashboard2.Image");
            pbDashboard2.Location = new Point(21, 46);
            pbDashboard2.Name = "pbDashboard2";
            pbDashboard2.Size = new Size(60, 60);
            pbDashboard2.TabIndex = 1;
            pbDashboard2.TabStop = false;
            // 
            // pbDashboard3
            // 
            pbDashboard3.Image = (Image)resources.GetObject("pbDashboard3.Image");
            pbDashboard3.Location = new Point(26, 46);
            pbDashboard3.Name = "pbDashboard3";
            pbDashboard3.Size = new Size(60, 60);
            pbDashboard3.TabIndex = 1;
            pbDashboard3.TabStop = false;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlDashboard2);
            Controls.Add(pnlDashboar1);
            Name = "DashBoard";
            Size = new Size(847, 710);
            pnlDashboard3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            pnlDashboar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbDashboard1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDashboard2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDashboard3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlDashboard2;
        private Panel pnlDashboard3;
        private PictureBox pbDashboard1;
        private Panel panel1;
        private PictureBox pbDashboard2;
        private Panel panel2;
        private Panel pnlDashboar1;
        private PictureBox pbDashboard3;
    }
}
