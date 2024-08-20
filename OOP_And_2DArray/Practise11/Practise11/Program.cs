using Practise11;

TV tV = new TV();
Radio radio = new Radio();
Appliance[] app = {tV, radio};
IRemoteControl[] remoteControls = {tV, radio};
foreach (Appliance item in app)
{
    item.TurnOn();
    item.TurnOff();
}
foreach (IRemoteControl item in remoteControls)
{
    item.VolumeUp();
    item.VolumeDown();
}