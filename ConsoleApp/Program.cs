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
