using System;
using System.Collections.Generic;
using System.Linq;

namespace Algoritms
{
    class Program
    {
        //  Задание 1
        //  Требуется реализовать на C# функцию согласно блок-схеме. Блок-схема описывает алгоритм проверки, простое число или нет.
        //⦁	Реализовать в виде консольного приложения.
        //⦁	Алгоритм реализовать в отдельном классе согласно блок-схеме.
        //⦁	Написать проверочный код(один положительный, один отрицательный сценарий) в отдельной функции и вызывать его при запуске.
        //⦁	Код выложить на GitHub.

        /// <summary>
        /// Метод определяет простое число или нет. На вход подается переменная long. Результатом работы метода является переменная bool. 
        /// </summary>
        /// <param name="number">Исследуемое число</param>
        /// <returns bool>Результат работы</returns>
        static bool CheckPrimeOrNot(long number)
        {
            int d = 0;

            for (int i = 2; i < number; i++)
            {
                if (number%i == 0)
                {
                    d++;
                }
            }
            if (d == 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Метод запрашивает у пользователя число и выводит в консоль является ли это число простым.
        /// </summary>
        static void WritePrimeOrNot()
        {
            long number = 0;

            Console.Write($"Введите число >");

            try
            {
                number = Convert.ToInt64(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex}");
                return;
            }

            bool isPrime = CheckPrimeOrNot(number);

            if (isPrime)
            {
                Console.WriteLine($"Число {number} является простым");
            }
            else
            {
                Console.WriteLine($"Число {number} не является простым");
            }
        }

        /// <summary>
        /// Тестовый метод
        /// </summary>
        static void WritePrimeOrNotTest()
        {
            long number = 7;

            Console.WriteLine($"Введите число >{number}");

            bool isPrime = CheckPrimeOrNot(number);

            if (isPrime)
            {
                Console.WriteLine($"Число {number} является простым");
            }
            else
            {
                Console.WriteLine($"Число {number} не является простым");
            }
        
            number = 8;

            Console.WriteLine($"Введите число >{number}");

            isPrime = CheckPrimeOrNot(number);

            if (isPrime)
            {
                Console.WriteLine($"Число {number} является простым");
            }
            else
            {
                Console.WriteLine($"Число {number} не является простым");
            }
        }

        static void Main(string[] args)
        {
            //WritePrimeOrNotTest();

            //WritePrimeOrNot();

            //long w = Fibonacci.FibonacciCalculateRecursive(Convert.ToInt32(Console.ReadLine()));

            foreach (var item in Fibonacci.FibonacciCalculateRecursive(Convert.ToInt32(Console.ReadLine())))
            {
                Console.WriteLine(item);
            }
            
                Console.WriteLine();
            
        }
    }
    class Fibonacci
    {
        /// <summary>
        /// Расчет ряда Фибоначчи до заданного числа рекурсивным методом
        /// </summary>
        /// <param name="n">
        /// int задаваемое число
        /// </param>
        /// <returns>
        /// List<long> ряд Фибоначчи
        /// </returns>
        public static List<long> FibonacciCalculateRecursive(int n)
        {
            List<long> listFibonacci = new List<long>();

            if (n == 1)
            {
                listFibonacci.Add(0);                
            }
            else if (n == 2)
            {
                listFibonacci.Add(0);

                listFibonacci.Add(1);
            }
            else if (n > 2)
            {                
                listFibonacci.AddRange(FibonacciCalculateRecursive(n - 1));

                listFibonacci.Add(FibonacciCalculateRecursive(n - 1).Last<long>() + FibonacciCalculateRecursive(n - 2).Last<long>());
            }
            return listFibonacci;
        }

        /// <summary>
        /// Расчет ряда Фибоначчи до заданного числа без рекурсии с использованием цикла for
        /// </summary>
        /// <param name="n">
        /// int задаваемое число
        /// </param>
        /// <returns>
        /// long[] ряд Фибоначчи
        /// </returns>
        public static long[] FibonacciCalculateCycle(int n)
        {
            long[] rowFibonacci = new long[n];
            if (n == 1)
            {
                rowFibonacci[0] = 0;
            }
            else if (n == 2)
            {
                rowFibonacci[0] = 0;
                rowFibonacci[1] = 1;
            }
            if (n >= 3)
            {
                rowFibonacci[0] = 0;
                rowFibonacci[1] = 1;
                for (int i = 2; i < n; i++)
                {
                    rowFibonacci[i] = rowFibonacci[i - 1] + rowFibonacci[i - 2];
                }
            }
            return rowFibonacci;
        }

    }
}
