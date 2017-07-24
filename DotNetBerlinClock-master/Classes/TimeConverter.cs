using System;
using BerlinClock.Classes.Contracts;
using BerlinClock.Lib;
using BerlinClock.Lib.RowGenerators;

namespace BerlinClock.Classes
{
    public class TimeConverter : ITimeConverter
    {
        private BerlinClockGenerator _berlinClockGenerator;
        private RowGeneratorMinutesFirst _bottomFirstRow;
        private RowGeneratorMinutesSecond _bottomSecondRow;
        private RowGeneratorHoursFirst _topFirstRow;
        private RowGeneratorHoursSecond _topSecondRow;
        private RowGeneratorSeconds _topYellowLamp;

        public string ConvertTime(string actualTime)
        {
            var tsTime = TimeSpan.Parse(actualTime);

            _topYellowLamp = new RowGeneratorSeconds();
            _topFirstRow = new RowGeneratorHoursFirst();
            _topSecondRow = new RowGeneratorHoursSecond();
            _bottomFirstRow = new RowGeneratorMinutesFirst();
            _bottomSecondRow = new RowGeneratorMinutesSecond();
            _berlinClockGenerator = new BerlinClockGenerator(_topFirstRow, _topSecondRow, _bottomFirstRow,
                _bottomSecondRow, _topYellowLamp);

            var result = _berlinClockGenerator.Generate(tsTime.Hours, tsTime.Minutes, tsTime.Seconds);

            return result;
        }
    }
}