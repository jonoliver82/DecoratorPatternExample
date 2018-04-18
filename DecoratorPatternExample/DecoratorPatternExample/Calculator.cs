using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
