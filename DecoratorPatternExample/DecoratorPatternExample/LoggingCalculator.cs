using System;

namespace DecoratorPatternExample
{
    public class LoggingCalculator : ICalculator
    {

        private readonly ICalculator _calculator;

        public LoggingCalculator(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public int Add(int x, int y)
        {
            Console.WriteLine("Before Add");

            var result = _calculator.Add(x, y);

            Console.WriteLine("After Add");

            return result;
        }
    }
}
