using System;

namespace Chain_of_Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var handler = new BaseHandler();
            var concreteHandler = new ConcreteHandler();
            handler.SetNext(concreteHandler);
            handler.HandleRequest(20);
            handler.HandleRequest(15);
        }
    }
}
