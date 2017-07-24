namespace BerlinClock.Lib.RowGenerators
{
    public class RowGeneratorMinutesFirst : RowGenerator
    {
        public override string Generate(int minutes)
        {
            return string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}",
                Smaller(minutes, 5, 'Y'),
                Smaller(minutes, 10, 'Y'),
                Smaller(minutes, 15, 'R'),
                Smaller(minutes, 20, 'Y'),
                Smaller(minutes, 25, 'Y'),
                Smaller(minutes, 30, 'R'),
                Smaller(minutes, 35, 'Y'),
                Smaller(minutes, 40, 'Y'),
                Smaller(minutes, 45, 'R'),
                Smaller(minutes, 50, 'Y'),
                Smaller(minutes, 55, 'Y'));
        }
    }
}