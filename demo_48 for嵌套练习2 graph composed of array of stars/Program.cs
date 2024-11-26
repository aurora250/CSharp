namespace demo_48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=Convert.ToInt32(Console.ReadLine());
            string s = "";
            //以下为正方形
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();    
            //以下为三角形
            int a = 0;
            do
            {
                a++;
                s += "*";
                Console.WriteLine(s);
            } while (a < n);
            Console.WriteLine();
            //以下为三角形斜边
            string x = "";
            int b = 0;
            do
            {
                b++;
                Console.WriteLine(x + "*");
                x += " ";
            } while (b < n);
            Console.WriteLine();
            //以下为斜边镜像
            string y = "";
            int c = 0;
            int d = 0;
            while (c < n - 1)
            {
                y += " ";
                c++;
            }
            do
            {
                d++;
                Console.WriteLine(y + "*");
                y = y.Remove(0, 1);
            } while (d < n);
            Console.WriteLine();
            //以下为平行四边形
            for (int i = 0; i < n; i++)
            {
                Console.Write(s);
                for(int j = 0; j < n; j++)
                { 
                    Console.Write("*");
                }
                s += " ";//每输出一行加一个空格使图形倾斜为平行四边形
                Console.WriteLine();
            }
            Console.WriteLine();
            //以下为菱形
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
        }
    }
}