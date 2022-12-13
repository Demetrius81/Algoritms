using Algoritms.Sort;
using Algoritms.Sort.Tests;

namespace Algoritms;

internal class Program
{
    private static void Main(string[] args)
    {
        var result = TestSort.TestsSort();

        Console.WriteLine($"Время сортировки 10 000 элементов алгоритмом пузырьковой сортировки :\t{result.timeBubbleSort / 100} микросекунд");
        Console.WriteLine($"Время сортировки 10 000 элементов алгоритмом прямой сортировки :\t{result.timeDirectSort / 100} микросекунд");
        Console.WriteLine($"Время сортировки 10 000 элементов алгоритмом быстрой сортировки :\t{result.timeQuickSort / 100} микросекунд");
        Console.WriteLine($"Время сортировки 10 000 элементов алгоритмом сортировки вставками :\t{result.timeInsertionSort / 100000} микросекунд");
        Console.WriteLine($"Время сортировки 10 000 элементов алгоритмом пирамидальной сортировки :\t{result.timeHeapSort / 100000} микросекунд");

        Console.ReadKey(true);
    }
}