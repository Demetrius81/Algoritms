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

                Console.WriteLine($"Введите номер задачи(с 1 по 4) или 0 для выхода");

                int taskNumber = 0;

                bool isOK = Int32.TryParse(Console.ReadLine(), out taskNumber);

                if (!isOK || taskNumber < 0 || taskNumber > 4)
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
                            PrimeNumber temp = new PrimeNumber();

                            temp.TaskResultOutput();

                            PressToExit();

                            break;
                        }
                    case 2:
                        {
                            Fibonacci temp = new Fibonacci();

                            temp.TaskResultOutput();

                            PressToExit();

                            break;
                        }
                    case 3:
                        {
                            DoubleLinkedList temp = new DoubleLinkedList();

                            temp.TaskResultOutput();

                            PressToExit();

                            break;
                        }
                    case 4:
                        {
                            PointsTests temp = new PointsTests();

                            temp.TaskResultOutput();

                            PressToExit();

                            break;
                        }
                    case 5:
                        {
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
