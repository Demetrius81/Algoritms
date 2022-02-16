using System;
using System.Collections.Generic;
using System.Linq;
using Task;
using TaskInt;
using System.Reflection;

namespace Algoritms
{
    class Program
    {
        private static readonly List<ITask> _tasks = new List<ITask>();
        //{
        //    { new Task1() },
        //    { new Task2() },
        //    { new Task3() },
        //    { new Task4() },
        //    { new Task5() },
        //    { new Task6() },
        //    { new Task7() }
        //};

        static void Main(string[] args)
        {
            //TaskSelection();
            Tasks();
        }

        private static void Tasks()
        {
            Assembly asm = Assembly.LoadFrom(@"TaskLib.dll");

            Type[] types = asm.GetTypes();





            Console.WriteLine(asm.FullName);

            Console.WriteLine();

            foreach (Type type in types)
            {
                Console.WriteLine(type.FullName);
            }

            Console.ReadKey();
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
