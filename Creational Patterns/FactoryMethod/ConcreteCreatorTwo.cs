namespace FactoryMethod
{
    class ConcreteCreatorTwo : ProductCreator
    {
        public override IProduct CreateProduct()
        {
            return new ProductTwo();
        }
    }
}