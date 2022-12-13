namespace Algoritms.Sort;
internal class InsertionSort
{
    protected InsertionSort() { }

    public static void Sort(int[] inArray)
    {
        int x;
        int j;

        for (int i = 1; i < inArray.Length; i++)
        {
            x = inArray[i];
            j = i;

            while (j > 0 && inArray[j - 1] > x)
            {
                Swap(inArray, j, j - 1);
                j -= 1;
            }
            inArray[j] = x;
        }
    }

    private static void Swap(int[] array, int i, int j)
    {
        (array[i], array[j]) = (array[j], array[i]);
    }
}
