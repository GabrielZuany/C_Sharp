using System;
using System.Collections.Generic;
using _002_ex.Entities.Enums;

namespace _002_ex.Entities
{
    internal class Worker
    {
        Person worker;
        WorkerLevel level;
        Department department;
        double baseSalary;
        private List<HourContract> contracts = new List<HourContract>();

        public Worker(Person worker, WorkerLevel level, Department department, double baseSalary)
        {
            this.worker = worker;
            this.level = level;
            this.department = department;
            this.baseSalary = baseSalary;
    }

        public void AddContract(HourContract contract)
        {
            contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            contracts.Remove(contract);
        }

        public void ShowContracts()
        {
            Console.WriteLine("-------");
            foreach (HourContract contract in contracts)
            {
                Console.WriteLine(contract.ToString());
                Console.WriteLine("-------");
            }
        }

        public double Income(int year, int month)
        {
            double income = baseSalary;
            foreach (HourContract contract in contracts)
            {
                if (contract.date.Year == year && contract.date.Month == month)
                {
                    income += contract.TotalValue();
                }
            }
            return 0;
        }

        public void ShowWorkerFullData()
        {
            Console.WriteLine("Worker data:");
            Console.WriteLine(worker.ToString());
            Console.WriteLine("-------");
            Console.WriteLine("Worker level:" + level.ToString());
            Console.WriteLine("-------");
            Console.WriteLine("Worker department:" + department.ToString());
            Console.WriteLine("-------");
            Console.WriteLine("Worker base salary:" + baseSalary);
            Console.WriteLine("-------");
            ShowContracts();
        }

    }
}
