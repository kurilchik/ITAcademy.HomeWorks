using System;
using System.Collections.Generic;
using System.Text;

namespace HW06.Task2
{
    public class Array
    {
        static int[] _nums = new int[10];

        public static void InputNums()
        {
            for (int i = 0; i < _nums.Length - 1; i++)
            {
                Console.WriteLine($"Enter the {i + 1} integer");
                _nums[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Your array:");
            Print(_nums);
        }

        public static void AddNum()
        {
            Console.WriteLine("Enter position in this array:");
            int addPos = int.Parse(Console.ReadLine());

            for (int i = _nums.Length - 1; i > addPos - 1; i--)
            {
                _nums[i] = _nums[i - 1];
            }

            Console.WriteLine("Enter another value:");
            _nums[addPos - 1] = int.Parse(Console.ReadLine());

            Console.WriteLine("Your new array:");
            Print(_nums);
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
