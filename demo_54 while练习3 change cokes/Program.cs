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
                b += a / 3;
                a = a / 3 + a % 3;
            }
            Console.WriteLine("喝掉{0}瓶，剩下{1}瓶", b, a);
        }
    }
}