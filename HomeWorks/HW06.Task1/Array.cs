using System;
using System.Collections.Generic;
using System.Text;

namespace HW06.Task1
{
    public class Array
    {
        static int[] _firstNums = new int[10];
        static int[] _secondNums = new int[10];
        static int[] _thirdNums = new int[10];

        public static void FirstNums()
        {
            Random random = new Random();
            for (int i = 0; i < _firstNums.Length; i++)
            {
                _firstNums[i] = random.Next(0, 100);
            }

            Console.WriteLine("The first array:");
            Print(_firstNums);
        }

        public static void SecondNums()
        {
            for (int i = 0; i < _secondNums.Length; i++)
            {
                Console.WriteLine($"Enter the {i+1} integer");
                _secondNums[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The second array:");
            Print(_secondNums);
        }

        public static void ThirdNums()
        {
            for (int i = 0; i < _thirdNums.Length; i++)
            {
                _thirdNums[i] = _firstNums[i] + _secondNums[i];
            }

            Console.WriteLine("The third array:");
            Print(_thirdNums);
        }

        private static void Print(int[] nums) 
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {nums[i]}");
            }
        }
    }
}
