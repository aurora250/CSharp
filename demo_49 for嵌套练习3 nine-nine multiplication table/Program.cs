﻿namespace demo_49
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <=9; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    int s = i * j;
                    Console.Write("{0}*{1}={2} ", i, j, s);
                }
                Console.WriteLine();
            }
        }
    }
}