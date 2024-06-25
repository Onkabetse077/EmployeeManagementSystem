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
    public partial class Salary : UserControl
    {
        public Salary()
        {
            InitializeComponent();

            displayData();
        }

        public void displayData()
        {
            EmployeesData employeesData = new EmployeesData();
            List<EmployeesData> employeesList = employeesData.salaryEmployeesListData();

            dgvEmployeesData.DataSource = employeesList;
            
        }
        private void btnUpdateSalary_Click(object sender, EventArgs e)
        {

        }
    }
}
