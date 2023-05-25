using _001_Inheritance.Entities;
using System;

namespace _001_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(1000, "Gabriel", 0.0);
            BusinessBankAcount b_account = new BusinessBankAcount(1001, "Gabriel", 0.0, 500.0);


            //UPCASTING
            BankAccount account2 = b_account; // The variable b_account2 is of type BankAccount, but it points to an object of type BusinessBankAccount.
            BankAccount account3 = new BusinessBankAcount(1002, "Gabriel", 0.0, 200.0); // The variable b_account3 is of type BankAccount, but it points to an object of type BusinessBankAccount.
            BankAccount account4 = new SavingsAccount(1003, "Gabriel", 0.0, 0.01); // The variable b_account4 is of type BankAccount, but it points to an object of type SavingsAccount.


            //DOWNCASTING (not safe operation)
            BusinessBankAcount b_account2 = (BusinessBankAcount)account2; // The variable b_account2 is of type BusinessBankAccount, and it points to an object of type BusinessBankAccount.


            //---------

            BankAccount account5 = new BankAccount(1004, "Gabriel", 500.0);
            BankAccount account6 = new SavingsAccount(1005, "Gabriel", 500.0, 0.01);

            account5.Withdraw(10.0);
            account6.Withdraw(10.0);

            Console.WriteLine(account5.Balance);
            Console.WriteLine(account6.Balance);
        }
    }
}