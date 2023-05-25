using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_ex
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public Employee() { }
        public Employee(int id, string name, int age, double salary)
        {
            Id = id;
            Name = name;
            Age = age;
            Salary = salary;
        }

        public void RaiseSalary(double percent)
        {
            Salary += Salary * percent / 100;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}, Salary: {Salary}";
        }


    }
}
