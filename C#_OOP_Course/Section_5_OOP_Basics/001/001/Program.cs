using System;
using System.Globalization;

namespace _001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Product name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Product price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Product quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Product product = new Product(name, price, quantity);
            product.PrintData();

            Console.WriteLine("\nHow many items do you want to add in inventory? ");
            int add = int.Parse(Console.ReadLine());
            product.AddProduct(add);
            product.PrintData();

            Console.WriteLine("\nHow many items do you want to remove in inventory? ");
            int remove = int.Parse(Console.ReadLine());
            product.RemoveProduct(remove);
            Console.WriteLine("Product data: {0}", product);
        }
    }
}