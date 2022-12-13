namespace Algoritms.Sort;

/// <summary>Класс сортировки вставками</summary>
internal class InsertionSort
{
    protected InsertionSort() { }

    /// <summary>Метод запускает сортировку вставками</summary>
    /// <param name="array">ссылка на массив для сортировки</param>
    public static void Sort(int[] array)
    {
        int x;
        int j;

        for (int i = 1; i < array.Length; i++)
        {
            x = array[i];
            j = i;

            while (j > 0 && array[j - 1] > x)
            {
                Swap(array, j, j - 1);
                j -= 1;
            }
            array[j] = x;
        }
    }

    /// <summary>Метод меняет значения двух элементов массива по индексам этих элементов</summary>
    /// <param name="array">ссылка на массив</param>
    /// <param name="i">индекс первого элемента</param>
    /// <param name="j">индекс второго элемента</param>
    private static void Swap(int[] array, int i, int j)
    {
        (array[i], array[j]) = (array[j], array[i]);
    }
}
