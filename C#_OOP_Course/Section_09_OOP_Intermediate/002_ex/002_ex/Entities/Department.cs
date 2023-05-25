using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_ex.Entities
{
    class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Department(string name, int id)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}";
        }
    }
}
