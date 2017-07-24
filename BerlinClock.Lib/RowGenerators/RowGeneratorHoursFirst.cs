namespace BerlinClock.Lib.RowGenerators
{
    public class RowGeneratorHoursFirst : RowGenerator
    {
        public override string Generate(int hours)
        {
            return string.Format("{3}{2}{1}{0}",
                Smaller(hours, 20, 'R'),
                Smaller(hours, 15, 'R'),
                Smaller(hours, 10, 'R'),
                Smaller(hours, 5, 'R'));
        }
    }
}