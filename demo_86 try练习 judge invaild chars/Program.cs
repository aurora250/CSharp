namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入两个数");
            while (true)
            {
                try
                {
                    int n1 = Convert.ToInt32(Console.ReadLine());//一行出错，try里后边的代码都不执行
                    int n2 = Convert.ToInt32(Console.ReadLine());
                    break;//全部合法就会执行break
                }
                catch (FormatException e)
                {
                    Console.WriteLine("invaild");
                }
                
            }
            
        }
    }
}