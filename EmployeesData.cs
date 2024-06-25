using Microsoft.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;

// In SDK-style projects such as this one, several assembly attributes that were historically
// defined in this file are now automatically added during build and populated with
// values defined in project properties. For details of which attributes are included
// and how to customise this process see: https://aka.ms/assembly-info-properties


// Setting ComVisible to false makes the types in this assembly not visible to COM
// components.  If you need to access a type in this assembly from COM, set the ComVisible
// attribute to true on that type.

[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM.

[assembly: Guid("98939a6e-b461-49bc-bc85-b3ef71583e4b")]

namespace Employee_Management_System
{
    public class EmployeesData
    {

        public int ID { set; get; } 
        public string EmployeeID { set; get; }
        public string FullNames { set; get; }
        public string Gender { set; get; }
        public string PhoneNumbers { set; get; }
        public string Position { set; get; }
        public string Image { set; get; }
        public int Salary { set; get; }
        public string Status { set; get; }


        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Onkabetse\Documents\Projects\Visual Studio\DataBases\Employees\employee.mdf"";Integrated Security=True;Connect Timeout=30");

        public List<EmployeesData> employeesListData()
        {
            List<EmployeesData> employeesList = new List<EmployeesData>();

            if(connection.State != ConnectionState.Open)
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
                            EmployeesData employeeData = new EmployeesData();

                            employeeData.ID = (int)reader["id"];
                            employeeData.EmployeeID = reader["employee_id"].ToString();
                            employeeData.FullNames = reader["full_name"].ToString();
                            employeeData.Gender = reader["gender"].ToString();
                            employeeData.PhoneNumbers = reader["phone_number"].ToString();
                            employeeData.Position = reader["position"].ToString();
                            employeeData.Image = reader["image"].ToString();
                            employeeData.Salary = (int)reader["salary"];
                            employeeData.Status = reader["status"].ToString();

                            employeesList.Add(employeeData);

                        }
                    }
                }
                catch (Exception ex) {

                    Console.WriteLine("Error: " + ex.Message);

                }
                finally
                {
                    connection.Close();
                }
            }
            return employeesList;
        }

        public List<EmployeesData> salaryEmployeesListData()
        {
            List<EmployeesData> employeesList = new List<EmployeesData>();

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
                            EmployeesData employeeData = new EmployeesData();

                            employeeData.EmployeeID = reader["employee_id"].ToString();
                            employeeData.FullNames = reader["full_name"].ToString();
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