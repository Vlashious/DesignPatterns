using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client2D = new Client(new Factory2D());
            Client client3D = new Client(new Factory3D());

            var productA = client2D.CreateFigureA();
            var productB = client2D.CreateFigureB();

            var productC = client3D.CreateFigureA();
            var productD = client3D.CreateFigureB();

            Console.WriteLine(client2D.GetFactoryType()); // Factory2D
            Console.WriteLine(productA.GetName());        // It's a triangle.
            Console.WriteLine(productB.GetName());        // It's a rectangle.

            Console.WriteLine(client3D.GetFactoryType()); // Factory3D
            Console.WriteLine(productC.GetName());        // It's a pyramid.
            Console.WriteLine(productD.GetName());        // It's a cube.
        }
    }
}
