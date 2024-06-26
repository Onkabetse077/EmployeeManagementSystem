using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Employee_Management_System
{
    public partial class DashBoard : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Onkabetse\Documents\Projects\Visual Studio\DataBases\Employees\employee.mdf"";Integrated Security=True;Connect Timeout=30");

        public DashBoard()
        {
            InitializeComponent();

            displayTotalEmployees();
            displayActiveEmployees();
            displayInactiveEmployees();
        }

        public void RefreshData()
        {
            if (InvokeRequired) {
                Invoke((MethodInvoker)RefreshData);
                return;
             }
            displayTotalEmployees();
            displayActiveEmployees();
            displayInactiveEmployees();
        }

        public void displayTotalEmployees()
        {
          if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();

                    string selectData = "SELECT COUNT(id) FROM Employee WHERE delete_date IS NULL";

                    using(SqlCommand cmd = new SqlCommand(selectData, connection))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = (int)reader[0];

                            lblTotalEmployeesNumber.Text = count.ToString();
                        }
                        
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message,"Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                finally
                {

                   connection.Close();
                }
          }

        }

        public void displayActiveEmployees()
        {
            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();

                    string selectData = "SELECT COUNT(id) FROM Employee WHERE status = @status AND delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connection))
                    {
                        cmd.Parameters.AddWithValue("@status", "Active");
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = (int)reader[0];

                            lblActiveEmployeesNumber.Text = count.ToString();
                        }

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

        }

        public void displayInactiveEmployees()
        {
            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();

                    string selectData = "SELECT COUNT(id) FROM Employee WHERE status = @status AND delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connection))
                    {
                        cmd.Parameters.AddWithValue("@status", "Inactive");
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = (int)reader[0];

                            lblInactiveEmployeesNumber.Text = count.ToString();
                        }

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

        }
    }
}
