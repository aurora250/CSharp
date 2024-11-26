namespace demo_63
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
            int m1 = 0; int m2=0;
            for(int i=0; i<c.Length; i++)
            {
                if (c[i] > m1)
                {
                    m2 = m1;//将第二大给m2
                    m1= c[i];//第一大
                }
                else
                {
                    if (c[i] > m2)
                    {
                        m2= c[i];//第二大
                    }
                }
            }
            Console.WriteLine("第一大是" + m1 + " 第二大是" + m2);
        }
    }
}