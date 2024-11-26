using System;

namespace demo_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nu = Console.ReadLine();
            int l = nu.IndexOf(' ', 0);
            double n = Convert.ToInt32(nu.Substring(0, l));
            double m = Convert.ToInt32(nu.Substring(l + 1));
            double h = n;
            if (m == 0)
            {
                Console.WriteLine("{0:f1} {1:f1}", 0, 0);//落地零次结果
            }
            else
            {
                for (int i = 0; i < m; i++)
                {
                    h /= 2;//n次后反弹高度
                }
                double d = 2 * n;//每一次弹跳路程是上一次的二分之一
                double s = d;
                for (int i = 0; i < m - 1; i++)
                {
                    d /= 2;
                    s += d;
                }
                Console.WriteLine("{0:f1} {1:f1}", (s - n), h);//将第一次视作一次完整弹跳，最后在减去一半
            }
        }
    }
}