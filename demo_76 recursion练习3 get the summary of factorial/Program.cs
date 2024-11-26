namespace demo_76
{
    internal class Program
    {
        static long F(long x)
        {
            if (x == 1) return 1;
            long r = F(x - 1) * x;
            return r;
        }
        static void Main(string[] args)
        {
            long x=Convert.ToInt64(Console.ReadLine());
            long r = 0;
            for (int i = 1; i <= x; i++)
            {
                r += F(i);
            }
            Console.WriteLine(r);
        }
    }
}