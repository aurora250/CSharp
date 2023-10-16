namespace demo_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if ((a >= 18) && (a <= 30))
            {
                int b = a % 2;
                if (b != 0)
                {
                    Console.WriteLine("有奖品");
                }
                else
                {
                    Console.WriteLine("没有奖品");
                }
            
            }
            else
            {
                Console.WriteLine("不能参加");
            }
        }
    }
}