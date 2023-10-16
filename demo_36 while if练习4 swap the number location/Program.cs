namespace demo_36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            //while (n != 0)
            //{
            //    int i = n % 10;
            //    if (i != 0)
            //    {
            //        break;
            //    }
            //    n /= 10;

            //}
            //while (n != 0)
            //{
            //    int i = n % 10;
            //    Console.Write(i);
            //    n /= 10;

            bool b = false;//没有遇到0
            while (n != 0)
            {
                int i = n % 10;
                if (b == false)
                {
                    if (i != 0)
                    {
                        Console.Write(i);
                        b = true;
                    }//如果i=0，什么都不执行，直到i!=0,开始执行程序并变布尔为true
                }
                else
                {
                    Console.Write(i);
                }
                n /= 10;
            }
        }
    }
}