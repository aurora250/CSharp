namespace demo_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int a = Convert.ToInt32(Math.Min(m, n));
            int b = Convert.ToInt32(Math.Max(m, n));
            string x = "";
            string y = "";
            for (int f = a; f <= b; f++)
            {
                if (f % 2 == 0)
                {
                    x = x + f + " ";//得到偶数列
                }
                else
                {
                    y = y + f + " ";//得到奇数列
                }
            }
            Console.WriteLine(x.Trim());//去掉空格
            Console.WriteLine(y.Trim());
        }
    }
}