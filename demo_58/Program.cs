using System;

namespace demo_51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nu = Console.ReadLine();
            int l = nu.IndexOf(" ");
            int n = Convert.ToInt32(nu.Substring(0, l));
            int m = Convert.ToInt32(nu.Substring(l + 1));
            int x = Math.Max(m, n);
            int y = Math.Min(m, n);
            int s = 0;
            int a = 0;
            for (int i = x; i > y; i--)
            {
                for(int j = x; j > 0; j--)
                {
                    if (i % j == 0)
                    {
                        for (int k = j; k > 0; k--)
                        {
                            while (i % k == 0)
                            {
                                if (k == 1)
                                {
                                    a++;
                                    s += i;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(a + " " + s);
        }
    }
}