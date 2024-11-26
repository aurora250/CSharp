using System;   //引入命名空间
using System.Diagnostics;

namespace demo_02   //命名空间，一般与项目名一致，不以数字开头
{
    internal class Program   //program 类
    {
        static void Main(string[] args)   //main 方法
        {
            Console.WriteLine("Hello,World!");   //输出语句
            Console.WriteLine("Hello,World!");
            string path = Process.GetCurrentProcess().MainModule.FileName;
            Console.WriteLine(path);
            Console.WriteLine(path.LastIndexOf("."));
            Console.WriteLine(path.Substring(path.LastIndexOf(".")+1));
        }
    }
}

/*
  多行注释
*/