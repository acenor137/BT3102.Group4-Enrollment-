using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventDriven.Project.Enrollment.Model;

namespace EventDriven.Project.Enrollment.BusinessLogic
{
    internal class UserRepository
    {
        private string CONNECTIONSTRING = "Data Source=DAKI;Initial Catalog=Project1;Integrated Security=True;TrustServerCertificate=True";

        public UserModel ValidateUser (string Username, string Password)
        {
            try
            {
                UserModel matchingUser = new UserModel ();
                using (SqlConnection Enrollment = new SqlConnection(CONNECTIONSTRING)) 
                {
                    Enrollment.Open ();
                    string query = "SELECT * FROM dbo.User WHERE Username = @username AND Password = @password";
                    SqlCommand command = new SqlCommand (query, Enrollment);
                    command.Parameters.AddWithValue ("username", Username);
                    command.Parameters.AddWithValue("password", Password);
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine (ex.ToString());
            }
            return null;


        }
    }
}
