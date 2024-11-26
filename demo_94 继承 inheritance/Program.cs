namespace demo_94
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Baseclass bc = new Baseclass();
            bc.Function1();
            bc.Function2();

            Derivedclass dc1= new Derivedclass();
            dc1.Function1();//继承了Baseclass的字段和函数
            dc1.Function2();
        }
    }
}