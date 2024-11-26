using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static double F(double x)
        {
            if (x == 1)
                return 2;
            if (x == 2)
                return 3;
            double a = F(x - 1) + F(x - 2);
            return a;
        }
        static double G(double x)
        {
            if (x == 1)
                return 1;
            if (x == 2)
                return 2;
            double a = G(x - 1) + G(x - 2);
            return a;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double s = 0;
            for (int i = 1; i <= n; i++)
            {
                s += F(i) / G(i);
            }
            Console.WriteLine("{0:f3}", s);
        }
    }
}