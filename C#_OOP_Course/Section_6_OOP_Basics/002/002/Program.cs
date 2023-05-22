using System;
using System.Collections.Generic;
using System.Xml;

namespace _002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array size: ");
            int size = int.Parse(Console.ReadLine());
            double[] array = new double[size];

            int count = 0;
            while (count < size)
            {
                Console.WriteLine("Enter a number: ");
                double number = double.Parse(Console.ReadLine());
                array[count] = number;
                count++;
            }

            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
           
        }
    }
}