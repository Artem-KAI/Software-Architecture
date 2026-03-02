namespace ConsoleApp.SecMenu;

public static class PowerMenu
{
    public static void Show()
    {
        if (Menu.Device == null)
        {
            return;
        }

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("""
        1. Увімкнути енергію
        2. Вимкнути енергію
        0. Назад
        """);
        Console.ResetColor();

        string? choice = Console.ReadLine();

        switch (choice)
                    {
            case "1":
                Menu.Device.EnablePower();
                break;
            case "2":
                Menu.Device.DisablePower();
                break;
            default:
                break;
        }
    }
}