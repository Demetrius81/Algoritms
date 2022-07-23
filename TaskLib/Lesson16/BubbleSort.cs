using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms.Lesson16
{
    internal class BubbleSort
    {
        public static void Sort(int[] array)
        {
            bool needSort;
            do
            {
                needSort = false;

                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i - 1] > array[i])
                    {
                        int temp = array[i - 1];

                        array[i - 1] = array[i];

                        array[i] = temp;

                        needSort = true;
                    }
                }
            } while (needSort);
        }
    }
}
