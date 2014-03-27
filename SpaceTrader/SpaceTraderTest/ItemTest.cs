using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpaceTrader;

namespace SpaceTraderTest
{
    [TestClass]
    public class ItemTest
    {
        Item item; 

        [TestInitialize]
        public void init()
        {
            item = new Item("Pencil", 1, 10.00m);
        }

        [TestMethod]
        public void Item_Constructs_Ok()
        {
            Assert.IsNotNull(item); 
        }

        [TestMethod]
        public void Item_Initializes_Ok()
        {
            Assert.IsTrue(item.Name == "Pencil");
            Assert.IsTrue(item.Quantity == 1); 
            Assert.AreEqual(item.Price, 10.00m);
        }

        //[TestMethod]
        //public void ReduceStockLevel_Remove3FromStock_ShouldReduceQuantityBy3()
        //{

        //}

        //[TestMethod]
        //public void IncreaseStockLevel_Add3ToStock_ShouldIncreaseQuantityBy3()
        //{

        //}
    }
}
