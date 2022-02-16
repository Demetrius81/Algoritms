using System;
using System.Collections.Generic;
using System.Linq;

namespace Algoritms
{
    class Program
    {
        private static readonly List<ITask> _tasks = new List<ITask>()
        {
            {new Lesson1.Task1() },
            {new Lesson1.Task2() },
            {new Lesson2.Task3() },
            {new Lesson3.Task4() },
            {new Lesson4.Task5() },
            {new Lesson4.Task6() },
            {new Lesson5.Task7() }
        };

        static void Main(string[] args)
        {
            TaskSelection();
        }

        /// <summary>
        /// Метод запускает цикл по выбору и выполнению задачи
        /// </summary>
        private static void TaskSelection()
        {
            string userChoice = "";

            while (userChoice != "0")
            {
                Console.Clear();

                Console.WriteLine($"Список практических работ по дисциплине \"Алгоритмы и структуры данных\"");

                foreach (ITask task in _tasks)
                {
                    Console.WriteLine(task.TaskName);
                }
                Console.WriteLine($"Введите номер задачи или 0 для выхода");

                userChoice = Console.ReadLine();

                foreach (ITask task in _tasks)
                {
                    if (task.TaskNumber == userChoice)
                    {
                        task.TaskResultOutput();

                        PressToExit();
                    }
                }
            }
        }

        /// <summary>
        /// Метод запрашивает нажатия любой кнопки
        /// </summary>
        private static void PressToExit()
        {
            Console.WriteLine($"Press any key to exit...");

            Console.ReadKey();
        }       
    }
}
