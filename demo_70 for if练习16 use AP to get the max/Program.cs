namespace demo_70
{
    internal class Program
    {
        static int Max(params int[] n)
        {
            int m = n[0];
            for (int i = 1; i < n.Length; i++)
            {
                if (n[i] > m)
                {
                    m = n[i];
                }
            }
            return m;
        }
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
            int x = Max(c);
            Console.WriteLine(x);
        }
    }
}