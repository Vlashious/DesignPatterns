using System;

namespace FactoryMethod
{
    class ProductOne : IProduct
    {
        public void DoStuff()
        {
            Console.WriteLine("Product one.");
        }
    }
}