namespace demo_61
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s=Console.ReadLine();
            bool str = true;
            for(int i=0;i<s.Length/2;i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    str = false;
                    break;
                }
            }
            if (str)
            {
                Console.WriteLine("是回文串");
            }
            else
            {
                Console.WriteLine("不是回文串");
            }
        }
    }
}