using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms.Sort;
internal class HeapSort
{
    protected HeapSort() { }
    public static void Sort(int[] array)
    {
        int count = array.Length;

        for (int i = count / 2 - 1; i >= 0; i--)
        {
            Heapify(array, count, i);
        }

        for (int i = count - 1; i >= 0; i--)
        {
            (array[0], array[i]) = (array[i], array[0]);
            Heapify(array, i, 0);
        }
    }


    private static void Heapify(int[] array, int sizeHeap, int root)
    {
        int largest = root;
        int left = 2 * root + 1;
        int right = 2 * root + 2;

        if (left < sizeHeap && array[left] > array[largest])
        {
            largest = left;
        }

        if (right < sizeHeap && array[right] > array[largest])
        {
            largest = right;
        }

        if (largest != root)
        {
            (array[root], array[largest]) = (array[largest], array[root]);
            Heapify(array, sizeHeap, largest);
        }
    }
}

