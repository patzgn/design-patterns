using RemoteControlSystem.Devices;

namespace RemoteControlSystem.Remotes;

public class BasicRemote(IDevice device) : Remote(device);
