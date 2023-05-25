using System;
using System.Globalization;

namespace _003
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("TV", 100.50, 15);

            //using auto properties.
            product.Name = "TV 4K";

            // product.Price = 200.00; // error: set property is private.
            // product.Quantity = 20; // error: set property is private.


            Console.WriteLine("NAME: " + product.Name);
            Console.WriteLine("PRICE: " + product.Price);
            Console.WriteLine("QUANTITY: " + product.Quantity);

        }
    }
}