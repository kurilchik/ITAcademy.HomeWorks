using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace HW15
{
    public class FileMotorcycleRepository : IMotorcycleRepository<Motorcycle>
    {
        private readonly string _savePath = ".\\Motorcycles\\";

        public FileMotorcycleRepository()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(_savePath);
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }
        }

        public void CreateMotorcycle(Motorcycle motorcycle)
        {
            string path = $"{_savePath}ID_{motorcycle.Id}.json";

            File.WriteAllText(path, JsonConvert.SerializeObject(motorcycle));
        }

        public void DeleteMotorcycle(Guid id)
        {
            string path = $"{_savePath}ID_{id}.json";

            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                fileInfo.Delete();
            }
            else
                Console.WriteLine("File not found!");
        }

        public Motorcycle GetMotorcycleByID(Guid id)
        {
            string path = $"{_savePath}ID_{id}.json";

            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                return JsonConvert.DeserializeObject<Motorcycle>(File.ReadAllText(path));
            }
            else
            {
                Console.WriteLine("File not found!");
                return new Motorcycle();
            }
        }

        public List<Motorcycle> GetMotorcycles()
        {
            List<Motorcycle> motorcycles = new List<Motorcycle>();

            DirectoryInfo directoryInfo = new DirectoryInfo(_savePath);
            FileInfo[] filesInfo = directoryInfo.GetFiles();

            for (int i = 0; i < filesInfo.Length; i++)
            {
                if (filesInfo[i].Extension.Equals(".json", StringComparison.OrdinalIgnoreCase))
                    motorcycles.Add(JsonConvert.DeserializeObject<Motorcycle>(File.ReadAllText(filesInfo[i].FullName)));
            }

            if (motorcycles.Count.Equals(0))
            {
                Console.WriteLine("Files not found!");
            }

            return motorcycles;
        }

        public void UpdateMotorcycle(Motorcycle motorcycle)
        {
            string path = $"{_savePath}ID_{motorcycle.Id}.json";

            FileInfo fileInfo = new FileInfo(path);
            if (!fileInfo.Exists)
            {
                Console.WriteLine("File not found!");
            }
            else
                CreateMotorcycle(motorcycle);
        }
    }
}
