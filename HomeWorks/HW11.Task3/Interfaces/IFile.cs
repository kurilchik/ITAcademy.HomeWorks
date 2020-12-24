namespace HW11.Task3.Interfaces
{
    interface IFile
    {
        public string Name { get; set; }

        public int Code { get; set; }

        public string Category { get; set; }

        public int Size { get; set; }
    }
}
