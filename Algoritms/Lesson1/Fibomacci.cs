﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Algoritms.Lesson1
{
    //  Задание 3
    //  Реализуйте функцию вычисления числа Фибоначчи
    //⦁	Реализовать рекурсивную версию и версию без рекурсии(через цикл);
    //⦁	Обе реализации сделать методами отдельного класса;
    //⦁	На вход методы должны принимать целочисленный параметр, определяющий количество элементов формируемой последовательности.

    internal class Fibonacci : ITask
    {
        private string _taskNumber = "1_2";

        public string TaskNumber { get => _taskNumber; }

        private string _taskName = "Вывод ряда Фибоначчи до заданного предела";

        public string TaskName { get => _taskName; }

        public void TaskResultOutput()
        {
            Console.WriteLine("Введите длинну ряда чисел Фибоначчи");

            int temp = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ряд Фибоначчи циклическим методом:");

            foreach (var item in FibonacciCalculateCycle(temp))
            {
                Console.WriteLine($" {item}");
            }

            Console.WriteLine("Ряд Фибоначчи рекурсивным методом:");

            foreach (var item in FibonacciCalculateRecursive(temp))
            {
                Console.WriteLine($" {item}");
            }
        }

        /// <summary>
        /// Расчет ряда Фибоначчи до заданного числа рекурсивным методом
        /// </summary>
        /// <param name="n">
        /// long задаваемое число
        /// </param>
        /// <returns>
        /// List<long> ряд Фибоначчи
        /// </returns>
        private List<long> FibonacciCalculateRecursive(long n)
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

                listFibonacci.Add(listFibonacci.Last<long>() + listFibonacci.SkipLast(1).Last<long>());
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
        private long[] FibonacciCalculateCycle(int n)
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