using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcretePrototype prototype1 = new ConcretePrototype(1, "hello");
            var prototype2 = prototype1.Clone();

            Console.WriteLine(prototype1);
            Console.WriteLine(prototype2);

            Console.Read();
        }
    }
}
