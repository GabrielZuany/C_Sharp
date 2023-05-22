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

            // Note the use of the ref keyword to pass by reference, changing the value of result variable.
            Calculator.Triple(ref result); 

            Console.WriteLine("The sum * 3, using ref arg is: {0}", result);

            // Note the use of the out keyword to pass by reference, changing the value of pow_result variable.
            double pow_result;
            Calculator.Pow(ref result, 2, out pow_result);
            Console.WriteLine("The pow(sum*3), using ref and out args is: {0}", pow_result);


            //Using the params keyword, you avoid the need to create internally variables to store the values in functions/methods.
            //So, you save memory and processing time.
            //

        }
    }
}