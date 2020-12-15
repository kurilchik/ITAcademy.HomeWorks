using Newtonsoft.Json;
using System;
using System.IO;

namespace HW13
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\DELL\Documents\song.json";

            Song song = new Song();

            Serialize(Song.GetSongData(song), filePath);
            Console.WriteLine($"json file: {Deserialize(filePath)}");
        }

        public static void Serialize(object obj, string path)
        {
            var serializer = new JsonSerializer();

            using (var sw = new StreamWriter(path))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, obj);
            }
        }

        public static object Deserialize(string path)
        {
            var serializer = new JsonSerializer();

            using (var sw = new StreamReader(path))
            using (var reader = new JsonTextReader(sw))
            {
                return serializer.Deserialize(reader);
            }
        }
    }
}
