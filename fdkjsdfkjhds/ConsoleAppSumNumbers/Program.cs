using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSumNumbers
{
    //2.4) ДЗ: Сумма чисел
    //С помощью Random получить число number, которое не больше 100. 
    //Найти сумму всех положительных чисел меньше number(включая число), которые кратные 3 или 5.
    //(К примеру, это числа 3, 5, 6, 9, 10, 12, 15 и т.д.)
    class Program
    {
        static void Main(string[] args)
        {
            int tgt_1 = 3;
            int tgt_2 = 5;

            int sumNumbersResult_1;
            int sumNumbersResult_2 = 0;


            Random rand = new Random();
            int randomNumber = rand.Next(1, 25);
            Console.WriteLine($"randomNumber = {randomNumber}\n");

            sumNumbersResult_1 = SumMultiplesNums(tgt_1, randomNumber, ConsoleColor.Yellow);
            Console.WriteLine();
            sumNumbersResult_2 = SumMultiplesNums(tgt_2, randomNumber, ConsoleColor.Cyan);

            Console.WriteLine($"\nСумма чисел кратных {tgt_1} = {sumNumbersResult_1}");
            Console.WriteLine($"Сумма чисел кратных {tgt_2} = {sumNumbersResult_2}");

            //for (int i = 0; i < randomNumber; i++)
            //{
            //    Console.WriteLine($"i = {i}");
            //    var currentNum = i + 1;
            //    Console.WriteLine($"currentNum = {currentNum}");
            //    Console.WriteLine();

            //    if (true)
            //    {

            //    }
            //}
            //while (randomNumber>0)
            //{
            //    if (true)
            //    {

            //    }

            //}
            Console.ReadKey();
        }

        private static int SumMultiplesNums(int tgt, int randomNumber, ConsoleColor color)
        {
            int sumNumbers = 0;
            var iteration = randomNumber / tgt;
            int sumNumbersResult = 0;

            for (int i = 0; i < iteration; i++)
            {
                sumNumbers = sumNumbers + tgt;
                sumNumbersResult += sumNumbers;
                var n = i + 1;
                Console.ForegroundColor = color;
                Console.WriteLine($"число №{n} - " + sumNumbers);
                Console.ResetColor();
            }

            return sumNumbersResult;
        }
    }
}
