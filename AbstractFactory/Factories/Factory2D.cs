namespace AbstractFactory
{
    class Factory2D : IAbstractFactory
    {
        public IFigure CreateProductA()
        {
            return new Triangle();
        }

        public IFigure CreateProductB()
        {
            return new Rectangle();
        }
    }
}