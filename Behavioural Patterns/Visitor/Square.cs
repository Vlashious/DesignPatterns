namespace Visitor
{
    class Square : IShape
    {
        public string Name { get; set; }

        public Square(string name)
        {
            Name = name;
        }


        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}