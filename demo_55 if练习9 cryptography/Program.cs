namespace demo_55
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int x = a.Length;
            char[] c = a.ToCharArray();//取字符数组内的字符
            for(int i = 0; i < x; i++)
            {
                if ((int)a[i] < 91 && (int)a[i] > 87)
                {
                    Console.Write((char)((int)a[i] - 23));
                }
                else if ((int)a[i] < 123 && (int)a[i] > 119)
                {
                    Console.Write((char)((int)a[i] - 23));
                }
                else if ((int)a[i] < 88  && (int)a[i] > 64)
                {
                    Console.Write((char)((int)a[i] + 3));
                }
                else if ((int)a[i] < 120 && (int)a[i] > 96)
                {
                    Console.Write((char)((int)a[i] + 3));
                }
                else
                {
                    Console.Write(a[i]);
                }
            }
        }
    }
}