using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = new AddCommand(10);
            var invoker = new Invoker();
            invoker.SetCommand(sum);
            invoker.ExecuteCommand(10);
            invoker.UndoCommand();
        }
    }
}
