using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // The normal concrete instance, that we will decorate with additional functions
            var calc = new Calculator();

            #region Creation of Alternate Decorators
            var loggingCalc = new LoggingCalculator(calc);
            var stopwatch = new Stopwatch();
            var profilingCalc = new ProfilingCalculator(calc, stopwatch);
            #endregion

            // Create an instance of the decorator, providing it the instance to be decorated
            // Pass the normal instance to the cached decorator
            // Note we could pass another decorator if we choose to combine features
            var cachedCalc = new CachedCalculator(loggingCalc);

            // Create a client, inject it with the concrete or decorated instance of ICalculator as required
            // Note the client doesnt know or care which instance it has been given, and
            // neither the normal concrete instance or client has to be modified to add the functions of the decorator
            var client = new Client(cachedCalc);

            // First call - not in cache so calls down to normal instance
            var result1 = client.Test();
            Console.WriteLine(result1);

            // Second call - returned straight from cache and normal instance not called
            var result2 = client.Test();
            Console.WriteLine(result2);

            Console.ReadLine();
        }
    }
}
