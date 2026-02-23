namespace BLL.DTO;

public sealed class DeviceConfigDto
{
    public string CpuModel { get; init; } = string.Empty;
    public int MemoryGb { get; init; }
    public int BatteryMah { get; init; }
}
