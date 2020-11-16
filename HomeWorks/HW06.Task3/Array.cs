using System;
using System.Collections.Generic;
using System.Text;

namespace HW06.Task3
{
    public class Array
    {
        static int[] _nums = new int[10];

        public static void MyReverse()
        {
            NewArray();
            int temp = 0;
            int i = 0;
            int j = _nums.Length - 1;
            while (i < j)
            {
                temp = _nums[i];
                _nums[i] = _nums[j];
                _nums[j] = temp;
                i++;
                j--;
            }

            Console.WriteLine("The result of my reverse:");
            Print(_nums);
        }

        public static void SystemReverse()
        {
            NewArray();
            System.Array.Reverse(_nums);

            Console.WriteLine("The result of system reverse:");
            Print(_nums);
        }

        private static void NewArray()
        {
            Random random = new Random();
            for (int i = 0; i < _nums.Length; i++)
            {
                _nums[i] = random.Next(0, 10);
            }

            Console.WriteLine("New array:");
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
