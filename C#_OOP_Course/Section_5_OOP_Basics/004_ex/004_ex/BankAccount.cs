using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_ex
{
    internal class BankAccount
    {
        public int AccountId { get; private set; }
        public string Owner { get; private set; }
        public double Balance { get; private set; }

        public BankAccount(int accountId, string owner, double balance)
        {
            AccountId = accountId;
            Owner = owner;
            Balance = balance;
        }
        public BankAccount(int accountId, string owner)
        {
            AccountId = accountId;
            Owner = owner;
            Balance = 0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            Console.WriteLine("\nWithdraw cost: $5,00");

            if (Balance - amount - 5 < 0)
            {
                Console.WriteLine("You have ${0}. The withdraw value isnot valid!", Balance);
                return;
            }
            Balance -= amount + 5;
        }

    }
}
