namespace Visitor
{
    class Circle : IShape
    {
        public string Name { get; set; }

        public Circle(string name)
        {
            Name = name;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}