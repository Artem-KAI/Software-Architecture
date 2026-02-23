using DAL.Core;

namespace DAL.Core.Components;

public sealed class Battery
{
    public int CapacityMah { get; }
    public int RemainingHours { get; private set; }

    public Battery(int capacityMah)
    {
        CapacityMah = capacityMah;
        RemainingHours = CalculateMaxHours(BatteryUsageMode.Idle);
    }

    public void Consume(BatteryUsageMode usageMode)
    {
        if (RemainingHours > 0)
        {
            RemainingHours = RemainingHours - 1;
        }
    }

    private int CalculateMaxHours(BatteryUsageMode usageMode)
    {
        if (CapacityMah >= 2000 && CapacityMah <= 3000)
        {
            if (usageMode == BatteryUsageMode.Idle)
            {
                return 48;
            }
            else
            {
                return 16;
            }
        }

        if (CapacityMah >= 5000 && CapacityMah <= 7000)
        {
            if (usageMode == BatteryUsageMode.Idle)
            {
                return 12;
            }
            else
            {
                return 4;
            }
        }

        return 0;
    }
}


//public sealed class Battery
//{
//    public int CapacityMah { get; }
//    public int RemainingHours { get; private set; }

//    public Battery(int capacityMah)
//    {
//        CapacityMah = capacityMah;
//        RemainingHours = CalculateMaxHours(BatteryUsageMode.Idle);
//    }

//    public void Consume(BatteryUsageMode mode)
//    {
//        if (RemainingHours > 0)
//            RemainingHours--;
//    }

//    public int CalculateMaxHours(BatteryUsageMode mode)
//    {
//        return CapacityMah switch
//        {
//            >= 2000 and <= 3000 => mode == BatteryUsageMode.Idle ? 48 : 16,
//            >= 5000 and <= 7000 => mode == BatteryUsageMode.Idle ? 12 : 4,
//            _ => 0
//        };
//    }
//}
