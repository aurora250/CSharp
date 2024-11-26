namespace demo_88
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();//用类Customer创建对象c1；对象是类创建出来的变量
            Customer c2;//声明对象
            c2= new Customer();//实例化对象
            //Customer c3 = null;//空对象
            c1.name = "hu";
            c1.address = "qinhuangdao";
            c1.Setage(10);
            c1.Createtime = "yesterday";

            c1.Show();//show的输出调用
            //c3.Show();//值类型int、datetime等不可初始化为null，故会报错；引用类型可以初始化为null

            Console.WriteLine();

            Vehicle v1 = new Vehicle();
            v1.Run();
            v1.Stop();

            Console.WriteLine();

            Vector vector = new Vector();
            vector.Setx(1f);//用方法调用。因为方法的加入，操作更多元化
            vector.Sety(2f);
            vector.Setz(3f);
            Console.WriteLine(vector.Length());

            vector.Setx(-1f);//if的存在让-1f不能覆盖x值，是一种保护机制
            Console.WriteLine(vector.Getx());
            Console.WriteLine(vector.Length());
        }
    }
}