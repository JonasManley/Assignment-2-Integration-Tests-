using System;
using System.Collections.Generic;
using Assignment_2_Integration_Tests;
using Assignment_2_Integration_Tests.Contract;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment_2_Integration_TestsTests
{
    [TestClass]
    public class BankIntergrationTest
    {
        private Bank bank;
        private ICustomer customerJonas;
        private ICustomer customerChristoffer;
        private Account JonasAccount;
        private Account ChristofferAccount;


        public void setUp()
        {
            customerJonas = new Customer("2206921111", "Jonas pedersen", "1");
            customerChristoffer = new Customer("2206921111", "Christoffer dunk", "2");
            JonasAccount = new Account(bank, customerJonas, "1");
            ChristofferAccount = new Account(bank, customerChristoffer, "2");
            
            bank = new Bank("1203954", "Jyske Bank");
            bank.AddAccount(JonasAccount);
            bank.AddAccount(ChristofferAccount);
        }

        [TestMethod()]
        public void test()
        {
            //Arrange
            setUp();

            //Act
           List<IAccount> accountA = bank.GetAccounts();

            //Assert
            Assert.AreEqual(2, accountA.Count);
        }

        [TestMethod()]
        public void GetAccountByNumber()
        {
            //Arrange
            setUp();

            //Act
            IAccount accountA = bank.GetAccount(JonasAccount.getNumber());

            //Assert
            Assert.AreEqual(JonasAccount.getNumber(), accountA.getNumber());
        }

        [TestMethod()]
        [ExpectedException(typeof(Exception), "Account not found")]
        public void GetAccountByNumberWrongInput()
        {
            //Arrange
            setUp();

            //Act
            bank.GetAccount("321");

            //Assert

            // Asserting exception thrown
        }

        [TestMethod()]
        public void GetAccountByCustomer()
        {
            //Arrange
            setUp();

            //Act
            IAccount customerAccount = bank.GetAccount("1");

            //Assert
            Assert.AreEqual(0, customerAccount.getBalance());
        }
    }
}
