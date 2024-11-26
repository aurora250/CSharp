using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_103
{
    internal class Student
    {
        private int id;
        private string name;
        public Student(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
        public override bool Equals(object obj)
        {
            Student stu=(Student)obj;
            if (stu.id == id && stu.name == name)
            {
                return true;
            }
            return false;
        }

    }
}
