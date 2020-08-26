namespace Command
{
    class AddCommand : ICommand
    {
        private int _previousNumber;
        public AddCommand(int number)
        {
            _previousNumber = number;
        }
        public int Execute(int x)
        {
            return _previousNumber + x;
        }

        public int Undo()
        {
            return _previousNumber;
        }
    }
}