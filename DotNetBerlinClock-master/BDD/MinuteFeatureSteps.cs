using BerlinClock.Lib.RowGenerators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace BerlinClock.BDD
{
    [Binding]
    public class MinuteFeatureSteps
    {
        private RowGeneratorMinutesFirst _minutesFirstRow;
        private RowGeneratorMinutesSecond _minutesSecondRow;

        private int _thisMinute;

        #region Given

        [Given(@"this is the minutes first row")]
        public void GivenThisIsTheMinutesFirstRow()
        {
            _minutesFirstRow = new RowGeneratorMinutesFirst();
        }

        [Given(@"this is the minutes second row")]
        public void GivenThisIsTheMinutesSecondRow()
        {
            _minutesSecondRow = new RowGeneratorMinutesSecond();
        }

        #endregion

        #region Scenario

        [When(@"the current minute is (.*)")]
        public void WhenTheCurrentMinuteIs(int currentMinute)
        {
            _thisMinute = currentMinute;
        }

        [When(@"a minute adjustment of (.*) is made")]
        public void WhenAMinuteAdjustmentOfIsMade(int adjustment)
        {
            _thisMinute = _thisMinute - adjustment;
        }

        #endregion

        #region Expected

        [Then(@"the expected minutes first row output should be (.*)")]
        public void ThenExpectedMinutesFirstRowOutputShouldBe(string expectedMinutesFirstRowOutput)
        {
            var result = _minutesFirstRow.Generate(_thisMinute);
            Assert.AreEqual(result, expectedMinutesFirstRowOutput);
        }

        [Then(@"the expected minute second row output should be (.*)")]
        public void ThenExpectedMinutesSecondRowOutputShouldBe(string expectedMinutesSecondRowOutput)
        {
            var result = _minutesSecondRow.Generate(_thisMinute);
            Assert.AreEqual(result, expectedMinutesSecondRowOutput);
        }

        #endregion
    }
}