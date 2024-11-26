using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_88
{
    internal class Vehicle
    {
        public string brand;
        public int speed;
        public float weight;

        public void Run()
        {
            Console.WriteLine("行驶");
        }

        public void Stop()
        {
            Console.WriteLine("停止");
        }
    }
}
