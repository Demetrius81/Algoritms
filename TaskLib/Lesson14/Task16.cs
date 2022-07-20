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
        private readonly string _taskNumber = "16";

        public override string TaskNumber { get => _taskNumber; }

        private readonly string _taskName = $"Структуры данных. Красно-черное дерево.\t\t\t\t\t\t\t\t- задача 16";

        public override string TaskName { get => _taskName; }

        public override void TaskResultOutput()
        {
            Console.Clear();

            Console.WriteLine("Red Black Tree===========================================");
                        
            Console.WriteLine();


        }

    }
}
