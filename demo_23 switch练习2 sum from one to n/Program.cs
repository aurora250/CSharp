namespace demo_23
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = Convert.ToInt32(Console.ReadLine());
            int b = 1;
            int s = 0;
            while (s <= a)
            {
                s += b;//临时和
                b++;//递归
            }
            Console.WriteLine(s);
                
            
        }
    }
}