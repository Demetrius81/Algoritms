using System;
using System.Collections.Generic;


namespace Algoritms
{
    [Task]
    public class Task7 : BaseTask
    {
        private readonly string _taskNumber = "7";
                
        public override string TaskNumber { get => _taskNumber; }

        private readonly string _taskName = $"Практическая работа 5. Работа с бинарным деревом поиска. Поиск в ширину и в глубину\t- задача 7";
        
        public override string TaskName { get => _taskName; }

        /// <summary>
        /// Метод симуляции поступления данных извне. Генерирует сортированный список данных указанной длины
        /// </summary>
        /// <param name="count">int длина списка данных</param>
        /// <returns>SortedDictionary<int, object> список данных</returns>
        private SortedDictionary<int, object> DataGenerate(int count)
        {
            SortedDictionary<int, object> sDict = new SortedDictionary<int, object>();

            for (int i = 1; i <= count; i++)
            {
                sDict.Add(i, String.Format($"Данные элемента №{i}"));
            }
            return sDict;
        }

        public override void TaskResultOutput()
        {
            Tree tree = new Tree();

            int count = 15; //задаем размер массива данных

            SortedDictionary<int, object> sDict = DataGenerate(count);

            tree.BuildTree(sDict);

            PrintTree(tree);

            SerchInTree(tree);

            Console.ReadKey();
        }

        private void SerchInTree(Tree tree)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine($"Выберите режим поиска");

                Console.WriteLine($"1 - Обход в ширину");

                Console.WriteLine($"2 - Обход в глубину");

                Console.WriteLine($"0 - Выход");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        {
                            SearchBFS(tree);

                            break;
                        }
                    case "2":
                        {
                            SearchDFS(tree);

                            break;
                        }
                    case "0":
                        {
                            return;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
        }

        /// <summary>
        /// Метод производит взаимодействие с пользователем и инициализирует процедуру поиска DFS
        /// </summary>
        /// <param name="tree">Tree Дерево поиска</param>
        private void SearchDFS(Tree tree)
        {
            Console.Clear();

            Console.WriteLine($"Текущий размер дерева {tree.Count} элементов");

            Console.WriteLine($"Введите ключ для поиска");

            bool isDone = Int32.TryParse(Console.ReadLine(), out int userChoice);

            if (isDone)
            {
                object obj = tree.SerchByDFS(userChoice);
                if (obj != null)
                {
                    Console.WriteLine($"Искомая информация: {obj}");

                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine($"Нет такого ключа");

                    Console.ReadKey();

                    return;
                }
            }
            else
            {
                Console.WriteLine($"Вы ввели не ключ для поиска");

                Console.ReadKey();
            }
        }

        /// <summary>
        /// Метод производит взаимодействие с пользователем и инициализирует процедуру поиска DFS
        /// </summary>
        /// <param name="tree">Tree Дерево поиска</param>
        private void SearchBFS(Tree tree)
        {
            Console.Clear();

            Console.WriteLine($"Текущий размер дерева {tree.Count} элементов");

            Console.WriteLine($"Введите ключ для поиска");

            bool isDone = Int32.TryParse(Console.ReadLine(), out int userChoice);

            if (isDone)
            {
                object obj = tree.SerchByBFS(userChoice);
                if (obj != null)
                {
                    Console.WriteLine($"Искомая информация: {obj}");

                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine($"Нет такого ключа");

                    Console.ReadKey();

                    return;
                }
            }
            else
            {
                Console.WriteLine($"Вы ввели не ключ для поиска");

                Console.ReadKey();
            }
        }

        /// <summary>
        /// Метод выводит дерево в консоль
        /// </summary>
        /// <param name="tree">Lesson4.Tree дерево</param>
        private void PrintTree(Tree tree)
        {
            Console.Clear();

            tree.WriteAllLines("_", tree.RootNode);

            Console.ReadKey();
        }

    }
}
