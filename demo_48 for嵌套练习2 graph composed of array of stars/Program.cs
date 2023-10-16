namespace demo_48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=Convert.ToInt32(Console.ReadLine());
            string s = "";
            for(int i = 0; i < n; i++)
            {
                Console.Write(s);
                for(int j = 0; j < n; j++)
                { 
                    Console.Write("*");
                }
                s += " ";
                Console.WriteLine();
            }
            Console.WriteLine();
            for(int i = 1; i<=n; i++)//i为行号，输出n-i个空格，i个*
            {
                for(int j = 0;j <n-i; j++)
                {
                    Console.Write(" ");
                }
                for(int j = 0; j < (i-1)*2+1; j++)//改为j<i则是三角形
                {
                    Console.Write("*");
                }
                Console.WriteLine();//菱形上半部分
            }
            for (int i = 1;i<=n-1; i++)
            {

                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < (n - 1) * 2 + 1 - i * 2; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();//菱形下半部分
            }
            Console.WriteLine();
        }
    }
}