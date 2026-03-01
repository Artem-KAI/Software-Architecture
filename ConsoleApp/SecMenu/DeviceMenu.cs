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

        string? input = Console.ReadLine();

        switch (input)
        {
            case "1":
                Menu.Device = new Laptop(6000);
                break;
            case "2":
                Menu.Device = new Smartphone(2500);
                break;
            case "3":
                Menu.Device = new Tablet(2500);
                break;
            default:
                break;
        }

        if (Menu.Device != null)
        {
            Menu.Service = new DeviceService(Menu.Device);
        }
    }
}