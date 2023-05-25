using System;
using System.Collections.Generic;
using _003_AbstractClass.Entities;

namespace _003_AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> accounts = new List<BankAccount>();

            accounts.Add(new BusinessBankAccount(1001, "Alex", 500.0, 400.0));
            accounts.Add(new SavingsAccount(1002, "Maria", 500.0, 0.01));
            accounts.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            accounts.Add(new BusinessBankAccount(1004, "Anna", 500.0, 500.0));

            double sum = 0;

            foreach(BankAccount account in accounts)
            {
                sum += account.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("F2"));

            foreach(BankAccount account in accounts)
            {
                account.Withdraw(10.0);
            }

            foreach(BankAccount account in accounts)
            {
                Console.WriteLine("Updated balance for account " + account.AccountNumber + ": " + account.Balance.ToString("F2"));
            }

        }
    }
}