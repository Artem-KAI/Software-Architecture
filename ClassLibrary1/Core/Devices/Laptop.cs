namespace DAL.Core.Devices;

public sealed class Laptop : Device
{
    public Laptop(
        Components.Processor cpu,
        Components.Memory memory,
        Components.Battery battery)
        : base(cpu, memory, battery, new Components.TouchScreen(false))
    {
    }
}
