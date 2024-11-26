namespace demo_93
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer();
            cust.Age = 34;//调用set
            int m = 0;
            Console.WriteLine(cust.Age);//调用get
            Console.WriteLine();

            Customer c1= new Customer();
            c1.Show();
            Customer c2 = c1;
            c2.Show();
            Console.WriteLine();

            c2.Age = 0;
            c1.Show();//c2改变后c1也变，因为c2和c1共享地址，c1给c2传的是地址，不是值，c2更改了二者公用的地址后c1也就变了
            c2.Show();
            Console.WriteLine() ;

            Customer c3=new Customer();//可见，new后c3与c1和c2值不同，因为系统申请了新的内存给c3，c3有了原来的地址而不是c1和c2的地址
            c3.Show();
            //地址存储而非值存储是保护数据的关键


        }
    }
}