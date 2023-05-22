using _007_ex;
using System;
using System.Collections.Generic;

namespace _007ex
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.WriteLine("Number of employees: ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            while(count < n){

                Console.WriteLine("Emplyee Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Employee Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Employee Age: ");
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine("Employee Salary: ");
                double salary = double.Parse(Console.ReadLine());

                employees.Add(new Employee(id, name, age, salary));

                Console.WriteLine("---------\nEmployee added!\n---------");

                count++;
            }

            foreach(Employee emp in employees)
            {
                Console.WriteLine("Employee data: " + emp.ToString());
            }

            foreach(Employee emp in employees)
            {
                emp.RaiseSalary(10);
            }

            foreach(Employee emp in employees)
            {
                Console.WriteLine("Employee new data: " + emp.ToString());
            }

            Console.Read();
            
        }
    }
}