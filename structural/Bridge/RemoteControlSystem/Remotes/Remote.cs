using RemoteControlSystem.Devices;

namespace RemoteControlSystem.Remotes;

public abstract class Remote(IDevice device)
{
    protected readonly IDevice Device = device;

    public void TurnOn() => Device.TurnOn();

    public void TurnOff() => Device.TurnOff();

    public void SetVolume(int volume) => Device.SetVolume(volume);
}
