using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Employee_Management_System
{
    class SalaryData
    {
        public string EmployeeID { set; get; }
        public string FullNames { set; get; }
        public string Gender { set; get; }
        public string PhoneNumbers { set; get; }
        public string Position { set; get; }
        public int Salary { set; get; }


        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Onkabetse\Documents\Projects\Visual Studio\C#\Employee Management System\Database\Employees\employee.mdf"";Integrated Security=True;Connect Timeout=30");

        public List<SalaryData> salaryEmployeesListData()
        {
            List<SalaryData> employeesList = new List<SalaryData>();

            if (connection.State != ConnectionState.Open)
            {
                try
                {

                    connection.Open();

                    string selectData = "SELECT * FROM Employee WHERE delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connection))
                    {

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            SalaryData employeeData = new SalaryData();

                            employeeData.EmployeeID = reader["employee_id"].ToString();
                            employeeData.FullNames = reader["full_name"].ToString();
                            employeeData.Gender = reader["gender"].ToString();
                            employeeData.PhoneNumbers = reader["phone_number"].ToString();
                            employeeData.Position = reader["position"].ToString();
                            employeeData.Salary = (int)reader["salary"];


                            employeesList.Add(employeeData);

                        }
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Error: " + ex.Message);

                }
                finally
                {
                    connection.Close();
                }
            }
            return employeesList;
        }
    }
}
