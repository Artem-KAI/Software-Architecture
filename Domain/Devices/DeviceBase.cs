using Domain.Components;
using Domain.Enums;
using Domain.Interfaces;

namespace Domain.Devices;

public abstract class DeviceBase : IDevice
{
    public string Name { get; }

    // Компоненти (вимога завдання)
    protected Processor Processor { get; }
    protected List<Memory> Memory { get; }
    protected TouchScreen TouchScreen { get; }
    protected Battery Battery { get; }

    // Стан/передумови
    public bool HasSoftware { get; private set; }
    public bool HasNetwork { get; private set; }
    public bool HasAudio { get; private set; }
    public bool HasPrinter { get; private set; }
    public bool PowerOn { get; private set; } = true;

    public int RemainingHours => Battery.RemainingHours;

    protected DeviceBase(
        string name,
        Battery battery,
        Processor processor,
        List<Memory> memory,
        TouchScreen touchScreen)
    {
        Name = name;
        Battery = battery;
        Processor = processor;
        Memory = memory;
        TouchScreen = touchScreen;
    }

    // Налаштування
    public void InstallSoftware() => HasSoftware = true;
    public void ConnectNetwork() => HasNetwork = true;
    public void ConnectAudio() => HasAudio = true;
    public void ConnectPrinter() => HasPrinter = true;
    public void EnablePower() => PowerOn = true;
    public void DisablePower() => PowerOn = false;

    public bool CanPerform(DeviceAction action)
    {
        if (HasSoftware == false)
        {
            return false;
        }

        // Якщо немає енергії — працюємо тільки якщо батарея “дає години”
        if (PowerOn == false && Battery.RemainingHours <= 0)
        {
            return false;
        }

        if (action == DeviceAction.Chat && HasNetwork == false)
        {
            return false;
        }

        if ((action == DeviceAction.ListenMusic || action == DeviceAction.WatchVideo) && HasAudio == false)
        {
            return false;
        }

        if (action == DeviceAction.PrintPhoto && HasPrinter == false)
        {
            return false;
        }

        return true;
    }

    public void Perform(DeviceAction action)
    {

        if (PowerOn == true)
        {
            return;
        }

        UsageMode mode;

        switch (action)
        {
            case DeviceAction.Work:
            case DeviceAction.PlayGame:
            case DeviceAction.WatchVideo:
                mode = UsageMode.Intensive; 
                break;

            default:
                mode = UsageMode.NonIntensive;
                break;
        }

        Battery.SetMode(mode);
    }
}  