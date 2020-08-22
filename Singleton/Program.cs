using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = Calculator.CalculatorInstance.Sum(1, 2, 3);
            var subtract = Calculator.CalculatorInstance.Subtract(1, 2, 3);
        }
    }
}
