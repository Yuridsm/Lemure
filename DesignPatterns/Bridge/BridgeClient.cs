using Lemure.DesignPatterns.Bridge.Implementations;

namespace Lemure.DesignPatterns.Bridge
{
    public class BridgeClient
    {
        public static void RunWithTV()
        {
            TV tv = new TV();
            var remote = new RemoteAbstraction(tv);
            remote.GetDetails();

            remote.TogglePower();
            remote.ChannelUp();
            remote.VolumeDown();

            remote.GetDetails();
        }

        public static void RunWithRadio()
        {
            Radio radio = new Radio();
            var remote = new RemoteAbstraction(radio);
            remote.GetDetails();

            remote.TogglePower();
            remote.ChannelUp();
            remote.VolumeDown();

            remote.GetDetails();
        }
    }
}
