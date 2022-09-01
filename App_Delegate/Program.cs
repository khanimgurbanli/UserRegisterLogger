using App_Delegate.Models;
using App_Delegate.Service;
using static App_Delegate.Models.Company;
using static App_Delegate.Program;

namespace App_Delegate
{

    public class Program
    {

        public static void Main()
        {
            string name="";
            string surname="";
            string password = "";
            bool again;
            bool Exit=true;


            Company company = new Company();
            while (Exit)
            {
                backname:
                Console.WriteLine("Enter your name");
                name = Console.ReadLine();

                if (string.IsNullOrEmpty(name))
                {
                    again = company.Register(name, surname, password);
                    goto backname;
                }
                backsurname:
                Console.WriteLine("Enter your surname");
                surname = Console.ReadLine(); 
                if (string.IsNullOrEmpty(surname))
                {
                    again = company.Register(name, surname, password);
                    goto backsurname;
                }
                backpassword:
                Console.WriteLine("Enter your password");
                password = Console.ReadLine();
                if (string.IsNullOrEmpty(password))
                {
                    again = company.Register(name, surname, password);
                    goto backpassword; 
                }

                Console.WriteLine("\nFor exit pass to 'Y'");
                var ExitOrContinue = Console.ReadLine();
                if (ExitOrContinue.ToUpper() == "Y")
                    Exit = false;
            }
            Console.WriteLine("Welcome");
        }
    }
}

