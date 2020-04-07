using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Driven_Development;

namespace Assignment_2_Integration_Tests
{
    interface IBank
    {
        public List<Account> GetAccounts();
    }
}
