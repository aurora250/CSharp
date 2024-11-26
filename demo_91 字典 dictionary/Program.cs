using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int space = s.IndexOf(' ');
            string str1 = s.Substring(0, space);
            string str2 = s.Substring(space + 1);
            int[] a = Array.ConvertAll(str2.Split(' '), Convert.ToInt32);
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (int num in a)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num]++;
                }
                else
                {
                    dict[num] = 1;
                }
            }
            int maxNum = 0;
            int maxCount = 0;
            foreach (KeyValuePair<int, int> pair in dict)
            {
                if (pair.Value > maxCount)
                {
                    maxNum = pair.Key;
                    maxCount = pair.Value;
                }
            }
            Console.WriteLine(maxNum + " " + maxCount);
        }
    }
}