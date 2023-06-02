using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ_2.Enums;

namespace LINQ_2.Entities
{
    class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Tier Tier { get; set; }

        public Category(int id, string name, Tier tier)
        {
            Id = id;
            Name = name;
            Tier = tier;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Tier: {Tier}";
        }
    }
}
