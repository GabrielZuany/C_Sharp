using System;
using System.Collections.Generic;

namespace _003_ex.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product() { }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return "$ Name: " + Name + ", Price: " + Price.ToString("F2");
        }
    }
}
