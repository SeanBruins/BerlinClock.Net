namespace BerlinClock.Lib.RowGenerators
{
    public class RowGeneratorMinutesSecond : RowGenerator
    {
        public override string Generate(int minutes)
        {
            return string.Format("{3}{2}{1}{0}",
                Smaller(minutes, 4, 'Y'),
                Smaller(minutes, 3, 'Y'),
                Smaller(minutes, 2, 'Y'),
                Smaller(minutes, 1, 'Y'));
        }
    }
}