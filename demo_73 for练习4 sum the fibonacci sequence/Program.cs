using System;

namespace demo_73
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //f(n)=f(n-1)+f(n-2),f(0)=1,f(1)=1
            int n0 = 1;
            int n1 = 1;//1 1 2 3 5 8 13
            int ni = 0;
            int n=Convert.ToInt32(Console.ReadLine());
            for(int i = 2; i < n+1; i++)//从得到f(2)开始，所以设int i=2;
            {
                ni = n1 + n0;
                n0 = n1;
                n1 = ni;
            }
            Console.WriteLine(ni);
        }
    }
}

