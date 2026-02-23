using Domain.Interfaces;

namespace ConsoleApp.Status;
public static class StatusView
{
    public static void Show(IDevice? device)
    {
        if (device == null)
        {
            Console.WriteLine("Техніка не вибрана\n");
            return;
        }

        Console.WriteLine($"Пристрій: {device.Name}");
        Console.WriteLine($"ПЗ: {(device.HasSoftware ? "Так" : "Ні")}");
        Console.WriteLine($"Інтернет: {(device.HasNetwork ? "Так" : "Ні")}");
        Console.WriteLine($"Аудіо: {(device.HasAudio ? "Так" : "Ні")}");
        Console.WriteLine($"Принтер: {(device.HasPrinter ? "Так" : "Ні")}");
        Console.WriteLine($"Енергія: {(device.PowerOn ? "Є" : "Немає")}");

        if (!device.PowerOn)
            Console.WriteLine($"Годин залишилось (режим): {device.RemainingHours}");
        else
            Console.WriteLine("Годин залишилось: не обмежено (є енергія)");

        Console.WriteLine();
    }
}