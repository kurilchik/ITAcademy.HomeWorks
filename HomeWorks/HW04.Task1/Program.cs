using System;

namespace HW04.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your year of birth (example: 1990).");
            int birthdayYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your month of birth (example: 12).");
            int birthdayMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the current year (example: 2020).");
            int currentYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the current month (example: 1).");
            int currentMonth = int.Parse(Console.ReadLine());

            int age = currentYear - birthdayYear;

            if (currentMonth < birthdayMonth)
                age -= 1;

            Console.WriteLine($"You are {age} years old.");
        }
    }
}
