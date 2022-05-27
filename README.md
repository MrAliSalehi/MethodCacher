# Method Cacher

This Is A Quick Guide For Creating Cache System Over Your Methods!

Understand This That If Your Process Is Not <b>Heavy</b> You May Not Want To Use Cache System.

Also Consider This System Will Allocate <b>A Little</b> Bit More Memory In Caces That Your Dont Have Huge Operation!.

But Again Refer To [This Benchmark](https://github.com/MrAliSalehi/MethodCacher/blob/master/MethodCacher.Benchmark/Bench.cs) :

|        Method |               Mean |           Error |          StdDev |             Median | Allocated |
|-------------- |-------------------:|----------------:|----------------:|-------------------:|----------:|
|    WithCacher |           389.5 ns |        12.14 ns |        30.89 ns |           400.0 ns |     480 B |
| WithOutCacher | 2,010,654,446.7 ns | 4,548,054.94 ns | 4,254,253.41 ns | 2,011,370,300.0 ns | 125,480 B |


It Will Help You In Some Cases :))))

Feel Free To Open Issues Or PR.

<i>The Main Class Located In [Here](https://github.com/MrAliSalehi/MethodCacher/blob/master/MethodCacher/Cacher.cs)</i>

<i>And [How To Use](https://github.com/MrAliSalehi/MethodCacher/blob/master/MethodCacher.Test/Program.cs) </i>
