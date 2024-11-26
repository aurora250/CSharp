using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_95
{
    internal class Boss:Enemy
    {
        public override void Move()//重写
        {
            Console.WriteLine("bossmove!");
        }

        public new void AI()
        {
            Console.WriteLine("BossAI");
        }
    }
}
