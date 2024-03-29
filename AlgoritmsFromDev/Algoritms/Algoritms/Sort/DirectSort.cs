﻿using System;
using System.Collections.Generic;
using System.Text;
namespace Algoritms.Sort;

/// <summary>Класс прямой сортировки</summary>
internal class DirectSort
{
    protected DirectSort() { }

    /// <summary>Метод запускает прямую сортировку</summary>
    /// <param name="array">ссылка на массив для сортировки</param>
    public static void Sort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int min = array[i];
            int minPosition = i;

            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < min)
                {
                    min = array[j];
                    minPosition = j;
                }
            }

            if (min != array[i])
            {
                (array[i], array[minPosition]) = (array[minPosition], array[i]);
            }
        }
    }
}
