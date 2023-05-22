using System;

namespace _004
{
    internal class Calculator
    {
        public static double Sum(double[] values)
        {
            double sum = 0;
            foreach (double value in values)
            {
                sum += value;
            }
            return sum;
        }

        public static void Triple(ref double value)
        {
            value = value * 3;
        }

        public static void Pow(ref double value, double expo, out double result)
        {
            result = Math.Pow(value, expo);
        }
    }
}
