namespace demo_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int temp = a;
            a = b;
            b= temp;
            Console.WriteLine(a);
            Console.WriteLine(b);
            
            //不利用第三方进行交换
            a = a + b;
            b = a - b;//输出a
            a = a - b;//输出b
            Console.WriteLine(a+" "+b);
            Console.WriteLine("{0}+{1}={2}", a, b, a + b);//格式化输出   0 1 2位
            
        }
    }
}