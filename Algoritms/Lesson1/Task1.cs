using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms.Lesson1
{
    class Task1 : ITask
    {
        private string _taskNumber = "1";

        public string TaskNumber { get => _taskNumber; }

        private string _taskName = $"Практическая работа 1. Проверка является ли число простым\t\t\t\t- задача 1";

        public string TaskName { get => _taskName; }

        public void TaskResultOutput()
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
