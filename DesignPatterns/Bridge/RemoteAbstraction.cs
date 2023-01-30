using System;

namespace Lemure.DesignPatterns.Bridge
{
    public class RemoteAbstraction
    {
        protected IDevice _remoteDevice;

        public RemoteAbstraction(IDevice remoteDevice)
        {
            _remoteDevice = remoteDevice;
        }

        public void GetDetails()
        {
            Console.WriteLine($"Channel: {_remoteDevice.GetChannel()}");
            Console.WriteLine($"Volume: {_remoteDevice.GetVolumes()}\n\n");
        }

        public void TogglePower() 
        {
            if(_remoteDevice.IsEnable())
            {
                _remoteDevice.Disable();
            }
            else 
            { 
                _remoteDevice.Enable();
            }
        }

        public void VolumeDown() 
        {
            var oldVolume = _remoteDevice.GetVolumes();
            var newVolume = oldVolume - 5;

            if(newVolume >= 0 && newVolume <= 100)
            {
                _remoteDevice.SetVolumes(newVolume);
            }
        }

        public void VolumeUp() 
        {
            var oldVolume = _remoteDevice.GetVolumes();
            _remoteDevice.SetVolumes(oldVolume + 5);
        }

        public void ChannelDown() 
        {
            var oldChannel = _remoteDevice.GetChannel();
            _remoteDevice.SetChannel(oldChannel - 5);
        }

        public void ChannelUp() 
        {
            var oldChannel = _remoteDevice.GetChannel();
            _remoteDevice.SetChannel(oldChannel + 5);
        }
    }
}
