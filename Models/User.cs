using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        private string Password { get; set; } // Encapsulation
        public int UserType { get; set; }

        public string password { get { return "******"; } set { Password = value; } }

        public User() { 
        }   
        public User(string name, string email, string password, int userType)
        {
            Name = name;
            Email = email;
            Password = password;
            UserType = userType;
        }
        public bool CheckPassword(string password)
        {
            return Password == password;
        }
    }
}
