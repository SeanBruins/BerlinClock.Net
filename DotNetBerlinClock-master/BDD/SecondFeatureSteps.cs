using BerlinClock.Lib.RowGenerators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace BerlinClock.BDD
{
    [Binding]
    public class SecondFeatureSteps
    {
        private RowGeneratorSeconds _topSeconds;

        private int _thisSecond;

        #region Given

        [Given(@"this is the top second indicator")]
        public void GivenThisIsTheTopSecondIndicator()
        {
            _topSeconds = new RowGeneratorSeconds();
        }

        #endregion

        #region Scenario


        #endregion

        #region Expected


        #endregion

        [When(@"this second is (.*)")]
        public void WhenThisSecondIs(int currentSecond)
        {
            _thisSecond = currentSecond;
        }

        [Then(@"this top second lamp should be (.*)")]
        public void ThenThisTopSecondLampShouldBe(string expectedTopSecondIndicatorOutput)
        {
            Assert.AreEqual(_topSeconds.Generate(_thisSecond), expectedTopSecondIndicatorOutput);
        }
    }
}