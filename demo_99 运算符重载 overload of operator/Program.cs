namespace demo_99
{
    class Program
    {
        static void Main(string[] args)
        {
            //比较引用：
            Student s1=new Student(20,"hu",20231104);
            Student s2=new Student(20,"hu",20231104);
            Console.WriteLine(s1==s2); //数据相同，引用地址不同
            Student s3 = s1;           //复制地址，引用地址相同
            Console.WriteLine(s3==s1);

            //比较数据：  运算符重载，修改==的作用为比较存储值而非地址

        }
    }
}