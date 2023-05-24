using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Inheritance.Entities
{
    class BusinessBankAcount : BankAccount
    {
        public double loadLimit { get; set; }

        public BusinessBankAcount() { }

        public BusinessBankAcount(int accountNumber, string holder, double balance, double loadLimit) : base(accountNumber, holder, balance)
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
