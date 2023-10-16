namespace demo_33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r=Convert.ToInt32(Console.ReadLine());
            int m=Convert.ToInt32(Console.ReadLine());
            int y=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < y; i++)
            {
                m =(int)(m * (1 + (r / 100.0)));
            }
            Console.WriteLine(m);
        }
    }
}