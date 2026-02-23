using DAL.Core.Components;
using DAL.Core.State;

namespace DAL.Core.Devices;

public abstract class Device
{
    public Processor Processor { get; }
    public Memory Memory { get; }
    public Battery? Battery { get; }
    public TouchScreen TouchScreen { get; }

    public NetworkState Network { get; }
    public PeripheralState Peripherals { get; }
    public SoftwareState Software { get; }

    protected Device(
        Processor processor,
        Memory memory,
        Battery? battery,
        TouchScreen touchScreen)
    {
        Processor = processor;
        Memory = memory;
        Battery = battery;
        TouchScreen = touchScreen;

        Network = new NetworkState();
        Peripherals = new PeripheralState();
        Software = new SoftwareState();
    }
}
