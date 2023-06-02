using System;
using System.Collections.Generic;
using System.Linq;
using LINQ_2.Enums;

namespace LINQ_2.Entities
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public double Price { get; set; }

        public Product(int id, string name, Category category, double price)
        {
            Id = id;
            Name = name;
            Category = category;
            Price = price;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Category: {Category}, Price: {Price}";
        }
    }
}
