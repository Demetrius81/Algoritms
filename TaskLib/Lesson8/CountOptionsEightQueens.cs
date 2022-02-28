using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms
{
    class CountOptionsEightQueens : EightQueens
    {
        /// <summary>
        /// Список со всеми вариантами расстановки ферзей
        /// </summary>
        private List<int[]> _allVariants = new List<int[]>();

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
        private List<int[]> AllVariants { get => _allVariants; set => _allVariants = value; }

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

        /// <summary>
        /// Метод расставляет ферзей на игровом поле в соответствии с координатами
        /// </summary>
        /// <returns>int[,] игровое поле</returns>
        private int[,] SetQueenOnField()
        {
            int[,] gameField = new int[FIELD_DIMENTION, FIELD_DIMENTION];

            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    if (QueenPosition[i + 1] == j)
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
        /// Метод проверяет нахождение ферзей на главных диагоналях
        /// </summary>
        /// <returns>bool возврашает ответ на вопрои их там нет?</returns>
        private bool CheckCrossQueensMainDiagonal()
        {
            bool isNoThere = true;

            for (int i = 1; i <= QUEEN_COUNT; i++)
            {
                if ((i == QueenPosition[i]) | (i + QueenPosition[i] == 9))
                {
                    isNoThere = false;

                    break;
                }
            }
            return isNoThere;
        }

        /// <summary>
        /// Метод осуществляет перебор всех комбинаций взаимного расположения ферзей
        /// </summary>
        private void EnumerationOfAllOptions()
        {
            int count = 0;

            for (int i1 = 1; i1 <= QUEEN_COUNT; i1++)
            {
                QueenPosition[i1] = i1;

                for (int i2 = 1; i2 <= QUEEN_COUNT; i2++)
                {
                    QueenPosition[i2] = i2;

                    for (int i3 = 1; i3 <= QUEEN_COUNT; i3++)
                    {
                        QueenPosition[i3] = i3;

                        for (int i4 = 1; i4 <= QUEEN_COUNT; i4++)
                        {
                            QueenPosition[i4] = i4;

                            for (int i5 = 1; i5 <= QUEEN_COUNT; i5++)
                            {
                                QueenPosition[i5] = i5;

                                for (int i6 = 1; i6 <= QUEEN_COUNT; i6++)
                                {
                                    QueenPosition[i6] = i6;

                                    for (int i7 = 1; i7 <= QUEEN_COUNT; i7++)
                                    {
                                        QueenPosition[i7] = i7;

                                        for (int i8 = 1; i8 <= QUEEN_COUNT; i8++)
                                        {
                                            QueenPosition[i8] = i8;


                                            CountNotCrossAllQueens = 0;

                                            CheckCrossQueens();
                                            Console.Write(CountNotCrossAllQueens);
                                            //Console.WriteLine(NumberNotCrossAllQueens);
                                            if (CountNotCrossAllQueens == NumberNotCrossAllQueens)
                                            {
                                                bool b = CheckCrossQueensMainDiagonal();

                                                //b = false;

                                                if (!b)
                                                {
                                                    count++;
                                                    Console.WriteLine(count);
                                                    QueenPosition[0] = count;

                                                    AllVariants.Add(QueenPosition);

                                                    //for (int i = 1; i <= FIELD_DIMENTION; i++)
                                                    //{
                                                    //    Console.Write(count);

                                                    //    Console.Write("  ");

                                                    //    Console.Write(QueenPosition[i]);

                                                    //    Console.Write("  ");
                                                    //}
                                                    //Console.WriteLine();
                                                }
                                            }




                                        }
                                        Console.WriteLine();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }


        public void RunCheck()
        {
            EnumerationOfAllOptions();

            foreach (var item in AllVariants)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    Console.Write(item[i]);
                }
                Console.WriteLine();
            }
            //Console.WriteLine(AllVariants.Count + 1);
        }







    }
}
