using Domain.Enums;

namespace ConsoleApp.SecMenu;

public static class ActionsMenu
{
    public static void Show()
    {
        if (Menu.Service is null) return;

        Console.Clear();
        Console.WriteLine("""
        1. Працювати
        2. Чатитися
        3. Слухати музику
        4. Дивитись відео
        5. Грати
        6. Друкувати фото
        0. Назад
        """);

        var action = Console.ReadLine() switch
        {
            "1" => DeviceAction.Work,
            "2" => DeviceAction.Chat,
            "3" => DeviceAction.ListenMusic,
            "4" => DeviceAction.WatchVideo,
            "5" => DeviceAction.PlayGame,
            "6" => DeviceAction.PrintPhoto,
            _ => (DeviceAction?)null
        };

        if (action == null) return;

        bool ok = Menu.Service.TryPerform(action.Value);

        Console.WriteLine(ok
            ? "Дія виконана"
            : "Неможливо виконати (немає передумов)");

        Console.ReadKey();
    }
}