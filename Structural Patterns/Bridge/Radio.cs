using System;

namespace Bridge
{
    class Radio : IDevice
    {
        private bool _isEnabled;

        public int Volume { get; set; }
        public int Channel { get; set; }

        public void Disable()
        {
            _isEnabled = false;
            Console.WriteLine("Disabled Radio.");
        }

        public void Enable()
        {
            _isEnabled = true;
            Console.WriteLine("Enabled Radio.");
        }

        public bool IsEnabled()
        {
            return _isEnabled;
        }
    }
}