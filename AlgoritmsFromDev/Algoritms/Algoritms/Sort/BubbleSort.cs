using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms.Sort
{
    internal class BubbleSort
    {
        protected BubbleSort() { }

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
                        (array[i - 1], array[i]) = (array[i], array[i - 1]);
                        needSort = true;
                    }
                }

            } while (needSort);
        }
    }
}
