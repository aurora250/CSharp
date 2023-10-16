using System;

namespace ConsoleApp1
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
            double e = a + b + c;
            double f = a + b;
            double g = a + c;
            double h = b + c;
            double p = e / 2 * 1.0;
            if (f > c && g > b && h > a)
            {
                double q = (p - a) * (p - b) * (p - c);
                double s = Convert.ToDouble(Math.Sqrt(p * q));
                Console.WriteLine("area = {0:f2}; perimeter = {1:f2}", s, e);
            }
            else
            {
                Console.WriteLine("These sides do not correspond to a valid triangle");
            }
        }
    }
}