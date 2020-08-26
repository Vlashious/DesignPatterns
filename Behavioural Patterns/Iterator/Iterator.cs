using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    class Iterator : IEnumerator, IEnumerable
    {
        private string[] _items;
        private int _position;
        private bool _isBackwards;
        public Iterator(string[] items, bool isBackwards = false)
        {
            _items = items;
            _isBackwards = isBackwards;
            _position = _isBackwards ? items.Length : -1;
        }
        public object Current
        {
            get
            {
                return _items[_position];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (!_isBackwards)
            {
                if (_position < _items.Length - 1)
                {
                    _position++;
                    return true;
                }
                return false;
            }
            else
            {
                if (_position > 0)
                {
                    _position--;
                    return true;
                }
                return false;
            }
        }

        public void Reset()
        {
            _position = _isBackwards ? -1 : (_items.Length - 1);
        }
    }
}