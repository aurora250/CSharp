namespace demo_101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class<int> a=new Class<int>(34,12);
            Console.WriteLine(a.Getsum());
            Program p=new Program();
            Console.WriteLine();
            Console.WriteLine(p.ToString());
            Console.WriteLine(p);//默认调用.ToString()
            Student s=new Student(30,"hu");
            Console.WriteLine();
            Console.WriteLine(s);
            Console.WriteLine(s.ToString());
        }
    }
    class Class<T>//Type，表示类型，随不同类型而改变
    {
        private T a;
        private T b;
        public Class(T a, T b)
        {
            this.a = a;
            this.b = b;
        }
        public T Getsum()
        {
            dynamic num1 = a;
            dynamic num2 = b;
            return num1 + num2;
        }
    }
}