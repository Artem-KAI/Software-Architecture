namespace ConsoleApp.SecMenu;

public static class PowerMenu
{
    public static void Show()
    {
        if (Menu.Device is null) return;

        Console.Clear();
        Console.WriteLine("""
        1. Увімкнути енергію
        2. Вимкнути енергію
        0. Назад
        """);

        switch (Console.ReadLine())
        {
            case "1": Menu.Device.EnablePower(); break;
            case "2": Menu.Device.DisablePower(); break;
        }
    }
}