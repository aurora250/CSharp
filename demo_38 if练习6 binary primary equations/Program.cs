using System;

namespace practice
{
    internal class demo_38
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int x = n.IndexOf(" ", 0);
            int y = n.IndexOf(" ", x + 1);
            double a = Convert.ToDouble(n.Substring(0, x));
            double b = Convert.ToDouble(n.Substring(x + 1, y - x));
            double c = Convert.ToDouble(n.Substring(y + 1));
            if (a == 0 && b == 0)
            {
                if (c == 0)
                {
                    Console.WriteLine("Zero Equation");
                }
                else
                {
                    Console.WriteLine("Not An Equation");
                }
            }
            else if (a == 0 && b != 0)
            {
                Console.WriteLine("{0:f2}", -c / b);
            }
            else
            {
                double d = Math.Pow(b, 2) - 4 * a * c;
                if (Math.Abs(d) < 1E-6)
                {
                    Console.WriteLine("{0:f2}", -b / (2 * a));
                }
                else if (d > 0)
                {
                    double x1 = (-1 * b + Math.Sqrt(d)) / (2 * a);
                    double x2 = (-1 * b - Math.Sqrt(d)) / (2 * a);//不一定一大一小，需要判断
                    double t = 0;
                    if (x1 < x2)
                    {
                        t = x1;
                        x1 = x2;
                        x2 = t;
                    }
                    Console.WriteLine("{0:f2}", x1);
                    Console.WriteLine("{0:f2}", x2);
                }
                else
                {
                    {
                        double f = Math.Sqrt(-d) / (2 * a);
                        if (f < 0)
                        {
                            f = -f;
                        }
                        Console.WriteLine("{0:f2}+{1:f2}i", -b / (2 * a), f);
                        Console.WriteLine("{0:f2}-{1:f2}i", -b / (2 * a), f);
                    }
                }
            }
        }
    }
}