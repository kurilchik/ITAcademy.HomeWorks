using Serilog;
using System.Collections.Generic;
using System.IO;

namespace HW15
{
    class Program
    {
        static void Main(string[] args)
        {      
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File(Path(), rollingInterval: RollingInterval.Hour)
                .CreateLogger();

            Log.Information("App started.");

            Motorcycle motorcycle = new Motorcycle("Honda", "Gold Wing Tour GL1800", 2020, 0);
            Motorcycle motorcycle2 = new Motorcycle("BMW", "K 1600 GTL", 2020, 100);
            Motorcycle motorcycle3 = new Motorcycle("Honda", "CBR 1000 RR", 2012, 30000);


            ListMotorcycleRepository list = new ListMotorcycleRepository();
            Log.Information("CRUD for List started.");

            list.CreateMotorcycle(motorcycle);
            Log.Information("{Motorcycle} with ID: {Id} created.", motorcycle.Name, motorcycle.Id);

            list.CreateMotorcycle(motorcycle2);
            Log.Information("{Motorcycle} with ID: {Id} created.", motorcycle2.Name, motorcycle2.Id);

            list.CreateMotorcycle(motorcycle3);
            Log.Information("{Motorcycle} with ID: {Id} created.", motorcycle3.Name, motorcycle3.Id);

            Motorcycle motorcycle4 = list.GetMotorcycleByID(motorcycle.Id);
            Log.Information("{Motorcycle} with ID: {Id} read.", motorcycle4.Name, motorcycle4.Id);

            List<Motorcycle> motorcycles = list.GetMotorcycles();
            Log.Information("All {Count} motorcycles from List read.", motorcycles.Count);

            motorcycle.Odometer = 1000;
            list.UpdateMotorcycle(motorcycle);
            Log.Information("{Motorcycle} with ID: {Id} updated.", motorcycle.Name, motorcycle.Id);

            list.DeleteMotorcycle(motorcycle3.Id);
            Log.Information("Motorcycle with ID: {Id} deleted.", motorcycle3.Id);


            FileMotorcycleRepository file = new FileMotorcycleRepository();
            Log.Information("CRUD for Folder started.");

            file.CreateMotorcycle(motorcycle);
            Log.Information("{Motorcycle} with ID: {Id} created.", motorcycle.Name, motorcycle.Id);

            file.CreateMotorcycle(motorcycle2);
            Log.Information("{Motorcycle} with ID: {Id} created.", motorcycle2.Name, motorcycle2.Id);

            file.CreateMotorcycle(motorcycle3);
            Log.Information("{Motorcycle} with ID: {Id} created.", motorcycle3.Name, motorcycle3.Id);

            Motorcycle motorcycle5 = file.GetMotorcycleByID(motorcycle.Id);
            Log.Information("{Motorcycle} with ID: {Id} read.", motorcycle5.Name, motorcycle5.Id);

            List<Motorcycle> motorcycles2 = file.GetMotorcycles();
            Log.Information("All {Count} motorcycles from file read.", motorcycles2.Count);

            motorcycle.Odometer = 2000;
            file.UpdateMotorcycle(motorcycle);
            Log.Information("{Motorcycle} with ID: {Id} updated.", motorcycle.Name, motorcycle.Id);

            file.DeleteMotorcycle(motorcycle3.Id);
            Log.Information("Motorcycle with ID: {Id} deleted.", motorcycle3.Id);

            Log.Information("Program completed successfully!");
        }

        static string Path()
        {
            string path = ".\\Logs\\";

            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            if (!directoryInfo.Exists)
                directoryInfo.Create();

            return $"{path}Log.txt";
        }
    }
}
