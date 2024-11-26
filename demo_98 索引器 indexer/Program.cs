namespace demo_98
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] a = { 1, 2, 3, 4, 5, };
            //Console.WriteLine(a[1]);

            Test t= new Test();
            t[9] = "100";
            Console.WriteLine(t[9]);
            try
            {
                t[-1] = "10";
            }
            catch { }//不做相应,不中断
            
        }
    }
}