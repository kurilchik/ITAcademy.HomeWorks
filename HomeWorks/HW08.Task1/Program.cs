using System;
using System.Text;

namespace HW08.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1a!2.3!!..4.!.? 6 7!.. ?";

            int startIndex1 = 0;
            int count1 = str.IndexOf('?');
            int startIndex2 = count1;
            int count2 = str.Length - str.IndexOf('?');

            StringBuilder sb = new StringBuilder(str);

            sb.Replace('.', '\0', startIndex1, count1);
            sb.Replace('!', '\0', startIndex1, count1);
            sb.Replace(' ', '_', startIndex2, count2);

            Console.WriteLine(sb);
        }
    }
}
