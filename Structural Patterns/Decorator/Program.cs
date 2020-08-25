using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var basicBike = new CarbonBike();

            BikeAccessory upgraded = new MusicAccessory(basicBike);
            Console.WriteLine(upgraded.GetPrice());
            Console.WriteLine(upgraded.GetDetails());

            upgraded = new SecurityAccessory(upgraded);
            Console.WriteLine(upgraded.GetPrice());
            Console.WriteLine(upgraded.GetDetails());
        }
    }
}
