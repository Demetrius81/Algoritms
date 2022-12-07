using Algoritms.Lesson12;
using Algoritms.Lesson13;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms
{
    [Task]
    class Task17 : BaseTask
    {
        private readonly int _taskNumber = 17;

        public override int TaskNumber { get => _taskNumber; }

        private readonly string _taskName = $"Структуры данных. Бинарное дерево поиска.\t\t\t\t\t\t- задача 17";

        public override string TaskName { get => _taskName; }

        public override void TaskResultOutput()
        {
            Console.Clear();

            Console.WriteLine("Бинарное дерево поиска ===========================================");

            Console.WriteLine();


        }
    }
}
