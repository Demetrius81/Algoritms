﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms.Lesson4
{
    class Task5 : ITask
    {
        private string _taskNumber = "5";

        public string TaskNumber { get => _taskNumber; }

        private string _taskName = "Работа с бинарным деревом поиска";

        public string TaskName { get => _taskName; }


        private SortedDictionary<int, object> DataGenerate(int count)
        {
            SortedDictionary<int, object> sDict = new SortedDictionary<int, object>();

            for (int i = 1; i <= count; i++)
            {
                sDict.Add(i, String.Format($"Данные элемента №{i}"));
            }
            return sDict;
        }

        public void TaskResultOutput()
        {
            Tree tree = new Tree();

            int count = 10; //задаем размер дерева

            SortedDictionary<int, object> sDict = DataGenerate(count);

            tree.CreateTree(sDict);

            tree.PrintTreePrefixBypass();

            tree.PrintTreePostfixBypass();

            tree.PrintTreeInfixBypass();

            tree.Add(12, "goooooooooo");

            tree.PrintTreeInfixBypass("Добавлен элемент по индексом 12");

            tree.Remove(5);

            tree.PrintTreeInfixBypass("Удален элемент по индексом 5");

            tree.Remove(8);

            tree.PrintTreeInfixBypass("Удален элемент по индексом 8");

            tree.Add(11);

            tree.PrintTreeInfixBypass("Добавлен элемент по индексом 11 без данных");

            tree.Add(10, "yaaaaaaaaaaa");

            tree.PrintTreeInfixBypass("Добавлен элемент по индексом 10");

            tree.Add(5, "YOOOOOOOOOOOO");

            tree.PrintTreeInfixBypass("Добавлен элемент по индексом 5");

            Console.WriteLine($"Поиск элемента с индексом 5 и вывод его данных в консоль");

            object rrr = tree.Contains(5) ? tree.FindNode(5).Data : "Не найден";

            Console.WriteLine(rrr);

            Console.ReadKey();

            Console.WriteLine($"Поиск элемента с индексом 18 (такого элемента нет) и вывод его данных в консоль");

            object www = tree.Contains(18) ? tree.FindNode(18).Data : "Не найден";

            Console.WriteLine(www);

            Console.ReadKey();
        }
    }
}
