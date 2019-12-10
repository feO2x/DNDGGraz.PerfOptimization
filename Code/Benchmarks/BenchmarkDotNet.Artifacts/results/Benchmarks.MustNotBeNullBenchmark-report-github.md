``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
Intel Core i5-6300U CPU 2.40GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.100
  [Host]     : .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT
  Job-HPRIJY : .NET Framework 4.8 (4.8.4042.0), X64 RyuJIT
  Job-BQRCYN : .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT


```
|             Method |       Runtime |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------- |-------------- |----------:|----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
|         Imperative |      .NET 4.8 | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |     - |     - |     - |         - |
|  LightGuardClauses |      .NET 4.8 | 2.2602 ns | 0.0858 ns | 0.0803 ns | 2.2908 ns |     ? |       ? |     - |     - |     - |         - |
|             Simple |      .NET 4.8 | 0.9328 ns | 0.0973 ns | 0.0862 ns | 0.9785 ns |     ? |       ? |     - |     - |     - |         - |
| AggressiveInlining |      .NET 4.8 | 0.1010 ns | 0.0841 ns | 0.0786 ns | 0.0571 ns |     ? |       ? |     - |     - |     - |         - |
|  ExternalThrowCall |      .NET 4.8 | 0.0548 ns | 0.0681 ns | 0.0637 ns | 0.0523 ns |     ? |       ? |     - |     - |     - |         - |
|                    |               |           |           |           |           |       |         |       |       |       |           |
|         Imperative | .NET Core 3.1 | 0.4442 ns | 0.0727 ns | 0.0644 ns | 0.4774 ns |  1.00 |    0.00 |     - |     - |     - |         - |
|  LightGuardClauses | .NET Core 3.1 | 2.5430 ns | 0.1092 ns | 0.0968 ns | 2.5035 ns |  5.85 |    0.93 |     - |     - |     - |         - |
|             Simple | .NET Core 3.1 | 1.4524 ns | 0.1091 ns | 0.1021 ns | 1.4376 ns |  3.32 |    0.50 |     - |     - |     - |         - |
| AggressiveInlining | .NET Core 3.1 | 0.2319 ns | 0.0812 ns | 0.0760 ns | 0.1955 ns |  0.56 |    0.22 |     - |     - |     - |         - |
|  ExternalThrowCall | .NET Core 3.1 | 0.3100 ns | 0.1058 ns | 0.0989 ns | 0.3708 ns |  0.71 |    0.30 |     - |     - |     - |         - |
