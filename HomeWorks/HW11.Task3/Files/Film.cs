using HW11.Task3.Interfaces;
using System;

namespace HW11.Task3.Files
{
    class Film : IFile, IMusicMovies
    {
        public string Name { get; set; }

        public int Code { get; set; }

        public string Category { get; set; }

        public int Size { get; set; }

        public string Director { get; set; }

        public string MainActor { get; set; }

        public string MainActress { get; set; }

        public void Play()
        {
        }

        public string RetrieveInformation()
        {
            string information = String.Empty;
            return information;
        }
    }
}
