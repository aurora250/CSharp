namespace demo_35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////法一
            //string x=Console.ReadLine();
            //string y = x.Replace("0", "");
            //Console.WriteLine(y);

            //法二
            int n = Convert.ToInt32(Console.ReadLine());
            int c = 1;
            int s = 0;
            while (n != 0)
            {
                int i = n % 10;//从个位向高位输出
                if (i != 0)//i！=0，加到s里再循环
                {
                    i *= c;
                    s += i;
                    c *= 10;
                }
                n /= 10;//i==0,直接下一位计算循环
            }
            Console.WriteLine(s);

        }
    }
}