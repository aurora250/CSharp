namespace demo_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char s = Convert.ToChar(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            if(s=='F')
            {
                if(n%2==0)
                {
                    Console.WriteLine("800米 仰卧起坐");
                }
                else
                {
                    Console.WriteLine("800米 跳绳");
                }
            }
            else if(n%2==0)
            {
                Console.WriteLine("1000米 俯卧撑");
            }
            else
            {
                Console.WriteLine("1000米 跳远");
            }
        }
    }
}