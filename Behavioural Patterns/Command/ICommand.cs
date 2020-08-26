namespace Command
{
    interface ICommand
    {
        int Execute(int x);
        int Undo();
    }
}