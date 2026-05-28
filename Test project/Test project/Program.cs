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
            string userName;

            userName = EnterUserName();
            PasswordInput(Password, userName);
        }

        private static string EnterUserName()
        {
            string input;
            Console.WriteLine("Введите ваше имя");
            input = Console.ReadLine();

            Console.WriteLine($"\nВаше имя {input}");
            return input;
        }

        private static void PasswordInput(string Password, string userName)
        {
            int tryiescount = 3;
            string passwordInput = null;

            while (passwordInput != Password && tryiescount > 0)
            {
                tryiescount--;
                Console.WriteLine("Введите пароль:");
                passwordInput = Console.ReadLine();

                ShowAuthMessage(Password, passwordInput, userName, tryiescount);
            }
        }

        private static void ShowAuthMessage(string Password, string passwordInput, string input, object tryiescount)
        {
            if (passwordInput == Password)
                Console.WriteLine("Password.OK");
            else
                Console.WriteLine($">>> Пользователь {input}, Password.IS_NOT_OK !!!! осталось {tryiescount} попыток <<<");
        }
    }
}
