namespace demo_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int t = a;
            while (a != 0)
            {
                a = Convert.ToInt32(Console.ReadLine());
                t += a;
            }
            Console.WriteLine(t);



            int m = 0;
            int s = 0;
            do
            {
                int x = Convert.ToInt32(Console.ReadLine());
                t += x;
                s = x;
            } while (s != 0);
            Console.WriteLine(m);



            int y = Convert.ToInt32(Console.ReadLine());
            int p = y;
            for(int b=y;b!=0;)
            {
                b = Convert.ToInt32(Console.ReadLine());
                p += b;
            }
            Console.WriteLine(p);
        }
    }
}