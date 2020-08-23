using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var hole = new RoundHole(5);
            var roundPeg = new RoundPeg(5);

            Console.WriteLine(hole.Fits(roundPeg)); // True.

            var smallSquarePeg = new SquarePeg(5);
            var largeSquarePeg = new SquarePeg(10);

            // hole.Fits(smallSquarePeg); This won't compile! Incompatible types.

            var smallPegAdapter = new SquarePegAdapter(smallSquarePeg);
            var largePegAdapter = new SquarePegAdapter(largeSquarePeg);

            Console.WriteLine(hole.Fits(smallPegAdapter)); // True.
            Console.WriteLine(hole.Fits(largePegAdapter)); // False.
        }
    }
}
