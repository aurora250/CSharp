namespace demo_57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int x = Convert.ToInt32(Console.ReadLine());
            string[] b = a.Split(" ");
            int[] c = new int[b.Length];
            for (int i = 0; i < b.Length; i++)
            {
                int n = Convert.ToInt32(b[i]);
                c[i] = n;

            }
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] <= x && c[i + 1] >= x)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write(b[j] + " ");
                    }
                    Console.Write(x);
                    for (int j = i+1; j < b.Length; j++)
                    {
                        Console.Write(" " + b[j]);
                    }
                }
                else if (x < c[0])
                {
                    Console.Write(x);
                    for (int j = 0; j < b.Length; j++)
                    {
                        Console.Write(" " + b[j]);
                    }
                }
                else if (x > c[c.Length])
                {
                    for (int j = 0; j <= c.Length; j++)
                    {
                        Console.Write(b[j] + " ");
                    }
                    Console.Write(x);
                }
            }
        }
    }
}