using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventDriven.Project.Enrollment.Model;

namespace EventDriven.Project.Enrollment.BusinessLogic.Controller
{
    public class UserContrroller
    {
        private UserRepository userRepo;

        public UserContrroller()
        {
            userRepo = new UserRepository();
        }
        public List<UserModel> GetUserList()
        {
            return new List<UserModel> { new UserModel() };
        }
        public UserModel ValidateUser(string Username, string Password)
        {
            try
            {
                if (string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(Username))
                {
                    throw new Exception("Password and Username Cannot be empty. Please put your valid credentials");
                }
                else
                {
                    Console.WriteLine("Log in successful");
                }
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return userRepo.ValidateUser(Username, Password);
        }
    }
}
