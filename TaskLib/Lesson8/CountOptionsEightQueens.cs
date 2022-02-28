using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms
{
    class CountOptionsEightQueens : EightQueens
    {
        /// <summary>
        /// Массив с координатами расположения ферзей
        /// </summary>
        private int[] _queenPosition;

        /// <summary>
        /// Счетчик непересечений всех ферзей = ((N-1) + (N-2) + ... + 1), где N количество ферзей
        /// </summary>
        private int _countNotCrossAllQueens;

        /// <summary>
        /// Количество непересечений
        /// </summary>
        private readonly int _numberNotCrossAllQueens;

        private int NumberNotCrossAllQueens { get => _numberNotCrossAllQueens; }
        private int CountNotCrossAllQueens { get => _countNotCrossAllQueens; set => _countNotCrossAllQueens = value; }
        private int[] QueenPosition { get => _queenPosition; set => _queenPosition = value; }
        
        /// <summary>
        /// Конструктор
        /// </summary>
        public CountOptionsEightQueens()
        {
            QueenPosition = new int[FIELD_DIMENTION + 1];

            CountNotCrossAllQueens = 0;

            _numberNotCrossAllQueens = NumberNotCrossAllQueensCalculator(QUEEN_COUNT);
        }

        /// <summary>
        /// Метод считает количество непересечений для N ферзей по формуле ((N-1) + (N-2) + ... + 1), где N количество ферзей
        /// </summary>
        /// <param name="countOfQueens">int количество ферзей</param>
        /// <returns>int количество непересечений для N ферзей</returns>
        private int NumberNotCrossAllQueensCalculator(int countOfQueens)
        {
            int numberNotCross = 0;

            if (countOfQueens != 0)
            {
                numberNotCross = NumberNotCrossAllQueensCalculator(countOfQueens - 1) + (countOfQueens - 1);
            }
            return numberNotCross;
        }

        #region реализовать позже
        /// <summary>
        /// Метод расставляет ферзей на игровом поле в соответствии с координатами
        /// </summary>
        /// <returns>int[,] игровое поле</returns>
        private int[,] SetQueenOnField(int[] Queenpos)
        {
            int[,] gameField = new int[FIELD_DIMENTION, FIELD_DIMENTION];

            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    if (Queenpos[i + 1] == j)
                    {
                        gameField[i, j] = -1;
                    }
                    else
                    {
                        gameField[i, j] = 0;
                    }
                }
            }
            return gameField;
        }
        #endregion

        /// <summary>
        /// Метод считает количество непересечений ферзей
        /// </summary>
        private void CheckCrossQueens()
        {
            bool notOneHorisontal = false;

            bool notOneDiagonalLeft = false;

            bool notOneDiagonalRight = false;

            for (int i = 1; i < QUEEN_COUNT; i++)
            {
                for (int j = (i + 1); j <= QUEEN_COUNT; j++)
                {
                    notOneHorisontal = QueenPosition[i] != QueenPosition[j];

                    notOneDiagonalLeft = (QueenPosition[j] - QueenPosition[i]) != (j - i);

                    notOneDiagonalRight = (QueenPosition[i] + i) != (QueenPosition[j] + j);

                    if (notOneHorisontal && notOneDiagonalLeft && notOneDiagonalRight)
                    {
                        CountNotCrossAllQueens++;
                    }
                }
            }
        }

        /// <summary>
        /// Метод осуществляет перебор всех комбинаций взаимного расположения ферзей
        /// </summary>
        private int EnumerationOfAllOptions()
        {
            int count = 0;

            for (int a = 1; a <= QUEEN_COUNT; a++)
            {
                QueenPosition[1] = a;

                for (int b = 1; b <= QUEEN_COUNT; b++)
                {
                    QueenPosition[2] = b;

                    for (int c = 1; c <= QUEEN_COUNT; c++)
                    {
                        QueenPosition[3] = c;

                        for (int d = 1; d <= QUEEN_COUNT; d++)
                        {
                            QueenPosition[4] = d;

                            for (int e = 1; e <= QUEEN_COUNT; e++)
                            {
                                QueenPosition[5] = e;

                                for (int f = 1; f <= QUEEN_COUNT; f++)
                                {
                                    QueenPosition[6] = f;

                                    for (int g = 1; g <= QUEEN_COUNT; g++)
                                    {
                                        QueenPosition[7] = g;

                                        for (int h = 1; h <= QUEEN_COUNT; h++)
                                        {
                                            QueenPosition[8] = h;

                                            CountNotCrossAllQueens = 0;

                                            CheckCrossQueens();

                                            if (CountNotCrossAllQueens == NumberNotCrossAllQueens)
                                            {
                                                count++;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return count;
        }

        /// <summary>
        /// Метод запускает расчет всех комбинаций и выводит на экран результаты расчета
        /// </summary>
        public void RunCheck()
        {
            Console.Clear();

            Console.WriteLine($"Идет подсчет количества вариантов методом перебора всех комбинаций...");

            int count = EnumerationOfAllOptions();

            Console.WriteLine($"Задача о восьми ферзях имеет {count} вариантов решений.");

        }
    }
}