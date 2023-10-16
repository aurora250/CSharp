namespace demo_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=1;i<11;i++)  
            {
                Console.WriteLine(i);
            }


            int a = 1;
            while(a<11)
            {
                Console.WriteLine(a);
                a++;
            }

            int b = 1;
            do
            {
                Console.WriteLine(b);
                b++;
            }while(b< 11);
        }
    }
}