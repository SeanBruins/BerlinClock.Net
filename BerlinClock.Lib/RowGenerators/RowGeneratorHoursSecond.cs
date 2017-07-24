namespace BerlinClock.Lib.RowGenerators
{
    public class RowGeneratorHoursSecond : RowGenerator
    {
        public override string Generate(int hours)
        {
            return string.Format("{3}{2}{1}{0}",
                Smaller(hours, 4, 'R'),
                Smaller(hours, 3, 'R'),
                Smaller(hours, 2, 'R'),
                Smaller(hours, 1, 'R'));
        }
    }
}