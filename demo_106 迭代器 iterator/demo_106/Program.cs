using System.Collections;

namespace demo_106
{
    class ColorEnumerator: IEnumerator
    {
        string[] colors;
        int position = -1;

        public ColorEnumerator(string[] colors)
        {
            this.colors = new string[colors.Length];
            for (int i = 0; i < colors.Length; i++)
            {
                this.colors[i] = colors[i];
            }
        }
        public object Current
        {
            get
            {
                if (position == -1)
                {
                    throw new InvalidOperationException();
                }
                if(position >= this.colors.Length)
                {
                    throw new InvalidOperationException();
                }
                return this.colors[position];
            }
        }

        public bool MoveNext()
        {
            if(position < this.colors.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            position = -1;
        }
    }

    class Spectrum: IEnumerable
    {
        string[] Colors = { "violet", "blue", "cyan", "green", "yellow", "orange", "red" };

        public IEnumerator GetEnumerator()
        {
            return new ColorEnumerator(Colors);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Spectrum spectrum = new Spectrum();
            foreach(string s in spectrum)
                Console.WriteLine(s);
        }
    }
}
