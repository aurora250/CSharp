namespace demo_62
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string[] b = a.Split(" ");
            int[] c = new int[b.Length];
            for (int i = 0; i < b.Length; i++)
            {
                int n = Convert.ToInt32(b[i]);
                c[i] = n;
            }
            //需要两个存储值，一个随数据迭代，一个存储最高值
            int md = 1;//记录最高的气温连续升高天数
            int d = 1;//记录气温连续升高天数，默认为1
            for(int i=0; i < c.Length-1; i++)
            {
                if (c[i] < c[i + 1])
                {
                    d++;
                }
                else
                {
                    if (md < d)
                    {
                        md = d;//更新最大值
                    }
                    d = 1;//归1重记，
                }
            }
            if (md < d)
            {
                md = d;//因为i < c.Length-1，所以最后一次md覆盖不执行，要再进行一次覆盖判断
            }
            Console.WriteLine("最高的气温连续升高天数为{0}", md);
        }
    }
}