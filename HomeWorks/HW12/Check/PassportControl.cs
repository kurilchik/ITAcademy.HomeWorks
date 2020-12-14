using HW12.Interfaces;
using System;

namespace HW12.Check
{
    class PassportControl : ICheck
    {
        readonly Passenger _passenger;

        public PassportControl(Passenger passenger)
        {
            _passenger = passenger;
        }

        public void Hello()
        {
            Console.WriteLine($"Welcome to passport control.");
        }

        public void Check()
        {
            Console.WriteLine("Can I see your passport?");
            if (Questions.YesOrNo())
                Console.WriteLine("Thank you.");
            else
                Console.WriteLine("Please, give me your passport!");
        }

        public void Goodbye()
        {
            Console.WriteLine($"{_passenger.Name}, please go to the plane. Have a good trip!");
        }
    }
}
