using System;

namespace AbstractClassesApp
{
    // 1. Abstract base
    abstract class Shape
    {
        public abstract double GetArea();
    }

    // 2. Circle
    class Circle : Shape
    {
        public double Radius { get; }
        public Circle(double radius) => Radius = radius;

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // 3. Rectangle
    class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);

            Console.WriteLine($"Circle area: {circle.GetArea()}");
            Console.WriteLine($"Rectangle area: {rectangle.GetArea()}");
        }
    }
}
