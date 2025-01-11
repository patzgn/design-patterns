using RemoteControlSystem.Devices;
using RemoteControlSystem.Remotes;

IDevice tv = new TV();
IDevice radio = new Radio();

Remote basicRemote = new BasicRemote(tv);
Remote advancedRemote = new AdvancedRemote(radio);

Console.WriteLine("Testing BasicRemote with TV:");
basicRemote.TurnOn();
basicRemote.SetVolume(15);
basicRemote.TurnOff();

Console.WriteLine("Testing AdvancedRemote with Radio:");
advancedRemote.TurnOn();
advancedRemote.SetVolume(30);
((AdvancedRemote)advancedRemote).Mute();
advancedRemote.TurnOff();
