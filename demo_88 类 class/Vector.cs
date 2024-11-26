using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_88
{
    internal class Vector
    {
        private float x, y, z;
        public void Setx(float x)//private只能用方法调用才能被外界使用
        {
            if(x < 0)
            {
                return;
            }
            this.x = x;
        }
        public void Sety(float y)
        {
            if(y < 0)
            {
                return;
            }
            this.y = y;
        }
        public void Setz(float z)
        {
            if(z < 0)
            {
                return;
            }
            this.z = z;
        }

        public float Getx()
        {
            return x;
        }
        public double Length()
        {
            double m=Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
            return m;
        }
    }
}
