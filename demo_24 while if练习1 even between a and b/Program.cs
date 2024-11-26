namespace demo_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int M = Convert.ToInt32(Math.Max(a,b));
            int m = Convert.ToInt32(Math.Min(a,b));
            int x = m;//设置一个可以改变的m值
            while(x>=m&&x<=M)
            {
                if(x%2==0)//是偶数
                {
                    Console.WriteLine(x);
                    x += 2;
                }
                else//是奇数
                {
                    x++;//变偶，由上面输出
                }
            }
        }
    }
}