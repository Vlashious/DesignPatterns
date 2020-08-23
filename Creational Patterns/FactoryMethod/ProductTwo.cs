using System;

namespace FactoryMethod
{
    class ProductTwo : IProduct
    {
        public void DoStuff()
        {
            Console.WriteLine("Product two.");
        }
    }
}