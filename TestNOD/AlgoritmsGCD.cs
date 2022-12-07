using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNOD;

internal class AlgoritmsGCD
{
    /// <summary>
    /// Алгоритм перебора от произвольного числа
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int GetGCD01(int a, int b)
    {

        int nod = 1;
        for (int i = a; i > 0; i--)
        {
            if (a % i == 0 && b % i == 0)
            {
                nod = i;
                break;
            }
        }
        return nod;
    }

    /// <summary>
    /// Алгоритм перебора от минимального числа
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int GetGCD02(int a, int b)
    {

        int nod = 1;
        for (int i = min(a, b); i > 0; i--)
        {
            if (a % i == 0 && b % i == 0)
            {
                nod = i;
                break;
            }
        }
        return nod;
    }

    /// <summary>
    /// Алгоритм с разложением на делители
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int GetGCD03(int a, int b)
    {

        int nod = 1;

        if (a > b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        while (a > 1 && b > 1)
        {
            for (int i = 2; i <= a; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    nod *= i;
                    a /= i;
                    b /= i;
                    break;
                }
                if (a % i == 0)
                {
                    a /= i;
                    break;
                }
                if (b % i == 0)
                {
                    b /= i;
                    break;
                }
            }
        }
        return nod;
    }

    /// <summary>
    /// Алгоритм Евклида рекурсивный
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int GetGCD04(int a, int b)
    {

        if (a == b)
        {
            return a;
        }
        if (a > b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
        return GetGCD04(a, b - a);
    }

    /// <summary>
    /// Алгоритм Евклида итерационный
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int GetGCD05(int a, int b)
    {

        while (a != b)
        {
            if (a > b)
            {
                int tmp = a;
                a = b;
                b = tmp;
            }
            b -= a;
        }
        return a;
    }

    /// <summary>
    /// Бинарный алгоритм рекурсивный
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int GetGCD06(int a, int b)
    {
        if (a == 0)
        {
            return b;
        }

        if (b == 0)
        {
            return a;
        }

        if (a == b)
        {
            return a;
        }

        if (a == 1 || b == 1)
        {
            return 1;
        }

        if (a % 2 == 0 && b % 2 == 0)
        {
            return 2 * GetGCD06(a / 2, b / 2);
        }

        if (a % 2 == 0 && b % 2 != 0)
        {
            return GetGCD06(a / 2, b);
        }

        if (a % 2 != 0 && b % 2 == 0)
        {
            return GetGCD06(a, b / 2);
        }

        if (a < b)
        {
            return GetGCD06((b - a) / 2, a);
        }
        else
        {
            return GetGCD06((a - b) / 2, b);
        }
    }

    /// <summary>
    /// Бинарный алгоритм итерационный
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int GetGCD07(int a, int b)
    {
        int nod = 1;
        int tmp;

        if (a == 0)
        {
            return b;
        }

        if (b == 0)
        {
            return a;
        }

        if (a == b)
        {
            return a;
        }

        if (a == 1 || b == 1)
        {
            return 1;
        }

        while (a != 0 && b != 0)
        {
            if (a % 2 == 0 && b % 2 == 0)
            {
                nod *= 2;
                a /= 2;
                b /= 2;
                continue;
            }

            if (a % 2 == 0 && b % 2 != 0)
            {
                a /= 2;
                continue;
            }

            if (a % 2 != 0 && b % 2 == 0)
            {
                b /= 2;
                continue;
            }

            if (a > b)
            {
                tmp = a;
                a = b;
                b = tmp;
            }

            tmp = a;
            a = (b - a) / 2;
            b = tmp;
        }

        if (a == 0)
        {
            return nod * b;
        }
        else
        {
            return nod * a;
        }
    }

    /// <summary>
    /// Бинарный итерационный алгоритм с использованием битовых операций
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int GetGCD08(int a, int b)
    {
        int nod = 1;
        int tmp;
        if (a == 0)
        {
            return b;
        }

        if (b == 0)
        {
            return a;
        }

        if (a == b)
        {
            return a;
        }

        if (a == 1 || b == 1)
        {
            return 1;
        }

        while (a != 0 && b != 0)
        {
            if (((a & 1) | (b & 1)) == 0)
            {
                nod <<= 1;
                a >>= 1;
                b >>= 1;
                continue;
            }

            if (((a & 1) == 0) && (b & 1) != 0)
            {
                a >>= 1;
                continue;
            }

            if ((a & 1) != 0 && ((b & 1) == 0))
            {
                b >>= 1;
                continue;
            }

            if (a > b)
            {
                tmp = a;
                a = b;
                b = tmp;
            }

            tmp = a;
            a = (b - a) >> 1;
            b = tmp;
        }

        if (a == 0)
        {
            return nod * b;
        }
        else
        {
            return nod * a;
        }
    }

    /// <summary>
    /// Поиск минимального числа
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    private int min(int a, int b)
    {
        return a > b ? b : a;
    }
}
