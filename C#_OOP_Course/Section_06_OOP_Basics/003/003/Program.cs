using System;

namespace _003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantity of products: ");
            int quantity = int.Parse(Console.ReadLine());

            Product[] products = new Product[quantity];

            double sum = 0;

            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine($"Product #{i + 1} data:");
                Console.WriteLine("Name: ");
                string name = Console.ReadLine() ?? string.Empty;

                Console.WriteLine("Price: ");
                double price = double.Parse(Console.ReadLine());

                Console.WriteLine("Quantity: ");
                int quantityProduct = int.Parse(Console.ReadLine());

                products[i] = new Product(name, price, quantityProduct);
                sum += products[i].Price;
            }

            Console.WriteLine("Products list: ");
            for (int i = 0; i < quantity; i++)
            {
                products[i].PrintData();
            }

            Console.WriteLine($"Product list average: {sum / quantity}");
            
        }
    }
}