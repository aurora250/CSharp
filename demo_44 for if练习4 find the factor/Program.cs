namespace demo_44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=Convert.ToInt32(Console.ReadLine());
            int b = 0;
            string s = "";
            for(int i=1;i<=a; i++)
            {
                if (a % i == 0)//要取余，不取i初始为0，而取1
                {
                    b++;
                    s += i + " ";
                }
            }
            Console.WriteLine(b);
            Console.WriteLine(s.Trim());
            if (b == 2)
            {
                Console.WriteLine("是质数");
            }
            else
            {
                Console.WriteLine("不是质数");
            }
        }
    }
}