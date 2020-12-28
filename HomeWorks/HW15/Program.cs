using Serilog;
using System.Collections.Generic;

namespace HW15
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File("C:\\Users\\DELL\\Documents\\motoLog.txt", rollingInterval: RollingInterval.Hour)
                .CreateLogger();

            Log.Information("App started.");

            Motorcycle motorcycle = new Motorcycle(1, "Honda", "Gold Wing Tour GL1800", 2020, 0);
            Motorcycle motorcycle2 = new Motorcycle(2, "BMW", "K 1600 GTL", 2020, 100);
            Motorcycle motorcycle3 = new Motorcycle(1, "Honda", "Gold Wing Tour GL1800", 2020, 3000);

            ListMotorcycleRepository list = new ListMotorcycleRepository();
            Log.Information("CRUD for List started.");

            list.CreateMotorcycle(motorcycle);
            Log.Information("{Motorcycle} created.", motorcycle.Name);

            list.CreateMotorcycle(motorcycle2);
            Log.Information("{Motorcycle} created.", motorcycle2.Name);

            Motorcycle motorcycle4 = list.GetMotorcycleByID(1);
            Log.Information("{Motorcycle} with ID {Id} read.", motorcycle4.Name, motorcycle4.Id);

            List<Motorcycle> motorcycles = list.GetMotorcycles();
            Log.Information("All motorcycles from List read.");

            list.UpdateMotorcycle(motorcycle3);
            Log.Information("{Motorcycle} with ID {Id} updated.", motorcycle3.Name, motorcycle3.Id);

            list.DeleteMotorcycle(2);
            Log.Information("Motorcycle deleted.");

            FileMotorcycleRepository file = new FileMotorcycleRepository();
            Log.Information("CRUD for Folder started.");

            file.CreateMotorcycle(motorcycle);
            Log.Information("{Motorcycle} created.", motorcycle.Name);

            file.CreateMotorcycle(motorcycle2);
            Log.Information("{Motorcycle} created.", motorcycle2.Name);

            Motorcycle motorcycle5 = file.GetMotorcycleByID(1);
            Log.Information("{Motorcycle} with ID {Id} read.", motorcycle5.Name, motorcycle5.Id);

            List<Motorcycle> motorcycles2 = file.GetMotorcycles();
            Log.Information("All motorcycles from Folder read.");

            file.UpdateMotorcycle(motorcycle3);
            Log.Information("{Motorcycle} with ID {Id} updated.", motorcycle3.Name, motorcycle3.Id);

            file.DeleteMotorcycle(2);
            Log.Information("Motorcycle deleted.");

            Log.Information("Program completed successfully!");
        }
    }
}
