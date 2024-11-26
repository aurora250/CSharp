using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_98
{
    class Test//数组管理器,进行非法赋值控制
    {
        private string[] s = new string[10];
        public string this[int index]//索引器
        {
            get
            {
                return s[index];
            }
            set
            {
                if (index < 0)
                {
                    Console.WriteLine("Invalid!");
                    return;
                }
                s[index] = value.ToString();
            }
        }
    }
}
