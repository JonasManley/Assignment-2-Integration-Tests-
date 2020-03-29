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
        private IBank bank;
        private ICustomer customer;
        private string number;
        private long balance = 0;

        public long Balance { get { return balance; } set { balance = value; } }

        public Account(IBank bank, ICustomer customer, string number)
        {
            this.bank = bank;
            this.customer = customer;
            this.number = number;
        }

        public IBank getBank()
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

        public void Transfer(long amount, IAccount target)  
        {
            if(amount < 0)
            {
                throw new ArgumentException("Amount is negative");
            }
            balance -= amount;
            target.Balance += amount;
        }

        public void Transfer(long amount, string targetNumber) 
        {
            if (balance < 0)
            {
                throw new ArgumentException("Amount is negative");
            }
            IAccount target = bank.GetAccount(targetNumber);
            Transfer(amount, target);
        }

       public void Deposit(IAccount target, long amount)
        {
           target.Balance += amount;
        }

       //public void Withdrawal(double amount, IAccount target)
       // {
       //     target.balance -=  amount;
       // }
    }
}
