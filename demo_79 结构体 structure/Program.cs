namespace demo_79
{
    internal class Program
    {
        struct inform//结构体声明
        {
            public int age;//定义结构体属性；public变量门，即允许公共访问
            public string name;
            public int grade;
            public int id;
        }
        static void Main(string[] args)
        {

            inform student1;
            student1.age = 10;
            student1.name = "hu";
            student1.grade = 3;
            student1.id = 2023;
            Console.WriteLine(student1.age);

            inform[] students=new inform[10];//整体存储
            students[0].age = 30;
            Console.WriteLine(students[0].age);
        }
    }
}