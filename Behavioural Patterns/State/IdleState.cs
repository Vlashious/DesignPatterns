using System;

namespace State
{
    class IdleState : IState
    {
        public void DoStuff()
        {
            Console.WriteLine("Moved to Idle state.");
        }
    }
}