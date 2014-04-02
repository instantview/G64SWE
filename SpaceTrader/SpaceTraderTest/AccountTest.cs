using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpaceTrader;

namespace SpaceTraderTest
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void Account_Constructs_Ok()        {
            Account sys = new Account();
            Assert.IsNotNull(sys);
        }
        [TestMethod]
        public void Account_Created_BalanceShouldBeZero()
        {
            Account sys = new Account();
            int balance = sys.Balance;
            Assert.IsTrue(balance == 0);
        }
        [TestMethod]
        public void Deposit_Deposit5Pounds_BalanceShouldIncreaseBy5()
        {
            Account sys = new Account();
            sys.Deposit(5);
            int balance = sys.Balance;
            Assert.IsTrue(balance == 5);
        }
        [TestMethod]
        public void MoneyOut_MoneyOut5Pounds_BalanceShouldDecreaseBy5()
        {
            Account sys = new Account();
            sys.MoneyOut(5);
            int balance = sys.Balance;
            Assert.IsTrue(balance == -5);
        }
    }
}
