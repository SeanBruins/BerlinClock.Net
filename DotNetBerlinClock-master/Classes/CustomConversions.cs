using System;
using BerlinClock.Lib;
using BerlinClock.Lib.RowGenerators;
using TechTalk.SpecFlow;

namespace BerlinClock.Classes
{
    [Binding]
    internal class CustomConversions
    {
        private BerlinClockGenerator _berlinClockGenerator;
        private RowGeneratorMinutesFirst _bottomFirstRow;
        private RowGeneratorMinutesSecond _bottomSecondRow;
        private RowGeneratorHoursFirst _topFirstRow;
        private RowGeneratorHoursSecond _topSecondRow;
        private RowGeneratorSeconds _topYellowLamp;

        [StepArgumentTransformation(@"the time is ""(^(?:(?:([01]?\d|2[0-3]):)?([0-5]?\d):)?([0-5]?\d)$)""")]
        public string ConvertRegularTimeToBerlinUhrTime(string time)
        {
            var tsTime = TimeSpan.Parse(time);

            _topYellowLamp = new RowGeneratorSeconds();
            _topFirstRow = new RowGeneratorHoursFirst();
            _topSecondRow = new RowGeneratorHoursSecond();
            _bottomFirstRow = new RowGeneratorMinutesFirst();
            _bottomSecondRow = new RowGeneratorMinutesSecond();
            _berlinClockGenerator = new BerlinClockGenerator(_topFirstRow, _topSecondRow, _bottomFirstRow,
                _bottomSecondRow, _topYellowLamp);

            return _berlinClockGenerator.Generate(tsTime.Hours, tsTime.Minutes, tsTime.Seconds);
        }
    }
}