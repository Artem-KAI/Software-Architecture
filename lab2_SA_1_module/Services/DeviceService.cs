using BLL.Mappers;
using BLL.Models;
using DAL.Core;
using DAL.Core.Devices;

namespace BLL.Services;

public class DeviceService
{
    private readonly IDevice device;

    public DeviceService(IDevice device)
    {
        this.device = device;
    }

    public void InstallSoftware(SoftwareModel software)
    {
        device.Software.Install(DeviceTypeMapper.ToDalSoftware(software));
    }

    public bool CanRunSoftware(SoftwareModel software)
    {
        return device.Software.CanRun(DeviceTypeMapper.ToDalSoftware(software));
    }

    public void UseSoftware(SoftwareModel software)
    {
        device.Software.Run(DeviceTypeMapper.ToDalSoftware(software));
    }

    public void ConnectPeripheral(PeripheralModel peripheral)
    {
        device.Peripherals.Connect(DeviceTypeMapper.ToDalPeripheral(peripheral));
    }
}
