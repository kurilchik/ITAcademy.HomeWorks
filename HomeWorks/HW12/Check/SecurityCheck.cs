using HW12.Interfaces;
using System;

namespace HW12.Check
{
    class SecurityCheck : ICheck
    {
        readonly Passenger _passenger;

        public SecurityCheck(Passenger passenger)
        {
            _passenger = passenger;
        }

        public void Hello()
        {
            Console.WriteLine($"Welcome to security check.");
        }

        public void Check()
        {
            CheckDangerousItems();
            CheckCarryOn();
        }

        public void Goodbye()
        {
            Console.WriteLine($"{_passenger.Name}, please go to the passport control.");            
        }

        private void CheckDangerousItems()
        {
            Console.WriteLine("Do you have weapons, drugs or explosives with you?");
            try
            {
                if (Questions.YesOrNo())
                {
                    throw new Exception("You are not flying anywhere. You are under arrest!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }
        }

        private void CheckCarryOn()
        {
            if (_passenger.CarryOn)
            {
                Console.WriteLine("Can I see your carry-on?");
                if (Questions.YesOrNo())
                    Console.WriteLine("Thank you.");
                else
                    Console.WriteLine("Please, give me your carry-on!");
            }
        }
    }
}
