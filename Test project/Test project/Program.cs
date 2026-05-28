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
            string input;

            Console.WriteLine("Введите ваше имя");
            input = Console.ReadLine();

            Console.WriteLine($"Ваше имя {input}");
            Console.ReadKey();
        }
    }
}
