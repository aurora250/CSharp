namespace demo_56
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] a = s.Split(" ");
            int[] b = new int[a.Length];//int[]是把a从string转int并存储的容器
            for(int i = 0; i < b.Length; i++)
            {
                int n = Convert.ToInt32(a[i]);
                b[i] = n;//依次转换并赋值给int[]
            }
            int m = b[0];
            int c = 0;
            for(int i = 1; i < b.Length; i++)
            {
                if (b[i] < m)
                {
                    m= b[i];
                    c = i;
                }
            }
            int d = b[0];
            b[0] = b[c];//c为min的索引
            b[c] = d;
            foreach(int i in b)
            {
                Console.Write(i+" ");
            }
        }
    }
}