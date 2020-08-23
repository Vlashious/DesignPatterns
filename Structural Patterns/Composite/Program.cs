using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var chargePlug = new ChargePlug(50);
            var eyeshadow = new Eyeshadow(150);
            var expensiveChargePlug = new ChargePlug(200);

            var package = new Package();
            package.AddItem(chargePlug);
            package.AddItem(eyeshadow);

            Console.WriteLine(package.GetPrice());  // 200.

            var package1 = new Package();
            package1.AddItem(expensiveChargePlug);
            package.AddItem(package1);

            Console.WriteLine(package.GetPrice());  // 400.
            Console.WriteLine(package1.GetPrice()); // 200.
        }
    }
}
