using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms
{
    [Task]
    class Task13 : BaseTask
    {
        private readonly int _taskNumber = 13;

        public override int TaskNumber { get => _taskNumber; }

        private readonly string _taskName = $"Структуры данных. Множество.\t\t\t\t\t\t\t\t- задача 13";

        public override string TaskName { get => _taskName; }

        public override void TaskResultOutput()
        {
            Console.Clear();

            var easySet1 = new EasySet<int>(new int[] { 1, 2, 3, 4, 5 });
            var easySet2 = new EasySet<int>(new int[] { 4, 5, 6, 7, 8, 9 });
            var easySet3 = new EasySet<int>(new int[] { 3, 4, 5 });

            Console.WriteLine("Union");

            foreach (var i in easySet1.Union(easySet2))
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Intersection");

            foreach (var i in easySet1.Intersection(easySet2))
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Difference A \\ B");

            foreach (var i in easySet1.Difference(easySet2))
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Difference B \\ A");

            foreach (var i in easySet2.Difference(easySet1))
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Subset");

            
                Console.Write(easySet1.Subset(easySet3));
           

            Console.WriteLine();

            Console.WriteLine("SymmetricDifference A \\ B");

            foreach (var i in easySet1.SymmetricDifference(easySet2))
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            Console.WriteLine("SymmetricDifference B \\ A");

            foreach (var i in easySet2.SymmetricDifference(easySet1))
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

        }

    }
}
