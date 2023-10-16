namespace demo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            switch(a)
            {
                case 1:
                    Console.WriteLine("红茶");
                    break;
                case 2:
                    Console.WriteLine("绿茶");
                    break;
                case 3:
                    Console.WriteLine("矿泉水");
                    break;
                case 4:
                    Console.WriteLine("雪碧");
                    break;
                case 5:
                    Console.WriteLine("可乐");
                    break;
                default://可有可无
                    Console.WriteLine("脉动");
                    break;

            
            }
        }
    }
}