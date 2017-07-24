using BerlinClock.Classes;
using BerlinClock.Classes.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace BerlinClock.BDD
{
    [Binding]
    public class TheBerlinClockSteps
    {
        private string _theTime;
        private readonly ITimeConverter _berlinClock = new TimeConverter();

        #region Scenario

        [When(@"the time is ""(.*)""")]
        public void WhenTheTimeIs(string time)
        {
            _theTime = time;
        }

        #endregion

        #region Expected

        [Then(@"the clock should look like")]
        public void ThenTheClockShouldLookLike(string theExpectedBerlinClockOutput)
        {
            Assert.AreEqual(_berlinClock.ConvertTime(_theTime), theExpectedBerlinClockOutput);
        }

        [Then(@"the clock should not look like")]
        public void ThenTheClockShouldNotLookLike(string theExpectedBerlinClockOutput)
        {
            Assert.AreNotEqual(_berlinClock.ConvertTime(_theTime), theExpectedBerlinClockOutput);
        }

        #endregion
    }
}