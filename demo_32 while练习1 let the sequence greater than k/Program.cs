using System.Data;

namespace demo_32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = Convert.ToInt32(Console.ReadLine());
            double s = 0;
            int n = 0;
            while(s<=k)
            {
                n++;
                s += 1.0 / n;
            }
            Console.WriteLine(n);
        }
    }
}