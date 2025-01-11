namespace RemoteControlSystem.Devices;

public class TV : IDevice
{
    private int _volume;

    public void TurnOn() => Console.WriteLine("TV is now ON.");

    public void TurnOff() => Console.WriteLine("TV is now OFF.");

    public void SetVolume(int volume)
    {
        _volume = volume;
        Console.WriteLine($"TV volume set to {_volume}");
    }
}
