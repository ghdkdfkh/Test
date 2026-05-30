using System;

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
            int tgt_3 = 3;
            int tgt_5 = 5;

            Random rand = new Random();
            int randomNumber = rand.Next(1, 25);
            Console.WriteLine($"randomNumber = {randomNumber}\n");

            #region Простой способ решения
            //sumNumbersResult_1 = SumMultiplesNums(tgt_1, randomNumber, ConsoleColor.Yellow);
            //Console.WriteLine();
            //sumNumbersResult_2 = SumMultiplesNums(tgt_2, randomNumber, ConsoleColor.Cyan);
            #endregion

            #region Другой способ решения
            var sumNumbersResult_1 = AlterSumMultiplesNums(randomNumber, tgt_3, ConsoleColor.Yellow);
            Console.WriteLine();
            var sumNumbersResult_2 = AlterSumMultiplesNums(randomNumber, tgt_5, ConsoleColor.Cyan);

            Console.WriteLine("\n==================");
            Console.WriteLine($"\nСумма чисел кратных {tgt_3} = {sumNumbersResult_1}");
            Console.WriteLine($"Сумма чисел кратных {tgt_5} = {sumNumbersResult_2}");
            #endregion

            Console.ReadKey();
        }

        private static int AlterSumMultiplesNums(int randomNumber, int tgt, ConsoleColor color)
        {
            int sumNumbers = 0;

            for (int i = 0; i < randomNumber; i++)
            {
                var currentNum = i + 1;

                if (currentNum % tgt == 0)
                {
                    sumNumbers = sumNumbers + currentNum;// sumNumbersResult_1 += tgt_1;

                    Console.ForegroundColor = color;
                    Console.WriteLine($"{currentNum}%{tgt} -> остаток от деления {currentNum % tgt}, общ.сумма = {sumNumbers}");
                    Console.ResetColor();
                }
            }

            return sumNumbers;
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
