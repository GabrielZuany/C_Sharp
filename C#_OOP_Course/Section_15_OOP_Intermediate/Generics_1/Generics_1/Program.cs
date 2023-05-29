using System;
using System.Collections.Generic;

namespace Generics_1
{
    class Program
    {
        static void Main(string[] args)
        {

            PrintService<int> ps = new PrintService<int>();
            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                ps.add(x);
            }
            ps.print();
            Console.WriteLine("First: " + ps.first());


            PrintService<string> ps2 = new PrintService<string>();
            Console.Write("How many values? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string x = Console.ReadLine();
                ps2.add(x);
            }
            ps2.print();
            Console.WriteLine("First: " + ps2.first());
        }
    }
}