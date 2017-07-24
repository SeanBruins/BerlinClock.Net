using BerlinClock.Lib.RowGenerators;
using NUnit.Framework;

namespace BerlinClock.UnitTests
{
    [TestFixture]
    public class RowGeneratorMinutesSecondTests
    {
        [TestCase(0, 0, "OOOO")]
        [TestCase(17, 15, "YYOO")]
        [TestCase(59, 55, "YYYY")]
        public void ShouldGenerateCorrectResult(int value, int adjustment, string expectedResult)
        {
            var generator = new RowGeneratorMinutesSecond();
            var adjustedValue = value - adjustment;
            var result = generator.Generate(adjustedValue);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}