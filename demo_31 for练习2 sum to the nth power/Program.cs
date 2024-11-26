namespace demo_31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int q=Convert.ToInt32(Console.ReadLine());
            int n=Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 0;
            for(int i=0; i<n+1; i++)
            {
                int x= Convert.ToInt32(Math.Pow(q,a));
                a++;
                b += x;
            }
            Console.WriteLine(b);
        }
    }
}