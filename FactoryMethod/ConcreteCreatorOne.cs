namespace FactoryMethod
{
    class ConcreteCreatorOne : ProductCreator
    {
        public override IProduct CreateProduct()
        {
            return new ProductOne();
        }
    }
}