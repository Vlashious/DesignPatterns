using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var convertor = new VideoConverter();
            convertor.ConvertVideo();
        }
    }
}
