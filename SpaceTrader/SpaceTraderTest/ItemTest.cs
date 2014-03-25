using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpaceTrader;

namespace SpaceTraderTest
{
    [TestClass]
    public class ItemTest
    {
        [TestMethod]
        public void Item_Constructs_Ok()
        {
            Item item = new Item();
            Assert.IsNotNull(item); 
        }
    }
}
