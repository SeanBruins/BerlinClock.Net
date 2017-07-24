﻿using System.Collections.Generic;
using System.Linq;

namespace BerlinClock.Lib.Helpers
{
    public class ValueBiggestFit
    {
        private readonly IEnumerable<int> _pivots;

        public ValueBiggestFit(IEnumerable<int> pivots)
        {
            _pivots = pivots;
        }

        public int GetFit(int value)
        {
            return _pivots.Where(x => x < value).OrderByDescending(x => x).FirstOrDefault();
        }
    }
}