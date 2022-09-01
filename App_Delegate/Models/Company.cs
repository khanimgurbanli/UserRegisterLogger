using App_Delegate.Service;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static App_Delegate.Program;

namespace App_Delegate.Models
{
    public class Company
    {
        public delegate bool RegisterLogger(string name, string surname, string password);
        public int Id { get; set; }
        public static int Counter { get; set; }
        public string Name { get; set; }
        public bool Register(string name, string surname, string password)
        {
            RegisterErrorLogger nullNameLogger = new RegisterErrorLogger();
            RegisterErrorLogg registerErrorLogg = new RegisterErrorLogg(nullNameLogger.NameErrorLogger);
            RegisterErrorLogg registerErrorLogg2 = new RegisterErrorLogg(nullNameLogger.SurnameErrorLogger);
            RegisterErrorLogg registerErrorLogg3 = new RegisterErrorLogg(nullNameLogger.PasswordErrorLogger);

            List<User> CompanyUserList2 = new List<User>();

            Regex regex = new(@"^^(?=.*?\d).{8}");
            Match match = regex.Match(password.ToString());

            if (string.IsNullOrEmpty(name))
            {
                registerErrorLogg.Invoke("Name is not valid ");
                return false;
            }
            if (string.IsNullOrEmpty(surname))
            {
                registerErrorLogg2.Invoke("Surname is not valid ");
                return false;
            }
            if (!match.Success)
            {
                registerErrorLogg3.Invoke("Password is not valid ");
                return false;
            }
            CompanyUserList2.Add(new User { _id = Counter++, _name = Name, _surname = surname, _password = password });

            return true;
        }
    }
}
