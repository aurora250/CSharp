using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_101
{
    internal class Student
    {
        private int id;
        private string name;

        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        //重写.ToString()方法
        public override string ToString()
        {
            return id + ":" + name;
        }
    }
}
