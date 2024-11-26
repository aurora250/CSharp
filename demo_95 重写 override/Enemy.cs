using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_95
{
    internal class Enemy
    {
        public virtual void Move()
        {
            Console.WriteLine("Move!");
        }

        public void AI()
        {
            Console.WriteLine("AI");
        }
    }
}
