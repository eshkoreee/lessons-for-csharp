using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benchmark
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<MyParserBenchmark>();
        }
    }
}
