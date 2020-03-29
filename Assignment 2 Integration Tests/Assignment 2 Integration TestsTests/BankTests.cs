using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_2_Integration_Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_2_Integration_Tests.Contract;

namespace Assignment_2_Integration_Tests.Tests
{
    [TestClass()]
    public class BankTests
    {
        // Naming convention used in the project:
        // [the name of the tested method]_[expected input / tested state]_[expected behavior].
        // Mock objects:  Mock<Customer> customerJonas = new Mock<Customer>();
        Bank bank = new Bank("1203954", "Jyske Bank");


        [TestMethod]
        public void TransferAmountBewteenAccounts_500kr_Successful()
        {
            
            //Arrange
            ICustomer customerJonas = new Customer("2206921111", "Jonas pedersen", "1");
            ICustomer customerChristoffer = new Customer("2206921111", "Christoffer dunk", "2");
            Account JonasAccount = new Account(bank, customerJonas, "1");
            Account ChristofferAccount = new Account(bank, customerChristoffer, "2");
            int TransferAmount = 500;
            double ChristofferStatingBalance = ChristofferAccount.getBalance();

            //Act 
            JonasAccount.Transfer(TransferAmount, ChristofferAccount);

            //Assert
            Assert.AreEqual(TransferAmount + ChristofferStatingBalance, ChristofferAccount.getBalance());
        }


        [TestMethod]
        public void TransferAmountBewteenAccounts_500kr_Successful_Mock()
        {
            //Arrange
            ICustomer customerJonas = new Customer("2206921111", "Jonas pedersen", "1");
            ICustomer customerChristoffer = new Customer("2206921111", "Christoffer dunk", "2");
            Account JonasAccount = new Account(bank, customerJonas, "1");
            Account ChristofferAccount = new Account(bank, customerChristoffer, "2");
            int TransferAmount = 500;
            double ChristofferStatingBalance = ChristofferAccount.getBalance();

            //Act 
            JonasAccount.Transfer(TransferAmount, ChristofferAccount);

            //Assert
            Assert.AreEqual(TransferAmount + ChristofferStatingBalance, ChristofferAccount.getBalance());
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Amount is negative")]
        public void TransferNegativeAmountBewteenAccounts_Minus500kr_ExecptionThrown()
        {
            //Arrange 
            ICustomer customerJonas = new Customer("2206921111", "Jonas pedersen", "1");
            ICustomer customerChristoffer = new Customer("2206921111", "Christoffer dunk", "2");
            Account JonasAccount = new Account(bank, customerJonas, "1");
            Account ChristofferAccount = new Account(bank, customerChristoffer, "2");

            int TransferAmount = -500;
            double ChristofferStatingBalance = ChristofferAccount.getBalance();

            //DateTime dateTime = DateTime.Now;
            //Movement movement = new Movement(TransferAmount, dateTime);

            //Act 
            JonasAccount.Transfer(TransferAmount, ChristofferAccount);

            //Assert

        }

        [TestMethod]
        public void CreateAccountWith0Balance_Successful()
        {
            //Arrange
            ICustomer customerJonas = new Customer("2206921111", "Jonas pedersen", "1");
            Account JonasAccount = new Account(bank, customerJonas, "1");
            int TransferAmount = 0;

            //Act

            //Assert
            Assert.AreEqual(0, JonasAccount.getBalance());
        }


        public void CheckBalance_1000kr_Successful()
        {
            //Arrange
            ICustomer customerJonas = new Customer("2206921111", "Jonas pedersen", "1");
            Account JonasAccount = new Account(bank, customerJonas, "1");

            //Act 
            double currentBalance = JonasAccount.getBalance();

            //Assert
            Assert.AreEqual(1000, currentBalance);
        }
    }
}