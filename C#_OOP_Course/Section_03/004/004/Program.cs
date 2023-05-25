using System;

namespace _004
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 1.5f;
            double b = a; //implicit conversion (b have 8bytes, so it can store 4bytes (float)). A cannot store 8bytes (double).

            double c = 1.5;
            float d = (float)c; //explicit conversion (casting).

            int x1 = 5;
            int x2 = 2;
            double res = (float)x1 / (float)x2; //without casting, the result will be 2 (integer division).

            Console.WriteLine(res);
        }
    }
}
