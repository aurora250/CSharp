namespace demo_50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b = 0;
            for (int i = 0; i < 100 / 5; i++)
            {
                for (int j = 0; j < 100 / 3; j++)
                {
                    for (int k = 0; k < 100 * 3; k++)
                    {
                        a = i * 15 + j * 9 + k;//a与100同乘3
                        if (a == 300 && i + j + k == 100)
                        {
                            b++;
                            Console.WriteLine("公鸡{0,2}只，母鸡{1,2}只，小鸡{2,2}只", i, j, k);
                        }
                    }
                }
            }
        }
    }
}