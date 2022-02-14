using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms.Lesson1
{
    class Task2 : ITask
    {
        private string _taskNumber = "2";

        public string TaskNumber { get => _taskNumber; }

        private string _taskName = $"Практическая работа 1. Вывод ряда Фибоначчи до заданного предела\t\t\t- задача 2";

        public string TaskName { get => _taskName; }

        public void TaskResultOutput()
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
