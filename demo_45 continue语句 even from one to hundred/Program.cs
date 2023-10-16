namespace demo_45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for(int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            for(int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}