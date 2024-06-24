using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void lblExitMain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        

        private void btnLogoutMain_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                this.Hide();
                LoginPage login = new LoginPage();
                login.Show();
            }
        }

        private void pnlMainMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHomeMain_Click(object sender, EventArgs e)
        {
            dashBoard1.Visible = true;
            addEmployees1.Visible = false;
            salary1.Visible = false;
        }

        private void btnAddEmployeeMain_Click(object sender, EventArgs e)
        {
            dashBoard1.Visible = false;
            addEmployees1.Visible = true;
            salary1.Visible = false;
        }
        private void btnSalaryMain_Click(object sender, EventArgs e)
        {
            dashBoard1.Visible = false;
            addEmployees1.Visible = false;
            salary1.Visible = true;
        }
    }
}
