using Algoritms.Sort;
using Algoritms.Sort.Tests;

namespace Algoritms;

internal class Program
{
    private static void Main(string[] args)
    {
        var result = TestSort.TestsSort();

        Console.WriteLine($"Время сортировки 10 000 элементов алгоритмом пузырьковой сортировки :\t{result.timeBubbleSort / 100000} милисекунд");
        Console.WriteLine($"Время сортировки 10 000 элементов алгоритмом прямой сортировки :\t{result.timeDirectSort / 100000} милисекунд");
        Console.WriteLine($"Время сортировки 10 000 элементов алгоритмом быстрой сортировки :\t{result.timeQuickSort / 100000} милисекунд");

        Console.ReadKey(true);
    }
}