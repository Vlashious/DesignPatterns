using System.Linq;

namespace Strategy
{
    class LinqMaxStrategy : IStrategy
    {
        public int Max(params int[] args)
        {
            return args.Max();
        }
    }
}