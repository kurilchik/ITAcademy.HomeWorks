using System;

namespace HW04.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task2();
            Task3();
            
            static void Task2()
            {
                Console.WriteLine("Enter first number:");
                double firstNumber = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number:");
                double secondNumber = double.Parse(Console.ReadLine());

                double result = firstNumber + secondNumber;
                Console.WriteLine($"Result: {result}");
            }

            static void Task3()
            {
                Console.WriteLine("Enter first number:");
                double firstNumber = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number:");
                double secondNumber = double.Parse(Console.ReadLine());

                double result = firstNumber + secondNumber;

                Console.WriteLine("Enter the result of adding these numbers:");
                double userResult = double.Parse(Console.ReadLine());

                if (userResult == result)
                    Console.WriteLine("Correctly!");
                else
                    Console.WriteLine("Wrong!");
            }
        }
    }
}
