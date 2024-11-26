namespace demo_69
{
    internal class Program
    {
        static int Add(int[] array)//参数数组；参数数组可以混搭，在前边就优先需要赋值，混搭时参数数组放在最后
        {
            int s = 0;
            for (int i = 0; i < array.Length; i++)
            {
                s += array[i];
            }
            return s;
        }
        static int Sum(string m, params int[] array)//params int[] array可以传递任意个参并自动组成数组,参用“，”分隔
        {
            int s = 0;
            for (int i = 0; i < array.Length; i++)
            {
                s += array[i];
            }
            return s;
        }
        static void Main(string[] args)
        {
            int x= Add(new int[] { 1, 2, 3 });//为int[]赋值
            int[] a = { 6, 8, 9 };
            int y = Add(a);
            Console.WriteLine(x+" "+y);
            int z = Sum("string",6, 8, 1);
            Console.WriteLine(z);
        }

    }
}