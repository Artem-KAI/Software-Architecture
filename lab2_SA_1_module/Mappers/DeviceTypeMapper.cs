using BLL.Models;
using DAL.Core;

namespace BLL.Mappers;

public static class DeviceTypeMapper
{
    public static SoftwareType ToDalSoftware(SoftwareModel software)
    {
        return software switch
        {
            SoftwareModel.Work => SoftwareType.Work,
            SoftwareModel.Game => SoftwareType.Game,
            SoftwareModel.Chat => SoftwareType.Chat,
            SoftwareModel.Music => SoftwareType.Music,
            SoftwareModel.Video => SoftwareType.Video,
            _ => throw new ArgumentOutOfRangeException(nameof(software))
        };
    }

    public static PeripheralType ToDalPeripheral(PeripheralModel peripheral)
    {
        return peripheral switch
        {
            PeripheralModel.Speakers => PeripheralType.Speakers,
            PeripheralModel.Headphones => PeripheralType.Headphones,
            PeripheralModel.Printer => PeripheralType.Printer,
            _ => throw new ArgumentOutOfRangeException(nameof(peripheral))
        };
    }
}
