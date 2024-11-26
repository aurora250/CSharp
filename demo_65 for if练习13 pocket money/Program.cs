namespace demo_65
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s=Console.ReadLine();
            string[] a = s.Split(" ");
            int[] b= new int[a.Length];
            for(int i = 0; i < a.Length; i++)
            {
                int n = Convert.ToInt32(a[i]);
                b[i] = n;
            }
            int x = 0;//存着的
            int y = 0;//自己手里的
            int z = 0;//超出预算月
            int t = 0;
            for(int i = 0; i < 12; i++)
            {
                t = 300 + y - b[i];
                if (t < 0)
                {
                    z = i;
                    break;
                }
                x += (t / 100) * 100;//取100整
                t %= 100;//取100余
            }
            if (t < 0)
            {
                Console.WriteLine(-z - 1);
            }
            else
            {
                x += x * 6 / 5;
                Console.WriteLine(x);
            }
        }
    }
}