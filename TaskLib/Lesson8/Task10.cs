using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms
{
    [Task]
    class Task10 : BaseTask
    {
        private readonly string _taskNumber = "10";

        public override string TaskNumber { get => _taskNumber; }

        private readonly string _taskName = $"Практическая работа 8. Задача о восьми ферзях, подсчет всех вариантов\t\t\t- задача 10";

        public override string TaskName { get => _taskName; }

        public override void TaskResultOutput()
        {
            CountOptionsEightQueens countOptionsEightQueens = new CountOptionsEightQueens();

            countOptionsEightQueens.RunCheck();
        }

    }
}
