using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new ConcreteMediator();
            var col1 = new ConcreteColleague1(mediator);
            var col2 = new ConcreteColleague2(mediator);
            mediator.Col1 = col1;
            mediator.Col2 = col2;

            col1.Send("Hello, colleague!");
            col2.Send("Ugh, I hate you.");
        }
    }
}
