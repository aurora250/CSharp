namespace demo_71
{
    internal class Program
    {
        static int[] Factor(int x)
        {
            int yinzi = 0;
            for (int i = 1; i < x + 1; i++)
            {
                if (x % i == 0)
                {
                    yinzi++;//得到数组长度
                }
            }
            int[] array = new int[yinzi];
            int index = 0;
            for (int i = 1; i < x + 1; i++)
            {
                if(x%i == 0)
                {
                    array[index] = i;//为数组依次赋值
                    index++;
                }
            }
            return array;
        }
        static void Main(string[] args)
        {
            int a=Convert.ToInt32(Console.ReadLine());
            int[] b=Factor(a);
            foreach(int x in b)
            {
                Console.Write(x+" ");//数组遍历
            }
        }
    }
}