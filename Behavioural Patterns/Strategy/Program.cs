using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context(new LinqMaxStrategy());
            Console.WriteLine(context.Max(1, 2, 3));

            context.ChangeStrategy(new MaxAlgorithmStrategy());
            Console.WriteLine(context.Max(1, 2, 3));
        }
    }
}
