using System;

namespace Chain_of_Responsibility
{
    class ConcreteHandler : BaseHandler
    {
        public override void HandleRequest(int data)
        {
            if (data % 2 == 0)
            {
                Console.WriteLine("This is an even number.");
            }
            else base.HandleRequest(data);
        }
    }
}