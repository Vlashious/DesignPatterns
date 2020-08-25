namespace Decorator
{
    class MusicAccessory : BikeAccessory
    {
        public MusicAccessory(IBike bike) : base(bike)
        {
        }

        public override string GetDetails()
        {
            return base.GetDetails() + " + Music Package";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 50;
        }
    }
}