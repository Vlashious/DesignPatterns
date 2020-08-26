namespace Mediator
{
    ///<summary>
    ///Hi bitch.
    ///</summary>
    abstract class Colleague
    {
        protected Mediator _mediator;
        public Colleague(Mediator mediator)
        {
            this._mediator = mediator;
        }
    }
}