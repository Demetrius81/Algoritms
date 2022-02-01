using System;
using System.Collections.Generic;
using System.Linq;

namespace Algoritms
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeNumber.PrimeNumber.WritePrimeOrNotTest();

            PrimeNumber.PrimeNumber.WritePrimeOrNot();

            foreach (var item in Fibonacci.Fibonacci.FibonacciCalculateRecursive(Convert.ToInt32(Console.ReadLine())))
            {
                Console.WriteLine(item);
            }

            foreach (var item in Fibonacci.Fibonacci.FibonacciCalculateCycle(Convert.ToInt32(Console.ReadLine())))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }    
}
