using System;
using System.Collections.Generic;
using TaskInt;
using System.Reflection;

namespace Algoritms
{
    class Program
    {
        private static readonly List<ITask> _tasks = new List<ITask>();

        static void Main(string[] args)
        {
            TaskSelection();
        }

        /// <summary>
        /// Метод при помощи механизмов класса System.Reflection динамически подключает библиотеку классов
        /// </summary>
        private static void Tasks()
        {
            Assembly asm = Assembly.LoadFrom(@"TaskLib.dll");

            Type[] types = asm.GetTypes();

            foreach (Type type in types)
            {
                Attribute attr = type.GetCustomAttribute(typeof(Task.TaskAttribute), false);

                if (attr != null)
                {
                    object obj = Activator.CreateInstance(type);

                    _tasks.Add(obj as ITask);
                }
            }
        }

        /// <summary>
        /// Метод запускает цикл по выбору и выполнению задачи
        /// </summary>
        private static void TaskSelection()
        {
            string userChoice = "";

            Tasks();

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
