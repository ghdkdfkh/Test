using System;

namespace Test_project
{
    internal  class Authoriser
    {
        public  void UserAuthorise()
        {
            //const string Password = "hu";
            string userName;

            userName = EnterUserName();
            PasswordInput(AllConstants.Password, userName);
            //PasswordInput(Password, userName);
        }

        //==================================
        private  string EnterUserName()
        {
            string input;
            Console.WriteLine("Введите ваше имя");
            input = Console.ReadLine();

            Console.WriteLine($"\nВаше имя {input}");
            return input;
        }

        private  void PasswordInput(string Password, string userName)
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

        private  void ShowAuthMessage(string Password, string passwordInput, string input, object tryiescount)
        {
            if (passwordInput == Password)
                Utilites.ShowText("Password.OK", ConsoleColor.Green);
            else
                Utilites.ShowText($">>> Пользователь {input}, Password.IS_NOT_OK !!!! осталось {tryiescount} попыток <<<"
                    , ConsoleColor.Red);
        }
    }
}