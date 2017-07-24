using BerlinClock.Lib.RowGenerators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace BerlinClock.BDD
{
    [Binding]
    public class HourFeatureSteps
    {
        private int _thisHour;
        private RowGeneratorHoursFirst _topFirstRow;
        private RowGeneratorHoursSecond _topSecondRow;

        #region Given

        [Given(@"this is the hours first row")]
        public void GivenTheTopFirstRowConsistingOfFourRedLamps()
        {
            _topFirstRow = new RowGeneratorHoursFirst();
        }

        [Given(@"this is the hours second row")]
        public void GivenTheTopSecondRowConsistingOfFourRedLamps()
        {
            _topSecondRow = new RowGeneratorHoursSecond();
        }

        #endregion

        #region When Scenarios

        [When(@"the current hour is (.*)")]
        public void WhenTheCurrentHourIs(int currentHour)
        {
            _thisHour = currentHour;
        }

        [When(@"an hour adjustment of (.*) is made")]
        public void WhenAnHourAdjustmentOfIsMade(int adjustment)
        {
            _thisHour = _thisHour - adjustment;
        }

        #endregion

        #region Then Expected

        [Then(@"the expected hour first row output should be (.*)")]
        public void ThenTheExpectedFirstRowResultShouldBe(string theExpectedTopFirstRowOutput)
        {
            var result = _topFirstRow.Generate(_thisHour);
            Assert.AreEqual(result, theExpectedTopFirstRowOutput);
        }

        [Then(@"the expected hour second row output should be (.*)")]
        public void ThenTheExpectedSecondRowResultShouldBe(string theExpectedTopSecondRowOutput)
        {
            var result = _topSecondRow.Generate(_thisHour);
            Assert.AreEqual(result, theExpectedTopSecondRowOutput);
        }

        #endregion
    }
}