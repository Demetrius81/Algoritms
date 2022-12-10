using System;
using System.Collections.Generic;
using System.Text;


namespace Algoritms
{
    [Task]
    public class Task5 : BaseTask
    {
        private readonly int _taskNumber = 5;

        public override int TaskNumber { get => _taskNumber; }

        private readonly string _taskName = $"Практическая работа 4. Работа с бинарным деревом поиска\t\t\t\t\t- задача 5";

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

            tree.PrintTreePrefixBypass("Префиксный обход дерева. Хорош для копирования");

            tree.PrintTreePostfixBypass("Постфиксный обход дерева. Хорош для удаления дерева");

            tree.PrintTreeInfixBypass("Инфиксный обход дерева. Хорош для сортировки");

            tree.Add(13, "goooooooooo");

            tree.PrintTreeInfixBypass($"Добавлен элемент по индексом 12. Размер дерева {tree.Count}");

            tree.Remove(5);

            tree.PrintTreeInfixBypass($"Удален элемент по индексом 5. Размер дерева {tree.Count}");

            tree.Remove(8);

            tree.PrintTreeInfixBypass($"Удален элемент по индексом 8. Размер дерева {tree.Count}");

            tree.Add(17, "yaaaaaaaaaaa");

            tree.PrintTreeInfixBypass($"Добавлен элемент по индексом 10. Размер дерева {tree.Count}");

            tree.Add(5, "YOOOOOOOOOOOO");

            tree.PrintTreeInfixBypass($"Добавлен элемент по индексом 5. Размер дерева {tree.Count}");

            Console.Clear();

            Console.WriteLine($"Поиск элемента с индексом 5 и вывод его данных в консоль");

            object rrr = tree.Contains(5) ? tree.FindNode(5).Data : "Не найден";

            Console.WriteLine(rrr);

            Console.ReadKey();

            Console.Clear();

            Console.WriteLine($"Поиск элемента с индексом 18 (такого элемента нет) и вывод его данных в консоль");

            object www = tree.Contains(18) ? tree.FindNode(18).Data : "Не найден";

            Console.WriteLine(www);

            Console.ReadKey();
        }
    }
}
