using System;

namespace Bridge
{
    class Remote
    {
        protected IDevice _device;

        public Remote(IDevice device)
        {
            _device = device;
        }

        public void ChangeDevice(IDevice device)
        {
            _device = device;
        }

        public void TogglePower()
        {
            if (_device.IsEnabled())
            {
                _device.Disable();
            }
            else _device.Enable();
        }

        public void VolumeDown()
        {
            _device.Volume--;
            Console.WriteLine($"Volume is {_device.Volume}.");
        }

        public void VolumeUp()
        {
            _device.Volume++;
            Console.WriteLine($"Volume is {_device.Volume}.");
        }

        public void ChannelDown()
        {
            _device.Channel--;
            Console.WriteLine($"Channel is {_device.Channel}.");
        }

        public void ChannelUp()
        {
            _device.Channel++;
            Console.WriteLine($"Channel is {_device.Channel}.");
        }
    }
}