namespace Strategy
{
    class Context : IStrategy
    {
        private IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ChangeStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public int Max(params int[] args)
        {
            return _strategy.Max(args);
        }
    }
}