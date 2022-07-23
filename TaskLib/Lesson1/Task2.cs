using System;
using System.Collections.Generic;
using System.Text;


namespace Algoritms
{
    [Task]
    public class Task2 : BaseTask
    {
        private readonly int _taskNumber = 2;

        public override int TaskNumber { get => _taskNumber; }

        private readonly string _taskName = $"Практическая работа 1. Вывод ряда Фибоначчи до заданного предела\t\t\t- задача 2";

        public override string TaskName { get => _taskName; }

        public override void TaskResultOutput()
        {
            Fibonacci fibonacci = new Fibonacci();

            fibonacci.ResultOutput();
        }
    }
}
