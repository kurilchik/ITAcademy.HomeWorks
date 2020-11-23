using System;
using System.Text;

namespace HW08.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1a!2.3!!.. 4.!.?6 7! ..?";
            StringBuilder sb = new StringBuilder(str);

            int index = str.IndexOf('?');

            for (int i = index; i >= 0; i--)
            {
                if (char.Equals(str[i], '!') || char.Equals(str[i], '.'))
                {
                    sb.Remove(i, 1);
                }
            }

            index = (sb.ToString()).IndexOf('?');

            sb.Replace(' ', '_', index, sb.Length - index);

            Console.WriteLine(sb);
        }
    }
}
