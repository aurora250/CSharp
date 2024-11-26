using System.Diagnostics;

namespace demo_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm gonna WIN!");
            Console.WriteLine("I'm gonna WIN!");
            Console.WriteLine("I'm gonna WIN!");
            string path = Process.GetCurrentProcess().MainModule.FileName;
            Console.WriteLine(path);
        }
    }
}