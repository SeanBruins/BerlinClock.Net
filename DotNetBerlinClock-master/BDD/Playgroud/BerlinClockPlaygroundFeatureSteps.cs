using BerlinClock.Classes;
using BerlinClock.Lib;
using BerlinClock.Lib.RowGenerators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BerlinClock.BDD.Playgroud
{
    [Binding]
    public class BerlinClockPlaygroundSteps
    {
        private BerlinClockGenerator _berlinClockGenerator;
        private RowGeneratorMinutesFirst _minutesFirstRow;
        private RowGeneratorMinutesSecond _minuesSecondRow;
        private RowGeneratorHoursFirst _hoursFirstRow;
        private RowGeneratorHoursSecond _hoursSecondRow;
        private RowGeneratorSeconds _topSeconds;

        private BerlinClockAttributes _berlinClockAttributes;

        #region Given

        [Given(@"this is a Berlin Clock")]
        public void GivenThisIsABerlinClock()
        {
            _topSeconds = new RowGeneratorSeconds();
            _hoursFirstRow = new RowGeneratorHoursFirst();
            _hoursSecondRow = new RowGeneratorHoursSecond();
            _minutesFirstRow = new RowGeneratorMinutesFirst();
            _minuesSecondRow = new RowGeneratorMinutesSecond();
            _berlinClockGenerator = new BerlinClockGenerator(_hoursFirstRow, _hoursSecondRow, _minutesFirstRow,
                _minuesSecondRow, _topSeconds);
        }

        #endregion

        #region Scenario


        [When(@"the clock has the following attributes strongly typed")]
        public void WhenTheClockHasTheFollowingAttributesStronglyTyped(Table table)
        {
            _berlinClockAttributes = table.CreateInstance<BerlinClockAttributes>();
        }

        //[When(@"the clock has the following attributes dynamic")]
        //public void WhenTheClockHasTheFollowingAttributesDynamic(Table table)
        //{
        //    dynamic berlinClockAttributesDynamic = table.CreateDynamicInstance();
        //    _berlinClockAttributes.Hour = berlinClockAttributesDynamic.Hour;
        //    _berlinClockAttributes.Minute = berlinClockAttributesDynamic.Minute;
        //    _berlinClockAttributes.Second = berlinClockAttributesDynamic.Second;
        //}

        //[When(@"the clock has the following attributes muliti column")]
        //public void WhenTheClockHasTheFollowingAttributesMulitiColumn(Table table)
        //{
        //    ScenarioContext.Current.Pending();
        //}

        #endregion

        #region Expected

        [Then(@"the display should look like")]
        public void ThenTheDisplayShouldLookLike(string theExpectedBerlinClockOutput)
        {
            var result = _berlinClockGenerator.Generate(_berlinClockAttributes.Hour, _berlinClockAttributes.Minute,
                _berlinClockAttributes.Second);
            Assert.AreNotEqual(result, theExpectedBerlinClockOutput);
        }

        #endregion
    }
}
