using System;
using System.Globalization;

namespace _003
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 20;
            double balance = 2500.15995;
            string name = "Gabriel";

            Console.WriteLine(balance.ToString("F2"));
            Console.WriteLine(balance.ToString("F2", CultureInfo.InvariantCulture)); // InvariantCulture = US format.

            Console.WriteLine("{0} has {1} years and balance = U${2}", name, age, balance.ToString("F2", CultureInfo.InvariantCulture)); // placeholder
            Console.WriteLine($"{name} has {age} years and balance = U${balance.ToString("F2", CultureInfo.InvariantCulture)}"); // string interpolation
            Console.WriteLine(name + " has " + age + " years and balance = U$" + balance.ToString("F2", CultureInfo.InvariantCulture)); // concatenation

        }
    }
}
