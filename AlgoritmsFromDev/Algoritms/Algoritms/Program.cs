using Algoritms.Sort;
using Algoritms.Sort.Tests;

namespace Algoritms;

internal class Program
{
    private static void Main(string[] args)
    {
        //var result = TestSort.TestsSort();

        //Console.WriteLine($"Время сортировки 10 000 элементов алгоритмом пузырьковой сортировки :\t{result.timeBubbleSort / 100000} милисекунд");
        //Console.WriteLine($"Время сортировки 10 000 элементов алгоритмом прямой сортировки :\t{result.timeDirectSort / 100000} милисекунд");
        //Console.WriteLine($"Время сортировки 10 000 элементов алгоритмом быстрой сортировки :\t{result.timeQuickSort / 100000} милисекунд");



        Random rnd = new Random();
        var arr = new int[10];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(0, 10);
        }

        Console.WriteLine();

        foreach (var item in arr)
        {
            Console.Write($"{item} ");
        }

        Console.WriteLine();

        HeapSort.Sort(arr);

        foreach (var item in arr)
        {
            Console.Write($"{item} ");
        }

        Console.WriteLine();



        Console.ReadKey(true);
    }
}