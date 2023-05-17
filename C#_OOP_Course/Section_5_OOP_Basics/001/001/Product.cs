using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001
{
    class Product
    {
        public string? Name;
        public double Price;
        public int Quantity;


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
