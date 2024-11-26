using System;

namespace demo_64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string t = "";
            bool x;
            for (int i = 0; i < s.Length; i++)
            {
                x = true;
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        x = false;
                        break;
                    }
                }
                if (x)
                {
                    t = t + s[i];
                }
            }
            int[] m = new int[t.Length];
            for (int i = 0; i < t.Length; i++)
            {
                m[i] = (int)t[i];
            }
            bool change;
            for (int i = 0; i < t.Length - 1; i++)
            {
                change = false;
                for (int j = 0; j < t.Length - i - 1; j++)
                {
                    if (m[j] > m[j + 1])
                    {
                        int l = m[j];
                        m[j] = m[j + 1];
                        m[j + 1] = l;
                        change = true;
                    }
                }
                if (!change)
                {
                    break;
                }
            }
            char[] n = new char[m.Length];
            for (int i = 0; i < t.Length; i++)
            {
                n[i] = Convert.ToChar(m[i]);
                Console.Write(n[i]);
            }
        }
    }
}