namespace demo_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a = (3 < 4) && (9 < 6);//同真假为真  
            bool c = (3 < 4) || (9 < 6);//同真假为真
            bool b = !(4 < 7);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            int m = Convert.ToInt32(Console.ReadLine());
            bool n = (m >= 18) && (m <= 60);
            Console.WriteLine(n);
        }
    }
}