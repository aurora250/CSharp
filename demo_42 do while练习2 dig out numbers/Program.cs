namespace demo_42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s=Console.ReadLine();
            int b = 0;
            char[] c = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                c[i] = s[i];
                if (c[i] >= '0' && c[i] <= '9')
                {
                    b++;
                }
                if (c[i] == '.')
                {
                    break;
                }
            }
            Console.WriteLine(b);
        }
    }
}