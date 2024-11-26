using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_97
{
    class Bird:IFly
    {
        public void Fly()
        {
            Console.WriteLine("BirdFly!");
        }
        public void Attack()
        {
            Console.WriteLine("BirdAttack!");
        }
    }
}
