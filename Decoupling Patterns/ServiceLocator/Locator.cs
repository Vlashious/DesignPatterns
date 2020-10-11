namespace ServiceLocator
{
    class Locator
    {
        private static readonly IProductService _prodService;
        private static readonly IAudioService _audioService;
        public static IAudioService GetAudioService()
        {
            return _audioService;
        }
        public static IProductService GetProductService()
        {
            return _prodService;
        }
        static Locator()
        {
            _prodService = new ProductService();
            _audioService = new AudioService();
        }
    }
}