using HW11.Task3.Interfaces;
using System;

namespace HW11.Task3.Files
{
    class Music : IFile, IMusicMovies
    {
        public string Name { get; set; }

        public int Code { get; set; }

        public string Category { get; set; }

        public int Size { get; set; }

        public string Singer { get; set; }

        public int Length { get; set; }

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
