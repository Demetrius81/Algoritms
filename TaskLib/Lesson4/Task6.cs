using System;
using System.Collections.Generic;
using System.Text;
using TaskInt;

namespace Task
{
    public class Task6 : BaseTask
    {
        private readonly string _taskNumber = "6";

        public override string TaskNumber { get => _taskNumber; }

        private readonly string _taskName = $"Практическая работа 4. Работа с массивом и HashSet. Замеры времени\t\t\t- задача 6";

        public override string TaskName { get => _taskName; }

        public override void TaskResultOutput()
        {
            HashVsArray hva = new HashVsArray();

            hva.ResultOutput();
        }
    }
}
