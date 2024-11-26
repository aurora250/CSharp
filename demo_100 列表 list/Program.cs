using System;
using System.Collections.Generic;

namespace demo_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lists = new List<int>() { 123, 456, 789 };
            lists.Add(1);
            Console.WriteLine(lists[1]);
            Console.WriteLine(lists.Count);
            Console.WriteLine(lists.Capacity);
            
        }
    }
}