namespace demo_82
{
    internal class Program
    {
        static double M(double x,double y)
        {
            return x * y;
        }
        static double D(double x, double y)
        {
            return x / y;
        }
        delegate double MD(double x, double y); //delegate委托声明；委托不调用，只指向；指向类型相同的static
        static void Main(string[] args)
        {
            Console.WriteLine(M(2.2 ,2));
            Console.WriteLine(D(2.2 ,2));
            MD delegate1;
            delegate1 = M;//指向函数引用，使调用M
            Console.WriteLine(delegate1(2.2, 2));
            delegate1 = D;//改变指向
            Console.WriteLine(delegate1(2.2, 2));
        }
    }
}