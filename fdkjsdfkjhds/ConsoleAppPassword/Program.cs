using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            int tryCount = 3;
            string password = "adsa";
            string userInput;
            userInput = CheckingPassword(tryCount, password);
        }

        private static string CheckingPassword(int tryCount, string password)
        {
            string userInput;
            for (int i = 0; i < tryCount; i++)
            {
                Console.WriteLine("Введите пароль");
                userInput = Console.ReadLine();
                if (userInput == password)
                {
                    Console.WriteLine("Введен правильный пароль");
                    Console.WriteLine("=D");
                    break;
                }
                else
                {
                    Console.WriteLine("Введен неправильный пароль");
                    Console.WriteLine("У вас осталось " + (tryCount - i - 1) + " попыток");
                }
            }

            return userInput=Console.ReadLine();
        }
    }
}
