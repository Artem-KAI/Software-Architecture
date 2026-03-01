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
     
    void InstallSoftware();
    void ConnectNetwork();
    void ConnectAudio();
    void ConnectPrinter();
    void EnablePower();
    void DisablePower();

    // перевіряє чи можна виконати дію: чи є ПЗ, мережа ітд
    bool CanPerform(DeviceAction action);
    // виконує дію, змінює стан: режим батареї і тд
    void Perform(DeviceAction action);
}
