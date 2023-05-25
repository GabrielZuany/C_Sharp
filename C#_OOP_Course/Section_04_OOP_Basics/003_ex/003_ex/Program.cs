using System;
using System.Globalization;

namespace _003
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

    class Product
    {
        public string Name;
        public double Price;
        public int Quantity;

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public int GetQuantity()
        {
            return Quantity;
        }

        public void AddProduct(int quantity)
        {
            Quantity += quantity;
        }

        public void RemoveProduct(int quantity)
        {   
            int result = Quantity - quantity;
            if(result < 0)
            {
                Quantity = 0;
                return;
            }
            Quantity -= quantity;
        }

        public void PrintData()
        {
            Console.WriteLine($"" 
                + $"Product data: {Name}, R${Price.ToString("F2", CultureInfo.InvariantCulture)}"
                + $"; {Quantity} units. " 
                + $"Total: R${(Price * Quantity).ToString("F2", CultureInfo.InvariantCulture)}");
        }

        // when you call Console.WriteLine(product) this method is called implicitly.
        public override string ToString()
        {
            return Name +  $"; R${Price.ToString("F2", CultureInfo.InvariantCulture)}"
                + $"; {Quantity} units. "
                + $"Total: R${(Price * Quantity).ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
