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
        // Без ПЗ — нічого не працює (умова)
        if (!HasSoftware)
            return false;

        // Якщо немає енергії — працюємо тільки якщо батарея “дає години”
        if (!PowerOn && Battery.RemainingHours <= 0)
            return false;

        // Умови мережі
        if (action == DeviceAction.Chat && !HasNetwork)
            return false;

        // Зовнішні пристрої (аудіо/принтер)
        if ((action == DeviceAction.ListenMusic || action == DeviceAction.WatchVideo) && !HasAudio)
            return false;

        if (action == DeviceAction.PrintPhoto && !HasPrinter)
            return false;

        return true;
    }

    public void Perform(DeviceAction action)
    {
        // Якщо є енергія — батарея не обмежує (в рамках цієї симуляції)
        if (PowerOn)
            return;

        // Якщо енергії нема — вибираємо режим, як у завданні
        var mode = action switch
        {
            DeviceAction.Work or DeviceAction.PlayGame or DeviceAction.WatchVideo
                => UsageMode.Intensive,

            _ => UsageMode.NonIntensive
        };

        // Саме це дає 48->16 або 12->4 одразу (як ти хочеш)
        Battery.SetMode(mode);
    }
}

//using Domain.Components;
//using Domain.Enums;
//using Domain.Interfaces;

//namespace Domain.Devices;

//public abstract class DeviceBase : IDevice
//{
//    public string Name { get; }

//    protected Battery Battery { get; }
//    protected Processor Processor { get; }
//    protected List<Memory> Memory { get; }
//    protected TouchScreen TouchScreen { get; }

//    public bool HasSoftware { get; private set; }
//    public bool HasNetwork { get; private set; }
//    public bool HasAudio { get; private set; }
//    public bool HasPrinter { get; private set; }
//    public bool PowerOn { get; private set; } = true;

//    public int RemainingHours => Battery.RemainingHours;

//    protected DeviceBase(
//        string name,
//        Battery battery,
//        Processor processor,
//        List<Memory> memory,
//        TouchScreen touchScreen)
//    {
//        Name = name;
//        Battery = battery;
//        Processor = processor;
//        Memory = memory;
//        TouchScreen = touchScreen;
//    }

//    public void InstallSoftware() => HasSoftware = true;
//    public void ConnectNetwork() => HasNetwork = true;
//    public void ConnectAudio() => HasAudio = true;
//    public void ConnectPrinter() => HasPrinter = true;

//    public void EnablePower() => PowerOn = true;
//    public void DisablePower() => PowerOn = false;

//    public bool CanPerform(DeviceAction action)
//    {
//        if (!HasSoftware)
//            return false;

//        return action switch
//        {
//            DeviceAction.ListenMusic => HasAudio,
//            DeviceAction.WatchVideo => HasAudio,
//            DeviceAction.PrintPhoto => HasPrinter,
//            _ => true
//        };
//    }

//    public void Perform(DeviceAction action)
//    {
//        if (PowerOn)
//            return;

//        var mode = action switch
//        {
//            DeviceAction.Work or
//            DeviceAction.PlayGame or
//            DeviceAction.WatchVideo => UsageMode.Intensive,

//            _ => UsageMode.NonIntensive
//        };

//        Battery.SetMode(mode);
//    }
//}

////using Domain.Components;
////using Domain.Enums;
////using Domain.Interfaces;

////namespace Domain.Devices;

////public abstract class DeviceBase : IDevice
////{
////    public string Name { get; }
////    public bool HasSoftware { get; private set; }
////    public bool HasNetwork { get; private set; }
////    public bool HasPrinter { get; private set; }
////    public bool HasAudio { get; private set; }
////    public bool PowerOn { get; private set; } = true;

////    protected Battery Battery { get; }

////    public int RemainingHours => Battery.RemainingHours;

////    protected DeviceBase(string name, Battery battery)
////    {
////        Name = name;
////        Battery = battery;
////    }

////    public void InstallSoftware() => HasSoftware = true;
////    public void ConnectNetwork() => HasNetwork = true;
////    public void ConnectPrinter() => HasPrinter = true;
////    public void ConnectAudio() => HasAudio = true;

////    public void EnablePower() => PowerOn = true;
////    public void DisablePower() => PowerOn = false;

////    public bool CanPerform(DeviceAction action)
////    {
////        if (!HasSoftware)
////            return false;

////        if (!PowerOn && Battery.RemainingHours <= 0)
////            return false;

////        return action switch
////        {
////            DeviceAction.ListenMusic => HasAudio,
////            DeviceAction.WatchVideo => HasAudio,
////            DeviceAction.PrintPhoto => HasPrinter,
////            _ => true
////        };
////    }

////    public void Perform(DeviceAction action)
////    {
////        if (!PowerOn)
////            Battery.ConsumeHour();
////    }
////}