using DAL.Core;

namespace DAL.Core.State;

public sealed class PeripheralState
{
    private readonly HashSet<PeripheralType> connectedPeripherals;

    public PeripheralState()
    {
        connectedPeripherals = new HashSet<PeripheralType>();
    }

    public bool HasPeripheral(PeripheralType peripheralType)
    {
        bool isConnected = connectedPeripherals.Contains(peripheralType);
        return isConnected;
    }

    public void Connect(PeripheralType peripheralType)
    {
        bool alreadyConnected = connectedPeripherals.Contains(peripheralType);

        if (alreadyConnected == false)
        {
            connectedPeripherals.Add(peripheralType);
        }
    }
}
