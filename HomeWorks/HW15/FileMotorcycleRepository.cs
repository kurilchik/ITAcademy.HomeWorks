using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace HW15
{
    class FileMotorcycleRepository : IMotorcycle
    {
        private readonly string _savePath = @"C:\Users\DELL\Documents\";

        public void CreateMotorcycle(Motorcycle motorcycle)
        {
            string path = _savePath + $"motorcycle{motorcycle.Id}.json";

            File.WriteAllText(path, JsonConvert.SerializeObject(motorcycle));
        }

        public void DeleteMotorcycle(int id)
        {
            string path = _savePath + $"motorcycle{id}.json";

            FileInfo userSave = new FileInfo(path);
            if (userSave.Exists)
            {
                userSave.Delete();
            }
            else
                Console.WriteLine("File not found!");
        }

        public Motorcycle GetMotorcycleByID(int id)
        {
            string path = _savePath + $"motorcycle{id}.json";

            return JsonConvert.DeserializeObject<Motorcycle>(File.ReadAllText(path));
        }

        public List<Motorcycle> GetMotorcycles()
        {
            List<Motorcycle> motorcycles = new List<Motorcycle>();

            DirectoryInfo saveFolder = new DirectoryInfo(_savePath);
            FileInfo[] saveFiles = saveFolder.GetFiles();

            for (int i = 0; i < saveFiles.Length; i++)
            {
                if (saveFiles[i].Extension.Equals(".json", StringComparison.OrdinalIgnoreCase))
                {
                    motorcycles.Add(JsonConvert.DeserializeObject<Motorcycle>(File.ReadAllText(saveFiles[i].FullName)));
                }
            }

            return motorcycles;
        }

        public void UpdateMotorcycle(Motorcycle motorcycle)
        {
            DeleteMotorcycle(motorcycle.Id);

            string path = _savePath + $"motorcycle{motorcycle.Id}.json";

            File.WriteAllText(path, JsonConvert.SerializeObject(motorcycle));
        }
    }
}
