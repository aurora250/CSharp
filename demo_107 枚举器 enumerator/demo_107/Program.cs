using System;
using System.Collections.Generic;

namespace demo_107
{
    class Spectrum
    {
        bool _listFromUVtoIR;
        string[] colors = { "violet", "blue", "cyan", "green", "yellow", "orange", "red" };

        public Spectrum(bool listFromUVtoIR)
        {
            this._listFromUVtoIR = listFromUVtoIR;
        }
        public IEnumerator<string> GetEnumerator()
        {
            return _listFromUVtoIR ? UVtoIR : IRtoUV;
        }
        public IEnumerator<string> UVtoIR
        {
            get
            {
                for (int i = 0; i < colors.Length; i++)
                {
                    yield return colors[i];
                }
            }
        }
        public IEnumerator<string> IRtoUV
        {
            get
            {
                for(int i=0; i < colors.Length; i++)
                {
                    yield return colors[i];
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Spectrum startUV=new Spectrum(true);
            Spectrum startIR=new Spectrum(false);
            foreach(string color in startUV)
            {
                Console.WriteLine(color + "   ");
            }
            Console.WriteLine();
            foreach(string color in startIR)
            {
                Console.WriteLine(color + "   ");
            }
        }
    }
}
