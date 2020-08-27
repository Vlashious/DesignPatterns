using System;

namespace Visitor
{
    class GetNameVisitor : IVisitor
    {
        public void Visit(IShape shape)
        {
            Console.WriteLine(shape.Name);
        }
    }
}