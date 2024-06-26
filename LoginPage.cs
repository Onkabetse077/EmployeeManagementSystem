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
    public partial class LoginPage : Form
    {
       SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Onkabetse\Documents\Projects\Visual Studio\C#\Employee Management System\Database\Employees\employee.mdf"";Integrated Security=True;Connect Timeout=30");
        public LoginPage()
        {
            InitializeComponent();
        }


        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (tbUsernameLogin.Text == "" || tbPasswordLogin.Text == "")
            {
                MessageBox.Show("Please fill in all fields", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed) {
                    try
                    {
                        connect.Open();
                        String selectUser = "SELECT * FROM Users WHERE Username =  @username " + "AND Password = @password";

                        using(SqlCommand cmd = new SqlCommand(selectUser, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", tbUsernameLogin.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", tbPasswordLogin.Text.Trim());

                           SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Login Successful", "Success Message",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                               
                                Main main = new Main();
                                main.Show();
                                this.Hide();

                            }
                            else
                            {
                                MessageBox.Show("Invalid Username or Password", "Error Message",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {

                        connect.Close();
                    }
                }
                
            }
        }

        private void btnSignupLogin_Click(object sender, EventArgs e)
        {
            SignupPage signupPage = new SignupPage();
            signupPage.Show();
            this.Hide();
        }

        private void cbShowPasswordLogin_CheckedChanged(object sender, EventArgs e)
        {
            tbPasswordLogin.PasswordChar = cbShowPasswordLogin.Checked ? '\0' : '*';
        }
    }
}
