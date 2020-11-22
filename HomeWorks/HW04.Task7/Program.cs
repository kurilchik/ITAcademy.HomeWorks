using System;

namespace HW04.Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();

            if (userInput == "w" || userInput == "W")
                Console.WriteLine("Move ahead!");
            else if (userInput == "s" || userInput == "S")
                Console.WriteLine("Move back!");
            else if (userInput == "a" || userInput == "A")
                Console.WriteLine("Move left!");
            else if (userInput == "d" || userInput == "D")
                Console.WriteLine("Move right!");
            else
                Console.WriteLine("Do not move!");
        }
    }
}
