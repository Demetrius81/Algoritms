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
                Console.WriteLine($"Список практических работ по дисциплине \"Алгоритмы и структуры данных\"");
                Console.WriteLine($"Практическая работа 1. Проверка является ли число простым -\t\tзадача 1");
                Console.WriteLine($"Практическая работа 1. Вывод ряда Фибоначчи до заданного предела -\tзадача 2");
                Console.WriteLine($"Практическая работа 2. Работа с двусвязным списком -\t\t\tзадача 3");
                Console.WriteLine($"Практическая работа 3. Работа с замерами времени вычислений -\t\tзадача 4");
                Console.WriteLine($"Практическая работа 4. Работа с бинарным деревом поиска -\t\tзадача 5");
                Console.WriteLine($"Практическая работа 4. Работа с массивом и HashSet. Замеры времени -\tзадача 6");
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
                            Lesson4.Task5 tree = new Lesson4.Task5();

                            tree.TaskResultOutput();

                            break;
                        }
                    case 6:
                        {
                            Lesson4.Task6 tree = new Lesson4.Task6();

                            tree.TaskResultOutput();

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
