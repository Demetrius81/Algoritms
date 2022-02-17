using System;
using System.Collections.Generic;
using System.Text;
using TaskInt;

namespace Task
{
    [Task]
    public class Task4 : BaseTask
    {
        private readonly string _taskNumber = "4";

        public override string TaskNumber { get => _taskNumber; }

        private readonly string _taskName = $"Практическая работа 3. Работа с замерами времени вычислений\t\t\t\t- задача 4";

        public override string TaskName { get => _taskName; }

        public override void TaskResultOutput()
        {
            PointsTests testResult = new PointsTests();

            testResult.PrintHead();

            testResult.Test(100000);

            testResult.Test(200000);

            testResult.Test(500000);

            testResult.Test(1000000);

            testResult.Test(10000000);

            testResult.Test(100000000);

            Console.ReadKey();
        }
    }
}
