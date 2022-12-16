using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms.Search;
internal class BinarySearch
{
    protected BinarySearch() { }
    public static int Search(int[] array, int searchedValue) => Search(array, searchedValue, 0, array.Length);

    private static int Search(int[] array, int searchedValue, int first, int last)
    {
        if (first > last)
        {
            return -1;
        }

        var middle = (first + last) / 2;
        var middleValue = array[middle];

        if (middleValue == searchedValue)
        {
            return middle;
        }
        else
        {
            if (middleValue > searchedValue)
            {
                return Search(array, searchedValue, first, middle - 1);
            }
            else
            {
                return Search(array, searchedValue, middle + 1, last);
            }
        }
    }
}
