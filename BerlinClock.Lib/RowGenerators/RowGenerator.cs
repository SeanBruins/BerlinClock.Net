using BerlinClock.Lib.RowGenerators.Contracts;

namespace BerlinClock.Lib.RowGenerators
{
    public abstract class RowGenerator : IRowGenerator
    {
        public abstract string Generate(int time);

        protected static char Smaller(int value, int valueToCompare, char trueReturnChar = 'n', char falseReturnChar = 'O')
        {
            return value < valueToCompare ? falseReturnChar : trueReturnChar;
        }
    }
}