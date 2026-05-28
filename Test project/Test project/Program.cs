using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_project
{
    class Program
    {
        static void Main(string[] args)
        {
            UserAuthorise();

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }

        private static void UserAuthorise()
        {
            const string Password = "hu";
            int tryiescount = 3;
            string passwordInput = null;
            string userName;

            userName = EnterUserName();

            PasswordInput(Password, ref tryiescount, ref passwordInput, userName);
        }

        private static void PasswordInput(string Password, ref int tryiescount, ref string passwordInput, string userName)
        {
            while (passwordInput != Password && tryiescount > 0)
            {
                tryiescount--;
                Console.WriteLine("Введите пароль:");
                passwordInput = Console.ReadLine();

                ShowAuthMessage(Password, passwordInput, userName, tryiescount);
            }
        }

        private static string EnterUserName()
        {
            string input;
            Console.WriteLine("Введите ваше имя");
            input = Console.ReadLine(); 

            Console.WriteLine($"\nВаше имя {input}");
            return input;
        }

        private static void ShowAuthMessage(string Password, string passwordInput, string input, object tryiescount)
        {
            if (passwordInput == Password)
                Console.WriteLine("Password.OK");
            else
                Console.WriteLine($">>> {input}, Password.IS_NOT_OK !!!! осталось {tryiescount} попыток <<<");
        }
    }
}
