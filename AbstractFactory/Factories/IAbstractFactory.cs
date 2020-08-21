namespace AbstractFactory
{
    interface IAbstractFactory
    {
        public IFigure CreateProductA();
        public IFigure CreateProductB();
    }
}