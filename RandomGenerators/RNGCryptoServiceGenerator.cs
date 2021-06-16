using System;
using System.Security.Cryptography;

namespace RandomGeneratorPerformance
{
    public class RNGCryptoServiceGenerator : IRandomGenerator
    {
        private readonly RNGCryptoServiceProvider _rand = new();

        public int RandomNumber(int min, int max)
        {
            var scale = uint.MaxValue;
            while (scale == uint.MaxValue)
            {
                var fourBytes = new byte[4];
                _rand.GetBytes(fourBytes);
                scale = BitConverter.ToUInt32(fourBytes, 0);
            }

            return (int)(min + (max - min) * (scale / (double)uint.MaxValue));
        }
    }
}
