using BerlinClock.Lib.Helpers;
using BerlinClock.Lib.RowGenerators;
using BerlinClock.Lib.RowGenerators.Contracts;
using System;
using System.Collections.Generic;

namespace BerlinClock.Lib
{
    public class BerlinClockGenerator
    {
        private readonly IRowGenerator _secondsRowGenerator;
        private readonly IRowGenerator _minutesFirstRowGenerator;
        private readonly IRowGenerator _minutesSecondRowGenerator;
        private readonly IRowGenerator _hoursFirstRowGenerator;
        private readonly IRowGenerator _hoursSecondRowGenerator;

        private readonly ValueBiggestFit _minuteBiggestFit;
        private readonly ValueBiggestFit _hourBiggestFit;

        public BerlinClockGenerator() : this(
            new RowGeneratorHoursFirst(),
            new RowGeneratorHoursSecond(),
            new RowGeneratorMinutesFirst(),
            new RowGeneratorMinutesSecond(),
            new RowGeneratorSeconds())
        {
        }

        public BerlinClockGenerator(IRowGenerator topFirstRow, IRowGenerator topSecondRow, IRowGenerator bottomFirstRow,
            IRowGenerator bottomSecondRow, IRowGenerator lampGenerator)
        {
            _hoursFirstRowGenerator = topFirstRow;
            _hoursSecondRowGenerator = topSecondRow;
            _minutesFirstRowGenerator = bottomFirstRow;
            _minutesSecondRowGenerator = bottomSecondRow;
            _secondsRowGenerator = lampGenerator;
            _hourBiggestFit = new ValueBiggestFit(new List<int> {5, 10, 15, 20});
            _minuteBiggestFit = new ValueBiggestFit(new List<int> {5, 10, 15, 20, 25, 30, 35, 40, 35, 50, 55});
        }

        public string Generate(DateTime timeOfDay)
        {
            return Generate(timeOfDay.Hour, timeOfDay.Minute, timeOfDay.Second);
        }

        public string Generate(int hour, int minute, int second)
        {
            var hoursFirstRow = hour;
            var hoursSecondRow = hour - _hourBiggestFit.GetFit(hour);

            var minutesFirstRow = minute;
            var minutesSecondRow = minute - _minuteBiggestFit.GetFit(minute);

            return string.Format("{0}\r\n{1}\r\n{2}\r\n{3}\r\n{4}",
                _secondsRowGenerator.Generate(second),
                _hoursFirstRowGenerator.Generate(hoursFirstRow),
                _hoursSecondRowGenerator.Generate(hoursSecondRow),
                _minutesFirstRowGenerator.Generate(minutesFirstRow),
                _minutesSecondRowGenerator.Generate(minutesSecondRow));
        }
    }
}