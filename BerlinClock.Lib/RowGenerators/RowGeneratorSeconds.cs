using BerlinClock.Lib.RowGenerators.Contracts;

namespace BerlinClock.Lib.RowGenerators
{
    public class RowGeneratorSeconds : IRowGenerator
    {
        public string Generate(int seconds)
        {
            return seconds % 2 == 0 ? "Y" : "O";
        }
    }
}