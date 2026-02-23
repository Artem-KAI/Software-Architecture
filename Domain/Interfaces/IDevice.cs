using Domain.Enums;

namespace Domain.Interfaces;

public interface IDevice
{
    string Name { get; }

    bool HasSoftware { get; }
    bool HasNetwork { get; }
    bool HasAudio { get; }
    bool HasPrinter { get; }
    bool PowerOn { get; }
    int RemainingHours { get; }

    // Налаштування (щоб UI не робив кастів)
    void InstallSoftware();
    void ConnectNetwork();
    void ConnectAudio();
    void ConnectPrinter();
    void EnablePower();
    void DisablePower();

    bool CanPerform(DeviceAction action);
    void Perform(DeviceAction action);
}

//using Domain.Enums; 

//namespace Domain.Interfaces;

//public interface IDevice
//{
//    string Name { get; }
//    bool HasSoftware { get; }
//    bool HasNetwork { get; }
//    bool HasPrinter { get; }
//    bool HasAudio { get; }
//    bool PowerOn { get; }
//    int RemainingHours { get; }

//    bool CanPerform(DeviceAction action);
//    void Perform(DeviceAction action);
//}