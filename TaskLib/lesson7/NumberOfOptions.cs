using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms
{
    class NumberOfOptions
    {
        public void NumberOfOptionsOutput(int n = 16)
        {
            double[] results = TestNumberOfOptionsLogicOnArray(out double[] array, n);

            Console.Clear();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Количество вариантов для числа | {array[i]}\t| равно | {results[i]}\t|");
            }
            Console.ReadKey();
        }

        private double NumberOfOptionsLogic(double n)
        {
            double numberOfOptions = 1;

            if (n % 2 != 0 && n > 1)
            {
                numberOfOptions = NumberOfOptionsLogic(n - 1);
            }
            else if (n % 2 == 0 && n > 1)
            {
                numberOfOptions = NumberOfOptionsLogic(n - 1) + NumberOfOptionsLogic(n / 2);
            }
            return numberOfOptions;
        }

        private double[] TestNumberOfOptionsLogicOnArray(out double[] array, int length = 100)
        {
            double[] arr = new double[length];

            double[] results = new double[length];

            for (int i = 0; i < length; i++)
            {
                arr[i] = i + 1;
            }
            
            for (int i = 0; i < length; i++)
            {
                results[i] = NumberOfOptionsLogic(arr[i]);
            }
            for (int i = 0; i < length; i++)
            {
                results[i] = NumberOfOptionsLogic(arr[i]);
            }
            array = arr;

            return results;
        }
    }
}
