using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_Integration_Tests.Contract
{
    public interface IAccount
    {
        abstract long Balance {get; set; }

        IBank getBank();

        ICustomer getCustomer();

        string getNumber();

        long getBalance();

        void Transfer(long amount, IAccount target);

        void Transfer(long amount, string targetNumber);

        void Deposit(IAccount target, long amount);

        //void Withdrawal(double amount, IAccount target);

    }
}
