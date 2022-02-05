using System;
using System.Collections.Generic;
using System.Linq;

namespace Algoritms
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskSelection(args);
        }

        /// <summary>
        /// Метод запрашивает нажатия любой кнопки
        /// </summary>
        private static void PressToExit()
        {
            Console.WriteLine($"Press any key to exit...");

            Console.ReadKey();
        }

        /// <summary>
        /// Метод запускает работу задач по выбору номера задачи
        /// </summary>
        private static void TaskSelection(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine($"Введите номер задачи(с 1 по 6) или 0 для выхода");

                int taskNumber = 0;

                bool isOK = Int32.TryParse(Console.ReadLine(), out taskNumber);

                if (!isOK || taskNumber < 0 || taskNumber > 6)
                {
                    Console.WriteLine("Вы ввели некорректное значение");

                    continue;
                }
                switch (taskNumber)
                {
                    case 0:
                        {
                            return;
                        }
                    case 1:
                        {
                            PrimeNumber.WritePrimeOrNotTest();

                            PressToExit();

                            break;
                        }
                    case 2:
                        {
                            PrimeNumber.WritePrimeOrNot();

                            PressToExit();

                            break;
                        }
                    case 3:
                        {
                            Fibonacci.FibonacciCyclePrint();

                            PressToExit();

                            break;
                        }
                    case 4:
                        {
                            Fibonacci.FibonacciRecursivePrint();

                            PressToExit();

                            break;
                        }
                    case 5:
                        {
                            DoubleLinkedList.DoubleLinkedListResults();

                            PressToExit();

                            break;
                        }
                    case 6:
                        {
                            PointsTests.TestResults();

                            PressToExit();

                            break;
                        }

                    default:
                        {
                            break;
                        }
                }
            }
        }
    }
}
