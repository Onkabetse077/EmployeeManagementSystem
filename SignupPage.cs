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
    public partial class SignupPage : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Onkabetse\Documents\Projects\Visual Studio\C#\Employee Management System\Database\Employees\employee.mdf"";Integrated Security=True;Connect Timeout=30");
        public SignupPage()
        {
            InitializeComponent();
        }

        private void SignupPage_Load(object sender, EventArgs e)
        {

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSigninRegister_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }

        private void cbShowPasswordSignup_CheckedChanged(object sender, EventArgs e)
        {
            tbPasswordSignup.PasswordChar = cbShowPasswordSignup.Checked ? '\0' : '*';
        }

        private void btnSignupRegister_Click(object sender, EventArgs e)
        {
           if (tbUsernameSignup.Text == "" || tbPasswordSignup.Text == "")
            {
                MessageBox.Show("Please fill in all fields", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {

                    try
                    {
                        connect.Open();
                        //Check if username already exists
                        string selectUsername = "SELECT COUNT(id) FROM users WHERE username = @username";
                        using (SqlCommand cmd = new SqlCommand(selectUsername, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", tbUsernameSignup.Text.Trim());
                            int count = (int)cmd.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show("Username already exists", "Error Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                DateTime today = DateTime.Today;

                                string insertQuery = "INSERT INTO users (username, password, date_registered) " +
                                    "VALUES (@username, @password,@dateRegistered)";
                                using (SqlCommand cmd2 = new SqlCommand(insertQuery, connect))
                                {
                                    cmd2.Parameters.AddWithValue("@username", tbUsernameSignup.Text.Trim());
                                    cmd2.Parameters.AddWithValue("@password", tbPasswordSignup.Text.Trim());
                                    cmd2.Parameters.AddWithValue("@dateRegistered", today);

                                    cmd2.ExecuteNonQuery();

                                    MessageBox.Show("Account created successfully", "Success Message",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    LoginPage loginPage = new LoginPage();
                                    loginPage.Show();
                                    this.Hide();

                                }
                            }
                        }
                       
                    }
                    catch (Exception ex)
                    {
                            MessageBox.Show(ex.Message, "Error Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }
    }
}
