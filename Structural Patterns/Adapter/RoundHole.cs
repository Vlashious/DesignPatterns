namespace Adapter
{
    class RoundHole
    {
        public float Radius { get; private set; }

        public RoundHole(float radius)
        {
            Radius = radius;
        }

        public bool Fits(RoundPeg peg)
        {
            return peg.Radius <= Radius;
        }
    }
}