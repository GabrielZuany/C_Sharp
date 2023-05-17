using System;

namespace _006
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Console.WriteLine(Higher(a, b) + " is higher than " + Lower(a, b));

            CountWhile();
            Console.WriteLine();
            CountFor();
        }

        static int Higher(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }

        static int Lower(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            return b;
        }

        static void CountWhile()
        {
            int i = 0;
            while (i < 10)
            {
                Console.Write(i + " | ");
                i++;
            }
        }

        static void CountFor()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + " | ");
            }
        }
    }
}
