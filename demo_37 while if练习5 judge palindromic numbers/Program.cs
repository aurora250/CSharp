namespace demo_36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int t = n;
            int x = 0;
            while (n != 0)//从低位到高位
            {
                int i = n % 10;
                x *= 10;//乘10再加个位
                x += i;
                n /= 10;
            }
            Console.WriteLine(x);
            int y = t - x;
            Console.WriteLine(y);
            if (y == 0)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}