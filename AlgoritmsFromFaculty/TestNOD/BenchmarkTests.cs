using BenchmarkDotNet.Attributes;

namespace TestNOD;

public class BenchmarkTests
{
    private readonly AlgoritmsGCD _algoritmsGCD;

    [Params(1, int.MaxValue)]
    public int a;

    [Params(1, int.MaxValue)]
    public int b;

    public BenchmarkTests()
    {
        _algoritmsGCD = new AlgoritmsGCD();
    }



    [Benchmark(Description = "01 перебор от произвольного числа       ")]
    public int Gsd01()
    {
        return _algoritmsGCD.GetGCD01(a, b);
    }

    [Benchmark(Description = "02 перебор от минимального числа        ")]
    public int Gsd02()
    {
        return _algoritmsGCD.GetGCD02(a, b);
    }

    [Benchmark(Description = "03 с разложением на делители            ")]
    public int Gsd03()
    {
        return _algoritmsGCD.GetGCD03(a, b);
    }

    [Benchmark(Description = "04 алгоритм Евклида рекурсивный         ")]
    public int Gsd04()
    {
        return _algoritmsGCD.GetGCD04(a, b);
    }

    [Benchmark(Description = "05 алгоритм Евклида итерационный        ")]
    public int Gsd05()
    {
        return _algoritmsGCD.GetGCD05(a, b);
    }

    [Benchmark(Description = "06 бинарный алгоритм рекурсивный        ")]
    public int Gsd06()
    {
        return _algoritmsGCD.GetGCD06(a, b);
    }

    [Benchmark(Description = "07 бинарный алгоритм итерационный       ")]
    public int Gsd07()
    {
        return _algoritmsGCD.GetGCD07(a, b);
    }

    [Benchmark(Description = "08 бинарный алгоритм итерац. со сдвигом ")]
    public int Gsd08()
    {
        return _algoritmsGCD.GetGCD08(a, b);
    }
}
