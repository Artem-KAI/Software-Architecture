using Application;
using ConsoleApp.SecMenu;
using ConsoleApp.Status;
using Domain.Interfaces;

namespace ConsoleApp;

public static class Menu
{
    public static IDevice? Device { get; set; }
    public static DeviceService? Service { get; set; }

    public static void Run()
    {
        while (true)
        {
            Console.Clear();
            StatusView.Show(Device);

            Console.WriteLine("""
            1. Вибрати техніку
            2. Налаштування
            3. Дія
            4. Вкл/Викл енергію
            0. Вихід
            """);

            switch (Console.ReadLine())
            {
                case "1": DeviceMenu.Select(); break;
                case "2": SettingsMenu.Show(); break;
                case "3": ActionsMenu.Show(); break;
                case "4": PowerMenu.Show(); break;
                case "0": return;
            }
        }
    }
}