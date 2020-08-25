namespace Proxy
{
    class Proxy : IServiceInterface
    {
        private IServiceInterface _service;
        public Proxy(IServiceInterface service)
        {
            _service = service;
        }
        public void SomeOperation()
        {
            _service.SomeOperation();
        }
    }
}