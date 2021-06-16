using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace RandomGeneratorPerformance
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class RNGCryptoServiceProviderBenchmarks
    {
        private static readonly IRandomGenerator randomGenerator = new RandomGenerator();
        private static readonly IRandomGenerator rngCryptoServiceGenerator = new RNGCryptoServiceGenerator();

        [Benchmark(Baseline = true)]
        public void PseudoGenerateOneToHundred()
        {
            randomGenerator.RandomNumber(1, 100);
        }

        [Benchmark]
        public void PseudoGenerateZeroToHundredMillion()
        {
            randomGenerator.RandomNumber(1, 1_000_000);
        }

        [Benchmark]
        public void GenerateOneToHundred()
        {
            rngCryptoServiceGenerator.RandomNumber(1, 100);
        }

        [Benchmark]
        public void GenerateZeroToHundredMillion()
        {
            rngCryptoServiceGenerator.RandomNumber(1, 100_000_000);
        }
    }
}
