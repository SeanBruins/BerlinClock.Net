using BerlinClock.Lib.RowGenerators;
using NUnit.Framework;

namespace BerlinClock.UnitTests
{
    [TestFixture]
    public class RowGeneratorHoursFirstTests
    {
        [TestCase(0, "OOOO")]
        [TestCase(9, "ROOO")]
        [TestCase(13, "RROO")]
        [TestCase(24, "RRRR")]
        public void GenerateCorrectZeroHour(int hour, string expectedResult)
        {
            var hourGenerator = new RowGeneratorHoursFirst();
            var result = hourGenerator.Generate(hour);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}