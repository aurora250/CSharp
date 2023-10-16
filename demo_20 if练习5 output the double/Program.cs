namespace demo_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double m = Convert.ToDouble(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            if(k == 0)
            {
                int n = Convert.ToInt32(Math.Round(m, 0));
                Console.WriteLine(n);
            }
            else
            {
                int p = Convert.ToInt32(Math.Round(m, 1));
                Console.WriteLine(p);
            }
        }
    }
}