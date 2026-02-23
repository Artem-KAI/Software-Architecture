using BLL.DTO;
using BLL.Factories;
using BLL.Services;
using BLL;
//using PL.Models;

class Program
{
    static void Main()
    {
        var config = new DeviceConfigDto
        {
            CpuModel = "Intel i7",
            MemoryGb = 16,
            BatteryMah = 5000
        };

        var device = DeviceFactory.CreateLaptop(config);
        var service = new DeviceService(device);

        service.InstallSoftware(SoftwareAction.Work);
        service.ConnectPeripheral(PeripheralAction.Speakers);

        if (service.CanRunSoftware(SoftwareAction.Work))
        {
            service.UseSoftware(SoftwareAction.Work);
            Console.WriteLine("Робота виконується");
        }
    }
}
