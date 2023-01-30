namespace Lemure.DesignPatterns.Bridge.RefinedAbstraction
{
    public class AdvancedRemoteControl : RemoteAbstraction
    {
        public AdvancedRemoteControl(IDevice device): base(device)
        {
        }

        public void Mute()
        {
            _remoteDevice.SetVolumes(0);
        }
    }
}
