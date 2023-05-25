using System;

namespace _008
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Square matrix dimension: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            Console.WriteLine("Matrix elements (x y z): ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Line [{0}]: ", i);
                string[] line = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(line[j]);
                }
            }

            Console.WriteLine("Main diagonal: ");
            int negative_count = 0;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(i == j)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    if (matrix[i,j] < 0)
                    {
                        negative_count++;
                    }
                }
            }

            Console.WriteLine("\nNegative numbers: " + negative_count);
            
        }
    }
}