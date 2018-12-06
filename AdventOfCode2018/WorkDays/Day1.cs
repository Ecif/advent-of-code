using System.Collections.Generic;
using AdventOfCode2018.Common;
using AdventOfCode2018.Core;
using AdventOfCode2018.WorkDays.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace AdventOfCode2018.WorkDays
{
    public class Day1 : IDay1
    {
        private readonly IFrequencyFinder _frequencyFinder;

        public int Day { get; set; }
        
        public Day1(IFrequencyFinder frequencyFinder)
        {
            _frequencyFinder = frequencyFinder;
            Day = 1;            
        }

        public int CalculateTask1Frequency()
        {
            return _frequencyFinder.GetFrequencyRecurringXTimes(0);
        }

        public int CalculateTask2Frequency()
        {
            return _frequencyFinder.GetFrequencyRecurringXTimes(1);
        }
    }
}