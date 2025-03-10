using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Models
{
    class Customer : User
    {
        public int Age { get; set; }
        public Customer(string name, string email, string password, int usertype,int age) : base(name, email, password, usertype)
        {
            Age = age;
            
        }
    }

}
