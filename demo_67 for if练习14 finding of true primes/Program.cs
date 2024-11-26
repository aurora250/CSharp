namespace demo_67
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "2 7";
            string[] b = a.Split(" ");
            int[] c = new int[b.Length];
            for (int i = 0; i < b.Length; i++)
            {
                c[i] = Convert.ToInt32(b[i]);
            }
            int m = Math.Min(c[0], c[1]);
            int n = Math.Max(c[0], c[1]);
            for(int i=m;i<n+1;i++)
            {
                bool right = true;
                for (int j=2;j<i;j++)
                {
                    if (i % j == 0)//被某个数整除了，不是素数
                    {
                        right = false;
                        break;
                    }
                }
                if(right)
                {
                    int t = i;
                    int y = 0;
                    while (t % 10 != 0)//得到素数，开始倒序
                    {
                        y = y * 10 + t % 10;
                        t /= 10;
                    }
                    bool x = true;
                    for (int j=2;j<y; j++)//素数判断
                    {
                        if (y % j == 0)
                        {
                            x = false;
                            break;
                        }
                    }
                    if(x)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}