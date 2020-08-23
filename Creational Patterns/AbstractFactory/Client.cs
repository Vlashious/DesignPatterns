namespace AbstractFactory
{
    class Client
    {
        private IAbstractFactory _factory;

        public Client(IAbstractFactory factory)
        {
            _factory = factory;
        }

        public string GetFactoryType()
        {
            return _factory.GetType().ToString();
        }

        public IFigure CreateFigureA()
        {
            return _factory.CreateProductA();
        }

        public IFigure CreateFigureB()
        {
            return _factory.CreateProductB();
        }
    }
}