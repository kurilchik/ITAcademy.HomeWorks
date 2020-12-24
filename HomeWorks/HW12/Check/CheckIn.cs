using HW12.Interfaces;
using System;

namespace HW12.Check
{
    class CheckIn : ICheck
    {
        readonly Passenger _passenger;

        public CheckIn(Passenger passenger)
        {
            _passenger = passenger;
        }

        public void Hello()
        {
            Console.WriteLine($"Welcome to check-in.");
        }

        public void Check()
        {
            CheckPassport();
            CheckTicket();
            CheckCarryOn();
            CheckBaggage();
        }

        public void Goodbye()
        {
            Console.WriteLine($"{_passenger.Name}, please go to the security check.");
        }

        private void CheckPassport()
        {
            Console.WriteLine("Can I see your passport?");
            if (Questions.YesOrNo())
                Console.WriteLine("Thank you.");
            else
                Console.WriteLine("Please, give me your passport!");
        }

        private void CheckTicket()
        {
            if (_passenger.Ticket)
            {
                Console.WriteLine("Can I see your ticket?");
                if (Questions.YesOrNo())
                    Console.WriteLine("Thank you.");
                else
                    Console.WriteLine("Please, give me your ticket!");
            }
            else
                _passenger.Ticket = true;
        }

        private void CheckCarryOn()
        {
            _passenger.CarryOn = Questions.PassengerCarryOn();
            if (_passenger.CarryOn)
                Console.WriteLine("You can take it on board with you.");
        }

        private void CheckBaggage()
        {
            _passenger.Baggage = Questions.PassengerBaggage();
            if (_passenger.Baggage)
                Console.WriteLine("You must pass it to baggage.");
        }
    }
}
