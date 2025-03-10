using Eticaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret
{
    public class Controllers
    {
        
        List<Customer> users = new List<Customer>();
        List<Seller> user = new List<Seller>();
        public void AddUser(string name, string email, string password, int age)
        {
            Customer customer = new Customer(name, email, password, 1, age);
            users.Add(customer);
            Console.WriteLine("Kullanıcı eklendi");

        }
        public void AddUser(string name, string email, string password, string taxId, string location)
        {

            Seller seller = new Seller(name, email, password, 2, taxId, location);
            user.Add(seller);
            Console.WriteLine("Kullanıcı eklendi");
        }

        public int CheckUser(string email, string password, int type)
        {

            if (type == 1)
            {
                Customer FoundCustomer = users.FirstOrDefault(x => x.Email == email && x.CheckPassword(password));
                if (FoundCustomer != null)
                {
                    Console.WriteLine("Login Successfull!!");
                    return 1;
                }
                else
                {
                    Console.WriteLine("Invalid EMail or Password");
                    return 0;

                }
            }
            else if (type == 2)
            {
                Seller FoundSeller = user.FirstOrDefault(a => a.Email == email && a.CheckPassword(password));
                if (FoundSeller != null)
                {
                    Console.WriteLine("Login Successfull!!");
                    return 1;
                }
                else
                {
                    Console.WriteLine("Invalid EMail or Password");
                    return 0;

                }
            }
            else
            {
                return 0;
            }
        }
    }
}
