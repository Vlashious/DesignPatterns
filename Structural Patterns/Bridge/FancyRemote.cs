using System;

namespace Bridge
{
    class FancyRemote : Remote
    {
        private int _prevVolume;

        public FancyRemote(IDevice device) : base(device)
        {
        }

        public void Mute()
        {
            _prevVolume = _device.Volume;
            _device.Volume = 0;
            Console.WriteLine("Muted.");
        }

        public void UnMute()
        {
            _device.Volume = _prevVolume;
            Console.WriteLine("Unmuted.");
        }
    }
}