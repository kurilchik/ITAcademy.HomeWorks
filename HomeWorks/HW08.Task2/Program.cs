using System;
using System.Text;

namespace HW08.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string str = Console.ReadLine();
            Math(str);
        }

        static void Math(string str)
        {
            int firstNum = FirstNum(str);
            int secondNum = SecondNum(str);
            char symbol = str[Index(str)];

            int result = 0;
            if (char.Equals(symbol, '/'))
            {
                result = firstNum / secondNum;
            }
            else if (char.Equals(symbol, '*'))
            {
                result = firstNum * secondNum;
            }
            else if (char.Equals(symbol, '-'))
            {
                result = firstNum - secondNum;
            }
            else if (char.Equals(symbol, '+'))
            {
                result = firstNum + secondNum;
            }
            Console.WriteLine(result);

        }

        static int FirstNum(string str)
        {
            int index = Index(str);
            StringBuilder sb = new StringBuilder(str);
            sb.Remove(index, sb.Length - index);
            for (int i = index - 1; i >= 0; i--)
            {
                if (!char.IsNumber(sb[i]))
                {
                    sb.Remove(i, 1);
                }
            }
            int result = int.Parse(sb.ToString());
            return result;
        }

        static int SecondNum(string str)
        {
            int index = Index(str);
            StringBuilder sb = new StringBuilder(str);
            sb.Remove(0, index);
            for (int i = sb.Length - 1; i >= 0; i--)
            {
                if (!char.IsNumber(sb[i]))
                {
                    sb.Remove(i, 1);
                }
            }
            int result = int.Parse(sb.ToString());
            return result;
        }

        static int Index(string str)
        {
            int index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.Equals(str[i], '/') || char.Equals(str[i], '*') || char.Equals(str[i], '-') || char.Equals(str[i], '+'))
                {
                    index = i;
                }
            }
            return index;
        }
    }
}
