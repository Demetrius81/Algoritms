using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms
{
    internal class PointsTests
    {
        /// <summary>
        /// Заполняет массив точек класса случайными числами
        /// </summary>
        /// <param name="count">int длина массива</param>
        /// <returns>PointDoubleCla[] заполненный массив</returns>
        private static PointDoubleClass[] PointsArrayCla(int count)
        {
            PointDoubleClass[] points = new PointDoubleClass[count];

            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                points[i] = new PointDoubleClass();

                points[i].X = -42.132 + (random.NextDouble() * (7.003 + 42.132));

                points[i].Y = -42.132 + (random.NextDouble() * (7.003 + 42.132));
            }
            return points;
        }

        /// <summary>
        /// Заполняет массив точек структуры случайными числами
        /// </summary>
        /// <param name="count">int длина массива</param>
        /// <returns>PointDoubleStr[] заполненный массив</returns>
        private static PointDoubleStructure[] PointsArrayStr(int count)
        {
            PointDoubleStructure[] points = new PointDoubleStructure[count];

            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                points[i].X = -42.132 + random.NextDouble() * (7.003 + 42.132);

                points[i].Y = -42.132 + random.NextDouble() * (7.003 + 42.132);
            }
            return points;
        }

        /// <summary>
        /// Шапка таблицы
        /// </summary>
        public static void PrintHead()
        {
            Console.Clear();

            Console.SetCursorPosition(0, 5);

            Console.WriteLine($"| Количество итераций |PointStructDouble,mks|PointClassDouble,mks | Ratio               |");

            Console.WriteLine($"|---------------------|---------------------|---------------------|---------------------|");
        }

        /// <summary>
        /// Вывод результатов работы методов
        /// </summary>
        /// <param name="numC">int Количество итераций</param>
        /// <param name="timeStruct">double время расчета для структуры</param>
        /// <param name="timeClass">double время расчета для класса</param>
        /// <param name="Ratio">отношение времени расчета</param>
        public static void PrintResults(int numC, double timeStruct, double timeClass, double Ratio)
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

        /// <summary>
        /// Тест структуры и класса
        /// </summary>
        public static void TestResults()
        {
            PrintHead();

            Test(100000);

            Test(200000);

            Test(500000);

            Test(1000000);

            Test(10000000);

            Test(100000000);

            Console.ReadKey();
        }

        private static void Test(int num)
        {
            StopWatch swClass = new StopWatch();

            StopWatch swStruct = new StopWatch();

            PointDoubleClass[] pointsClass = PointsArrayCla(num);

            PointDoubleStructure[] pointsStruct = PointsArrayStr(num);

            swClass.Start();

            int numC = CalculatePointsDistance(pointsClass);

            swClass.Stop();

            swStruct.Start();

            int numS = CalculatePointsDistance(pointsStruct);

            swStruct.Stop();

            double Ratio = swStruct.Time / swClass.Time;

            PrintResults(numC, swStruct.Time, swClass.Time, Ratio);
        }

        /// <summary>
        /// Метод считает расстояние между всеми точками
        /// </summary>
        /// <param name="points">PointDoubleCla[] массив точек</param>
        /// <returns>int количество итераций</returns>
        public static int CalculatePointsDistance(PointDoubleClass[] points)
        {
            int i;

            for (i = 1; i < points.Length; i++)
            {
                double x = points[i - 1].X - points[i].X;

                double y = points[i - 1].Y - points[i].Y;

                double yа = Math.Sqrt((x * x) + (y * y));
            }
            return i;
        }

        /// <summary>
        /// Метод считает расстояние между всеми точками
        /// </summary>
        /// <param name="points">PointDoubleStr[] массив точек</param>
        /// <returns>int количество итераций</returns>
        public static int CalculatePointsDistance(PointDoubleStructure[] points)
        {
            int i;

            for (i = 1; i < points.Length; i++)
            {
                double x = points[i - 1].X - points[i].X;

                double y = points[i - 1].Y - points[i].Y;

                double yа = Math.Sqrt((x * x) + (y * y));
            }
            return i;
        }
    }
}
