using Algoritms.Sort;
using Algoritms.Sort.Tests;

namespace Algoritms;

internal class Program
{
    private static void Main(string[] args)
    {
        var result = TestSort.TestsSort();

        Console.WriteLine("Время сортировки 10 000 элементов алгоритмом:");
        Console.WriteLine($"> > > пузырьковой сортировки :\t\t{result.timeBubbleSort / 10} микросекунд");
        Console.WriteLine($"> > > сортировки вставками :\t\t{result.timeInsertionSort / 10} микросекунд");
        Console.WriteLine($"> > > прямой сортировки :\t\t{result.timeDirectSort / 10} микросекунд");
        Console.WriteLine($"> > > быстрой сортировки :\t\t{result.timeQuickSort / 10} микросекунд");
        Console.WriteLine($"> > > пирамидальной сортировки :\t{result.timeHeapSort / 10} микросекунд");

        Console.ReadKey(true);
    }
}