namespace demo_42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int b = 0;
            char c;
            do
            {
                c= (char)Console.Read();
                if(c>='0'&&c<='9')
                {
                    int n = c - '0';
                    b += n;
                }
            } while (c!='@');
            Console.WriteLine(b);
        }
    }
}