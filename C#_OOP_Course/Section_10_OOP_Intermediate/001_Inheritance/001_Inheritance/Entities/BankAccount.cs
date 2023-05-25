using System;
namespace _001_Inheritance.Entities
{
    class BankAccount
    {
        public int AccountNumber { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; } // Protected: Only the class itself and subclasses can change the value of Balance.
        private double WithdrawFee = 5.0;

        public BankAccount()
        {
        }

        public BankAccount(int accountNumber, string holder, double balance)
        {
            AccountNumber = accountNumber;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount) // The "virtual" keyword indicates that the method can be overrided by subclasses.
        {
            if (Balance - amount - WithdrawFee >= 0)
            {
                Balance -= (amount + WithdrawFee);
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
