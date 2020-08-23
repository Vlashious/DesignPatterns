using System.Linq;

namespace Singleton
{
    class Calculator
    {
        public static Calculator CalculatorInstance { get; private set; }

        static Calculator()
        {
            CalculatorInstance = new Calculator();
        }

        public int Sum(params int[] arguments)
        {
            return arguments.Sum();
        }

        public int Subtract(params int[] args)
        {
            return args.Sum(x => -x);
        }
    }
}