using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms
{
    class NumberOfOptions
    {
        /// <summary>
        /// Метод выводит в консоль результаты вычислений количества вариантов для числа n
        /// </summary>
        /// <param name="n">Длина массива</param>
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

        /// <summary>
        /// Метод несет в себе логику подсчета количества вариантов для числа n
        /// </summary>
        /// <param name="n">double число для подсчета количества вариантов</param>
        /// <returns>double результат работы метода</returns>
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

        /// <summary>
        /// Метод производит тест логики на выбранной последовательности
        /// </summary>
        /// <param name="array">Массив исходных чисел</param>
        /// <param name="length">Длина массива</param>
        /// <returns>Массив результатов вычислений</returns>
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
            array = arr;

            return results;
        }
    }
}
