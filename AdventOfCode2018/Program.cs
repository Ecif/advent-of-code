using System;
using AdventOfCode2018.Core;
using AdventOfCode2018.Infrastucture;
using AdventOfCode2018.WorkDays.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace AdventOfCode2018
{
    class Program
    {
        private static IServiceProvider _serviceProvider;

        static void Main(string[] args)
        {
            _serviceProvider = Dependencies.MapServices();

            var workday1 = _serviceProvider.GetService<IDay1>();

            Console.WriteLine($"Workday {workday1.Day}! Task 1 set to frequency @ {workday1.CalculateTask1Frequency()} Hz");
            Console.WriteLine($"Workday {workday1.Day}! Task 2 set to frequency @ {workday1.CalculateTask2Frequency()} Hz");

            Console.ReadLine();
        }
    }
}
