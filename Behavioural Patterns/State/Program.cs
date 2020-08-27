using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context(new IdleState());
            context.DoStuff(); // Moved to Idle state.

            context.ChangeState(new AttackState());
            context.DoStuff(); // Moved to Attack state.
        }
    }
}
