using Domain.Interfaces;

namespace ConsoleApp.Status;
public static class StatusView
{
    public static void Show(IDevice? device)
    {
        if (device == null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Техніка не вибрана\n");
            Console.ResetColor();
            return;
        }

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Пристрій: {device.Name}");
        Console.WriteLine($"ПЗ: {(device.HasSoftware ? "Так" : "Ні")}");
        Console.WriteLine($"Інтернет: {(device.HasNetwork ? "Так" : "Ні")}");
        Console.WriteLine($"Аудіо: {(device.HasAudio ? "Так" : "Ні")}");
        Console.WriteLine($"Принтер: {(device.HasPrinter ? "Так" : "Ні")}");
        Console.WriteLine($"Енергія: {(device.PowerOn ? "Є" : "Немає")}");
        Console.ResetColor();

        if (device.PowerOn == false)
        {
            int hours = device.RemainingHours;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Годин залишилось (режим): {hours}");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Годин залишилось: не обмежено (є енергія)");
            Console.ResetColor();
        }

        Console.WriteLine();
    }
}