using System;
using Framework;

namespace Facade
{
    class VideoConverter
    {
        public void ConvertVideo()
        {
            var videoCodec = new VideoCodec();
            // Do some stuff with the framework.
            Console.WriteLine("Video converted!");
        }
    }
}