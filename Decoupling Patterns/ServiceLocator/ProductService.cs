using System;

namespace ServiceLocator
{
    class ProductService : IProductService
    {
        public void AddProduct()
        {
            Console.WriteLine("Adding product...");
        }

        public void GetProduct()
        {
            Console.WriteLine("Getting product...");
        }
    }
}