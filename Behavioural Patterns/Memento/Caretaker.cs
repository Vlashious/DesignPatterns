namespace Memento
{
    class Caretaker
    {
        public Memento Memento { get; private set; }
        public Caretaker(Memento memento)
        {
            Memento = memento;
        }
    }
}