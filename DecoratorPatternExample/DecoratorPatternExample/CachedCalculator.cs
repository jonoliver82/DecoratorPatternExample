using System;

namespace DecoratorPatternExample
{
    public class CachedCalculator : ICalculator
    {
        private readonly ICalculator _calculator;

        private int? _cached;

        public CachedCalculator(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public int Add(int x, int y)
        {
            if(_cached.HasValue == false)
            {
                Console.WriteLine("Not in cache");

                //Store in cache
                _cached = _calculator.Add(x, y);
            }

            return _cached.Value;
        }
    }
}
