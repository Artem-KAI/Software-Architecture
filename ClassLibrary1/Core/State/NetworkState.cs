namespace DAL.Core.State;

public sealed class NetworkState
{
    public bool IsConnected { get; private set; }

    public NetworkState()
    {
        IsConnected = false;
    }

    public void Connect()
    {
        IsConnected = true;
    }

    public void Disconnect()
    {
        IsConnected = false;
    }
}
