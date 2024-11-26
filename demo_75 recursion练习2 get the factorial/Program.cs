namespace demo_75
{
    internal class Program
    {
        static int F(int n)
        {
            if(n == 1) return 1;
            int r = n * F(n - 1);
            return r;
        }
        static void Main(string[] args)
        {
            int n=Convert.ToInt32(Console.ReadLine());
            int s=F(n);
            Console.WriteLine(s);
        }
    }
}