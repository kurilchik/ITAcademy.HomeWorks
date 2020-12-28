namespace HW15
{
    class Motorcycle
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public int Odometer { get; set; }

        public Motorcycle()
        {
        }

        public Motorcycle(int id, string name, string model, int year, int odometer)
        {
            Id = id;
            Name = name;
            Model = model;
            Year = year;
            Odometer = odometer;
        }
    }
}
