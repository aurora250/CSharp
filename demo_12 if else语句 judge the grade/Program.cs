namespace demo_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            //法一：
            //if(a>=90)
            //{
            //    Console.WriteLine("A");
            //}
            //if(a<=89&&a>=70)
            //{
            //    Console.WriteLine("B");
            //}
            //if (a <= 69 && a >= 60)
            //{
            //    Console.WriteLine("C");
            //}
            //if (a <= 60)
            //{
            //    Console.WriteLine("D");
            //}

            //法二：else if语句
            if(a>=90)
            {
                Console.WriteLine("A");
            }else if(a>=80)//默认小于90，只需判断80
            {
                Console.WriteLine("B");
            }else if(a>=70)
            {
                Console.WriteLine("C");
            }
            else if(a>=60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("E");
            }

        }
    }
}