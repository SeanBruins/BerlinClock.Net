using System;

namespace BerlinClock.Helpers
{
    public class RandomNumberGenerator
    {
        public static int GenerateOddNumber()
        {
            var rnd = new Random();

            return 1 + 2 * rnd.Next(5);
        }

        public int GenerateEvenNumber()
        {
            var rnd = new Random();

            return 2 * rnd.Next(5);
        }
    }
}