namespace demo_85
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4 };


            try//可能异常的代码
            {
                int t = a[5];
            }
            catch(IndexOutOfRangeException e)//要捕捉的异常类型；catch可以有多个；catch与finally必须至少存在一个
            {
                //出现异常如何处理
                Console.WriteLine(e.Message);
            }
            catch//捕捉任意类型异常
            {

            }
            finally//恒执行
            {

            }
        }
    }
}