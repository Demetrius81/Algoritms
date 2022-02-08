﻿using System;
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

                Console.WriteLine($"Введите номер задачи(с 1 по 5) или 0 для выхода");

                int taskNumber = 0;

                bool isOK = Int32.TryParse(Console.ReadLine(), out taskNumber);

                if (!isOK || taskNumber < 0 || taskNumber > 5)
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
                            Lesson1.PrimeNumber temp = new Lesson1.PrimeNumber();

                            temp.TaskResultOutput();

                            PressToExit();

                            break;
                        }
                    case 2:
                        {
                            Lesson1.Fibonacci temp = new Lesson1.Fibonacci();

                            temp.TaskResultOutput();

                            PressToExit();

                            break;
                        }
                    case 3:
                        {
                            Lesson2.DoubleLinkedList temp = new Lesson2.DoubleLinkedList();

                            temp.TaskResultOutput();

                            PressToExit();

                            break;
                        }
                    case 4:
                        {
                            Lesson3.PointsTests temp = new Lesson3.PointsTests();

                            temp.TaskResultOutput();

                            PressToExit();

                            break;
                        }
                    case 5:
                        {
                            Lesson4.Tree tree = new Lesson4.Tree();

                            tree.TaskResultOutput();

                            break;
                        }
                    case 6:
                        {
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
