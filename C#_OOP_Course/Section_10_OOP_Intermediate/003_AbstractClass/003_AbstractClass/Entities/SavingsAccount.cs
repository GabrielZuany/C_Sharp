using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_AbstractClass.Entities
{
    class SavingsAccount : BankAccount // The ":" symbol indicates that SavingsAccount inherits from BankAccount.
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int accountNumber, string holder, double balance, double interestRate)
            : base(accountNumber, holder, balance) // The "base" keyword indicates that the constructor of the base class (BankAccount) will be called.
        {
            InterestRate = interestRate;
        }

        public void UpdateBalace()
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount)
        {
            if(Balance - amount >= 0)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient funds");
            }
        }
    }
}
