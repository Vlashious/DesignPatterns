using System;

namespace Observer
{
    class Publisher
    {
        public event Action Update;
        private int _number;

        public int Number
        {
            get
            {
                return _number;
            }
            set
            {
                Update?.Invoke();
                _number = value;
            }
        }
    }
}