namespace Strategy
{
    class MaxAlgorithmStrategy : IStrategy
    {
        public int Max(params int[] args)
        {
            int max = int.MinValue;
            foreach (var num in args)
            {
                if (max < num)
                {
                    max = num;
                }
            }
            return max;
        }
    }
}