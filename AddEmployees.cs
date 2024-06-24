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
using System.IO;

namespace Employee_Management_System
{
    public partial class AddEmployees : UserControl
    {

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Onkabetse\Documents\Projects\Visual Studio\DataBases\Employees\employee.mdf"";Integrated Security=True;Connect Timeout=30");
        public AddEmployees()
        {
            InitializeComponent();

            displayEmployeeData();
        }

        public void displayEmployeeData()
        {
            EmployeesData employeeData = new EmployeesData();
            List<EmployeesData> employeesList = employeeData.employeesListData();

            dgvEmployeesData.DataSource = employeesList;
        }   

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblFullNames_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbEmployeeID.Text == "" || tbFullNames.Text == ""
                || tbPhoneNumbers.Text == "" || cbGender.Text == "" ||
                cbStatus.Text == "" || cbPosition.Text == "" || pbAddEmployees.Image == null)
            {
                MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connection.State == ConnectionState.Closed)
                {
                    try
                    {
                        connection.Open();

                        string checkEmployeeID = "SELECT * FROM Employees WHERE employee_id = @employee_id";

                        using (SqlCommand checkEmployeeIDs= new SqlCommand(checkEmployeeID, connection))
                        {
                            int count = (int)checkEmployeeIDs.ExecuteScalar();

                            if (count >= 1)
                            {

                                MessageBox.Show(lblEmployeeID.Text.Trim() + " Employee ID already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else { 
                                string insertData = "INSERT INTO Employees(employee_id, full_name,gender,phone_number," +
                                    "position,image,insert_date,status) VALUES(@employee_id, @full_name, @gender, " +
                                    "@phone_number, @position, @image,insert_date ,@status)";

                                string path = Path.Combine(@"C:\Users\Onkabetse\Documents\Projects\Visual Studio\C#\Employee Management System\Pictures\" 
                                                            + tbEmployeeID.Text.Trim() + ".jpg");

                                string picturePath = Path.GetDirectoryName(path);

                                if(!Directory.Exists(picturePath))
                                {
                                    Directory.CreateDirectory(picturePath);
                                }

                                File.Copy(pbAddEmployees.ImageLocation, path, true);
                                
                                using(SqlCommand cmd = new SqlCommand(insertData, connection))
                                {
                                    cmd.Parameters.AddWithValue("@employee_id", tbEmployeeID.Text.Trim());
                                    cmd.Parameters.AddWithValue("@full_name", tbFullNames.Text.Trim());
                                    cmd.Parameters.AddWithValue("@gender", cbGender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@phone_number", tbPhoneNumbers.Text.Trim());
                                    cmd.Parameters.AddWithValue("@position", cbPosition.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image", path);
                                    cmd.Parameters.AddWithValue("@insert_date", DateTime.Today);
                                    cmd.Parameters.AddWithValue("@status", cbStatus.Text.Trim());

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Employee added successfully", "Success",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);    


                                }
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                       connection.Close();
                    }
                }
                
            }
            
        }
        
    }
    
}

