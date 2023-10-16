namespace demo_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Math.Max(a, b));
            int n = Convert.ToInt32(Math.Min(a, b));
            int p = Convert.ToInt32(Math.Max(m, c));
            int q = Convert.ToInt32(Math.Min(m, c));
            Console.WriteLine("{0}<{1}<{2}", n, q, p);
        }
    }
}