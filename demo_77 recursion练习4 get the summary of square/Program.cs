namespace demo_77
{
    internal class Program
    {
        static int F(int x)
        {
            if(x == 1) return 1;
            int r = F(x - 1) + x * x;
            return r;
        }
        static void Main(string[] args)
        {
            int x=Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (F(i) < 2000)
            {
                i++;
            }
            Console.WriteLine(i - 1);


            //int s = 0;
            //int m = 1;
            //while(true)
            //{
            //    int y = m * m;
            //    s += y;
            //    if (s > x)
            //    {
            //        break;
            //    }
            //    m++;
            //} 
            //Console.WriteLine(m - 1);
        }
    }
}