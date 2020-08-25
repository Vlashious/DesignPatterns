using System;

namespace Proxy
{
    class Service : IServiceInterface
    {
        public void SomeOperation()
        {
            Console.WriteLine("Operation called.");
        }
    }
}