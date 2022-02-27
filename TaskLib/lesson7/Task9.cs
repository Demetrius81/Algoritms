using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms
{
    [Task]
    class Task9 : BaseTask
    {
        private readonly string _taskNumber = "9";

        public override string TaskNumber { get => _taskNumber; }

        private readonly string _taskName = $"Практическая работа 7. Задача о восьми ферзях\t\t\t\t\t\t- задача 9";

        public override string TaskName { get => _taskName; }

        public override void TaskResultOutput()
        {
            EightQueens eightQueens = new EightQueens();

            eightQueens.OutputResult();
        }

    }
}
