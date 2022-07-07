using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms
{
    [Task]
    class Task11 : BaseTask
    {
        private readonly string _taskNumber = "11";

        public override string TaskNumber { get => _taskNumber; }

        private readonly string _taskName = $"Структуры данных. Стек.\t\t\t\t\t- задача 10";

        public override string TaskName { get => _taskName; }

        public override void TaskResultOutput()
        {
            CountOptionsEightQueens countOptionsEightQueens = new CountOptionsEightQueens();

            countOptionsEightQueens.RunCheck();
        }

    }
}
