namespace DecoratorPatternExample
{
    public class Calculator : ICalculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}
