using System;

namespace Memento
{
    class Originator
    {
        private string _state;

        public string State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
                Console.WriteLine("State has changed to: " + _state);
            }
        }

        public Memento CreateMemento()
        {
            return new Memento(_state);
        }

        public void SetMemento(Memento memento)
        {
            State = memento.State;
        }
    }
}