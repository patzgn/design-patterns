namespace RemoteControlSystem.Devices;

public class Radio : IDevice
{
    private int _volume;

    public void TurnOn() => Console.WriteLine("Radio is now ON.");

    public void TurnOff() => Console.WriteLine("Radio is now OFF.");

    public void SetVolume(int volume)
    {
        _volume = volume;
        Console.WriteLine($"Radio volume set to {_volume}");
    }
}
