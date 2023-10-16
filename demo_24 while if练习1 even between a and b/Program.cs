namespace demo_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!")/*;*/
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int M = Convert.ToInt32(Math.Max(a,b));
            int m = Convert.ToInt32(Math.Min(a,b));
            int x = m;
            while(x>=m&&x<=M)
            {
                if(x%2==0)
                {
                    Console.WriteLine(x);
                    x += 2;
                }
                else
                {
                    x++;
                    Console.WriteLine(x);
                    x++;
                }
            }
        }
    }
}