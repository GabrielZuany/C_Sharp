using System;

namespace _004
{
    internal class Circle
    {
        //using "public static type", we can access the variable without creating an instance of the class.

        public static double PI = 3.14;

        public static double Perimeter(double radius)
        {
            return 2 * PI * radius;
        }

        public static double Area(double radius)
        {
            return PI * radius * radius;
        }

        public static double Volume(double radius)
        {
            return 4 / 3 * PI * radius * radius * radius;
        }
    }
}
