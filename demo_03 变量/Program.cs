namespace demo_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //创建变量。创建数据容器，名字叫age，类型为int整数.变量名不以数字开头
            int age;
            age = 10;//赋值
            double high;//小数
            char Age;//字符
            Console.WriteLine("Hello, World!");

            int a= 4,b=8;//变量初始化（第一次赋值）
            a = a + 7 - 8;//赋值覆盖为3
            Console.WriteLine(a);

            char sex = 'f';

            Console.WriteLine(a + b);//11
            Console.WriteLine("a+b");//a+b
            Console.WriteLine(a + "+" + b);//3+8
            Console.WriteLine("a+b" + a + b);//a+b38
            Console.WriteLine("a+b" + (a + b));//a+b11
        }
    }
}