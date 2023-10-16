namespace demo_53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ages = { 32, 23, 56, 78, 12 };//[]进行数组声明、{}赋值，必须在同一行；数组有索引号，从0开始，本质为引用
            Console.WriteLine(ages[0]);//输出0索引号数据
            ages[4] = 20;//将4号值赋为20，将原本值覆盖
            int[] x=new int[10];//new为声明；[数组长度]；数组默认值为0
            string[] s = new string[10];//string默认为null
            char[] c= new char[10];
            Console.WriteLine(ages.Length);//数组长度
            for(int i=0; i< ages.Length; i++)
            {
                Console.WriteLine(ages[i] + " ");//数组遍历，可顺可反
            }

            foreach(int t in ages) {
                Console.WriteLine(t + " ");//数组遍历，只有顺序
            }
            string y=Console.ReadLine();
            char[] m = y.ToCharArray();
            for (int i = 0; i < ages.Length; i++)
            {
                
            }
        }
    }
}