using HW11.Task3.Interfaces;

namespace HW11.Task3.Files
{
    class ComputerProgram : IFile
    {
        public string Name { get; set; }

        public int Code { get; set; }

        public string Category { get; set; }

        public int Size { get; set; }
    }
}
