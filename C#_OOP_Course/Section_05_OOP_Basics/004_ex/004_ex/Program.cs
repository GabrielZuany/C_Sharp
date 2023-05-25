using System;
using System.Globalization;

namespace _004_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int accountId = 0;
            string owner = null;
            double balance = 0;

            Console.WriteLine("Account number: ");
            accountId = int.Parse(Console.ReadLine());

            Console.WriteLine("Account owner: ");
            owner = Console.ReadLine();

            Console.WriteLine("Do you want to add initial founds to this account? [Y/N]");
            string initialFounds = Console.ReadLine();

            if(initialFounds == "Y" || initialFounds == "y")
            {
                Console.WriteLine("Initial founds: ");
                balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            else
            {
                balance = 0;
            }

            BankAccount account = new BankAccount(accountId, owner,  balance);

            PrintData(account);

            Console.WriteLine("Deposit value: ");
            double depositValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Deposit(depositValue);

            PrintData(account);

            Console.WriteLine("Withdraw value: ");
            double withdrawValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Withdraw(withdrawValue);
            
            PrintData(account);

        }


        public static void PrintData(BankAccount account)
        {
            Console.WriteLine("Account data:");
            Console.WriteLine("Account Id: " + account.AccountId);
            Console.WriteLine("Account owner: " + account.Owner);
            Console.WriteLine("Account balance: $" + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("-------");
        }
    }
}