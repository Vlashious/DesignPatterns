using System.Collections.Generic;

namespace Command
{
    class Invoker
    {
        private ICommand _command;
        public void SetCommand(ICommand command)
        {
            _command = command;
        }
        public int ExecuteCommand(int x)
        {
            return _command.Execute(x);
        }
        public int UndoCommand()
        {
            return _command.Undo();
        }
    }
}