using System;

namespace ServiceLocator
{
    class Program
    {
        static void Main(string[] args)
        {
            IAudioService audio = Locator.GetAudioService();
            IProductService product = Locator.GetProductService();

            audio.PlaySound();
            product.AddProduct();

            audio.StopSound();
            product.GetProduct();
        }
    }
}
