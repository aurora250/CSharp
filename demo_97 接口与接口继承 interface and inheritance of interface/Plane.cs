using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_97
{
    class Plane:IFly
    {
        public void Fly()
        {
            Console.WriteLine("PlaneFly!");
        }
        public void Attack()
        {
            Console.WriteLine("PlaneAttack!");
        }
    }
}
