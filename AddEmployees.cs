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

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
                
            }
            displayEmployeeData();
        }
        public void displayEmployeeData()
        {
            EmployeesData employeeData = new EmployeesData();
            List<EmployeesData> employeeList = employeeData.employeesListData();

            dgvEmployeesData.DataSource = employeeList;
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

                        string checkEmployeeID = "SELECT COUNT(*) FROM Employee WHERE employee_id = @employee_id AND delete_date IS NULL";

                        using (SqlCommand checkEmployeeIDs = new SqlCommand(checkEmployeeID, connection))
                        {
                            checkEmployeeIDs.Parameters.AddWithValue("@employee_id", tbEmployeeID.Text.Trim());
                            int count = (int)checkEmployeeIDs.ExecuteScalar();

                            if (count >= 1)
                            {

                                MessageBox.Show(lblEmployeeID.Text.Trim() + " Employee ID already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO Employee(employee_id, full_name,gender,phone_number," +
                                    "position,image,salary,insert_date,status) VALUES(@employee_id, @full_name, @gender, " +
                                    "@phone_number, @position, @image,@salary,@insert_date ,@status)";

                                string path = Path.Combine(@"C:\Users\Onkabetse\Documents\Projects\Visual Studio\C#\Employee Management System\Pictures\"
                                                            + tbEmployeeID.Text.Trim() + ".jpg");

                                string picturePath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(picturePath))
                                {
                                    Directory.CreateDirectory(picturePath);
                                }

                                File.Copy(pbAddEmployees.ImageLocation, path, true);

                                using (SqlCommand cmd = new SqlCommand(insertData, connection))
                                {
                                    cmd.Parameters.AddWithValue("@employee_id", tbEmployeeID.Text.Trim());
                                    cmd.Parameters.AddWithValue("@full_name", tbFullNames.Text.Trim());
                                    cmd.Parameters.AddWithValue("@gender", cbGender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@phone_number", tbPhoneNumbers.Text.Trim());
                                    cmd.Parameters.AddWithValue("@position", cbPosition.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image", path);
                                    cmd.Parameters.AddWithValue("@salary", 0);
                                    cmd.Parameters.AddWithValue("@insert_date", DateTime.Today);
                                    cmd.Parameters.AddWithValue("@status", cbStatus.Text.Trim());

                                    cmd.ExecuteNonQuery();

                                    displayEmployeeData();

                                    MessageBox.Show("Employee added successfully", "Success",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();

                                }
                            }
                        }
                    }
                    catch (Exception ex)
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

        private void btnImport_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();

                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pbAddEmployees.Image = Image.FromFile(dialog.FileName);
                    pbAddEmployees.ImageLocation = dialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvEmployeesData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvEmployeesData.Rows[e.RowIndex];
                tbEmployeeID.Text = row.Cells[1].Value.ToString();
                tbFullNames.Text = row.Cells[2].Value.ToString();
                cbGender.Text = row.Cells[3].Value.ToString();
                tbPhoneNumbers.Text = row.Cells[4].Value.ToString();
                cbPosition.Text = row.Cells[5].Value.ToString();
                pbAddEmployees.ImageLocation = row.Cells[6].Value.ToString();
                if (pbAddEmployees.ImageLocation != null)
                {
                    pbAddEmployees.Image = Image.FromFile(pbAddEmployees.ImageLocation);
                }
                else
                {

                    pbAddEmployees.Image = null;
                }

                cbStatus.Text = row.Cells[8].Value.ToString();

            }
        }

        public void clearFields()
        {
            tbEmployeeID.Text = "";
            tbFullNames.Text = "";
            cbGender.SelectedIndex = -1;
            tbPhoneNumbers.Text = "";
            cbPosition.SelectedIndex = -1;
            cbStatus.SelectedIndex = -1;
            pbAddEmployees.Image = null;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (tbEmployeeID.Text == "" || tbFullNames.Text == ""
                || tbPhoneNumbers.Text == "" || cbGender.Text == "" ||
                cbStatus.Text == "" || cbPosition.Text == "" || pbAddEmployees.Image == null)
            {
                MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                DialogResult confirm = MessageBox.Show("Are you sure you want to update this employee?", "Employee ID: " +
                    tbEmployeeID.Text.Trim(), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {

                    try
                    {
                        connection.Open();

                        string updateData = "UPDATE Employee SET full_name = @fullName,gender= @gender,phone_number = @phone_number," +
                            "position = @position,image = @image,salary = @salary,update_date = @update_date,status = @status WHERE employee_id = @employee_id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connection))
                        {
                            cmd.Parameters.AddWithValue("@fullName", tbFullNames.Text.Trim());
                            cmd.Parameters.AddWithValue("@gender", cbGender.Text.Trim());
                            cmd.Parameters.AddWithValue("@phone_number", tbPhoneNumbers.Text.Trim());
                            cmd.Parameters.AddWithValue("@position", cbPosition.Text.Trim());
                            cmd.Parameters.AddWithValue("@image", pbAddEmployees.ImageLocation);
                            cmd.Parameters.AddWithValue("@salary", 0);
                            cmd.Parameters.AddWithValue("@update_date", DateTime.Today);
                            cmd.Parameters.AddWithValue("@status", cbStatus.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayEmployeeData();

                            MessageBox.Show("Employee Updated successfully", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {

                        connection.Close();
                    }
                }
                else
                {

                    MessageBox.Show("Employee not updated", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (tbEmployeeID.Text == "" || tbFullNames.Text == ""
                || tbPhoneNumbers.Text == "" || cbGender.Text == "" ||
                cbStatus.Text == "" || cbPosition.Text == "" || pbAddEmployees.Image == null)
            {
                MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this employee?", "Employee ID: " +
                    tbEmployeeID.Text.Trim(), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {

                    try
                    {
                        connection.Open();

                        string updateData = "UPDATE Employee SET delete_date = @delete_date WHERE employee_id = @employee_id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connection))
                        {
                            
                            cmd.Parameters.AddWithValue("@delete_date", DateTime.Today);
                            cmd.Parameters.AddWithValue("@employee_id", tbEmployeeID.Text.Trim());  

                            cmd.ExecuteNonQuery();

                            displayEmployeeData();

                            MessageBox.Show("Employee removed successfully", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {

                        connection.Close();
                    }
                }
                else
                {

                    MessageBox.Show("Employee not removed", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
    }

}

