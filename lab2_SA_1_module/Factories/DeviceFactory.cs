using BLL.DTO;
using DAL.Core.Components;
using DAL.Core.Devices;

namespace BLL.Factories;

public static class DeviceFactory
{
    public static Device CreateLaptop(DeviceConfigDto dto)
    {
        return new Laptop(
            new Processor(dto.CpuModel),
            new Memory(dto.MemoryGb),
            new Battery(dto.BatteryMah));
    }

    public static Device CreateSmartphone(DeviceConfigDto dto)
    {
        return new Smartphone(
            new Processor(dto.CpuModel),
            new Memory(dto.MemoryGb),
            new Battery(dto.BatteryMah));
    }

    public static Device CreateTablet(DeviceConfigDto dto)
    {
        return new Tablet(
            new Processor(dto.CpuModel),
            new Memory(dto.MemoryGb),
            new Battery(dto.BatteryMah));
    }
}
