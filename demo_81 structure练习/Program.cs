namespace demo_81
{
    internal class Program
    {
        struct Vector3
        {
            public double x; public double y; public double z;
            public double D()
            {
                return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
            }
        }
        static void Main(string[] args)
        {
            Vector3 v1;
            v1.x = 3;
            v1.y = 5;
            v1.z = 4;
            Console.WriteLine(v1.D());
        }
    }
}