namespace demo_67
{
    internal class Program
    {
        static bool Judge(int n)
        {
            bool right = true;
            for (int j = 2; j < n; j++)
            {
                if (n % j == 0)
                {
                    right = false;
                    break;
                }
            }
            return right;
        }
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string[] b = a.Split(" ");
            int[] c = new int[b.Length];
            for (int i = 0; i < b.Length; i++)
            {
                c[i] = Convert.ToInt32(b[i]);
            }
            int m = Math.Min(c[0], c[1]);
            int n = Math.Max(c[0], c[1]);
            for (int i = m; i < n + 1; i++)
            {
                bool d=Judge(i);
                if (d)
                {
                    int t = i;
                    int y = 0;
                    while (t % 10 != 0)
                    {
                        y = y * 10 + t % 10; 
                        t /= 10;
                    }
                    bool e=Judge(y);
                    if (e)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}