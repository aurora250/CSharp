using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_96
{
    class Derived:Base
    {
        int attack;
        public Derived():base()//调用父类的构造函数
        {
            Console.WriteLine("Derived");
        }

        public Derived(int attack)// : base()
        {
            this.attack = attack;
            Console.WriteLine(attack);
        }
        public Derived(int attack,int hp,int speed): base(hp,speed)
        {
            this.attack = attack;
            Console.WriteLine(attack+" "+hp+" "+speed);
        }
    }
}
