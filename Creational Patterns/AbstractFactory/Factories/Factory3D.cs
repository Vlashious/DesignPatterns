namespace AbstractFactory
{
    class Factory3D : IAbstractFactory
    {
        public IFigure CreateProductA()
        {
            return new Pyramid();
        }

        public IFigure CreateProductB()
        {
            return new Cube();
        }
    }
}