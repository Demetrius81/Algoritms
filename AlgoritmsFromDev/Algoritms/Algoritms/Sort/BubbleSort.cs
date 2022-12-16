namespace Algoritms.Sort;

/// <summary>Класс пузырьковой сортировки</summary>
internal class BubbleSort
{
    protected BubbleSort() { }

    /// <summary>Метод выполняет пузырьковую сортировку</summary>
    /// <param name="array">ссылка на массив для сортировки</param>
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
