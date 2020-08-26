namespace Mediator
{
    class ConcreteMediator : Mediator
    {
        public ConcreteColleague1 Col1 { private get; set; }
        public ConcreteColleague2 Col2 { private get; set; }
        public override void Send(string msg, Colleague colleague)
        {
            if (colleague == Col1)
            {
                Col2.Notify(msg);
            }
            else Col1.Notify(msg);
        }
    }
}