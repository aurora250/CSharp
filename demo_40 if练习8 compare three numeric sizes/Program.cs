using System;

namespace practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int x = n.IndexOf(" ", 0);
            int y = n.LastIndexOf(" ");
            int a = Convert.ToInt32(n.Substring(0, x));
            int b = Convert.ToInt32(n.Substring(x + 1, y - 1 - x));
            int c = Convert.ToInt32(n.Substring(y + 1));
            int d = Math.Max(a, b);
            int e = Math.Min(a, b);
            int f = Math.Max(c, d);
            int g = Math.Min(c, e);
            int h = Math.Max(b, c);
            int i = Math.Max(c, a);
            if (d == h)
            {
                int j = i;
                Console.WriteLine("{0}->{1}->{2}", g, j, f);
            }
            else if (d == i)
            {
                int j = h;
                Console.WriteLine("{0}->{1}->{2}", g, j, f);
            }
            else if (i == h)
            {
                int j = d;
                Console.WriteLine("{0}->{1}->{2}", g, j, f);
            }
        }
    }
}