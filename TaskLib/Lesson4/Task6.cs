using System;
using System.Collections.Generic;
using System.Text;


namespace Algoritms
{
    [Task]
    public class Task6 : BaseTask
    {
        private readonly int _taskNumber = 6;

        public override int TaskNumber { get => _taskNumber; }

        private readonly string _taskName = $"Практическая работа 4. Работа с массивом и HashSet. Замеры времени\t\t\t- задача 6";

        public override string TaskName { get => _taskName; }

        public override void TaskResultOutput()
        {
            HashVsArray hva = new HashVsArray();

            hva.ResultOutput();
        }
    }
}
