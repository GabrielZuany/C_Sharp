using System;
using System.Globalization;

namespace _001
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle x = new Triangle();
            Triangle y = new Triangle(3, 4, 5);

            Console.Write("(X) a = ");
            x.SetByConsole('a');

            Console.Write("(X) b = ");
            x.SetByConsole('b');

            Console.Write("(X) c = ");
            x.SetByConsole('c');

            Console.WriteLine("------------");

            Console.WriteLine("X area is " + x.Area());
            Console.WriteLine("Y area is " + y.Area());
        }

        class Triangle
        {
            private double a, b, c;

            // Constructor.
            public Triangle(double a = 0, double b = 0, double c = 0)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }

            public void SetA(double value)
            {
                this.a = value;
            }
            public void SetB(double value)
            {
                this.b = value;
            }
            public void SetC(double value)
            {
                this.c = value;
            }

            public void SetByConsole(char side)
            {
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (side == 'a')
                {
                    this.a = value;
                }
                else if (side == 'b')
                {
                    this.b = value;
                }
                else
                {
                    this.c = value;
                }
            }

            public double Area()
            {
                double a = this.a;
                double b = this.b;
                double c = this.c;
                double p = (a + b + c) / 2.0;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }

        }
    }
}