using Application;
using Domain.Devices;

namespace ConsoleApp.SecMenu;

public static class DeviceMenu
{
    public static void Select()
    {
        Console.Clear();
        Console.WriteLine("""
        1. Ноутбук (5000-7000 мАг)
        2. Смартфон (2000-3000 мАг)
        3. Планшет (2000-3000 мАг)
        0. Назад
        """);

        Menu.Device = Console.ReadLine() switch
        {
            "1" => new Laptop(6000),
            "2" => new Smartphone(2500),
            "3" => new Tablet(2500),
            _ => Menu.Device
        };

        if (Menu.Device != null)
            Menu.Service = new DeviceService(Menu.Device);
    }
}