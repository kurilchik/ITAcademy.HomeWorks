using System;
using System.Collections.Generic;
using System.Text;

namespace HW07.Task1
{
    public class Poem
    {
        static string _userInput;
        static string[] _result;

        public static void ReplaceLetter()
        {
            UserInput();
            Separate();
            Replace();
            PrintResult();
        }

        private static void UserInput()
        {
            Console.WriteLine("Enter the poem on one line, separating lines with semicolons:");
            _userInput = Console.ReadLine();
        }

        private static void Separate()
        {
            _result = _userInput.Split(';');
        }

        private static void Replace()
        {
            for (int i = 0; i < _result.Length; i++)
            {
                _result[i] = _result[i].Replace('O', 'A');
                _result[i] = _result[i].Replace('o', 'a');
            }
        }

        private static void PrintResult()
        {
            Console.WriteLine("Your new poem:");
            foreach (var item in _result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
