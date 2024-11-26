using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_96
{
    class Base
    {
        private int hp;
        private int speed;
        public Base()
        {
            Console.WriteLine("Base");
        }
        public Base(int hp,int speed)
        {
            this.hp=hp;
            this.speed=speed;
            Console.WriteLine(hp+" "+speed);
        }
    }
}
