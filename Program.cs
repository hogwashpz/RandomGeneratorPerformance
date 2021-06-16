using System;
using BenchmarkDotNet.Running;

namespace RandomGeneratorPerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<RNGCryptoServiceProviderBenchmarks>();
        }
    }
}