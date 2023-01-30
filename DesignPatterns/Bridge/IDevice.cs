namespace Lemure.DesignPatterns.Bridge
{
    public interface IDevice
    {
        bool IsEnable();
        void Enable();
        void Disable();
        int GetVolumes();
        void SetVolumes(int percente);
        int GetChannel();
        void SetChannel(int channel);
    }
}
