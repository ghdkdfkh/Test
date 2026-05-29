using System;

namespace Test_project
{
    internal class Utilites
    {

        public static void ShowText(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}