using System.Drawing;

namespace demo_92
{
    public class Time
    {
        //构造函数。没有返回值，名字必须和类一样，缺省默认
        public int hour, minute,second;
        public Time()
        {
            hour=minute=second=0;//数据批量初始化
        }
        public Time(int h)//多态，引用数据数目相同的函数
        {
            hour=h;
        }
        public Time (int h, int m,int s)
        {
            hour=h;
            minute=m;
            second=s;
        }
    }
    class Point
    {
        public int x=0, y=0;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    //析构函数，释放内存，不返回，不带参，缺省默认


    internal class Program
    {
        static void Main(string[] args)
        {
            Time t1=new Time(2);
            Time t2=new Time(2,3,4);
        }
    }
}