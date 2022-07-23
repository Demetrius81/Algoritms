using Algoritms.Lesson12;
using Algoritms.Lesson13;
using Algoritms.Lesson16;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms
{
    [Task]
    class Task19 : BaseTask
    {
        private readonly int _taskNumber = 19;

        public override int TaskNumber { get => _taskNumber; }

        private readonly string _taskName = $"Сортировка. Прямая сортировка.\t\t\t\t\t\t\t\t- задача 19";

        public override string TaskName { get => _taskName; }

        public override void TaskResultOutput()
        {
            Console.Clear();

            Console.WriteLine("Прямая сортировка ===========================================");

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

            DirectSort.Sort(arr);

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
