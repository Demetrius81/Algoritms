using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Algoritms
{
    internal static class Run
    {
        private static List<ITask> _tasks = new List<ITask>();

        /// <summary>
        /// Метод при помощи механизмов класса System.Reflection динамически подключает библиотеку классов
        /// </summary>
        private static void Tasks()
        {
            Assembly asm = Assembly.LoadFrom(@"TaskLib.dll");

            Type[] types = asm.GetTypes();

            foreach (Type type in types)
            {
                Attribute attr = type.GetCustomAttribute(typeof(TaskAttribute), false);

                if (attr != null)
                {
                    object obj = Activator.CreateInstance(type);

                    _tasks.Add(obj as ITask);
                }
            }
            _tasks = _tasks.OrderBy(x => x.TaskNumber).ToList();
        }

        /// <summary>
        /// Метод запускает цикл по выбору и выполнению задачи
        /// </summary>
        internal static void TaskSelection()
        {
            int userChoice = -1;

            Tasks();

            while (userChoice != 0)
            {
                Console.Clear();

                Console.WriteLine($"Список практических работ по дисциплине \"Алгоритмы и структуры данных\"");

                foreach (ITask task in _tasks)
                {
                    Console.WriteLine(task.TaskName);
                }
                Console.WriteLine($"Введите номер задачи или 0 для выхода");

                if (!int.TryParse(Console.ReadLine(), out userChoice))
                {
                    userChoice = -1;
                }

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
