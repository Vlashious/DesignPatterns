using System;

namespace Bridge
{
    class TV : IDevice
    {
        private bool _isEnabled;

        public int Volume { get; set; }
        public int Channel { get; set; }

        public void Disable()
        {
            _isEnabled = false;
            Console.WriteLine("Disabled TV.");
        }

        public void Enable()
        {
            _isEnabled = true;
            Console.WriteLine("Enabled TV.");
        }

        public bool IsEnabled()
        {
            return _isEnabled;
        }
    }
}