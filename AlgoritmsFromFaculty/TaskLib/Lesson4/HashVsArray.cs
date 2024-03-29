﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Algoritms
{
    /// <summary>
    /// Тест Хеш список против массива, скорость поиска значения значения
    /// </summary>
    class HashVsArray
    {
        /// <summary>
        /// Метод генерирует массив строк заданной длины и заполняет его случайными строками
        /// </summary>
        /// <param name="lenght">int длина массива</param>
        /// <returns>string[] массив строк</returns>
        private string[] GenerateArray(int lenght)
        {
            const double variableToFill = 42.132;

            const double variableToFillOneMore = 7.003;

            Random random = new Random();

            string[] arr = new string[lenght];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (-variableToFill + (random.NextDouble() * (variableToFillOneMore + variableToFill))).ToString();
            }
            return arr;
        }

        /// <summary>
        /// Метод генерирует HashSet список заданной длины и заполняет его случайными строками
        /// </summary>
        /// <param name="lenght">int длина списка</param>
        /// <returns>HashSet<string> список</returns>
        private HashSet<string> GenerateHashSet(int lenght)
        {
            const double variableToFill = 42.132;

            const double variableToFillOneMore = 7.003;

            Random random = new Random();

            HashSet<string> hs = new HashSet<string>();

            for (int i = 0; i < lenght; i++)
            {
                hs.Add((-variableToFill + (random.NextDouble() * (variableToFillOneMore + variableToFill))).ToString());
            }
            return hs;
        }

        /// <summary>
        /// Метод производит непосредственно тест
        /// </summary>
        /// <param name="lenght">int количество элементов</param>
        private void Test(int lenght)
        {
            StopWatch swHs = new StopWatch();

            StopWatch swArr = new StopWatch();

            HashSet<string> hs = GenerateHashSet(lenght);

            string[] arr = GenerateArray(lenght);

            swHs.Start();
            _ = hs.Contains(" ");

            swHs.Stop();

            swArr.Start();
            _ = arr.Contains(" ");

            swArr.Stop();

            double Ratio = swHs.Time / swArr.Time;

            PrintResults(lenght, swHs.Time, swArr.Time, Ratio);
        }

        /// <summary>
        /// Метод проводит несколько тестов
        /// </summary>
        public void ResultOutput()
        {
            PrintHead();

            Test(10000);

            Test(50000);

            Test(100000);

            Test(500000);

            Test(1000000);

            Test(5000000);

            Test(10000000);

            Console.ReadKey();
        }

        /// <summary>
        /// Шапка таблицы
        /// </summary>
        private void PrintHead()
        {
            Console.Clear();

            Console.SetCursorPosition(0, 5);

            Console.WriteLine($"|Количество элементов |HashSet<string>, mks | string[] array, mks | Ratio               |");

            Console.WriteLine($"|---------------------|---------------------|---------------------|---------------------|");
        }

        /// <summary>
        /// Вывод результатов работы методов
        /// </summary>
        /// <param name="numC">int Количество итераций</param>
        /// <param name="timeStruct">double время расчета для структуры</param>
        /// <param name="timeClass">double время расчета для класса</param>
        /// <param name="Ratio">отношение времени расчета</param>
        private void PrintResults(int numC, double timeStruct, double timeClass, double Ratio)
        {
            Console.SetCursorPosition(0, Console.CursorTop);

            Console.Write($"| ");

            Console.SetCursorPosition(2, Console.CursorTop);

            Console.Write($"{numC}");

            Console.SetCursorPosition(22, Console.CursorTop);

            Console.Write($"| ");

            Console.SetCursorPosition(24, Console.CursorTop);

            Console.Write($"{timeStruct}");

            Console.SetCursorPosition(44, Console.CursorTop);

            Console.Write($"| ");

            Console.SetCursorPosition(46, Console.CursorTop);

            Console.Write($"{timeClass}");

            Console.SetCursorPosition(66, Console.CursorTop);

            Console.Write($"| ");

            Console.SetCursorPosition(68, Console.CursorTop);

            Console.Write($"{Ratio}");

            Console.SetCursorPosition(88, Console.CursorTop);

            Console.WriteLine($"|");

            Console.WriteLine($"|---------------------|---------------------|---------------------|---------------------|");
        }
    }
}
