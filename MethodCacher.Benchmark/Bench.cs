using BenchmarkDotNet.Attributes;

namespace MethodCacher.Benchmark;

[MemoryDiagnoser(true)]
public class Bench
{
    private static readonly Cacher<int, int> Cacher = new(Math.SumNumber);
    [Benchmark]
    public int WithCacher()
    {
        return Cacher.Invoke(10);
    }

    [Benchmark]
    public int WithOutCacher()
    {
        return Math.SumNumber(10);
    }
}

public static class Math
{
    public static int SumNumber(int num)
    {
        var secNum = Enumerable.Range(340, 30434).ToList().First();
        Thread.Sleep(2000);
        return num + secNum;
    }
}