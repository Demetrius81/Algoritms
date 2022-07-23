using Algoritms.Lesson12;
using Algoritms.Lesson13;
using Algoritms.Lesson16;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms
{
    [Task]
    class Task20 : BaseTask
    {
        private readonly int _taskNumber = 20;

        public override int TaskNumber { get => _taskNumber; }

        private readonly string _taskName = $"Сортировка. Быстрая сортировка.\t\t\t\t\t\t\t\t- задача 20";

        public override string TaskName { get => _taskName; }

        public override void TaskResultOutput()
        {
            Console.Clear();

            Console.WriteLine("Быстрая сортировка ===========================================");

            Console.WriteLine();

            Random random = new Random();

            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(9);
            }
            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }

            QuickSort.Sort(arr);

            Console.WriteLine();

            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            Console.WriteLine();
        }
    }
}
