using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    internal class PrimeNumber
    {
        //  Задание 1
        //  Требуется реализовать на C# функцию согласно блок-схеме. Блок-схема описывает алгоритм проверки, простое число или нет.
        //⦁	Реализовать в виде консольного приложения.
        //⦁	Алгоритм реализовать в отдельном классе согласно блок-схеме.
        //⦁	Написать проверочный код(один положительный, один отрицательный сценарий) в отдельной функции и вызывать его при запуске.
        //⦁	Код выложить на GitHub.

        /// <summary>
        /// Метод определяет простое число или нет. На вход подается переменная long. Результатом работы метода является переменная bool. 
        /// </summary>
        /// <param name="number">Исследуемое число</param>
        /// <returns bool>Результат работы</returns>
        private bool CheckPrimeOrNot(long number)
        {
            int d = 0;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    d++;
                }
            }
            if (d == 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Метод определяет простое число или нет. На вход подается переменная long. Результатом работы метода является переменная bool. 
        /// </summary>
        /// <param name="number">Исследуемое число</param>
        /// <returns bool>Результат работы</returns>
        public bool CheckPrimeOrNotUpgrade(long number)
        {
            int d = 0;

            if (number == 2)
            {
                return true;
            }

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    d++;

                    return false;
                }
            }
            if (d == 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Метод запрашивает у пользователя число и выводит в консоль является ли это число простым.
        /// </summary>
        public void WritePrimeOrNot()
        {
            long number = 0;

            Console.Write($"Введите число >");

            try
            {
                number = Convert.ToInt64(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex}");

                return;
            }

            bool isPrime = CheckPrimeOrNot(number);

            if (isPrime)
            {
                Console.WriteLine($"Число {number} является простым");
            }
            else
            {
                Console.WriteLine($"Число {number} не является простым");
            }
        }
    }
}
