namespace demo_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n=Convert.ToDouble(Console.ReadLine());
            double h = n;
            for(int i=0;i<10;i++)
            {
                h /= 2;
            }
            Console.WriteLine("10次后反弹高度"+h);
            double d = 2 * n;
            double s = d;
            for(int i = 0; i < 9; i++)
            {
                d /= 2;
                s += d;
            }
            Console.WriteLine("总路程" + (s-n));
        }
    }
}