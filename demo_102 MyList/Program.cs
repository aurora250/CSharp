namespace demo_102
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>() { };
            Console.WriteLine(list.Capacity);
            Console.WriteLine(list.Count);
            int temp = list[-1];

        }
    }
}