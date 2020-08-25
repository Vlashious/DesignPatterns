namespace Decorator
{
    class CarbonBike : IBike
    {
        public string GetDetails()
        {
            return "Carbon";
        }

        public double GetPrice()
        {
            return 100;
        }
    }
}