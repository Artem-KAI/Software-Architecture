using System.Text;

namespace ConsoleApp;

class Program
{
    static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        Menu.Run();
    }
}

//using Application;
 //using Domain.Devices;
 //using Domain.Enums;
 //using Domain.Interfaces;

//class Program
//{
//    static IDevice? device;
//    static DeviceService? service;

//    static void Main()
//    {
//        while (true)
//        {
//            Console.Clear();
//            ShowStatus();

//            Console.WriteLine("""
//            1. Вибрати техніку
//            2. Налаштування
//            3. Дія
//            4. Вкл/Викл енергію
//            0. Вихід
//            """);

//            switch (Console.ReadLine())
//            {
//                case "1": SelectDevice(); break;
//                case "2": Settings(); break;
//                case "3": Actions(); break;
//                case "4": PowerMenu(); break;
//                case "0": return;
//            }
//        }
//    }

//    static void ShowStatus()
//    {
//        if (device == null)
//        {
//            Console.WriteLine("Техніка не вибрана\n");
//            return;
//        }

//        Console.WriteLine($"Пристрій: {device.Name}");
//        Console.WriteLine($"ПЗ: {(device.HasSoftware ? "Так" : "Ні")}");
//        Console.WriteLine($"Інтернет: {(device.HasNetwork ? "Так" : "Ні")}");
//        Console.WriteLine($"Аудіо: {(device.HasAudio ? "Так" : "Ні")}");
//        Console.WriteLine($"Принтер: {(device.HasPrinter ? "Так" : "Ні")}");
//        Console.WriteLine($"Енергія: {(device.PowerOn ? "Є" : "Немає")}");

//        if (!device.PowerOn)
//            Console.WriteLine($"Годин залишилось (режим): {device.RemainingHours}");
//        else
//            Console.WriteLine($"Годин залишилось: не обмежено (є енергія)");

//        Console.WriteLine();
//    }

//    static void SelectDevice()
//    {
//        Console.Clear();
//        Console.WriteLine("""
//        1. Ноутбук (5000-7000 мАг)
//        2. Смартфон (2000-3000 мАг)
//        3. Планшет (2000-3000 мАг)
//        0. Назад
//        """);

//        device = Console.ReadLine() switch
//        {
//            "1" => new Laptop(6000),
//            "2" => new Smartphone(2500),
//            "3" => new Tablet(2500),
//            _ => device
//        };

//        if (device != null)
//            service = new DeviceService(device);
//    }

//    static void Settings()
//    {
//        if (device is null) return;

//        Console.Clear();
//        Console.WriteLine("""
//        1. Встановити ПЗ
//        2. Підключитись до мережі
//        3. Підключити аудіо (динаміки/навушники)
//        4. Підключити принтер
//        0. Назад
//        """);

//        switch (Console.ReadLine())
//        {
//            case "1": device.InstallSoftware(); break;
//            case "2": device.ConnectNetwork(); break;
//            case "3": device.ConnectAudio(); break;
//            case "4": device.ConnectPrinter(); break;
//        }
//    }

//    static void Actions()
//    {
//        if (service is null) return;

//        Console.Clear();
//        Console.WriteLine("""
//        1. Працювати
//        2. Читати
//        3. Чатитися
//        4. Слухати музику
//        5. Дивитись відео
//        6. Грати
//        7. Друкувати фото
//        0. Назад
//        """);

//        var action = Console.ReadLine() switch
//        {
//            "1" => DeviceAction.Work,
//            "2" => DeviceAction.Read,
//            "3" => DeviceAction.Chat,
//            "4" => DeviceAction.ListenMusic,
//            "5" => DeviceAction.WatchVideo,
//            "6" => DeviceAction.PlayGame,
//            "7" => DeviceAction.PrintPhoto,
//            _ => (DeviceAction?)null
//        };

//        if (action == null) return;

//        var ok = service.TryPerform(action.Value);

//        Console.WriteLine(ok ? "Дія виконана" : "Неможливо виконати (немає передумов)");
//    }

//    static void PowerMenu()
//    {
//        if (device is null) return;

//        Console.Clear();
//        Console.WriteLine("""
//        1. Увімкнути енергію
//        2. Вимкнути енергію
//        0. Назад
//        """);

//        switch (Console.ReadLine())
//        {
//            case "1": device.EnablePower(); break;
//            case "2": device.DisablePower(); break;
//        }
//    }
//}

////using Application;
////using Domain.Devices;
////using Domain.Enums;
////using Domain.Interfaces;

////class Program
////{
////    static IDevice? device;
////    static DeviceService? service;

////    static void Main()
////    {
////        while (true)
////        {
////            Console.Clear();
////            ShowStatus();

////            Console.WriteLine("""
////            1. Вибрати техніку
////            2. Налаштування
////            3. Дія
////            4. Вкл/Викл енергію
////            0. Вихід
////            """);

////            switch (Console.ReadLine())
////            {
////                case "1": SelectDevice(); break;
////                case "2": Settings(); break;
////                case "3": Actions(); break;
////                case "4": PowerMenu(); break;
////                case "0": return;
////            }
////        }
////    }

////    static void ShowStatus()
////    {
////        if (device == null)
////        {
////            Console.WriteLine("❌ Техніка не вибрана\n");
////            return;
////        }

////        Console.WriteLine($"Пристрій: {device.Name}");
////        Console.WriteLine($"ПЗ: {(device.HasSoftware ? "Так" : "Ні")}");
////        Console.WriteLine($"Мережа: {(device.HasNetwork ? "Так" : "Ні")}");
////        Console.WriteLine($"Аудіо: {(device.HasAudio ? "Так" : "Ні")}");
////        Console.WriteLine($"Принтер: {(device.HasPrinter ? "Так" : "Ні")}");
////        Console.WriteLine($"Енергія: {(device.PowerOn ? "Є" : "Немає")}");
////        Console.WriteLine($"Годин залишилось: {device.RemainingHours}\n");
////    }

////    static void SelectDevice()
////    {
////        Console.Clear();
////        Console.WriteLine("""
////        1. Ноутбук (5000-7000 мАг)
////        2. Смартфон (2000-3000 мАг)
////        3. Планшет (2000-3000 мАг)
////        0. Назад
////        """);

////        device = Console.ReadLine() switch
////        {
////            "1" => new Laptop(6000),
////            "2" => new Smartphone(2500),
////            "3" => new Tablet(2500),
////            _ => device
////        };

////        if (device != null)
////            service = new DeviceService(device);
////    }

////    static void Settings()
////    {
////        if (device is null) return;

////        Console.Clear();
////        Console.WriteLine("""
////        1. Встановити ПЗ
////        2. Підключитись до мережі
////        3. Підключити аудіо
////        4. Підключити принтер
////        0. Назад
////        """);

////        var d = device as Domain.Devices.DeviceBase;

////        switch (Console.ReadLine())
////        {
////            case "1": d?.InstallSoftware(); break;
////            case "2": d?.ConnectNetwork(); break;
////            case "3": d?.ConnectAudio(); break;
////            case "4": d?.ConnectPrinter(); break;
////        }
////    }

////    static void Actions()
////    {
////        if (service is null) return;

////        Console.Clear();
////        Console.WriteLine("""
////        1. Працювати
////        2. Читати
////        3. Слухати музику
////        4. Дивитись відео
////        5. Грати
////        6. Друкувати фото
////        0. Назад
////        """);

////        var action = Console.ReadLine() switch
////        {
////            "1" => DeviceAction.Work,
////            "2" => DeviceAction.Read,
////            "3" => DeviceAction.ListenMusic,
////            "4" => DeviceAction.WatchVideo,
////            "5" => DeviceAction.PlayGame,
////            "6" => DeviceAction.PrintPhoto,
////            _ => (DeviceAction?)null
////        };

////        if (action != null)
////        {
////            Console.WriteLine(
////                service.TryPerform(action.Value)
////                    ? "Дія виконана"
////                    : "Неможливо виконати"
////            );
////            Console.ReadKey();
////        }
////    }

////    static void PowerMenu()
////    {
////        if (device is not Domain.Devices.DeviceBase d) return;

////        Console.Clear();
////        Console.WriteLine("""
////        1. Увімкнути енергію
////        2. Вимкнути енергію
////        0. Назад
////        """);

////        switch (Console.ReadLine())
////        {
////            case "1": d.EnablePower(); break;
////            case "2": d.DisablePower(); break;
////        }
////    }
////}