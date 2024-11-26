namespace demo_90
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 2)
            {
                Console.WriteLine(" {0,4}\n{1,4}{2,4}", 1, 1, 1);
            }
            else
            {
                int[][] a = new int[n][];//交错数组，其元素为数组，n为数组个数
                for (int i = 0; i < n; i++)
                {
                    a[i] = new int[i + 1];
                    a[i][0] = 1;
                    a[i][i] = 1;
                }
                for (int i = 2; i < n; i++)
                {
                    for (int j = 1; j < i; j++)
                    {
                        a[i][j] = a[i - 1][j - 1] + a[i - 1][j];//二项式定理
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    if (n - 1 > 1)
                    {
                        for (int j = 0; j < n - 1 - i; j++)
                        {
                            Console.Write(" ");
                        }
                    }
                    for (int j = 0; j < i + 1; j++)
                    {
                        Console.Write("{0,4}", a[i][j]);//存了n个数组，第i个数组有j+1个元素
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}