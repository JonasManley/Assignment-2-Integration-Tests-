using Assignment_2_Integration_Tests.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_Integration_Tests
{
    public class Account : IAccount
    {
        private Bank bank;
        private ICustomer customer;
        private string number;
        private long balance = 0;

        string IAccount.number { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        long IAccount.balance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Account(Bank bank, ICustomer customer, string number)
        {
            this.bank = bank;
            this.customer = customer;
            this.number = number;
        }

        public Bank getBank()
        {
            return bank;
        }

        public ICustomer getCustomer()
        {
            return customer;
        }

        public string getNumber()
        {
            return number;
        }

        public long getBalance()
        {
            return balance;
        }

        public void Transfer(long amount, IAccount target)  // Deposit method from assignment
        {
            balance -= amount;
            target.balance += amount;
        }

        public void Transfer(long amount, string targetNumber) // Withdrawal method from assignment
        {
            if (balance < 0)
            {
                throw new ArgumentException("Amount is negative");
            }
            IAccount target = bank.GetAccount(targetNumber);
            Transfer(amount, target);
        }

       public void Deposit( IAccount target, long amount)
        {
            target.balance += amount;
        }

       public void Withdrawal(long amount, IAccount target)
        {
            target.balance -= amount;
        }
    }
}
