using System;

namespace demo_104
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
            int m = ints[0];
            int n = ints[1];
            int[,] arr = new int[m, n];
            for(int i = 0; i < m; i++)
            {
                int[] tem= Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
                for(int j=0;j<n; j++)
                {
                    arr[i, j] = tem[j];
                }
            }
            //螺旋方向控制：
            //Down  向下（列号不变，行号+1)
            //Right 向右 (行号不变，列号+1)
            //Up    向上 (列号不变，行号-1)
            //Left  向左 (行号不变，列号-1)
            string orient = "Right";
            int y = 0;
            int x = 0;//设置起点为（0，0）
            for (int i = 1; i <= m * n; i++)//遍历一次数组
            {
                if (i == 1) { Console.WriteLine(arr[0, 0]); continue; }
                //右上到左下对角线转角处：
                if (x + y == n - 1)
                {
                    if (x > y)//左下转角
                    {
                        orient = "Up";
                    }
                    else
                    {
                        orient = "Down";
                    }
                }
                else if (x - 1 == y && x <= n / 2)//左上角
                {
                    orient = "Right";
                }
                else if (x == y && x >= n / 2)//右下角
                {
                    orient = "Left";
                }

                if (orient == "Down")//j行 k列
                {
                    x += 1;
                }
                else if (orient == "Right")
                {
                    y += 1;
                }
                else if (orient == "Up")
                {
                    x -= 1;
                }
                else if (orient == "Left")
                {
                    y -= 1;
                }
                Console.Write(" " + arr[x, y]);
            }
        }
    }
}