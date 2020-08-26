using System;

namespace Chain_of_Responsibility
{
    class BaseHandler : IHandler
    {
        protected IHandler _handler;
        public virtual void HandleRequest(int data)
        {
            if (data % 2 != 0)
            {
                Console.WriteLine("This is an odd number.");
            }
            else _handler?.HandleRequest(data);
        }

        public IHandler SetNext(IHandler next)
        {
            _handler = next;
            return this;
        }
    }
}