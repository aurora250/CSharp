using System;

namespace demo_61
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string x = "";
            bool str;
            for (int j = 0; j < n; j++)
            {
                string s = Console.ReadLine();
                str = true;
                for (int i = 0; i < s.Length / 2; i++)
                {
                    if (s[i] != s[s.Length - 1 - i])
                    {
                        str = false;
                        break;
                    }
                }
                if (str)
                {
                    x = x + "Yes\n";
                }
                else
                {
                    x = x + "No\n";
                }
            }
            Console.WriteLine(x.Trim());
        }
    }
}