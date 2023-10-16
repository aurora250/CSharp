using System;

namespace demo_52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random x = new Random();
            int r = x.Next();
            int a = Convert.ToInt32(Console.ReadLine());
            int t = 0;
            while (true)
            {
                t++;
                int m = Convert.ToInt32(Console.ReadLine());
                if (m < 0)
                {
                    Console.WriteLine("Game Over");
                    break;
                }
                else
                {
                    if (t > a)
                    {
                        Console.WriteLine("Game Over");
                        break;
                    }
                    else
                    {
                        if (m > r)
                        {
                            Console.WriteLine("Too big");
                        }
                        else if (m < r)
                        {
                            Console.WriteLine("Too small");
                        }
                        else
                        {
                            if (t == 1)
                            {
                                Console.WriteLine("Bingo!");
                            }
                            else if (t <= 3)
                            {
                                Console.WriteLine("Lucky You!");
                            }
                            else
                                Console.WriteLine("Good Guess!");
                            break;
                        }
                    }
                }
            }
        }
    }
}