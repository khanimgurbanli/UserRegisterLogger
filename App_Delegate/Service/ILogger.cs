using App_Delegate.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Delegate.Service
{

    public interface ILogger
    {
        void SetLogger(string log);
    }
    public delegate void RegisterErrorLogg(string message);
    public class RegisterErrorLogger : ILogger
    {
        public void SetLogger(string log)
        {
            Console.WriteLine($"Null Name  -> {log}");
        }
        public void NameErrorLogger(string log)
        {
            Console.WriteLine($"Name input is null -> {log}");
        }
        public void SurnameErrorLogger(string log)
        {
            Console.WriteLine($"Surname input is null -> {log}");
        }
        public void PasswordErrorLogger(string log)
        {
            Console.WriteLine($"Password format is invalid -> {log}"); ;
        }
    }
}
