using System;

namespace HW11.Task2
{
    class Person
    {
        private readonly string _name;
        private readonly House _house;

        public Person(string name, House house)
        {
            _name = name;
            _house = house;
        }

        public void ShowData()
        {
            Console.WriteLine($"Hello. My name is {_name}.");
            _house.ShowData();
            _house.GetDoor();
        }
    }
}
