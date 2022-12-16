using Algoritms.Lesson12;
using Algoritms.Lesson13;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms
{
    [Task]
    class Task16 : BaseTask
    {
        private readonly int _taskNumber = 16;

        public override int TaskNumber { get => _taskNumber; }

        private readonly string _taskName = $"Структуры данных. Красно-черное дерево.\t\t\t\t\t\t\t- задача 16";

        public override string TaskName { get => _taskName; }

        public override void TaskResultOutput()
        {
            Console.Clear();

            Console.WriteLine("EasyMap===========================================");

            Console.WriteLine();

            var easyMap = new EasyMap<int, string>();

            easyMap.Add(new Item<int, string>(1, "Один"));
            easyMap.Add(new Item<int, string>(2, "Два"));
            easyMap.Add(new Item<int, string>(3, "Три"));
            easyMap.Add(new Item<int, string>(4, "Четыре"));
            easyMap.Add(new Item<int, string>(5, "Пять"));

            foreach (var item in easyMap)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine(easyMap.Search(7) ?? "не найдено");
            Console.WriteLine(easyMap.Search(3) ?? "не найдено");

            easyMap.Remove(3);
            easyMap.Remove(1);

            Console.WriteLine();

            foreach (var item in easyMap)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("Dict==============================================");

            Console.WriteLine();

            var dict = new Dict<int, string>();

            dict.Add(new Item<int, string>(1, "Один"));
            dict.Add(new Item<int, string>(2, "Два"));
            dict.Add(new Item<int, string>(3, "Три"));
            dict.Add(new Item<int, string>(4, "Четыре"));
            dict.Add(new Item<int, string>(5, "Пять"));
            dict.Add(new Item<int, string>(5, "Пять"));
            dict.Add(new Item<int, string>(105, "Cто пять"));

            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine(dict.Search(7) ?? "не найдено");
            Console.WriteLine(dict.Search(3) ?? "не найдено");

            dict.Remove(3);
            dict.Remove(1);

            Console.WriteLine();

            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();


        }

    }
}
