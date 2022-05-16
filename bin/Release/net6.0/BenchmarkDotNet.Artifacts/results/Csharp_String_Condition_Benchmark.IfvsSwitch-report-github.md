``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.300
  [Host]     : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  DefaultJob : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT


```
|            Method |      Mean |     Error |    StdDev |
|------------------ |----------:|----------:|----------:|
|     BIf1Condition | 0.2186 ns | 0.0054 ns | 0.0042 ns |
| Bswitch1Condition | 0.2210 ns | 0.0110 ns | 0.0103 ns |
|     BIf2Condition | 0.4853 ns | 0.0161 ns | 0.0143 ns |
| Bswitch2Condition | 0.8587 ns | 0.0179 ns | 0.0168 ns |
|     BIf3Condition | 1.6122 ns | 0.0126 ns | 0.0105 ns |
| Bswitch3Condition | 1.3824 ns | 0.0207 ns | 0.0194 ns |
|     BIf4Condition | 1.7385 ns | 0.0153 ns | 0.0143 ns |
| Bswitch4Condition | 2.2057 ns | 0.0079 ns | 0.0070 ns |
|     BIf5Condition | 2.4899 ns | 0.0141 ns | 0.0125 ns |
| Bswitch5Condition | 3.1487 ns | 0.0089 ns | 0.0083 ns |
|     BIf6Condition | 3.1359 ns | 0.0119 ns | 0.0105 ns |
| Bswitch6Condition | 3.2520 ns | 0.0128 ns | 0.0120 ns |
