using DAL.Core;

namespace BLL.Interfaces;

public interface IDeviceService
{
    void InstallSoftware(SoftwareType softwareType);
    void UninstallSoftware(SoftwareType softwareType);
    bool IsSoftwareInstalled(SoftwareType softwareType);
    bool CanRunSoftware(SoftwareType softwareType);

    void ConnectPeripheral(PeripheralType peripheralType);
    void DisconnectPeripheral(PeripheralType peripheralType);
    bool IsPeripheralConnected(PeripheralType peripheralType);
}
