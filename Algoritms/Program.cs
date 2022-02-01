using System;
using System.Collections.Generic;
using System.Linq;

namespace Algoritms
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrimeNumber.WritePrimeOrNotTest();

            //PrimeNumber.WritePrimeOrNot();

            //foreach (var item in Fibonacci.FibonacciCalculateRecursive(Convert.ToInt32(Console.ReadLine())))
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in Fibonacci.FibonacciCalculateCycle(Convert.ToInt32(Console.ReadLine())))
            //{
            //    Console.WriteLine(item);
            //}

            DoubleLinkedListResults();

            Console.WriteLine();
        }

        internal static void DoubleLinkedListResults()
        {
            DoubleLinkedList list = new DoubleLinkedList();

            for (int i = 0; i < 10; i++)
            {
                list.AddNode((i+1)*10);
            }

            list.PrintDoubleLinkedList();

            list.AddNodeAfter(list.FindNode(50), 400);

            list.PrintDoubleLinkedList();

            list.RemoveNode(50);

            list.PrintDoubleLinkedList();
        }









    }    
}
