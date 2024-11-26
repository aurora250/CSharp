using System;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string[] b = a.Split(' ');
            int[] c = new int[b.Length];
            for (int i = 0; i < c.Length; i++)
            {
                c[i] = Convert.ToInt32(b[i]);
            }
            int m = c[0];
            int n = c[1];
            int t = 0;
            int r = 0;
            bool right = true;
            if (m == 1)//1%2=1，导致判断错误
            {
                m++;
            }
            for (int i = m; i < n + 1; i++)
            {
                right = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        right = false;
                        break;
                    }
                }
                if (right)
                {
                    t++;
                    r += i;
                }
            }
            Console.WriteLine(t + " " + r);
        }
    }
}