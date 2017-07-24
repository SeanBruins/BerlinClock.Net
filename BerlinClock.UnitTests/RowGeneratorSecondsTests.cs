using BerlinClock.Lib.RowGenerators;
using NUnit.Framework;

namespace BerlinClock.UnitTests
{
    [TestFixture]
    public class RowGeneratorSecondsTests
    {
        [TestCase(0, "Y")]
        [TestCase(1, "O")]
        [TestCase(2, "Y")]
        [TestCase(3, "O")]
        public void ShouldGenerateTheCorrectOutput(int value, string expectedValue)
        {
            var generator = new RowGeneratorSeconds();
            var result = generator.Generate(value);
            Assert.That(result, Is.EqualTo(expectedValue));
        }
    }
}