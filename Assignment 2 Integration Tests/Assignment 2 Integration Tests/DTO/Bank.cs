using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_Integration_Tests.DTO
{
    class Bank
    {
        private string cvr;
        private string name;
        private Customer customer;
        private Accounts account;
        private List<Accounts> accounts;

        public Bank(string cvr, string name)
        {
            this.cvr = cvr;
            this.name = name;
        }

        public List<Accounts> GetAccounts()
        {
            return accounts;
        }

        public Accounts GetAccount(int id)
        {
            foreach (var item in accounts)
            {
                if (item.Number == id)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
