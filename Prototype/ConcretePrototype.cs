namespace Prototype
{
    class ConcretePrototype : IPrototype
    {
        private int _id;
        private string _text;

        public ConcretePrototype(int id, string text)
        {
            _id = id;
            _text = text;
        }

        public IPrototype Clone()
        {
            return new ConcretePrototype(_id + 1, _text);
        }

        public override string ToString()
        {
            return $"{_id} {_text}";
        }
    }
}