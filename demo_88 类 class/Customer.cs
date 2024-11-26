using System;

namespace demo_88
{
    internal class Customer//类
    {
        public string name;
        public string address;
        //public int age;//没有保护性
        private int age;    
        public string Createtime;  

        public void Setage(int age)
        {
            if (age < 0)//防止非法数据随意更改
            {
                return;
            }
            this.age = age;
        }

        public int Getage()
        {
            return age;
        }

        public void Show()
        {
            Console.WriteLine("名字 " + name);
            Console.WriteLine("年龄 " + age);
            Console.WriteLine("地址 " + address);
            Console.WriteLine("创建时间 " + Createtime);
        }
    }

    struct CustomerStruct//结构体
    {
        public string name;
        public string address;
        public int age;
        public string Createtime;

        public void Show()
        {
            Console.WriteLine("名字" + name);
            Console.WriteLine("年龄" + age);
            Console.WriteLine("地址" + address);
            Console.WriteLine("创建时间" + Createtime);
        }
    }
}
