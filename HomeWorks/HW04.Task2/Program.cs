using System;

namespace HW04.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task2();
            //Task3();
            //Task4();
            Task5();
            
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

            static void Task4()
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
                {
                    Console.WriteLine("Wrong!");

                    if (userResult < result)
                        Console.WriteLine("There must be more!");
                    else
                        Console.WriteLine("There must be less!");
                }
            }

            static void Task5()
            {
                Console.WriteLine("Enter first number:");
                double firstNumber = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number:");
                double secondNumber = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter + or - :");
                string userChoice = Console.ReadLine();

                double result;
                if (userChoice == "+")
                    result = firstNumber + secondNumber;
                else
                    result = firstNumber - secondNumber;

                Console.WriteLine("Enter the result:");
                double userResult = double.Parse(Console.ReadLine());

                if (userResult == result)
                    Console.WriteLine("Correctly!");
                else
                {
                    Console.WriteLine("Wrong!");

                    if (userResult < result)
                        Console.WriteLine("There must be more!");
                    else
                        Console.WriteLine("There must be less!");
                }
            }
        }
    }
}
