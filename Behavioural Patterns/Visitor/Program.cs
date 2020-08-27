using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle("Circle1");
            var square = new Square("Square2");

            var visitor1 = new GetNameVisitor();
            visitor1.Visit(circle);
            visitor1.Visit(square);

            var visitor2 = new DoubleNameVisitor();
            visitor2.Visit(circle);
            visitor2.Visit(square);

            visitor1.Visit(circle);
            visitor1.Visit(square);
        }
    }
}
