namespace ConsoleApp.SecMenu;

public static class SettingsMenu
{
    public static void Show()
    {
        if (Menu.Device is null) return;

        Console.Clear();
        Console.WriteLine("""
        1. Встановити ПЗ
        2. Підключитись до мережі
        3. Підключити аудіо
        4. Підключити принтер
        0. Назад
        """);

        switch (Console.ReadLine())
        {
            case "1": Menu.Device.InstallSoftware(); break;
            case "2": Menu.Device.ConnectNetwork(); break;
            case "3": Menu.Device.ConnectAudio(); break;
            case "4": Menu.Device.ConnectPrinter(); break;
        }
    }
}