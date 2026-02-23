using Domain.Enums;

namespace Domain.Components;

public class Battery
{
    public int CapacityMah { get; }
    public int RemainingHours { get; private set; }

    public event Action<int>? BatteryChanged;

    public Battery(int capacityMah)
    {
        CapacityMah = capacityMah;
        SetMode(UsageMode.NonIntensive);
    }

    public void SetMode(UsageMode mode)
    {
        RemainingHours = CalculateHours(mode);
        BatteryChanged?.Invoke(RemainingHours);
    }

    private int CalculateHours(UsageMode mode)
    {
        if (CapacityMah >= 2000 && CapacityMah <= 3000)
            return mode == UsageMode.NonIntensive ? 48 : 16;

        if (CapacityMah >= 5000 && CapacityMah <= 7000)
            return mode == UsageMode.NonIntensive ? 12 : 4;

        return 0;
    }
}

//using Domain.Enums;

//namespace Domain.Components;

//public class Battery
//{
//    public int CapacityMah { get; }
//    public int RemainingHours { get; private set; }
//    private UsageMode currentMode;

//    public event Action<int>? BatteryChanged;

//    public Battery(int capacityMah)
//    {
//        CapacityMah = capacityMah;
//        SetMode(UsageMode.NonIntensive);
//    }

//    public void SetMode(UsageMode mode)
//    {
//        currentMode = mode;
//        RemainingHours = CalculateHours(mode);
//        BatteryChanged?.Invoke(RemainingHours);
//    }

//    private int CalculateHours(UsageMode mode)
//    {
//        if (CapacityMah >= 2000 && CapacityMah <= 3000)
//            return mode == UsageMode.NonIntensive ? 48 : 16;

//        if (CapacityMah >= 5000 && CapacityMah <= 7000)
//            return mode == UsageMode.NonIntensive ? 12 : 4;

//        return 0;
//    }
//}

////using Domain.Enums;

////namespace Domain.Components;

////public class Battery
////{
////    public int CapacityMah { get; }
////    public int RemainingHours { get; private set; }

////    public event Action<int>? BatteryChanged;

////    public Battery(int capacityMah)
////    {
////        CapacityMah = capacityMah;
////        RemainingHours = CalculateMaxHours(UsageMode.NonIntensive);
////    }

////    public int CalculateMaxHours(UsageMode mode)
////    {
////        if (CapacityMah >= 2000 && CapacityMah <= 3000)
////            return mode == UsageMode.NonIntensive ? 48 : 16;

////        if (CapacityMah >= 5000 && CapacityMah <= 7000)
////            return mode == UsageMode.NonIntensive ? 12 : 4;

////        return 0;
////    }

////    public void ConsumeHour()
////    {
////        if (RemainingHours <= 0)
////            return;

////        RemainingHours--;
////        BatteryChanged?.Invoke(RemainingHours);
////    }
////}