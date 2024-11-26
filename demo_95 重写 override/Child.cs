using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_95
{
    class Child:Abstract
    {
        public override void Attack()
        {
            Console.WriteLine("AbstractAttack!");
        }
    }
}
