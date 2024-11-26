namespace demo_103
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1=new Student(12,"hu");
            Student s2=new Student(12,"hu");
            Console.WriteLine(s1.Equals(s2));//重写
            Console.WriteLine(s1==s2);//仍然判断引用
            Student s3 = s1;
            Console.WriteLine(s3.Equals(s1));
        }
    }
}