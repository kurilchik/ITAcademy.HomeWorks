using System;

namespace HW07.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string userInput = Console.ReadLine();

            ChangeString.RemoveLongestWord(userInput);
            ChangeString.ReplaceMaxMinWord(userInput);
            ChangeString.CountLettersAndPunctuation(userInput);
            ChangeString.SortString(userInput);
        }
    }
}
