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

        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public string FullNames { get; set; }
        public string Gender { get; set; }
        public string PhoneNumbers { get; set; }
        public string Position { get; set; }
        public string Image { get; set; }
        public int Salary { get; set; }
        public string Status { get; set; }
        


        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Onkabetse\Documents\Projects\Visual Studio\DataBases\Employees\employee.mdf"";Integrated Security=True;Connect Timeout=30");

        public List<EmployeesData> employeesListData()
        {
            List<EmployeesData> employeesList = new List<EmployeesData>();

            if(connection.State != ConnectionState.Open)
            {
                try
                {

                    connection.Open();
                    
                    string selectData = "SELECT * FROM Employees WHERE delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connection))
                    {

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            EmployeesData employeesData = new EmployeesData();

                            employeesData.ID = Convert.ToInt32(reader["id"]);
                            employeesData.EmployeeID = Convert.ToInt32(reader["employee_id"]);
                            employeesData.FullNames = reader["full_name"].ToString();
                            employeesData.Gender = reader["gender"].ToString();
                            employeesData.PhoneNumbers = reader["phone_number"].ToString();
                            employeesData.Position = reader["position"].ToString();
                            employeesData.Image = reader["image"].ToString();
                            employeesData.Salary = Convert.ToInt32(reader["salary"]);
                            employeesData.Status = reader["tatus"].ToString();

                            employeesList.Add(employeesData);

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
    }
}