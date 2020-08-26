using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            var origin = new Originator();
            origin.State = "Kill me.";

            var caretaker = new Caretaker(origin.CreateMemento());
            origin.State = "Don't.";

            origin.SetMemento(caretaker.Memento);
        }
    }
}
