using BerlinClock.Lib.RowGenerators;
using NUnit.Framework;

namespace BerlinClock.UnitTests
{
    [TestFixture]
    public class RowGeneratorHoursSecondTests
    {
        [TestCase(24, 20, "RRRR")]
        [TestCase(13, 10, "RRRO")]
        [TestCase(0, 0, "OOOO")]
        public void GenerateCorrectZeroHour(int hour, int adjustment, string expectedResult)
        {
            var hourGenerator = new RowGeneratorHoursSecond();
            var adjustedValue = hour - adjustment;
            var result = hourGenerator.Generate(adjustedValue);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}