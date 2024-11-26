using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_93
{
    internal class Customer
    {
        private string name = "hu";
        private string address = "hebei";
        private int age = 18;
        private string Createtime = "2023";

        public int Age//声明属性，含有get块与set块，可以在外界直接调用
        {
            get
            {
                return age;
            }
            set//使用参数value
            {
                age = value;
            }
        }
        public void Show()
        {
            Console.WriteLine("名字 " + name);
            Console.WriteLine("年龄 " + age);
            Console.WriteLine("地址 " + address);
            Console.WriteLine("创建时间 " + Createtime);
        }
    }
}
