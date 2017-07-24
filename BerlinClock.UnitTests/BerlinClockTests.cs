using BerlinClock.Lib;
using BerlinClock.Lib.RowGenerators.Contracts;
using NUnit.Framework;
using Rhino.Mocks;
using System;

namespace BerlinClock.UnitTests
{
    [TestFixture]
    public class BerlinClockUnitTests
    {
        [Test]
        public void ShouldGenerateInCorrectFormat()
        {
            const string expectedResult = "Y\r\nAAAA\r\nBBBB\r\nCCCCCCCCCCC\r\nDDDD";
            var topFirstRow = MockRepository.Mock<IRowGenerator>();
            var topSecondRow = MockRepository.Mock<IRowGenerator>();
            var bottomFirstRow = MockRepository.Mock<IRowGenerator>();
            var bottomSecondRow = MockRepository.Mock<IRowGenerator>();
            var yellowLampGen = MockRepository.Mock<IRowGenerator>();

            topFirstRow.Expect(x => x.Generate(0)).Return("AAAA");
            topSecondRow.Expect(x => x.Generate(0)).Return("BBBB");
            bottomFirstRow.Expect(x => x.Generate(0)).Return("CCCCCCCCCCC");
            bottomSecondRow.Expect(x => x.Generate(0)).Return("DDDD");
            yellowLampGen.Expect(x => x.Generate(0)).Return("Y");

            var clock = new BerlinClockGenerator(topFirstRow, topSecondRow, bottomFirstRow, bottomSecondRow, yellowLampGen);
            var result = clock.Generate(0, 0, 0);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void ShouldConvertDateTimeToCorrectFormat()
        {
            const string expectedResult = "Y\r\nAAAA\r\nBBBB\r\nCCCCCCCCCCC\r\nDDDD";
            var topFirstRow = MockRepository.Mock<IRowGenerator>();
            var topSecondRow = MockRepository.Mock<IRowGenerator>();
            var bottomFirstRow = MockRepository.Mock<IRowGenerator>();
            var bottomSecondRow = MockRepository.Mock<IRowGenerator>();
            var yellowLampGen = MockRepository.Mock<IRowGenerator>();

            topFirstRow.Expect(x => x.Generate(0)).Return("AAAA");
            topSecondRow.Expect(x => x.Generate(0)).Return("BBBB");
            bottomFirstRow.Expect(x => x.Generate(0)).Return("CCCCCCCCCCC");
            bottomSecondRow.Expect(x => x.Generate(0)).Return("DDDD");
            yellowLampGen.Expect(x => x.Generate(0)).Return("Y");

            var clock = new BerlinClockGenerator(topFirstRow, topSecondRow, bottomFirstRow, bottomSecondRow, yellowLampGen);
            var result = clock.Generate(new DateTime(1, 1, 1, 0, 0, 0));
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}