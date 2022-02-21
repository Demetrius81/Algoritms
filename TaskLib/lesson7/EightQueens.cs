using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms
{
    class EightQueens
    {
        /// <summary>
        /// Размер игрового поля
        /// </summary>
        private const int FIELD_DIMENTION = 8;

        /// <summary>
        /// Количество ферзей
        /// </summary>
        private const int QUEEN_COUNT = 8;

        /// <summary>
        /// Игровое поле
        /// </summary>
        private int[,] _gameField;

        /// <summary>
        /// Конструктор инициализирует игровое поле
        /// </summary>
        public EightQueens()
        {
            _gameField = new int[FIELD_DIMENTION, FIELD_DIMENTION];
            
            for (int i = 0; i < _gameField.GetLength(0); i++)
            {
                for (int j = 0; j < _gameField.GetLength(1); j++)
                {
                    _gameField[i, j] = 0;                    
                }
            }
        }

        /// <summary>
        /// Метод устанавливает ферзей
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private bool TryPutQueenOnField(int n = 1)
        {
            bool isPut = false;

            for (int i = 0; i < FIELD_DIMENTION; i++)
            {                
                if (_gameField[n - 1, i] == 0)
                {
                    SetQueenOnField(n - 1, i);

                    if (n == QUEEN_COUNT)
                    {
                        isPut = true;
                    }
                    else
                    {
                        isPut = TryPutQueenOnField(n + 1);

                        if (!isPut)
                        {
                            RemoveQueenFromField(n - 1, i);
                        }
                    }
                }
                if (isPut)
                {
                    break;
                }
            }
            return isPut;
        }

        /// <summary>
        /// Метод выводит на экран игровое поле
        /// </summary>
        /// <param name="array">Икровое поле</param>
        private void PrintArray(int[,] array)
        {
            Console.Clear();
            Console.WriteLine("   A   B   C   D   E   F   G   H");
            Console.WriteLine(" ---------------------------------");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write($"{i + 1}|");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == -1)
                    {
                        Console.Write($" # |");
                    }
                    else
                    {
                        Console.Write($"   |");

                    }
                }
                Console.WriteLine($"{i + 1}");
                Console.WriteLine(" ---------------------------------");
            }
            Console.WriteLine("   A   B   C   D   E   F   G   H");
        }

        /// <summary>
        /// метод добавляет ферзя по координатам
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private void SetQueenOnField(int x, int y)
        {
            for (int i = 1; i < FIELD_DIMENTION; i++)
            {
                if ((x + i) < FIELD_DIMENTION && (y + i) < FIELD_DIMENTION && _gameField[x + i, y + i] == 0)
                {
                    _gameField[x + i, y + i] = x + 1;
                }
                if ((x - i) >= 0 && (y - i) >= 0 && _gameField[x - i, y - i] == 0)
                {
                    _gameField[x - i, y - i] = x + 1;
                }
                if ((x + i) < FIELD_DIMENTION && (y - i) >= 0 && _gameField[x + i, y - i] == 0)
                {
                    _gameField[x + i, y - i] = x + 1;
                }
                if ((x - i) >= 0 && (y + i) < FIELD_DIMENTION && _gameField[x - i, y + i] == 0)
                {
                    _gameField[x - i, y + i] = x + 1;
                }
                if ((y + i) < FIELD_DIMENTION && _gameField[x, y + i] == 0)
                {
                    _gameField[x, y + i] = x + 1;
                }
                if ((y - i) >= 0 && _gameField[x, y - i] == 0)
                {
                    _gameField[x, y - i] = x + 1;
                }
                if ((x + i) < FIELD_DIMENTION && _gameField[x + i, y] == 0)
                {
                    _gameField[x + i, y] = x + 1;
                }
                if ((x - i) >= 0 && _gameField[x - i, y] == 0)
                {
                    _gameField[x - i, y] = x + 1;
                }
            }
            _gameField[x, y] = -1;
        }

        /// <summary>
        /// Метод запускает выполнение алгоритмов задачи
        /// </summary>
        public void OutputResult()
        {
            TryPutQueenOnField();

            PrintArray(_gameField);
        }

        /// <summary>
        /// Метод удаляет ферзя по координатам
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private void RemoveQueenFromField(int x, int y)
        {
            for (int i = 1; i < FIELD_DIMENTION; i++)
            {
                if ((x + i) < FIELD_DIMENTION && (y + i) < FIELD_DIMENTION && _gameField[x + i, y + i] == x + 1)
                {
                    _gameField[x + i, y + i] = 0;
                }
                if ((x - i) >= 0 && (y - i) >= 0 && _gameField[x - i, y - i] == x + 1)
                {
                    _gameField[x - i, y - i] = 0;
                }
                if ((x + i) < FIELD_DIMENTION && (y - i) >= 0 && _gameField[x + i, y - i] == x + 1)
                {
                    _gameField[x + i, y - i] = 0;
                }
                if ((x - i) >= 0 && (y + i) < FIELD_DIMENTION && _gameField[x - i, y + i] == x + 1)
                {
                    _gameField[x - i, y + i] = 0;
                }
                if ((y + i) < FIELD_DIMENTION && _gameField[x, y + i] == x + 1)
                {
                    _gameField[x, y + i] = 0;
                }
                if ((y - i) >= 0 && _gameField[x, y - i] == x + 1)
                {
                    _gameField[x, y - i] = 0;
                }
                if ((x + i) < FIELD_DIMENTION && _gameField[x + i, y] == x + 1)
                {
                    _gameField[x + i, y] = 0;
                }
                if ((x - i) >= 0 && _gameField[x - i, y] == x + 1)
                {
                    _gameField[x - i, y] = 0;
                }
            }
            _gameField[x, y] = 0;
        }
    }
}
