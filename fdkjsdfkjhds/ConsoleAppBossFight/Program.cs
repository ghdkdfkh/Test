using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBossFight
{
    class Program
    {
        static void Main(string[] args)
        {
            int money;
            int food;
            int foodunitprice = 10;
            bool isAbletoPay;

            UserInput(out money, out food, foodunitprice);

            isAbletoPay = Buying(ref money, ref food, foodunitprice);
        }

        private static void UserInput(out int money, out int food, int foodunitprice)
        {
            Console.WriteLine("Добро пожаловать в магазин!" +
                 " Сегодня еда по " + foodunitprice + " тенге.");
            Console.WriteLine("Сколько у вас тенге?");
            money = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сколько еды вам нужно?");
            food = Convert.ToInt32(Console.ReadLine());
        }

        private static bool Buying(ref int money, ref int food, int foodunitprice)
        {
            bool isAbletoPay = money >= food * foodunitprice;
            food *= Convert.ToInt32(isAbletoPay);
            money -= food * foodunitprice;
            Console.WriteLine($"У вас в сумке {food} еды, и {money} тенге.");
            return isAbletoPay;
        }
    }
}
