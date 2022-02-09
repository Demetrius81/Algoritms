using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms.Lesson4
{
    class Task6 : ITask
    {
        private string _taskNumber = "6";

        public string TaskNumber { get => _taskNumber; }

        private string _taskName = "Работа с массивом и HashSet. Замеры времени.";

        public string TaskName { get => _taskName; }

        public void TaskResultOutput()
        {
            HashVsArray hva = new HashVsArray();

            hva.ResultOutput();
        }
    }
}
