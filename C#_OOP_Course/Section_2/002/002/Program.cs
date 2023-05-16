using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //byte n2 = -1; // Error: byte can only store positive numbers under 256.
            byte n1 = 255;
            n1++;
            Console.WriteLine(n1); // n1 = 0, like a circular buffer.

            int x1 = 2147483647;
            long x2 = 2147483648L; // L suffix is recommended for long values.
            Console.WriteLine(x1);
            Console.WriteLine(x2);

            float f1 = 4.5f; // f suffix is required for float values.
            double d1 = 4.5; // d suffix is optional for double values.
            Console.WriteLine(f1);
            Console.WriteLine(d1);

            object obj1 = 5;
            object obj2 = "object can be also a string";
            //all types in C# are derived from object type.
            Console.WriteLine(obj1);
            Console.WriteLine(obj1.GetType());
            Console.WriteLine(obj2);
        }
    }
}