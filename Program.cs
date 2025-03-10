using Eticaret;
using Eticaret.Models;

class Program()
{
    public static void Main(String[] args)
    {
          
        Menu menu = new Menu();   
        
        int i = 1;
        while(i==1)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("  Welcome to the JungleStore");
            Console.WriteLine("         1.SignIn");
            Console.WriteLine("         2.SignUp");
            Console.WriteLine("         3.Exit");
            Console.WriteLine("-----------------------------");
            string choice = Console.ReadLine();
            
            switch (choice) // Switch case for user choice
            {
                case "1": // Sign in
                    
                    int c = 1;
                    while (c==1)
                    {
                        c= menu.MenuProcess();
                    }
                    break;

                case "2": // Sign up
                    int a = 1;
                    while (a == 1)
                    {
                        a = menu.UserChoiceProcess();
                    }
                    break;

                case "3": // Exit
                    i= 2; 
                    break;

                default: // Invalid choice
                    Console.WriteLine("Invalid choice. Please try again (You can use '1,2')");
                    break;

            }
        }
    }
}