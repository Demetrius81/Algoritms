using System;
using System.Collections.Generic;
using System.Text;
using TaskInt;

namespace Task
{
    public class Task2 : BaseTask
    {
        private readonly string _taskNumber = "2";

        public override string TaskNumber { get => _taskNumber; }

        private readonly string _taskName = $"Практическая работа 1. Вывод ряда Фибоначчи до заданного предела\t\t\t- задача 2";

        public override string TaskName { get => _taskName; }

        public override void TaskResultOutput()
        {
            Fibonacci fibonacci = new Fibonacci();

            Console.WriteLine("Введите длинну ряда чисел Фибоначчи");

            int temp = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ряд Фибоначчи циклическим методом:");

            foreach (var item in fibonacci.FibonacciCalculateCycle(temp))
            {
                Console.WriteLine($" {item}");
            }

            Console.WriteLine("Ряд Фибоначчи рекурсивным методом:");

            foreach (var item in fibonacci.FibonacciCalculateRecursive(temp))
            {
                Console.WriteLine($" {item}");
            }
        }
    }
}
