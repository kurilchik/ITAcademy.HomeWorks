using System;

namespace HW04.Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 90; i >= 65; i--)
            {
                char alphabet = (char)i;
                Console.Write($"{alphabet} ");
            }
        }
    }
}
