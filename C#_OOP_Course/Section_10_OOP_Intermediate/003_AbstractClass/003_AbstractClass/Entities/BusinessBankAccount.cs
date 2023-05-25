using System;
using System.Collections.Generic;
namespace _003_AbstractClass.Entities
{
    class BusinessBankAccount : BankAccount
    {
        public double loadLimit { get; set; }

        public BusinessBankAccount() { }

        public BusinessBankAccount(int accountNumber, string holder, double balance, double loadLimit) : base(accountNumber, holder, balance)
        {
            this.loadLimit = loadLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= loadLimit)
            {
                Balance += amount;
            }
        }
    }
}
