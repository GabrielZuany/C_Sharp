using System;
using System.Collections.Generic;
using System.Linq;
using LINQ_2.Entities;
using LINQ_2.Enums;

namespace LINQ_2
{
    class Program
    {
        static void Main()
        {
            Category c1 = new Category(1, "Electronics", Tier.TOP);
            Category c2 = new Category(2, "Fashion", Tier.MIDDLE);
            Category c3 = new Category(3, "Home", Tier.BOTTOM);

            List<Product> products = new List<Product>()
            {
                new Product (1, "TV", c1, 1000.0),
                new Product (2, "Notebook", c1, 2000.0),
                new Product (3, "Tablet", c1, 1500.0),
                new Product (4, "Pants", c2, 100.0),
                new Product (5, "Bag", c2, 120.0),
                new Product (6, "T-shirt", c2, 50.0),
                new Product (7, "Bed", c3, 200.0),
                new Product (8, "Table", c3, 80.0),
                new Product (9, "Mug", c3, 30.0)
            };

            var result_1 = products.Where(p => p.Category.Tier == Tier.TOP && p.Price >= 1100);
            Console.WriteLine("TIER TOP and PRICE >= 1100");
            foreach (Product p in result_1)
            {
                Console.WriteLine(p);
            }

            var result_2 = products.Where(p => p.Category.Name == "Electronics").Select(p => p.Name);
            Console.WriteLine("\nNAMES OF PRODUCTS FROM ELECTRONICS");
            foreach (string p in result_2)
            {
                Console.WriteLine(p);
            }

            var result_3 = products.Where(p => p.Name[0] == 'T').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            Console.WriteLine("\nNAMES STARTED WITH 'T' AND ANONYMOUS OBJECT");
            foreach (var p in result_3)
            {
                Console.WriteLine(p);
            }

            var result_4 = products.FirstOrDefault();
            Console.WriteLine("\nFIRST OR DEFAULT");
            Console.WriteLine(result_4);

            var result_5 = 
                from p in products
                where p.Price > 900.0
                select p;
            Console.WriteLine("\nPRICE > 900.0");
            foreach (Product p in result_5)
            {
                Console.WriteLine(p);
            }

        }
    }
}