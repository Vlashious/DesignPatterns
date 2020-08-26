using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var publisher = new Publisher();
            var listener = new Listener(publisher);

            publisher.Number = 10;
        }
    }
}
