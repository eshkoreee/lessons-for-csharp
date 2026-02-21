using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
namespace Benchmark
{
    [MemoryDiagnoser]
    internal class Program
    {
        [Benchmark]
        public void NoBoxing()
        {
            int res = 0;
            int a = 1;
            res += a;
        }
        [Benchmark]
        public void Boxing()
        {
            int res = 0;
            object a = 1;
            res += (int)a;
        }
    }
}
