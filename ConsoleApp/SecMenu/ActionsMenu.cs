using Domain.Enums;

namespace ConsoleApp.SecMenu;

public static class ActionsMenu
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
        1. Працювати
        2. Чатитися
        3. Слухати музику
        4. Дивитись відео
        5. Грати
        6. Друкувати фото
        0. Назад
        """);
        Console.ResetColor();

        string? input = Console.ReadLine();
        DeviceAction? action;

        switch (input)
        {
            case "1": action = DeviceAction.Work; 
                break;
            case "2": action = DeviceAction.Chat;
                break;
            case "3": action = DeviceAction.ListenMusic;
                break;
            case "4": action = DeviceAction.WatchVideo;
                break;
            case "5": action = DeviceAction.PlayGame;   
                break;
            case "6": action = DeviceAction.PrintPhoto;
                break;
            default:
                action = null;
                break;
        }

        if (action == null)
        {
            return;
        }
                
        bool ok = Menu.Service.TryPerform(action.Value);

        if (ok == true)
        {
            Console.WriteLine("Дія виконана");
        }
        else{
            Console.WriteLine("Неможливо виконати (немає передумов)");
        }

        Console.ReadKey();
    }
}