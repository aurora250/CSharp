namespace demo_66
{
    internal class Program
    {
        static bool VarifyUsername(string username)//返回值和方法名必有  //设立形式参数，只有调用时使用并赋值
        {
            Console.WriteLine("校验"+username);
            return true;//返回true，类型由返回值定
        }
        //static void Main(string[] args)
        //{
        //    bool result = VarifyUsername("huenqi");    //调用方法，把实际参数"huenqi"赋值给username
        //    Console.WriteLine("Hello, World!");
        //}

        //用方法实现a+b
        static int Add(int a,int b,out int m)//out单向带回;不用初始化
        {
            int result = a + b;
            m = a * b;
            return result;//输出result并终止方法
        }

        static void SwapRef(ref int a,ref int b)//ref双向赋值
        {
            int t = a;
            a = b;
            b = t;
        }

        static int Print(int a,int b = 0)//给予默认值后边的变量都要赋予默认值
        {
            int m = a - b;
            return m;
        }

        public static int OK(params int[] a)//不定数目params只能引用数组
        {
            int m = 0;
            for(int i = 0; i < a.Length; i++)
            {
                m+= a[i];
            }
            return m;
            
        }
        static void Main(string[] args)
        {
            int m;
            int a=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());
            int result = Add(a, b,out m);//Add计算后赋给result
            SwapRef(ref a,ref b);
            Console.WriteLine(result);
            int n = Print(a, b);
            int x = OK(2, 3, 4, 5, 6);
        }
    }
}