namespace demo_72
{
    internal class Program
    {
        static int Maxvalue(int[] array)
        {
            int max = array[0];
            for(int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max; 
        }
        static double Maxvalue(double[] array)
        {
            double max = array[0];
            for (int i = 1;i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Maxvalue(new int[] { 2, 3, 4, 5, 6, 0, 9 }));
            Console.WriteLine(Maxvalue(new double[] { 2, 3, 4, 5, 6, 0, 9.4 }));

        }
    }
}