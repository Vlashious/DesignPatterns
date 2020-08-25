using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new Proxy(new Service());
            service.SomeOperation();
        }
    }
}
