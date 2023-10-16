namespace demo_60
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s=Console.ReadLine();
            bool right = true;//默认是合法标识符
            //标识符只含有数字，字母，_，且不以数字开头
            for(int i = 0;i<s.Length;i++)
            {
                if ((s[i] < '0' || s[i]>'9')&& (s[i] < 'a' || s[i] > 'z')&& (s[i] < 'A' || s[i] > 'Z') && (s[i] != '_'))
                {
                    right = false;
                    break;
                }
            }
            if(s[0] >= '0' || s[0] <= '9')
            {
                right = false;
            }
            if (right)
            {
                Console.WriteLine("是合法标识符");
            }
            else
            {
                Console.WriteLine("不是合法标识符");
            }

        }
    }
}