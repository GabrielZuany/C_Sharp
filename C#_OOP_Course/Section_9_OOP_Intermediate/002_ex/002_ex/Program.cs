using System;
using System.Collections.Generic;
using _002_ex.Entities;
using _002_ex.Entities.Enums;

namespace _002_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            string workerName = null, workerMail = null, workerCPF = null;
            DateTime workerBirthDate = new DateTime();
            WorkerLevel workerLevel = WorkerLevel.NOT_DEFINED;
            double workerBaseSalary = 0.00;
            int workerDepartmentId = -1;
            string workerDepartmentName = null;

            ReadWorkerPersonalData(ref workerName, ref workerMail, ref workerCPF, ref workerBirthDate);
            ReadWorkerProfessionalData(ref workerLevel, ref workerBaseSalary);
            ReadWorkerDepartmentData(ref workerDepartmentId, ref workerDepartmentName);

            Department department = new Department(workerDepartmentName, workerDepartmentId);
            Person workerPersonalData = new Person(workerName, workerMail, workerBirthDate, workerCPF);
            Worker worker = new Worker(workerPersonalData, workerLevel, department, workerBaseSalary);

            
            FillWorkerContractList(ref worker);
            RemoveWorkerContract(ref worker);

            Console.WriteLine("Showing the current contracts:");
            worker.ShowContracts();

            worker.ShowWorkerFullData();

            Console.Write("Enter the year and month to calculate the income (MM/YYYY): ");
            string[] date = Console.ReadLine().Split('/');
            int year = int.Parse(date[1]);
            int month = int.Parse(date[0]);
            
            Console.WriteLine($"Income for {month}/{year}: {worker.Income(year, month)}");

        }

        static void ReadWorkerPersonalData(ref string werkerName, ref string workerMail, ref string workerCPF, ref DateTime workerBirthDate)
        {
            Console.Write("Enter worker's name: ");
            werkerName = Console.ReadLine();
            Console.Write("Enter worker's email: ");
            workerMail = Console.ReadLine();
            Console.Write("Enter worker's CPF: ");
            workerCPF = Console.ReadLine();
            Console.Write("Enter worker's birth date (DD/MM/YYYY): ");
            workerBirthDate = DateTime.Parse(Console.ReadLine());
        }

        static void ReadWorkerDepartmentData(ref int workerDepartmentId, ref string workerDepartmentName)
        {
            Console.Write("Enter worker's department ID: ");
            workerDepartmentId = int.Parse(Console.ReadLine());
            Console.Write("Enter worker's department name: ");
            workerDepartmentName = Console.ReadLine();
        }

        static void ReadWorkerProfessionalData(ref WorkerLevel workerLevel, ref double workerBaseSalary)
        {
            Console.Write("Enter worker's level (Junior/MidLevel/Senior): ");
            workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Enter worker's base salary: ");
            workerBaseSalary = double.Parse(Console.ReadLine());
        }

        static void FillWorkerContractList(ref Worker worker)
        {
            Console.Write("How many contracts to this worker? ");
            int numberOfContracts = int.Parse(Console.ReadLine());
            for(int i = 0; i < numberOfContracts; i++)
            {
                Console.Write("Insert the contract date (DD/MM/YYYY): ");
                DateTime contractDate = DateTime.Parse(Console.ReadLine());
                Console.Write("Insert the contract value per hour: ");
                double contractValuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Insert the contract duration in hours: ");
                int contractHours = int.Parse(Console.ReadLine());
                HourContract newContract = new HourContract(contractDate, contractValuePerHour, contractHours);
                worker.AddContract(newContract);
            }
        }

        static void RemoveWorkerContract(ref Worker worker)
        {
            Console.WriteLine("Do you want to remove any contract? [Y/N]");
            char removeContract = char.Parse(Console.ReadLine());

            if (removeContract == 'y' || removeContract == 'Y')
            {
                Console.Write("Insert the contract date (DD/MM/YYYY): ");
                DateTime contractDate = DateTime.Parse(Console.ReadLine());
                Console.Write("Insert the contract value per hour: ");
                double contractValuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Insert the contract duration in hours: ");
                int contractHours = int.Parse(Console.ReadLine());

                HourContract contractToRemove = new HourContract(contractDate, contractValuePerHour, contractHours);

                try
                {
                    worker.RemoveContract(contractToRemove);
                    Console.WriteLine("Contract removed!");
                }
                catch
                {
                    Console.WriteLine("Contract not found!");
                }
            }
        }

    }
    
}