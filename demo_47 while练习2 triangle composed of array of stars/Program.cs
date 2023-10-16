namespace demo_47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=Convert.ToInt32(Console.ReadLine());
            string s="";
            int a = 0;
            do
            {
                a++;
                s += "*";
                Console.WriteLine(s);
            } while (a < n);
            Console.WriteLine();
            string x = "";
            int b= 0;
            do
            {
                b++;
                Console.WriteLine(x + "*");
                x += " ";
            } while (b < n);
            Console.WriteLine();
            string y = "";
            int c = 0;
            int d = 0;
            while (c < n-1)
            {
                y += " ";
                c++;
            }
            do
            {
                d++;
                Console.WriteLine(y + "*");
                y = y.Remove(0, 1);
            }while (d < n);
        }
    }
}