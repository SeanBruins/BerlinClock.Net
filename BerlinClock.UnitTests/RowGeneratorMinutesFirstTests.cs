using BerlinClock.Lib.RowGenerators;
using NUnit.Framework;

namespace BerlinClock.UnitTests
{
    [TestFixture]
    public class RowGeneratorMinutesFirstTests
    {
        [TestCase(0, "OOOOOOOOOOO")]
        [TestCase(17, "YYROOOOOOOO")]
        [TestCase(59, "YYRYYRYYRYY")]
        public void ShouldGenerateExpectedResult(int value, string expectedResult)
        {
            var generator = new RowGeneratorMinutesFirst();
            var result = generator.Generate(value);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}