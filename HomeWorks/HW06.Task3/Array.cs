using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HW06.Task3
{
    public class Array
    {
        static long[] _nums = new long[100_000_000];

        public static void MyReverse()
        {
            NewArray();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long temp = 0;
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

            stopwatch.Stop();
            Console.WriteLine($"My reverse time: {stopwatch.ElapsedMilliseconds} (while)");
        }

        public static void MySecondReverse()
        {
            NewArray();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long temp = 0;
            for (int i = 0, j = _nums.Length - 1; i < j; i++, j--)
            {
                temp = _nums[i];
                _nums[i] = _nums[j];
                _nums[j] = temp;
            }

            stopwatch.Stop();
            Console.WriteLine($"My second reverse time: {stopwatch.ElapsedMilliseconds} (for)");
        }

        public static void SystemReverse()
        {
            NewArray();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            System.Array.Reverse(_nums);

            stopwatch.Stop();
            Console.WriteLine($"System reverse time: {stopwatch.ElapsedMilliseconds}");
        }

        private static void NewArray()
        {
            Random random = new Random();
            for (int i = 0; i < _nums.Length; i++)
            {
                _nums[i] = random.Next();
            }
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
