using System;


namespace Algoritms
{
    [Task]
    public class Task1 : BaseTask
    {
        private readonly string _taskNumber = "1";

        public override string TaskNumber { get => _taskNumber; }

        private readonly string _taskName = $"Практическая работа 1. Проверка является ли число простым\t\t\t\t- задача 1";

        public override string TaskName { get => _taskName; }

        public override void TaskResultOutput()
        {
            PrimeNumber primeNumber = new PrimeNumber();

            long number = 7;

            Console.WriteLine($"Введите число >{number}");

            bool isPrime = primeNumber.CheckPrimeOrNotUpgrade(number);

            if (isPrime)
            {
                Console.WriteLine($"Число {number} является простым");
            }
            else
            {
                Console.WriteLine($"Число {number} не является простым");
            }

            number = 8;

            Console.WriteLine($"Введите число >{number}");

            isPrime = primeNumber.CheckPrimeOrNotUpgrade(number);

            if (isPrime)
            {
                Console.WriteLine($"Число {number} является простым");
            }
            else
            {
                Console.WriteLine($"Число {number} не является простым");
            }
        }
    }
}
