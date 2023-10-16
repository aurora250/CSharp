using System;

namespace demo_51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nu = Console.ReadLine();
            int l = nu.IndexOf(" ", 0);
            int n = Convert.ToInt32(nu.Substring(0, l));
            int m = Convert.ToInt32(nu.Substring(l + 1));
            int x = Math.Max(m, n);
            int y = 0;
            int a;
            for (int i = x; i > 0; i--)
            {
                if (m % i == 0 && n % i == 0)
                {
                    a = i;//最大公约数
                    Console.Write(a+" ");
                    break;
                }
            }
            for (int i = x; i > 0;i--)
            {
                if(m % i == 0 && n % i == 0)
                {
                    y = i;
                    break;
                }
            }
            Console.Write(n * m / y);//最小公倍数
        }
    }
}