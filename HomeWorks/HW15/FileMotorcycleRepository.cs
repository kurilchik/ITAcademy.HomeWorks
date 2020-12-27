using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace HW15
{
    class FileMotorcycleRepository : IMotorcycle
    {
        public void CreateMotorcycle(Motorcycle motorcycle)
        {
            string savePath = $"C:\\Users\\DELL\\Documents\\motorcycle{motorcycle.Id}.json";

            File.WriteAllText(savePath, JsonConvert.SerializeObject(motorcycle));
        }

        public void DeleteMotorcycle(int id)
        {
            string savePath = $"C:\\Users\\DELL\\Documents\\motorcycle{id}.json";

            FileInfo userSave = new FileInfo(savePath);
            if (userSave.Exists)
            {
                userSave.Delete();
            }
            else
                Console.WriteLine("File not found!");
        }

        public Motorcycle GetMotorcycleByID(int id)
        {
            string savePath = $"C:\\Users\\DELL\\Documents\\motorcycle{id}.json";

            return JsonConvert.DeserializeObject<Motorcycle>(File.ReadAllText(savePath));
        }

        public List<Motorcycle> GetMotorcycles()
        {
            List<Motorcycle> motorcycles = new List<Motorcycle>();

            string savePath = $"C:\\Users\\DELL\\Documents\\";

            DirectoryInfo saveFolder = new DirectoryInfo(savePath);
            FileInfo[] saveFiles = saveFolder.GetFiles();

            for (int i = 0; i < saveFiles.Length; i++)
            {
                if (saveFiles[i].Extension == ".json")
                {
                    motorcycles.Add(JsonConvert.DeserializeObject<Motorcycle>(File.ReadAllText(saveFiles[i].FullName)));
                }
            }

            return motorcycles;
        }

        public void UpdateMotorcycle(Motorcycle motorcycle)
        {
            DeleteMotorcycle(motorcycle.Id);

            string savePath = $"C:\\Users\\DELL\\Documents\\motorcycle{motorcycle.Id}.json";

            File.WriteAllText(savePath, JsonConvert.SerializeObject(motorcycle));
        }
    }
}
