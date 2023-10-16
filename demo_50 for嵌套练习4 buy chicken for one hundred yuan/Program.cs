namespace demo_50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b = 0;
            for(int i = 1; i <= 100/3; i++)
            {
                for(int j = 1; j <= 100/5; j++)
                {
                    for (int k = 1; k <= 100/2; k++)
                    {
                        a = i * 3 + j * 5 + k * 2;
                        if (a == 100)
                        {
                            b++;
                            Console.WriteLine("{0} {1} {2}", i, j, k);
                        }
                    }
                }
            }
            Console.WriteLine(b+"种情况");
        }
    }
}