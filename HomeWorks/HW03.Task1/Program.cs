using System;

namespace HW03.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //a. explicit conversion
            long task1 = 123;
            int expConv1 = (int)task1; //example 1
            short expConv2 = (short)expConv1; //example 2
            sbyte expConv3 = (sbyte)expConv2; //example 3

            //b. implicit conversion
            short impConv1 = expConv3; //example 1
            int impConv2 = impConv1; //example 2
            long impConv3 = impConv2; //example 3

            //c. boxing
            object exampleBoxing = impConv3;

            //d. unboxing
            long exampleUnboxing = (long)exampleBoxing;
        }
    }
}
