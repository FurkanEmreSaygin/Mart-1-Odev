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
        SellerUi sellerUi = new SellerUi();
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
            else
            {
                l = 0;
            }
            
            if (l == 15)
            {
                while (true)
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("      1.Add Product");
                    Console.WriteLine("      2.Show Products");
                    Console.WriteLine("      3.Exit");
                    Console.WriteLine("-----------------------------");
                    string choice3 = Console.ReadLine();
                    if (choice3 == "1")
                    {
                        controllers.AddProduct();
                    }
                    else if (choice3 == "2")
                    {
                        controllers.ShowProducts();
                    }
                    else if (choice3 == "3")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Try Again!!");
                    }
                }
            }
            else if (l == 10)
            {
                while (true)
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("      1.Show Products");
                    Console.WriteLine("      2.Buy Product");
                    Console.WriteLine("      3.Cart");
                    Console.WriteLine("      4.Exit");
                    Console.WriteLine("-----------------------------");
                    string choice3 = Console.ReadLine();
                    if (choice3 == "1")
                    {
                        controllers.ShowProducts();
                    }
                    else if (choice3 == "2")
                    {
                        controllers.AddToCart();
                    }
                    else if (choice3 == "3")
                    {
                        controllers.ShowCart();
                    }
                    else if (choice3 == "4")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Try Again!!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Try Again!!");
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
