namespace BerlinClock.Lib.RowGenerators.Contracts
{
    public interface IRowGenerator
    {
        string Generate(int minutes);
    }
}