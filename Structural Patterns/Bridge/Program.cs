using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV();
            Radio radio = new Radio();
            Remote remote = new Remote(tv);

            remote.TogglePower();
            remote.VolumeUp();
            remote.VolumeDown();
            remote.ChannelUp();
            remote.TogglePower();

            remote.ChangeDevice(radio);

            remote.TogglePower();
            remote.VolumeUp();
            remote.VolumeDown();
            remote.ChannelUp();
            remote.TogglePower();

            FancyRemote fancyRemote = new FancyRemote(tv);
            fancyRemote.Mute();

            fancyRemote.ChangeDevice(radio);
            fancyRemote.Mute();
        }
    }
}
