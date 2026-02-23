namespace DAL.Core.Devices;

public sealed class Smartphone : Device
{
    public Smartphone(
        Components.Processor cpu,
        Components.Memory memory,
        Components.Battery battery)
        : base(cpu, memory, battery, new Components.TouchScreen(true))
    {
    }
}
