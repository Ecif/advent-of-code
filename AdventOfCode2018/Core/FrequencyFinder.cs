﻿using System.Collections.Generic;
using System.Diagnostics;
using AdventOfCode2018.Common;

namespace AdventOfCode2018.Core
{
    public class FrequencyFinder : IFrequencyFinder
    {
        private IList<int> _frequenciesReached;

        public int GetFrequencyRecurringXTimes(int frequencyRecurringXTimes = 0)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            _frequenciesReached = new List<int>();
            var resp = GetFrequency(frequencyRecurringXTimes);
            stopwatch.Stop();

            var elapsedTime = stopwatch.ElapsedMilliseconds;
            return resp;

        }

        private int GetFrequency(int frequencyRecurringXTimes, int currentFrequency = 0, int currentFrequencyRepeatedXTimes = 0)
        {
            while (true)
            {
                foreach (var frequency in ResearchData.Frequencies)
                {
                    currentFrequency += frequency;

                    if (CheckForRepeatedFrequencyMatchWith(frequencyRecurringXTimes, ref currentFrequencyRepeatedXTimes, currentFrequency))
                    {
                        return currentFrequency;
                    }
                }

                if (frequencyRecurringXTimes > 0) continue;

                return currentFrequency;
            }
        }

        private bool CheckForRepeatedFrequencyMatchWith(int repeatingFrequencyAt, ref int timesXRepeated, int currentFrequency)
        {
            if (repeatingFrequencyAt == 0)
                return false;

            if (_frequenciesReached.Contains(currentFrequency))
            {
                timesXRepeated++;
                if (repeatingFrequencyAt == timesXRepeated)
                    return true;
            }

            _frequenciesReached.Add(currentFrequency);

            return false;
        }
    }
}