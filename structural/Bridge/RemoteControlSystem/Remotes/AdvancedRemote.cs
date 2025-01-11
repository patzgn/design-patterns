using RemoteControlSystem.Devices;

namespace RemoteControlSystem.Remotes;

public class AdvancedRemote(IDevice device) : Remote(device)
{
    public void Mute()
    {
        Console.WriteLine("Muting the device.");
        Device.SetVolume(0);
    }
}
