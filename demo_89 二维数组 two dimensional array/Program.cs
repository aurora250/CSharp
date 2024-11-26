namespace demo_89
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[6, 6];
            //a[r,c]  行 列
            int t = 1;
            for(int i = 0;i < 6; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        a[j, i] = t;
                        t++;
                    }
                }
                else
                {
                    for (int j = 5; j >= 0; j--)
                    {
                        a[j, i] = t;
                        t ++;
                    }
                }
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write($"{a[i, j]} \t");
                }
                Console.WriteLine();
            }
        }
    }
}