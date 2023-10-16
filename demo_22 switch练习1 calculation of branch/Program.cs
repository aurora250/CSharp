namespace demo_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            switch(c)
            {
                case 0:
                    Console.WriteLine(a + b);
                    break;
                case 1:
                    Console.WriteLine(a - b);
                    break;
                case 2:
                    Console.WriteLine(a * b);
                    break;
                case 3:
                    double d = a / b*1.0;//整数转分数
                    Console.WriteLine(d);
                    break;
            }
            }
        }
    }
}