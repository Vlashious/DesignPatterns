namespace Decorator
{
    class BikeAccessory : IBike
    {
        private IBike _bike;

        public BikeAccessory(IBike bike)
        {
            _bike = bike;
        }

        public virtual string GetDetails()
        {
            return _bike.GetDetails();
        }

        public virtual double GetPrice()
        {
            return _bike.GetPrice();
        }
    }
}