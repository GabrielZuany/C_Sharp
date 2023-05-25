using System;
using System.Globalization;

namespace _003
{
    class Product
    {

        // Using auto properties. Using it, you avoid the get() and set() methods. User can access the property directly.
        public string? Name { get; set; }
        public double Price { get; private set; }
        public int Quantity { get; private set; }


        // default constructor.
        public Product()
        {
        }

        // overloading constructor.
        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        // overloading constructor.
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
            Quantity = 0;
        }


        public void AddProduct(int quantity)
        {
            Quantity += quantity;
        }

        public void RemoveProduct(int quantity)
        {
            int result = Quantity - quantity;
            if (result < 0)
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
            return Name + $"; R${Price.ToString("F2", CultureInfo.InvariantCulture)}"
                + $"; {Quantity} units. "
                + $"Total: R${(Price * Quantity).ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
