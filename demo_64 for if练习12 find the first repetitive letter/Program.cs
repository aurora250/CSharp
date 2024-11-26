namespace demo_64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s=Console.ReadLine();
            bool a = false;
            for (int i = 0;i<s.Length;i++)
            {
                a = false;
                for(int j = i+1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        Console.WriteLine(s[i]);
                        a = true;
                    }
                }
                if (a)
                {
                    break;
                }
                while (i == s.Length-1)
                {
                    Console.WriteLine("NO");
                    break;
                }
            }
        }
    }
}