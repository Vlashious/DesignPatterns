namespace Composite
{
    class ChargePlug : IComposite
    {
        private float _price;

        public ChargePlug(float price)
        {
            _price = price;
        }

        public float GetPrice()
        {
            return _price;
        }
    }
}