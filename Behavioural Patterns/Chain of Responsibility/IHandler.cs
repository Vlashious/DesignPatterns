namespace Chain_of_Responsibility
{
    interface IHandler
    {
        IHandler SetNext(IHandler next);
        void HandleRequest(int data);
    }
}