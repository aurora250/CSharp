using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_99
{
    internal class Student
    {
        private int age;
        private string name;
        private int id;

        public Student(int age, string name, int id)
        {
            this.age = age;
            this.name = name;
            this.id = id;
        }

        public static bool operator==(Student s1, Student s2)
        {
            if(s1.id == s2.id&&s1.name==s2.name&&s1.age==s2.age) return true;
            return false;
        }
        public static bool operator !=(Student s1, Student s2)
        {
            return !(s1 == s2);
        }
    }
}
