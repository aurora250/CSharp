namespace demo_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            string str = Console.ReadLine();//得到字符
            int strint=Convert.ToInt32(str);//convert强行转换，只能将数字字符转换为数字整数，不转换字母字符
            //定义整数来接受转换后的整数
            Console.WriteLine(strint + "-");//输出整数strint,可进行运算

            int a = Convert.ToInt32(Console.ReadLine());//简化：输入值并转化为数赋给a
            Console.WriteLine(a);
            //int a=Convert.ToInt32(Console.ReadLine());
        }
    }
}