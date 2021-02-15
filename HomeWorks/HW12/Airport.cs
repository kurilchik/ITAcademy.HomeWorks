using HW12.Check;
using System;

namespace HW12
{
    class Airport
    {
        public const string Name = "Schiphol";

        Passenger _passenger;

        public void Departure()
        {
            Greeting();
            Introduce();
            GoTo();

            CheckIn checkIn = new CheckIn(_passenger);
            checkIn.Hello();
            checkIn.Check();
            checkIn.Goodbye();

            SecurityCheck securityCheck = new SecurityCheck(_passenger);
            securityCheck.Hello();
            securityCheck.Check();
            securityCheck.Goodbye();

            PassportControl passportControl = new PassportControl(_passenger);
            passportControl.Hello();
            passportControl.Check();
            passportControl.Goodbye();
        }

        private void Greeting()
        {
            TimeSpan now = DateTime.Now.TimeOfDay;

            if (now.Hours >= 9 && now.Hours < 12)
            {
                Console.Write("Good morning! ");
            }
            else if (now.Hours >= 12 && now.Hours < 15)
            {
                Console.Write("Good day! ");
            }
            else if (now.Hours >= 15 && now.Hours < 23)
            {
                Console.Write("Good day! ");
            }
            else
                Console.Write("Good night! ");

            Console.WriteLine($"Welcome to the airport {Airport.Name}.");
        }

        private void Introduce()
        {
            string name = Questions.PassengerName();

            bool passport = Questions.PassengerPasport();
            try
            {
                if (!passport)
                {
                    throw new Exception("We are very sorry. But without a passport, we have to deny you a flight.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }

            bool ticket = Questions.PassengerTicket();
            if (ticket)
                _passenger = new Passenger(name, passport, ticket);
            else
                _passenger = new Passenger(name, passport);
        }

        private void GoTo()
        {
            Console.WriteLine($"{_passenger.Name}, please go to the check-in.");
        }
    }
}
