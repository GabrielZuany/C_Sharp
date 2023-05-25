using System;

namespace _004
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = 3.0;

            double area = Circle.Area(radius);

            double volume = Circle.Volume(radius);

            double perimeter = Circle.Perimeter(radius);

            Console.WriteLine("Area: {0}", area);

            Console.WriteLine("Volume: {0}", volume);

            Console.WriteLine("Perimeter: {0}", perimeter);
        }
    }
}
