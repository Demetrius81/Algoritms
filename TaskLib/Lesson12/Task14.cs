using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms
{
    [Task]
    class Task14 : BaseTask
    {
        private readonly string _taskNumber = "14";

        public override string TaskNumber { get => _taskNumber; }

        private readonly string _taskName = $"Структуры данных. Хеш-таблицы.\t\t\t\t\t\t\t\t- задача 14";

        public override string TaskName { get => _taskName; }

        public override void TaskResultOutput()
        {
            Console.Clear();

            var badHashTable = new BadHashTable<int>(100);
            badHashTable.Add(5);
            badHashTable.Add(18);
            badHashTable.Add(777);
            badHashTable.Add(7);

            Console.WriteLine(badHashTable.Search(6));
            Console.WriteLine(badHashTable.Search(18));

            Console.WriteLine();

        }

    }
}
