using System;

namespace ServiceLocator
{
    class AudioService : IAudioService
    {
        public void PlaySound()
        {
            Console.WriteLine("Playing sound...");
        }

        public void StopSound()
        {
            Console.WriteLine("Stopping sound...");
        }
    }
}