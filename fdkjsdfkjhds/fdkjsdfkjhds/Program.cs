using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdkjsdfkjhds
{
    class Program
    {
        static void Main(string[] args)
        {
            float rubInwallet;
            float dollarsInwallet;
            float euroInwallet;
            int rubToUsd = 60, rubToEuro = 70, usdToRub = 62, usdToEuro = 78, euroToUsd = 80, euroToRub = 72;
            string desiredOperation;
            float exchanceCurrencyCount;

            ShowText("Добро пожаловать в обменник");
            ShowText("Ваш баланс рублей");
            rubInwallet = Convert.ToSingle(Console.ReadLine());
            ShowText("Ваш баланс долларов");
            dollarsInwallet = Convert.ToSingle(Console.ReadLine());
            ShowText("Ваш баланс евро");
            euroInwallet = Convert.ToSingle(Console.ReadLine());

            ShowText("Выберите операцию");
            ShowText("1 - рубли в доллары");
            ShowText("2 - рубли в евро");
            ShowText("3 - доллары в рубли");
            ShowText("4 - доллары в евро");
            ShowText("5 - евро в рубли");
            ShowText("6 - евро в доллары");
            ShowText("Ваш выбор ");

            desiredOperation = Console.ReadLine();
            switch (desiredOperation)
            {
                case "1":
                    exchanceCurrencyCount = RubToUsd(ref rubInwallet, ref dollarsInwallet, rubToUsd);
                    break;
                case "2":
                    exchanceCurrencyCount = RubToEu(ref rubInwallet, ref euroInwallet, rubToEuro);
                    break;
                case "3":
                    exchanceCurrencyCount = UsdToRub(ref rubInwallet, ref dollarsInwallet, usdToRub);
                    break;
                case "4":
                    exchanceCurrencyCount = UsdtoEu(ref dollarsInwallet, ref euroInwallet, usdToEuro);
                    break;
                case "5":
                    exchanceCurrencyCount = EuToRub(ref rubInwallet, ref euroInwallet, euroToRub);
                    break;
                case "6":
                    exchanceCurrencyCount = EuToUsd(ref dollarsInwallet, ref euroInwallet, euroToUsd);
                    break;
                default:
                    Console.WriteLine("Выбрана неверная операция");
                    break;
            }
            Console.WriteLine($"Ваш баланс рублей:{rubInwallet}, евро: {euroInwallet}, долларов: {dollarsInwallet}");






            #region dasd

            //bool Isworking = true;
            //string input;

            //while (Isworking)
            //{
            //    Console.WriteLine("Программа работает");
            //    input = Console.ReadLine();
            //    if (input == "exit")
            //    {
            //        Isworking = false;
            //    }
            //}
            #endregion
        }
        static void ShowText(string text)
        {
            Console.WriteLine();
        }

        private static float UsdtoEu(ref float dollarsInwallet, ref float euroInwallet, int usdToEuro)
        {
            float exchanceCurrencyCount;
            Console.WriteLine("Обмен долларов на евро");
            Console.Write("Сколько вы хотите обменять?");
            exchanceCurrencyCount = Convert.ToSingle(Console.ReadLine());
            if (dollarsInwallet >= exchanceCurrencyCount)
            {
                dollarsInwallet -= exchanceCurrencyCount;
                euroInwallet += exchanceCurrencyCount / usdToEuro;
            }
            else
            {
                Console.WriteLine("Недопустимое значение");
            }

            return exchanceCurrencyCount;
        }

        private static float EuToRub(ref float rubInwallet, ref float euroInwallet, int euroToRub)
        {
            float exchanceCurrencyCount;
            Console.WriteLine("Обмен евро на рубли");
            Console.Write("Сколько вы хотите обменять?");
            exchanceCurrencyCount = Convert.ToSingle(Console.ReadLine());
            if (euroInwallet >= exchanceCurrencyCount)
            {
                euroInwallet -= exchanceCurrencyCount;
                rubInwallet += exchanceCurrencyCount * euroToRub;
            }
            else
            {
                Console.WriteLine("Недопустимое значение");
            }

            return exchanceCurrencyCount;
        }

        private static float EuToUsd(ref float dollarsInwallet, ref float euroInwallet, int euroToUsd)
        {
            float exchanceCurrencyCount;
            Console.WriteLine("Обмен евро на доллары");
            Console.Write("Сколько вы хотите обменять?");
            exchanceCurrencyCount = Convert.ToSingle(Console.ReadLine());
            if (euroInwallet >= exchanceCurrencyCount)
            {
                euroInwallet -= exchanceCurrencyCount;
                dollarsInwallet += exchanceCurrencyCount / euroToUsd;
            }
            else
            {
                Console.WriteLine("Недопустимое значение");
            }

            return exchanceCurrencyCount;
        }

        private static float UsdToRub(ref float rubInwallet, ref float dollarsInwallet, int usdToRub)
        {
            float exchanceCurrencyCount;
            Console.WriteLine("Обмен долларов на рубли");
            Console.Write("Сколько вы хотите обменять?");
            exchanceCurrencyCount = Convert.ToSingle(Console.ReadLine());
            if (dollarsInwallet >= exchanceCurrencyCount)
            {
                dollarsInwallet -= exchanceCurrencyCount;
                rubInwallet += exchanceCurrencyCount * usdToRub;
            }
            else
            {
                Console.WriteLine("Недопустимое значение");
            }

            return exchanceCurrencyCount;
        }

        private static float RubToEu(ref float rubInwallet, ref float euroInwallet, int rubToEuro)
        {
            float exchanceCurrencyCount;
            Console.WriteLine("Обмен рублей на евро");
            Console.Write("Сколько вы хотите обменять?");
            exchanceCurrencyCount = Convert.ToSingle(Console.ReadLine());
            if (rubInwallet >= exchanceCurrencyCount)
            {
                rubInwallet -= exchanceCurrencyCount;
                euroInwallet += exchanceCurrencyCount / rubToEuro;
            }
            else
            {
                Console.WriteLine("Недопустимое значение");
            }

            return exchanceCurrencyCount;
        }

        private static float RubToUsd(ref float rubInwallet, ref float dollarsInwallet, int rubToUsd)
        {
            float exchanceCurrencyCount;
            Console.WriteLine("Обмен рублей на доллары");
            Console.Write("Сколько вы хотите обменять?");
            exchanceCurrencyCount = Convert.ToSingle(Console.ReadLine());
            if (rubInwallet >= exchanceCurrencyCount)
            {
                rubInwallet -= exchanceCurrencyCount;
                dollarsInwallet += exchanceCurrencyCount / rubToUsd;
            }
            else
            {
                Console.WriteLine("Недопустимое значение");
            }

            return exchanceCurrencyCount;
        }
    }
}
