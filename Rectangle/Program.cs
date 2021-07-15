using System;

namespace Rectangle
{
    class Rectangle
    {
        private int length;
        private int width;

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public int GetArea()
        {
            return length * width;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle(2, 2);
            Console.WriteLine(rec.GetArea());
        }
    }
}
