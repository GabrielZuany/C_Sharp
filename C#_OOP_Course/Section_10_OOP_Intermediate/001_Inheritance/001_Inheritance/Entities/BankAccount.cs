using System;
namespace _001_Inheritance.Entities
{
    class BankAccount
    {
        public int AccountNumber { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; } // Protected: Only the class itself and subclasses can change the value of Balance.

        public BankAccount()
        {
        }

        public BankAccount(int accountNumber, string holder, double balance)
        {
            AccountNumber = accountNumber;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient funds");
            }
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
