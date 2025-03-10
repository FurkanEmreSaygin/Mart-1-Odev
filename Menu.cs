using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret
{
    public class Menu
    {  
        Controllers controllers = new Controllers();
        public int MenuProcess() {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("      1.Customer");
            Console.WriteLine("      2.Seller");
            Console.WriteLine("-----------------------------");
            string choice2 = Console.ReadLine();
            switch (choice2)
            {
                case "1":
                    Console.WriteLine("");
                    LoginMenuProcess(1);
                    return 2;

                case "2":
                    Console.WriteLine("");
                    LoginMenuProcess(2);
                    return 2;

                default:
                    Console.WriteLine("Try Again!!");
                    return 1;
            }
        }

        public void SignUpMenuProcess(int choice) {
            Console.WriteLine("-----------------------------");
            
            Console.Write("Name:  ");
            string name = Console.ReadLine();
            
            Console.Write("EMail:  ");
            string email = Console.ReadLine();
            
            Console.Write("Password: ");
            string password = Console.ReadLine();
            
            if (choice == 1)
            {
                Console.WriteLine("Age:  ");
                int age = Convert.ToInt32(Console.ReadLine());
                controllers.AddUser(name,email,password,age);
            }
            else if (choice == 2)
            {
                Console.Write("TaxID:  ");
                string taxId = Console.ReadLine();
                Console.Write("Location:  ");
                string location = Console.ReadLine();
                controllers.AddUser(name,email,password,taxId,location);
            }
            


        }
        public void LoginMenuProcess(int choice)
        {
            int l;
            Console.WriteLine("-----------------------------");
            Console.Write("EMail:  ");
            string email = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            if (choice == 1)
            {
                l = controllers.CheckUser(email, password, 1);
            }
            else if (choice == 2)
            {
                l = controllers.CheckUser(email, password, 2);
            }

        }
        public int UserChoiceProcess()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("      1.Customer");
            Console.WriteLine("      2.Seller");
            Console.WriteLine("-----------------------------");
            string choice2 = Console.ReadLine();
            switch (choice2)
            {
                case "1":
                    Console.WriteLine("");
                    SignUpMenuProcess(1);
                    return 2;
                    
                case "2":
                    Console.WriteLine("");
                    SignUpMenuProcess(2);
                    return 2;
                    
                default:
                    Console.WriteLine("Try Again!!");
                    return 1;
            }
            
        }
    }
}
