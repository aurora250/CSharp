namespace demo_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            if(x==0&&y==0)
            {
                Console.WriteLine("在原点");
            }
            if(x==0&&y!=0)
            {
                Console.WriteLine("在X轴上");
            }
            if (x != 0 && y == 0)
            {
                Console.WriteLine("在Y轴上");
            }
            if (x > 0 && y > 0)
            {
                Console.WriteLine("在第一象限");
            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine("在第二象限");
            }
            if (x < 0 && y < 0)
            {
                Console.WriteLine("在第三象限");
            }
            if (x > 0 && y < 0)
            {
                Console.WriteLine("在第四象限");
            }
        }
    }
}