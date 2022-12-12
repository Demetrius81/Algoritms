using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms.Sort;
internal class HeapSort
{
    public static void Sort(int[] array) =>
        Sort(array, array.Length, array.Length / 2);

    private static void Sort(int[] array, int length, int root)
    {
        int left = 2 * root + 1;
        length = array.Length;
        int right = 2 * root + 2;
        int largest = root;

        if (left < length && array[left] > array[largest])
        {
            largest = left;
        }

        if (right < length && array[right] > array[largest])
        {
            largest = right;
        }

        if (largest != root)
        {            
            (array[root], array[largest]) = (array[largest], array[root]);            
            Sort(array, length, largest);
        }
    }
}
