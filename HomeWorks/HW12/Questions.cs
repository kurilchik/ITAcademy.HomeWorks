using System;

namespace HW12
{
    static class Questions
    {
        static public string PassengerName()
        {
            Console.WriteLine("Please introduce yourself:");
            return Console.ReadLine();
        }

        static public bool PassengerPasport()
        {
            Console.WriteLine("Do you have a passport?");
            return YesOrNo();
        }

        static public bool PassengerTicket()
        {
            Console.WriteLine("Do you have a ticket?");
            return YesOrNo();
        }

        static public bool PassengerCarryOn()
        {
            Console.WriteLine("Do you have a carry-on?");
            return YesOrNo();
        }

        static public bool PassengerBaggage()
        {
            Console.WriteLine("Do you have a baggage?");
            return YesOrNo();
        }

        static public bool YesOrNo()
        {
            Console.WriteLine("Enter <Y> or <N>:");
            string userChoice = Console.ReadLine();

            if (userChoice.Equals("Y", StringComparison.OrdinalIgnoreCase))
                return true;
            else if (userChoice.Equals("N", StringComparison.OrdinalIgnoreCase))
                return false;
            return YesOrNo();
        }
    }
}
