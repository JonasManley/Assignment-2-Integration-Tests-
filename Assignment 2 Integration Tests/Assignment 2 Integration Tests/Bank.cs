using Assignment_2_Integration_Tests.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_Integration_Tests
{
    public class Bank 
    {
        private string cvr;
        private string name;
        private ICustomer customer;
        private IAccount account;
        private List<IAccount> accounts;

        public Bank(string cvr, string name)
        {
            this.cvr = cvr;
            this.name = name;
        }

        public List<IAccount> GetAccounts()
        {
            return accounts;
        }

        public void AddAccount(IAccount account)
        {
            accounts.Add(account);
        }

        public IAccount GetAccount(string id)
        {
            bool found = false;
            foreach (var item in accounts)
            {
                if (item.getNumber() == id)
                {
                    found = true;
                    return item;
                }
            }
            if(found == false)
            {
                throw new ArgumentException("Account not found");
            }
            return null;
        }
    }
}

