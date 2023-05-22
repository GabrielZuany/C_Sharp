using System;

namespace _004
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] values = new double[5];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = (double)(i+1);
                Console.WriteLine(values[i]);
            }

            double result = Calculator.Sum(values);

            Console.WriteLine("The sum of the values is: {0}", result);
        }
    }
}