using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_Integration_Tests.DTO
{
    public class Accounts
    {
        private int number;
        private double money;
        private Customer customer;
        private Bank bank;


        public Accounts(int number, Customer customer, double money)
        {
            this.number = number;
            this.money = money;
            this.customer = customer;
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public double Money
        {
            get { return money; }
            set { money = value; }
        }

        //Not used atm. 
        public double getBalance()
        {
            return money;
        }

        public void Transfer(double money, Accounts targetAccount)
        {
            if (money < 0)
            {
                throw new ArgumentException("Amount is negative");
            }
            targetAccount.money += money;
            money -= money;
        }
    }
}
