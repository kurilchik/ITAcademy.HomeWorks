using System;

namespace HW15
{
    public class Motorcycle
    {
        public Guid Id { get; private set; }

        public string Name { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public int Odometer { get; set; }

        public Motorcycle()
        {
            Id = Guid.NewGuid();
        }

        public Motorcycle(string name, string model, int year, int odometer)
        {
            Id = Guid.NewGuid();
            Name = name;
            Model = model;
            Year = year;
            Odometer = odometer;
        }
    }
}
