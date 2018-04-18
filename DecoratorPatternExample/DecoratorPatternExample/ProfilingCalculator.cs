using System;
using System.Diagnostics;

namespace DecoratorPatternExample
{
    public class ProfilingCalculator : ICalculator
    {
        private readonly ICalculator _calculator;
        private readonly Stopwatch _stopwatch;

        public ProfilingCalculator(ICalculator calculator, Stopwatch stopwatch)
        {
            _calculator = calculator;
            _stopwatch = stopwatch;            
        }

        public int Add(int x, int y)
        {
            _stopwatch.Restart();

            //Call the actual function
            var result = _calculator.Add(x, y);

            _stopwatch.Stop();
            Console.WriteLine($"Method execution took {_stopwatch.ElapsedTicks} ticks");

            return result;
        }
    }
}
