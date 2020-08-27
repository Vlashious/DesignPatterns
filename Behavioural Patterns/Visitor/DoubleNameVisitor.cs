using System;

namespace Visitor
{
    class DoubleNameVisitor : IVisitor
    {
        public void Visit(IShape shape)
        {
            shape.Name = $"{shape.Name} + {shape.Name}";
        }
    }
}