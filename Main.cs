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


        private void btnHomeMain_Click(object sender, EventArgs e)
        {
            dashBoard1.Visible = true;
            addEmployees1.Visible = false;
            salary1.Visible = false;

            DashBoard dashForm = dashBoard1  as DashBoard;

            if(dashForm != null)
            {
                dashForm.RefreshData();
            }   
        }

        private void btnAddEmployeeMain_Click(object sender, EventArgs e)
        {
            dashBoard1.Visible = false;
            addEmployees1.Visible = true;
            salary1.Visible = false;

            AddEmployees addEmployees = addEmployees1 as AddEmployees;

            if(addEmployees != null)
            {
                addEmployees.RefreshData();
            }
        }
        private void btnSalaryMain_Click(object sender, EventArgs e)
        {
            dashBoard1.Visible = false;
            addEmployees1.Visible = false;
            salary1.Visible = true;

            Salary salary = salary1 as Salary;

            if (salary != null)
            {
                salary.RefreshData();
            }
        }

        
    }
}
