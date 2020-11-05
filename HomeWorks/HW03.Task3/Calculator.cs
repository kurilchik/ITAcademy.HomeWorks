using System;
using System.Collections.Generic;
using System.Text;

namespace HW03.Task3
{
    class Calculator
    {
        public static void AddingTwoNumbers()
        {
            Console.WriteLine("Adding two numbers");
            double firstNumber = FirstNumber();
            double secondNumber = SecondNumber();
            double result = firstNumber + secondNumber;
            Console.WriteLine($"Result: {result}");
        }

        public static void SubtractingTwoNumbers()
        {
            Console.WriteLine("Subtracting two numbers");
            double firstNumber = FirstNumber();
            double secondNumber = SecondNumber();
            double result = firstNumber - secondNumber;
            Console.WriteLine($"Result: {result}");
        }

        public static void MultiplicationOfTwoNumbers()
        {
            Console.WriteLine("Multiplication of two numbers");
            double firstNumber = FirstNumber();
            double secondNumber = SecondNumber();
            double result = firstNumber * secondNumber;
            Console.WriteLine($"Result: {result}");
        }

        public static void DivisionOfTwoNumbers()
        {
            Console.WriteLine("Division of two numbers");
            double firstNumber = FirstNumber();
            double secondNumber = SecondNumber();
            double result = firstNumber / secondNumber;
            Console.WriteLine($"Result: {result}");
        }

        public static void RemainderOfDivision()
        {
            Console.WriteLine("Remainder of the division");
            double firstNumber = FirstNumber();
            double secondNumber = SecondNumber();
            double result = firstNumber % secondNumber;
            Console.WriteLine($"Result: {result}");
        }

        public static void AreaOfCircle()
        {
            Console.WriteLine("Area of a circle");
            double firstNumber = FirstNumber();
            double result = Math.PI * Math.Pow(firstNumber, 2);
            Console.WriteLine($"Result: {result}");
        }

        private static double FirstNumber()
        {
            Console.WriteLine("Enter the first number:");
            double firstNumber = double.Parse(Console.ReadLine());
            return firstNumber;
        }

        private static double SecondNumber()
        {
            Console.WriteLine("Enter the second number:");
            double secondNumber = double.Parse(Console.ReadLine());
            return secondNumber;
        }
    }
}
