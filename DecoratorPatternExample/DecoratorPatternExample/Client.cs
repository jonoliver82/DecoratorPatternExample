namespace DecoratorPatternExample
{
    public class Client
    {
        private readonly ICalculator _calculator;
        public Client(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public int Test()
        {
            return _calculator.Add(1, 2);
        }
    }
}
