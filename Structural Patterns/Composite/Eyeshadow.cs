namespace Composite
{
    class Eyeshadow : IComposite
    {
        private float _price;

        public Eyeshadow(float price)
        {
            _price = price;
        }

        public float GetPrice()
        {
            return _price;
        }
    }
}