using System;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double e = Convert.ToDouble(Console.ReadLine());
            double i;
            double n = 0;
            double m = 1;
            double s = 0;
            do
            {
                n++;
                i = (1 / m) * Math.Pow(-1, n + 1);
                s += i;
                m += 3;
            } while (Math.Abs(i) > e);
            Console.WriteLine("sum = {0:f6}", s);
        }
    }
}