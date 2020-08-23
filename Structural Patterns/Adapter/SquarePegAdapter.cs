using System;

namespace Adapter
{
    class SquarePegAdapter : RoundPeg
    {
        public SquarePegAdapter(SquarePeg peg) : base(peg.Width * (float)Math.Sqrt(2) / 2)
        {

        }
    }
}