using System;

namespace ImplementAndOverrideAMethod
{
    class Shape
    {
        public Shape() { }

        public virtual double CalcArea()
        {
            return Math.PI;
        }
    }

    class Circle : Shape
    {
        private double _radius;

        public Circle(double radius)
        { 
            // Parameterized Constructor
            this._radius = radius;
        }

        // Override the Method CalcArea() which returns the area of a Circle
        public override double CalcArea()
        {
            return (double)(Math.PI * Math.Pow(_radius, 2));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(2);
            Console.WriteLine(circle.CalcArea());
        }
    }
}
