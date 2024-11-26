namespace demo_80
{
    internal class Program
    {
        struct Position
        {
            public int x;
            public int y;
            public int z;
            public void PointPosition()//结构体内定义函数public
            {
                Console.WriteLine(x + "," + y + "," + z);
            }
        }
        struct Name
        {
            public string fn;
            public string ln;
            public string FN()
            {
                return fn + " " + ln;
            }
        }
        static void Main(string[] args)
        {
            Position p1;
            p1.x = 1;
            p1.y = 2;
            p1.z = 3;
            p1.PointPosition();

            Name name;
            name.fn = "hu";
            name.ln = "enqi";
            Console.WriteLine(name.fn+" "+name.ln);
            Console.WriteLine(name.FN());
        }
    }
}