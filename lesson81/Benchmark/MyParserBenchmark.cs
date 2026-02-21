using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Benchmark
{
    [MemoryDiagnoser]
    [RankColumn]
    public class MyParserBenchmark
    {
        private const string STRING_TO_PARSE_WITH_ERROR = "qwerty22";
        private const string STRING_TO_PARSE = "54";

        private readonly MyParser _myParser = new MyParser();

        [Benchmark]
        public void TryCatchParseTestWithError()
        {
            int result = _myParser.TryCathParse(STRING_TO_PARSE_WITH_ERROR);
        }
        [Benchmark]
        public void TryParseTestWithError()
        {
            int result = _myParser.TryParse(STRING_TO_PARSE_WITH_ERROR);
        }
        [Benchmark]
        public void TryCatchParseTest()
        {

        }

    }
}
