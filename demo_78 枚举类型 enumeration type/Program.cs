namespace demo_78
{
    internal class Program
    {
        enum Roletype    //枚举定义
        {
            Mage=5, Archer, Assassin, Tank, Support, Warrior    //枚举值，是常量
        }
        enum Week
        {
            Mon,Tus,Wed,Thu=10,Fri,Sat,Sun//有对应索引号，默认从0开始，用整数存储；对应整数从改变处开始递增
        }
        static void Main(string[] args)
        {
            Week day= Week.Mon;
            day = Week.Tus;
            Console.WriteLine(day);
            int n = (int)day;
            Console.WriteLine(n);


            Roletype type = Roletype.Mage;    //引用枚举中的值
            if (type == Roletype.Tank)
            {
                Console.WriteLine("yes");
            }
        }
    }
}