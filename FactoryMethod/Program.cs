using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteCreatorOne creator1 = new ConcreteCreatorOne();
            var product1 = creator1.CreateProduct();

            ConcreteCreatorTwo creator2 = new ConcreteCreatorTwo();
            var product2 = creator2.CreateProduct();

            product1.DoStuff(); // "Product one."
            product2.DoStuff(); // "Product two."

            Console.WriteLine(product1.GetType()); // ProductOne
            Console.WriteLine(product2.GetType()); // ProductTwo
        }
    }
}
