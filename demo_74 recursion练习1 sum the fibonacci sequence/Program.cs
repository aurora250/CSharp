namespace demo_74
{
    internal class Program
    {
        static int F(int n)
        {
            if(n == 0)//递归终止的条件
            {
                return 2;
            }
            if (n == 1)
            {
                return 3;
            }
            int r = F(n - 1) + F(n - 2);
            return r;
        }
        static void Main(string[] args)
        {
            int n=Convert.ToInt32(Console.ReadLine());
            int s = F(n);
            Console.WriteLine(s);
        }
    }
}