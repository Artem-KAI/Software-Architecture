namespace DAL.Core.Devices;

public sealed class Tablet : Device
{
    public Tablet(
        Components.Processor cpu,
        Components.Memory memory,
        Components.Battery battery)
        : base(cpu, memory, battery, new Components.TouchScreen(true))
    {
    }
}
