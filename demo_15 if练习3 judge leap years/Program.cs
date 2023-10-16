namespace demo_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=Convert.ToInt32(Console.ReadLine());
            
            if (a%100 == 0) 
            {
                if(a%400==0 )
                {
                    Console.WriteLine("闰年");
                }
                else
                {
                    Console.WriteLine("不是闰年");
                }
            }
            else if(a%4==0)
            {
                Console.WriteLine("闰年");
            }
            else
            {
                Console.WriteLine("不是闰年");
            }

        }
    }
}