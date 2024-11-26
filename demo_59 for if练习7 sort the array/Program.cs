using System;

namespace demo_59
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a=Console.ReadLine();
            string[] b = a.Split(" ");
            int[] c = new int[b.Length];
            for(int i = 0; i < b.Length; i++)
            {
                int n = Convert.ToInt32(b[i]);
                c[i] = n;
            }
            //用Array.Sort排序
            //Array.Sort(c);
            //foreach(int n in c)
            //{
            //    Console.WriteLine(n);
            //}

            //用逻辑排序:冒泡排序，轮次交换，最后边的一定最大
            bool change;
            for(int i = 0; i < c.Length - 1; i++)
            {
                change = false;//优化：作为不再交换的条件
                for (int j = 0; j < c.Length - 1 - i; j++)//优化：不再需要和已经最大的值比较，故-i
                {
                    if (c[j] > c[j + 1])
                    {
                        int t = c[j];
                        c[j] = c[j + 1];
                        c[j + 1] = t;
                        change = true;
                    }
                }
                if (change == false)//优化：不再发生交换，排序完成
                {
                    break;
                }
            }
            foreach(int i in c)
            {
                Console.Write(i+" ");
            }
        }
    }
}