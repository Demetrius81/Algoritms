using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms
{
    [Task]
    class Task8 : BaseTask
    {
        private readonly string _taskNumber = "8";

        public override string TaskNumber { get => _taskNumber; }

        private readonly string _taskName = $"Практическая работа 7. Работа с количеством вариантов\t\t\t\t\t- задача 8";

        public override string TaskName { get => _taskName; }

        public override void TaskResultOutput()
        {
            NumberOfOptions numberOfOptions = new NumberOfOptions();

            numberOfOptions.NumberOfOptionsOutput(100);
        }

    }
}
