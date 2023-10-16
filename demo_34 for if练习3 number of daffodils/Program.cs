namespace demo_34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            for(int i = 100; i < 1000; i++)
            {
                int a = x / 100;
                int b = (x % 100)/10;
                int c = (x % 100) % 10;
                int d = Convert.ToInt32(Math.Pow(a, 3)) + Convert.ToInt32(Math.Pow(b, 3)) + Convert.ToInt32(Math.Pow(c, 3));
                if (d == x)
                {
                    Console.WriteLine(x);
                    x++;
                }
                else
                {
                    x++;
                }
            }
        }
    }
}