namespace State
{
    class Context : IState
    {
        private IState _state;

        public Context(IState state)
        {
            _state = state;
        }

        public void ChangeState(IState state)
        {
            _state = state;
        }

        public void DoStuff()
        {
            _state.DoStuff();
        }
    }
}