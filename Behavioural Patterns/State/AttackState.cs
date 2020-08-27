using System;

namespace State
{
    class AttackState : IState
    {
        public void DoStuff()
        {
            Console.WriteLine("Moved to Attack state.");
        }
    }
}