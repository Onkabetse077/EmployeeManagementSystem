using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Employee_Management_System
{
    public partial class Salary : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Onkabetse\Documents\Projects\Visual Studio\DataBases\Employees\employee.mdf"";Integrated Security=True;Connect Timeout=30");

        public Salary()
        {
            InitializeComponent();

            displayData();
            disableFields();
        }

        public void disableFields()
        {
            tbEmployeeIDSalary.Enabled = false;
            tbFullNamesSalary.Enabled = false;
            tbPositonSalary.Enabled = false;
        }

        public void displayData()
        {
            SalaryData employeesData = new SalaryData();
            List<SalaryData> employeesList = employeesData.salaryEmployeesListData();

            dgvEmployeesData.DataSource = employeesList;

        }

        public void clearFields()
        {
            tbEmployeeIDSalary.Text = "";
            tbFullNamesSalary.Text = "";
            tbPositonSalary.Text = "";
            tbSalarySalary.Text = "";
        }
        private void btnUpdateSalary_Click(object sender, EventArgs e)
        {
            if (tbEmployeeIDSalary.Text == "" || tbFullNamesSalary.Text == "" || tbPositonSalary.Text == "" || tbSalarySalary.Text == "")
            {
                MessageBox.Show("Please select a record to update", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update this EmployeeID: " +
                    tbEmployeeIDSalary.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        try
                        {
                            connection.Open();

                            string updateData = "UPDATE Employee SET salary = @salary,update_date = @updateDate WHERE employee_id = @employee_id";

                            using (SqlCommand cmd = new SqlCommand(updateData, connection))
                            {
                                cmd.Parameters.AddWithValue("@salary", tbSalarySalary.Text.Trim());
                                cmd.Parameters.AddWithValue(updateData, DateTime.Today);
                                cmd.Parameters.AddWithValue("@employee_id", tbEmployeeIDSalary.Text.Trim());


                                cmd.ExecuteNonQuery();
                                displayData();

                                MessageBox.Show("EmployeeID: " + tbEmployeeIDSalary.Text.Trim() + " has been updated successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Update Cancelled", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }


            }
        }

        private void dgvEmployeesData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvEmployeesData.Rows[e.RowIndex];
                tbEmployeeIDSalary.Text = row.Cells[0].Value.ToString();
                tbFullNamesSalary.Text = row.Cells[1].Value.ToString();
                tbPositonSalary.Text = row.Cells[4].Value.ToString();
                tbSalarySalary.Text = row.Cells[5].Value.ToString();


            }
        }

        private void btnClearSalary_Click(object sender, EventArgs e)
        {
            clearFields();  
        }
    }
}
