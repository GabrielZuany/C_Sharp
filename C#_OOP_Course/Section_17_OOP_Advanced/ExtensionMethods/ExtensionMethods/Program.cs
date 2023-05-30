using ExtensionMethods.Extensions;
using System;
using System.Collections.Generic;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2022, 11, 16, 8, 10, 15);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}