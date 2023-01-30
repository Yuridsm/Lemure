namespace Lemure.DesignPatterns.Bridge.Implementations
{
    public class Radio : IDevice
    {
        private bool _enable = false;
        private int _channel = 0;
        private int _volume = 0;

        public void Disable()
        {
            _enable = false;
        }

        public void Enable()
        {
            _enable = false;
        }

        public int GetChannel()
        {
            return _channel;
        }

        public int GetVolumes()
        {
            return _volume;
        }

        public bool IsEnable()
        {
            return _enable;
        }

        public void SetChannel(int channel)
        {
            _channel = channel;
        }

        public void SetVolumes(int percente)
        {
            _volume = percente;
        }
    }
}
