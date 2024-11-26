namespace demo_54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 364;
            int b = 364;
            while (a>=3)
            {
                b += a / 3;//a/3是空瓶换的
                a = a / 3 + a % 3;//上次剩的加上换的是现在手里的瓶子
            }
            Console.WriteLine("喝掉{0}瓶，剩下{1}瓶", b, a);
        }
    }
}