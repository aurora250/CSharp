namespace demo_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m=Convert.ToInt32(Console.ReadLine());
            int n=Convert.ToInt32(Console.ReadLine());
            int a=Convert.ToInt32(Math.Min(m,n));
            int b=Convert.ToInt32(Math.Max(m,n));
            int t = 0;
            for(int f=a;f<=b;f++)
            {
                if (f % 17 == 0)
                {
                    t = t + f;
                }
            }
            Console.WriteLine(t);
        }
    }
}