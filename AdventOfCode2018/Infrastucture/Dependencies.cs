using System;
using AdventOfCode2018.Common;
using AdventOfCode2018.Core;
using AdventOfCode2018.WorkDays;
using AdventOfCode2018.WorkDays.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace AdventOfCode2018.Infrastucture
{
    public static class Dependencies
    {
        public static IServiceProvider MapServices()
        {
            var services = new ServiceCollection();
            
            // Core
            services.AddSingleton<IFrequencyFinder, FrequencyFinder>();

            // Common
            
            //WorkDays
            services.AddSingleton<IDay1, Day1>();


            return services.BuildServiceProvider();
        }
    }
}