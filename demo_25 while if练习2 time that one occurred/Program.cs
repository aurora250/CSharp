namespace demo_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=Convert.ToInt32(Console.ReadLine());
            int t = 0;
            while(n!=1)
            {
                if (n % 2 == 0)
                {
                    n = n / 2;
                    t++;
                }
                else
                {
                    n = 3 * n + 1;
                    t++;
                }
            }
            
            Console.WriteLine(t);
        }
    }
}