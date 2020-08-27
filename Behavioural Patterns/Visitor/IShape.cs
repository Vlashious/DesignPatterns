namespace Visitor
{
    interface IShape
    {
        string Name { get; set; }
        void Accept(IVisitor visitor);
    }
}