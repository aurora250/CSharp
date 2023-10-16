namespace demo_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a, b;
            a = Convert.ToChar(Console.ReadLine());
            b = Convert.ToChar(Console.ReadLine());
            int c, d;
            c = a;
            d = b;
            int e = Convert.ToInt32(Math.Max(c, d));
            int f = Convert.ToInt32(Math.Min(c, d));
            char g = Convert.ToChar(e);
            char h = Convert.ToChar(f);
            Console.WriteLine("{0}<{1}",h,g);
        }
    }
}