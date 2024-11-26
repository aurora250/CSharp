using System;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            double x = Math.Pow(10, N - 1);
            double d;
            int[] m = new int[N];
            string s;
            int[] n = new int[10];//设立缓存
            n[0] = 0;
            n[1] = 1;
            for (int i = 2; i < 10; i++)
            {
                n[i] = (int)Math.Pow(i, N);//缓存的意义就在于在数据巨大且产生反复计算时快速引用，减少内存占用，加快运行
            }

            for (int i = (int)x; i < 10 * (int)x; i++)
            {
                int l = i;
                d = 0;
                for (int j = 0; j < N; j++)
                {
                    m[j] = l % 10;//得到每个位的数字
                    l /= 10;
                    d += n[m[j]];//引用缓存的数据，减少耗时
                }
                if (d == i)
                {
                    Console.WriteLine(d);
                }
            }
        }
    }
}