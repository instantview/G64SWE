using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpaceTrader;

namespace SpaceTraderTest
{
    [TestClass]
    public class DatabaseTest
    {
        [TestMethod]
        public void TestValPriceDB()
        {
            DatabaseAccessMock dam = new DatabaseAccessMock();
            DatabaseRepositoryClass dr = new DatabaseRepositoryClass(dam);
            string item = "Gold";
            int validprice = 100;

            int result = dr.getPrice(item);

            Assert.AreEqual(validprice, result);
        }
    }
}
