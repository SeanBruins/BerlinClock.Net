using BerlinClock.Lib;
using BerlinClock.Lib.RowGenerators;
using NUnit.Framework;

namespace BerlinClock.IntegrationTests
{
    [TestFixture]
    public class BerlinClockTests
    {
        [TestCase(0,0,0, "Y\r\nOOOO\r\nOOOO\r\nOOOOOOOOOOO\r\nOOOO")]
        [TestCase(13,17,1, "O\r\nRROO\r\nRRRO\r\nYYROOOOOOOO\r\nYYOO")]
        [TestCase(23,59,59, "O\r\nRRRR\r\nRRRO\r\nYYRYYRYYRYY\r\nYYYY")]
        [TestCase(24,0,0, "Y\r\nRRRR\r\nRRRR\r\nOOOOOOOOOOO\r\nOOOO")]
        public void ShouldReturnTheRightValue(int hours, int minutes, int seconds, string expectedResult)
        {
            var hoursFirstRow = new RowGeneratorHoursFirst();
            var hourSecondRow = new RowGeneratorHoursSecond();
            var minuteFirstRow = new RowGeneratorMinutesFirst();
            var minuteecondRow = new RowGeneratorMinutesSecond();
            var topSeconds = new RowGeneratorSeconds();

            var clock = new BerlinClockGenerator(hoursFirstRow, hourSecondRow, minuteFirstRow, minuteecondRow, topSeconds);
            var result = clock.Generate(hours, minutes, seconds);
            Assert.That(result, Is.EqualTo(expectedResult));

        }
    }
}