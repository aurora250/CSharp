using System.ComponentModel;

namespace demo_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = 'c';//只能输入一个字符
            int b = a;//字符本质是数字，所以可以覆盖；字符与数字可以互换（强制类型转换）
            Console.WriteLine(b);//输出数
            Console.WriteLine(a);//输出符号

            int a2 = 97;
            char b2 = (char)a2;//强制类型转换
            Console.WriteLine(a2);//输出数
            Console.WriteLine(b2);//输出字符a2

            Console.WriteLine(@"c:\a\b\c""");//@使转义失效，很方便阅读//两个""表示"
            string str = @"c:\a\b\c"+"   siki";//定义字符串
            string str2 = str + "   www";//字符串的叠加
            Console.WriteLine(str2+123);
            Console.WriteLine(str);
            Console.WriteLine(123);
        }
    }
}