using System.Diagnostics;
using MethodCacher;

Cacher<int, int> cacher = new(Sum);

var result1 = cacher.Invoke(12);
var result2 = cacher.Invoke(12);
var result3 = cacher.Invoke(12);

var sv = new Stopwatch();
sv.Start();
Console.WriteLine($"First Time: {result1}");
sv.Stop();
Console.WriteLine($"First Execute:{sv.ElapsedMilliseconds}ms");
sv.Reset();
sv.Start();
Console.WriteLine($"Second Time: {result2}");
Console.WriteLine($"Third Time: {result3}");
sv.Stop();
Console.WriteLine($"The Next 2 Execute {sv.ElapsedMilliseconds}ms");
Console.ReadKey();
int Sum(int a)
{
    Thread.Sleep(3000);
    return a + 2;
}