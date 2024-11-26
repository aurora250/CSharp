using System.Security.Cryptography.X509Certificates;

namespace demo_97
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane();
            plane.Attack();
            plane.Fly();
            Console.WriteLine();

            IFly fly =new Plane();
            fly.Attack();
            fly.Fly();
            Console.WriteLine();    
            fly = new Bird();//多态
            fly.Attack();
            fly.Fly();
        }
    }
}