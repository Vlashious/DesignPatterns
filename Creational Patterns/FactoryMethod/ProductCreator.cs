namespace FactoryMethod
{
    abstract class ProductCreator
    {
        public void SomeOperation()
        {

        }

        abstract public IProduct CreateProduct();
    }
}