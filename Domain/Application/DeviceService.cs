using Domain.Enums;
using Domain.Interfaces;

namespace Application;

public class DeviceService
{
    private readonly IDevice _device;

    public DeviceService(IDevice device) => _device = device;

    public bool TryPerform(DeviceAction action)
    {
        if (!_device.CanPerform(action))
            return false;

        _device.Perform(action);
        return true;
    }
}

//using Domain.Enums;
//using Domain.Interfaces;

//namespace Application;

//public class DeviceService
//{
//    private readonly IDevice _device;

//    public DeviceService(IDevice device)
//    {
//        _device = device;
//    }

//    public bool TryPerform(DeviceAction action)
//    {
//        if (!_device.CanPerform(action))
//            return false;

//        _device.Perform(action);
//        return true;
//    }
//}