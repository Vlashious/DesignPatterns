using System;

namespace Observer
{
    class Listener
    {
        public Listener(Publisher publisher)
        {
            publisher.Update += Log;
        }

        private void Log()
        {
            Console.WriteLine("The number has changed.");
        }
    }
}