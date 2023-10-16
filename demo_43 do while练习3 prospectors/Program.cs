namespace demo_43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c;
            int s = 0;
            do
            {
                c = (char)Console.Read();
                if (c >= '0' && c <= '9')
                {
                    int n = c - '0';
                    s += n;
                }
                else if (c == '*')
                {
                    s += 500;
                }
            } while (c != '#');
            Console.WriteLine(s);
        }
    }
}