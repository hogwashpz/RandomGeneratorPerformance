using System;

namespace RandomGeneratorPerformance
{
    public class RandomGenerator : IRandomGenerator
    {
        private readonly Random _rand = new();

        public int RandomNumber(int min, int max) => _rand.Next(min, max);
    }
}
