```

BenchmarkDotNet v0.13.11, Windows 11 (10.0.22631.2861/23H2/2023Update/SunValley3)
Intel Core i5-9300H CPU 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.403
  [Host]     : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2


```
| Method                | N | Mean      | Error     | StdDev    |
|---------------------- |-- |----------:|----------:|----------:|
| **ListContains**          | **1** |  **5.217 ns** | **0.1389 ns** | **0.2036 ns** |
| HashSetContains       | 1 |  5.795 ns | 0.2209 ns | 0.6304 ns |
| ArrayListContains     | 1 | 20.594 ns | 0.5958 ns | 1.7286 ns |
| DictionaryContainsKey | 1 |  5.297 ns | 0.1409 ns | 0.3179 ns |
| **ListContains**          | **2** | **11.941 ns** | **0.2397 ns** | **0.5210 ns** |
| HashSetContains       | 2 | 10.787 ns | 0.2881 ns | 0.8079 ns |
| ArrayListContains     | 2 | 46.489 ns | 1.8806 ns | 5.4259 ns |
| DictionaryContainsKey | 2 | 10.105 ns | 0.2346 ns | 0.4290 ns |
| **ListContains**          | **3** | **18.672 ns** | **0.2808 ns** | **0.3121 ns** |
| HashSetContains       | 3 | 14.881 ns | 0.2712 ns | 0.5226 ns |
| ArrayListContains     | 3 | 64.038 ns | 0.4334 ns | 0.3842 ns |
| DictionaryContainsKey | 3 | 13.920 ns | 0.1050 ns | 0.0982 ns |
