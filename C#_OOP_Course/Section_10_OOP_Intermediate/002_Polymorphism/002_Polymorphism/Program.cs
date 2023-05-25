using System;
using System.Collections.Generic;
using _002_Polymorphism.Entities;

namespace _002_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            int numberOfEmployees = 0;

            Console.Write("Enter the number of employees: ");
            numberOfEmployees = int.Parse(Console.ReadLine());

            for(int i = 0; i < numberOfEmployees; i++)
            {
                Console.WriteLine($"Employee #{i + 1} data:");
                Console.Write("Outsourced (y/n)? ");
                char outsourcedEmployee = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                if(outsourcedEmployee == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    employees.Add(new OutsourcedEmployee(additionalCharge, name, hours, valuePerHour));
                }
                else
                {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }

            }

            Console.WriteLine("-------------------");
            Console.WriteLine("PAYMENTS:");
            foreach(Employee employee in employees)
            {
                Console.WriteLine("{0} - {1}", employee.name, employee.Payment().ToString("F2"));
            }
        }
    }
}