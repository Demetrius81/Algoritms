using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms.Sort.Tests;
internal class TestSort
{
    protected TestSort() { }

    internal static (double timeBubbleSort, double timeDirectSort, double timeQuickSort, double timeInsertionSort, double timeHeapSort) TestsSort()
    {
        Random rnd = new Random();
        var arr = new int[10000];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next();
        }

        var arr2 = (int[])arr.Clone();
        var arr3 = (int[])arr.Clone();
        var arr4 = (int[])arr.Clone();
        var arr5 = (int[])arr.Clone();

        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();
        BubbleSort.Sort(arr);
        stopwatch.Stop();

        var time1 = stopwatch.ElapsedTicks;

        stopwatch.Restart();
        DirectSort.Sort(arr2);
        stopwatch.Stop();

        var time2 = stopwatch.ElapsedTicks;

        stopwatch.Restart();
        QuickSort.Sort(arr3);
        stopwatch.Stop();

        var time3 = stopwatch.ElapsedTicks;

        stopwatch.Restart();
        InsertionSort.Sort(arr4);
        stopwatch.Stop();

        var time4 = stopwatch.ElapsedTicks;

        stopwatch.Restart();
        HeapSort.Sort(arr5);
        stopwatch.Stop();

        var time5 = stopwatch.ElapsedTicks;

        return (time1, time2, time3, time4, time5);
    }
}
