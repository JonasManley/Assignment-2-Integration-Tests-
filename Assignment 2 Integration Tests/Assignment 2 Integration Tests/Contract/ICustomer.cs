using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_Integration_Tests.Contract
{
    public interface ICustomer
    {
        void transfer(int amount, Account account, Customer target);

        string getId();
    }
}
