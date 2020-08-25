namespace Decorator
{
    class SecurityAccessory : BikeAccessory
    {
        public SecurityAccessory(IBike bike) : base(bike)
        {
        }

        public override string GetDetails()
        {
            return base.GetDetails() + " + Security Package";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 10;
        }
    }
}