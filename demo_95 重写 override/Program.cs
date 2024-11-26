namespace demo_95
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Abstract e = new Child();
            e.Attack();
        }
    }
}