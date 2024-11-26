using System;

namespace demo_73
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n0 = 1;
            int n1 = 1;
            int ni = 0;
            int i = 2;
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                while (ni < n)
                {
                    ni = n1 + n0;
                    n0 = n1;
                    n1 = ni;
                    i++;
                }
                Console.WriteLine(i);
            }
        }
    }
}