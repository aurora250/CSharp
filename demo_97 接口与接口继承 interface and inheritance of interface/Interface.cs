using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_97
{
    interface Interface:IFly//接口继承
    {
        void IFly(IFly fly);//重载
    }
}
