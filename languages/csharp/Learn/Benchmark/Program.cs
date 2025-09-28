using System.Diagnostics;
using Benchmark;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Validators;

var sw = new Stopwatch();
sw.Start();

var config = new ManualConfig()
    .WithOptions(ConfigOptions.DisableOptimizationsValidator)
    .AddValidator(JitOptimizationsValidator.DontFailOnError)
    .AddLogger(ConsoleLogger.Default)
    .AddColumnProvider(DefaultColumnProviders.Instance);
BenchmarkRunner.Run<Arrays>(config);

sw.Stop();
Console.WriteLine(sw.ElapsedMilliseconds);
