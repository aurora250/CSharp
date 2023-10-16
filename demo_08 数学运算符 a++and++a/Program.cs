using System;

namespace demo_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = a++;
            int c = ++a;
            Console.WriteLine(a++);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            int m = 3;
            int n = m++ + m++;      //m先取值再计算，3+4=7,此时m=5
            Console.WriteLine(n);   //7
            int p = m++ + (++m);    //括号和没有一样，5+7=12，此时m=7
            int q = m++ + (m++);    //括号和没有一样，7+8=15，此时m=9
            int x = m++ + ++m;      //9+11=20，此时m=11
            Console.WriteLine(p);   //12
            Console.WriteLine(q);   //15
            Console.WriteLine(x);   //20
            Console.WriteLine(m);   //11
        }
    }
}