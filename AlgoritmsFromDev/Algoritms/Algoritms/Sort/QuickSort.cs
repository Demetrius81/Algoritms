namespace Algoritms.Sort;

internal class QuickSort
{
    protected QuickSort() { }

    /// <summary>Метод запускает быструю сортировку</summary>
    /// <param name="array">ссылка на массив для сортировки</param>
    public static void Sort(int[] array) =>
        Sort(array, 0, array.Length - 1);

    /// <summary>Метод выполняет быструю сортировку</summary>
    /// <param name="array">ссылка на массив для сортировки</param>
    /// <param name="startPosition">начальная позиция сортировки</param>
    /// <param name="endPosition">конечная позиция сортировки</param>
    private static void Sort(int[] array, int startPosition, int endPosition)
    {
        int leftPosition = startPosition;
        int rightPosition = endPosition;
        int pivot = array[(startPosition + endPosition) / 2];

        do
        {
            while (array[leftPosition] < pivot)
            {
                leftPosition++;
            }

            while (array[rightPosition] > pivot)
            {
                rightPosition--;
            }

            if (leftPosition <= rightPosition)
            {
                if (leftPosition < rightPosition)
                {
                    (array[leftPosition], array[rightPosition]) = (array[rightPosition], array[leftPosition]);
                }

                leftPosition++;
                rightPosition--;
            }

        } while (leftPosition <= rightPosition);

        if (leftPosition < endPosition)
        {
            Sort(array, leftPosition, endPosition);
        }
        if (startPosition < rightPosition)
        {
            Sort(array, startPosition, rightPosition);
        }
    }
}
